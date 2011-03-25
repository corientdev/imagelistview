﻿// ImageListView - A listview control for image files
// Copyright (C) 2009 Ozgur Ozcitak
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Ozgur Ozcitak (ozcitak@yahoo.com)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Manina.Windows.Forms
{
    public partial class ImageListView
    {
        /// <summary>
        /// Represents the collection of items in the image list view.
        /// </summary>
        public class ImageListViewItemCollection : IList<ImageListViewItem>, ICollection, IList, IEnumerable
        {
            #region Member Variables
            private List<ImageListViewItem> mItems;
            internal ImageListView mImageListView;
            private ImageListViewItem mFocused;
            private Dictionary<Guid, ImageListViewItem> lookUp;
            internal bool collectionModified;
            #endregion

            #region Constructors
            /// <summary>
            /// Initializes a new instance of the <see cref="ImageListViewItemCollection"/>  class.
            /// </summary>
            /// <param name="owner">The <see cref="ImageListView"/> owning this collection.</param>
            internal ImageListViewItemCollection(ImageListView owner)
            {
                mItems = new List<ImageListViewItem>();
                lookUp = new Dictionary<Guid, ImageListViewItem>();
                mFocused = null;
                mImageListView = owner;
                collectionModified = true;
            }
            #endregion

            #region Properties
            /// <summary>
            /// Gets the number of elements contained in the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            public int Count
            {
                get { return mItems.Count; }
            }
            /// <summary>
            /// Gets a value indicating whether the <see cref="ImageListViewItemCollection"/> is read-only.
            /// </summary>
            public bool IsReadOnly
            {
                get { return false; }
            }
            /// <summary>
            /// Gets or sets the focused item.
            /// </summary>
            public ImageListViewItem FocusedItem
            {
                get
                {
                    return mFocused;
                }
                set
                {
                    ImageListViewItem oldFocusedItem = mFocused;
                    mFocused = value;
                    // Refresh items
                    if (oldFocusedItem != mFocused && mImageListView != null)
                        mImageListView.Refresh();
                }
            }
            /// <summary>
            /// Gets the <see cref="ImageListView"/> owning this collection.
            /// </summary>
            [Category("Behavior"), Browsable(false), Description("Gets the ImageListView owning this collection.")]
            public ImageListView ImageListView { get { return mImageListView; } }
            /// <summary>
            /// Gets or sets the <see cref="ImageListViewItem"/> at the specified index.
            /// </summary>
            [Category("Behavior"), Browsable(false), Description("Gets or sets the item at the specified index.")]
            public ImageListViewItem this[int index]
            {
                get
                {
                    return mItems[index];
                }
                set
                {
                    ImageListViewItem item = value;
                    ImageListViewItem oldItem = mItems[index];

                    if (mItems[index] == mFocused)
                        mFocused = item;
                    bool oldSelected = mItems[index].Selected;
                    item.mIndex = index;
                    if (mImageListView != null)
                        item.mImageListView = mImageListView;
                    item.owner = this;
                    mItems[index] = item;
                    lookUp.Remove(oldItem.Guid);
                    lookUp.Add(item.Guid, item);
                    collectionModified = true;

                    if (mImageListView != null)
                    {
                        mImageListView.thumbnailCache.Remove(oldItem.Guid);
                        mImageListView.itemCacheManager.Remove(oldItem.Guid);
                        if (mImageListView.CacheMode == CacheMode.Continuous)
                        {
                            mImageListView.thumbnailCache.Add(item.Guid, item.Adaptor, item.VirtualItemKey,
                                mImageListView.ThumbnailSize, mImageListView.UseEmbeddedThumbnails,
                                mImageListView.AutoRotateThumbnails,
                                (mImageListView.UseWIC == UseWIC.Auto || mImageListView.UseWIC == UseWIC.ThumbnailsOnly));
                        }
                        mImageListView.itemCacheManager.Add(item.Guid, item.Adaptor, item.VirtualItemKey,
                            (mImageListView.UseWIC == UseWIC.Auto || mImageListView.UseWIC == UseWIC.DetailsOnly));
                        if (item.Selected != oldSelected)
                            mImageListView.OnSelectionChanged(new EventArgs());
                    }
                }
            }
            /// <summary>
            /// Gets the <see cref="ImageListViewItem"/> with the specified Guid.
            /// </summary>
            [Category("Behavior"), Browsable(false), Description("Gets or sets the item with the specified Guid.")]
            internal ImageListViewItem this[Guid guid]
            {
                get
                {
                    return lookUp[guid];
                }
            }
            #endregion

            #region Instance Methods
            /// <summary>
            /// Adds an item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="item">The <see cref="ImageListViewItem"/> to add to the <see cref="ImageListViewItemCollection"/>.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            public void Add(ImageListViewItem item, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                AddInternal(item, adaptor);

                if (mImageListView != null)
                {
                    if (item.Selected)
                        mImageListView.OnSelectionChangedInternal();
                    mImageListView.Refresh();
                }
            }
            /// <summary>
            /// Adds an item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="item">The <see cref="ImageListViewItem"/> to add to the <see cref="ImageListViewItemCollection"/>.</param>
            public void Add(ImageListViewItem item)
            {
                Add(item, mImageListView.defaultAdaptor);
            }
            /// <summary>
            /// Adds an item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="item">The <see cref="ImageListViewItem"/> to add to the <see cref="ImageListViewItemCollection"/>.</param>
            /// <param name="initialThumbnail">The initial thumbnail image for the item.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            public void Add(ImageListViewItem item, Image initialThumbnail, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                item.clonedThumbnail = initialThumbnail;
                Add(item, adaptor);
            }
            /// <summary>
            /// Adds an item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="item">The <see cref="ImageListViewItem"/> to add to the <see cref="ImageListViewItemCollection"/>.</param>
            /// <param name="initialThumbnail">The initial thumbnail image for the item.</param>
            public void Add(ImageListViewItem item, Image initialThumbnail)
            {
                Add(item, initialThumbnail, mImageListView.defaultAdaptor);
            }
            /// <summary>
            /// Adds an item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="filename">The name of the image file.</param>
            public void Add(string filename)
            {
                Add(filename, null);
            }
            /// <summary>
            /// Adds an item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="filename">The name of the image file.</param>
            /// <param name="initialThumbnail">The initial thumbnail image for the item.</param>
            public void Add(string filename, Image initialThumbnail)
            {
                ImageListViewItem item = new ImageListViewItem(filename);
                item.mAdaptor = mImageListView.defaultAdaptor;
                item.clonedThumbnail = initialThumbnail;
                Add(item);
            }
            /// <summary>
            /// Adds a virtual item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="key">The key identifying the item.</param>
            /// <param name="text">Text of the item.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            public void Add(object key, string text, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                Add(key, text, null, adaptor);
            }
            /// <summary>
            /// Adds a virtual item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="key">The key identifying the item.</param>
            /// <param name="text">Text of the item.</param>
            public void Add(object key, string text)
            {
                Add(key, text, mImageListView.defaultAdaptor);
            }
            /// <summary>
            /// Adds a virtual item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="key">The key identifying the item.</param>
            /// <param name="text">Text of the item.</param>
            /// <param name="initialThumbnail">The initial thumbnail image for the item.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            public void Add(object key, string text, Image initialThumbnail, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                ImageListViewItem item = new ImageListViewItem(key, text);
                item.clonedThumbnail = initialThumbnail;
                Add(item, adaptor);
            }
            /// <summary>
            /// Adds a virtual item to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="key">The key identifying the item.</param>
            /// <param name="text">Text of the item.</param>
            /// <param name="initialThumbnail">The initial thumbnail image for the item.</param>
            public void Add(object key, string text, Image initialThumbnail)
            {
                Add(key, text, initialThumbnail, mImageListView.defaultAdaptor);
            }
            /// <summary>
            /// Adds a range of items to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="items">An array of <see cref="ImageListViewItem"/> 
            /// to add to the <see cref="ImageListViewItemCollection"/>.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            public void AddRange(ImageListViewItem[] items, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                if (mImageListView != null)
                    mImageListView.SuspendPaint();

                foreach (ImageListViewItem item in items)
                    Add(item, adaptor);

                if (mImageListView != null)
                {
                    mImageListView.Refresh();
                    mImageListView.ResumePaint();
                }
            }
            /// <summary>
            /// Adds a range of items to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="items">An array of <see cref="ImageListViewItem"/> 
            /// to add to the <see cref="ImageListViewItemCollection"/>.</param>
            public void AddRange(ImageListViewItem[] items)
            {
                AddRange(items, mImageListView.defaultAdaptor);
            }
            /// <summary>
            /// Adds a range of items to the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="filenames">The names or the image files.</param>
            public void AddRange(string[] filenames)
            {
                if (mImageListView != null)
                    mImageListView.SuspendPaint();

                for (int i = 0; i < filenames.Length; i++)
                {
                    Add(filenames[i]);
                }

                if (mImageListView != null)
                {
                    mImageListView.Refresh();
                    mImageListView.ResumePaint();
                }

            }
            /// <summary>
            /// Removes all items from the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            public void Clear()
            {
                mItems.Clear();

                mFocused = null;
                lookUp.Clear();
                collectionModified = true;

                if (mImageListView != null)
                {
                    mImageListView.itemCacheManager.Clear();
                    mImageListView.thumbnailCache.Clear();
                    mImageListView.SelectedItems.Clear();
                    mImageListView.Refresh();
                }
            }
            /// <summary>
            /// Determines whether the <see cref="ImageListViewItemCollection"/> 
            /// contains a specific value.
            /// </summary>
            /// <param name="item">The object to locate in the 
            /// <see cref="ImageListViewItemCollection"/>.</param>
            /// <returns>
            /// true if <paramref name="item"/> is found in the 
            /// <see cref="ImageListViewItemCollection"/>; otherwise, false.
            /// </returns>
            public bool Contains(ImageListViewItem item)
            {
                return mItems.Contains(item);
            }
            /// <summary>
            /// Returns an enumerator that iterates through the collection.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> 
            /// that can be used to iterate through the collection.
            /// </returns>
            public IEnumerator<ImageListViewItem> GetEnumerator()
            {
                return mItems.GetEnumerator();
            }
            /// <summary>
            /// Inserts an item to the <see cref="ImageListViewItemCollection"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
            /// <param name="item">The <see cref="ImageListViewItem"/> to 
            /// insert into the <see cref="ImageListViewItemCollection"/>.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            public void Insert(int index, ImageListViewItem item, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                InsertInternal(index, item, adaptor);

                if (mImageListView != null)
                {
                    if (item.Selected)
                        mImageListView.OnSelectionChangedInternal();
                    mImageListView.Refresh();
                }
            }
            /// <summary>
            /// Inserts an item to the <see cref="ImageListViewItemCollection"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
            /// <param name="item">The <see cref="ImageListViewItem"/> to 
            /// insert into the <see cref="ImageListViewItemCollection"/>.</param>
            public void Insert(int index, ImageListViewItem item)
            {
                Insert(index, item, mImageListView.defaultAdaptor);
            }
            /// <summary>
            /// Inserts an item to the <see cref="ImageListViewItemCollection"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
            /// <param name="filename">The name of the image file.</param>
            public void Insert(int index, string filename)
            {
                Insert(index, new ImageListViewItem(filename));
            }
            /// <summary>
            /// Inserts an item to the <see cref="ImageListViewItemCollection"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
            /// <param name="filename">The name of the image file.</param>
            /// <param name="initialThumbnail">The initial thumbnail image for the item.</param>
            public void Insert(int index, string filename, Image initialThumbnail)
            {
                ImageListViewItem item = new ImageListViewItem(filename);
                item.clonedThumbnail = initialThumbnail;
                Insert(index, item);
            }
            /// <summary>
            /// Inserts a virtual item to the <see cref="ImageListViewItemCollection"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
            /// <param name="key">The key identifying the item.</param>
            /// <param name="text">Text of the item.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            public void Insert(int index, object key, string text, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                Insert(index, key, text, null, adaptor);
            }
            /// <summary>
            /// Inserts a virtual item to the <see cref="ImageListViewItemCollection"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
            /// <param name="key">The key identifying the item.</param>
            /// <param name="text">Text of the item.</param>
            public void Insert(int index, object key, string text)
            {
                Insert(index, key, text, mImageListView.defaultAdaptor);
            }
            /// <summary>
            /// Inserts a virtual item to the <see cref="ImageListViewItemCollection"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
            /// <param name="key">The key identifying the item.</param>
            /// <param name="text">Text of the item.</param>
            /// <param name="initialThumbnail">The initial thumbnail image for the item.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            public void Insert(int index, object key, string text, Image initialThumbnail, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                ImageListViewItem item = new ImageListViewItem(key, text);
                item.mAdaptor = adaptor;
                item.clonedThumbnail = initialThumbnail;
                Insert(index, item);
            }
            /// <summary>
            /// Inserts a virtual item to the <see cref="ImageListViewItemCollection"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
            /// <param name="key">The key identifying the item.</param>
            /// <param name="text">Text of the item.</param>
            /// <param name="initialThumbnail">The initial thumbnail image for the item.</param>
            public void Insert(int index, object key, string text, Image initialThumbnail)
            {
                Insert(index, key, text, initialThumbnail, mImageListView.defaultAdaptor);
            }
            /// <summary>
            /// Removes the first occurrence of a specific object 
            /// from the <see cref="ImageListViewItemCollection"/>.
            /// </summary>
            /// <param name="item">The <see cref="ImageListViewItem"/> to remove 
            /// from the <see cref="ImageListViewItemCollection"/>.</param>
            /// <returns>
            /// true if <paramref name="item"/> was successfully removed from the 
            /// <see cref="ImageListViewItemCollection"/>; otherwise, false. This method also 
            /// returns false if <paramref name="item"/> is not found in the original 
            /// <see cref="ImageListViewItemCollection"/>.
            /// </returns>
            public bool Remove(ImageListViewItem item)
            {
                for (int i = item.mIndex; i < mItems.Count; i++)
                    mItems[i].mIndex--;
                if (item == mFocused) mFocused = null;
                bool ret = mItems.Remove(item);
                lookUp.Remove(item.Guid);
                collectionModified = true;
                if (mImageListView != null)
                {
                    mImageListView.thumbnailCache.Remove(item.Guid);
                    mImageListView.itemCacheManager.Remove(item.Guid);
                    if (item.Selected)
                        mImageListView.OnSelectionChangedInternal();
                    mImageListView.Refresh();
                }
                return ret;
            }
            /// <summary>
            /// Removes the <see cref="ImageListViewItem"/> at the specified index.
            /// </summary>
            /// <param name="index">The zero-based index of the item to remove.</param>
            public void RemoveAt(int index)
            {
                ImageListViewItem item = mItems[index];
                Remove(item);
            }
            #endregion

            #region Helper Methods
            /// <summary>
            /// Adds the (empty) subitem to each item for the given custom column.
            /// </summary>
            /// <param name="guid">Custom column ID.</param>
            internal void AddCustomColumn(Guid guid)
            {
                foreach (ImageListViewItem item in mItems)
                    item.AddSubItemText(guid);
            }
            /// <summary>
            /// Determines whether the collection contains the given key.
            /// </summary>
            /// <param name="guid">The key of the item.</param>
            /// <returns>true if the collection contains the given key; otherwise false.</returns>
            internal bool ContainsKey(Guid guid)
            {
                return lookUp.ContainsKey(guid);
            }
            /// <summary>
            /// Gets the value associated with the specified key.
            /// </summary>
            /// <param name="guid">The key of the item.</param>
            /// <param name="item">the value associated with the specified key, 
            /// if the key is found; otherwise, the default value for the type 
            /// of the value parameter. This parameter is passed uninitialized.</param>
            /// <returns>true if the collection contains the given key; otherwise false.</returns>
            internal bool TryGetValue(Guid guid, out ImageListViewItem item)
            {
                return lookUp.TryGetValue(guid, out item);
            }
            /// <summary>
            /// Removes the subitem of each item for the given custom column.
            /// </summary>
            /// <param name="guid">Custom column ID.</param>
            internal void RemoveCustomColumn(Guid guid)
            {
                foreach (ImageListViewItem item in mItems)
                    item.RemoveSubItemText(guid);
            }
            /// <summary>
            /// Removes the subitem of each item for the given custom column.
            /// </summary>
            internal void RemoveAllCustomColumns()
            {
                foreach (ImageListViewItem item in mItems)
                    item.RemoveAllSubItemTexts();
            }
            /// <summary>
            /// Adds the given item without raising a selection changed event.
            /// </summary>
            /// <param name="item">The <see cref="ImageListViewItem"/> to add.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            internal void AddInternal(ImageListViewItem item, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                InsertInternal(-1, item, adaptor);
            }
            /// <summary>
            /// Inserts the given item without raising a selection changed event.
            /// </summary>
            /// <param name="index">Insertion index. If index is -1 the item is added to the end of the list.</param>
            /// <param name="item">The <see cref="ImageListViewItem"/> to add.</param>
            /// <param name="adaptor">The adaptor associated with this item.</param>
            internal void InsertInternal(int index, ImageListViewItem item, ImageListView.ImageListViewItemAdaptor adaptor)
            {
                // Check if the file already exists
                if (mImageListView != null && !string.IsNullOrEmpty(item.FileName) && !mImageListView.AllowDuplicateFileNames)
                {
                    if (mItems.Exists(a => string.Compare(a.FileName, item.FileName, StringComparison.OrdinalIgnoreCase) == 0))
                        return;
                }
                item.owner = this;
                item.mAdaptor = adaptor;
                if (index == -1)
                {
                    item.mIndex = mItems.Count;
                    mItems.Add(item);
                }
                else
                {
                    item.mIndex = index;
                    for (int i = index; i < mItems.Count; i++)
                        mItems[i].mIndex++;
                    mItems.Insert(index, item);
                }
                lookUp.Add(item.Guid, item);
                collectionModified = true;
                if (mImageListView != null)
                {
                    item.mImageListView = mImageListView;

                    // Create sub item texts for custom columns
                    foreach (ImageListViewColumnHeader header in mImageListView.Columns)
                        if (header.Type == ColumnType.Custom)
                            item.AddSubItemText(header.Guid);

                    // Add current thumbnail to cache
                    if (item.clonedThumbnail != null)
                    {
                        mImageListView.thumbnailCache.Add(item.Guid, item.Adaptor, item.VirtualItemKey, mImageListView.ThumbnailSize,
                            item.clonedThumbnail, mImageListView.UseEmbeddedThumbnails, mImageListView.AutoRotateThumbnails,
                            (mImageListView.UseWIC == UseWIC.Auto || mImageListView.UseWIC == UseWIC.ThumbnailsOnly));
                        item.clonedThumbnail = null;
                    }

                    // Add to thumbnail cache
                    if (mImageListView.CacheMode == CacheMode.Continuous)
                    {
                        mImageListView.thumbnailCache.Add(item.Guid, item.Adaptor, item.VirtualItemKey,
                            mImageListView.ThumbnailSize, mImageListView.UseEmbeddedThumbnails, mImageListView.AutoRotateThumbnails,
                            (mImageListView.UseWIC == UseWIC.Auto || mImageListView.UseWIC == UseWIC.ThumbnailsOnly));
                    }

                    // Add to details cache
                    mImageListView.itemCacheManager.Add(item.Guid, item.Adaptor, item.VirtualItemKey,
                        (mImageListView.UseWIC == UseWIC.Auto || mImageListView.UseWIC == UseWIC.DetailsOnly));

                    // Add to shell info cache
                    string extension = item.extension;
                    if (!string.IsNullOrEmpty(extension))
                    {
                        CacheState state = mImageListView.shellInfoCache.GetCacheState(extension);
                        if (state == CacheState.Error && mImageListView.RetryOnError == true)
                        {
                            mImageListView.shellInfoCache.Remove(extension);
                            mImageListView.shellInfoCache.Add(extension);
                        }
                        else if (state == CacheState.Unknown)
                            mImageListView.shellInfoCache.Add(extension);
                    }
                }
            }
            /// <summary>
            /// Removes the given item without raising a selection changed event.
            /// </summary>
            /// <param name="item">The item to remove.</param>
            internal void RemoveInternal(ImageListViewItem item)
            {
                RemoveInternal(item, true);
            }
            /// <summary>
            /// Removes the given item without raising a selection changed event.
            /// </summary>
            /// <param name="item">The item to remove.</param>
            /// <param name="removeFromCache">true to remove item image from cache; otherwise false.</param>
            internal void RemoveInternal(ImageListViewItem item, bool removeFromCache)
            {
                for (int i = item.mIndex; i < mItems.Count; i++)
                    mItems[i].mIndex--;
                if (item == mFocused) mFocused = null;
                if (removeFromCache && mImageListView != null)
                {
                    mImageListView.thumbnailCache.Remove(item.Guid);
                    mImageListView.itemCacheManager.Remove(item.Guid);
                }
                mItems.Remove(item);
                lookUp.Remove(item.Guid);
                collectionModified = true;
            }
            /// <summary>
            /// Returns the index of the specified item.
            /// </summary>
            internal int IndexOf(ImageListViewItem item)
            {
                return item.Index;
            }
            /// <summary>
            /// Returns the index of the item with the specified Guid.
            /// </summary>
            internal int IndexOf(Guid guid)
            {
                ImageListViewItem item = null;
                if (lookUp.TryGetValue(guid, out item))
                    return item.Index;
                return -1;
            }
            /// <summary>
            /// Sorts the items by the sort order and sort column of the owner.
            /// </summary>
            internal void Sort()
            {
                if (mImageListView == null)
                    return;

                mImageListView.showGroups = false;
                mImageListView.groups = new Dictionary<string, List<ImageListViewItem>>();

                if ((mImageListView.GroupOrder == SortOrder.None || mImageListView.GroupColumn < 0 || mImageListView.GroupColumn >= mImageListView.Columns.Count) &&
                   (mImageListView.SortOrder == SortOrder.None || mImageListView.SortColumn < 0 || mImageListView.SortColumn >= mImageListView.Columns.Count))
                    return;

                // Display wait cursor while sorting
                Cursor cursor = mImageListView.Cursor;
                mImageListView.Cursor = Cursors.WaitCursor;

                // Sort and group items
                ImageListViewColumnHeader sortColumn = null;
                ImageListViewColumnHeader groupColumn = null;
                if (mImageListView.GroupColumn >= 0 && mImageListView.GroupColumn < mImageListView.Columns.Count)
                    groupColumn = mImageListView.Columns[mImageListView.GroupColumn];
                if (mImageListView.SortColumn >= 0 || mImageListView.SortColumn < mImageListView.Columns.Count)
                    sortColumn = mImageListView.Columns[mImageListView.SortColumn];
                mItems.Sort(new ImageListViewItemComparer(groupColumn, mImageListView.GroupOrder, sortColumn, mImageListView.SortOrder));
                if (mImageListView.GroupOrder != SortOrder.None && groupColumn != null)
                    mImageListView.showGroups = true;

                // Update item indices and create groups
                string lastGroup = string.Empty;
                for (int i = 0; i < mItems.Count; i++)
                {
                    ImageListViewItem item = mItems[i];
                    item.mIndex = i;
                    string group = item.group;
                    if (string.Compare(lastGroup, group, StringComparison.InvariantCultureIgnoreCase) != 0)
                    {
                        lastGroup = group;
                        mImageListView.groups.Add(group, new List<ImageListViewItem>() { item });
                    }
                    else
                        mImageListView.groups[lastGroup].Add(item);
                }

                // Restore previous cursor
                mImageListView.Cursor = cursor;
                collectionModified = true;
            }
            #endregion

            #region ImageListViewItemComparer
            /// <summary>
            /// Compares items by the sort order and sort column of the owner.
            /// </summary>
            private class ImageListViewItemComparer : IComparer<ImageListViewItem>
            {
                private ImageListViewColumnHeader mGroupColumn;
                private ImageListViewColumnHeader mSortColumn;
                private SortOrder mGroupOrder;
                private SortOrder mSortOrder;

                public ImageListViewItemComparer(ImageListViewColumnHeader groupColumn, SortOrder groupOrder, ImageListViewColumnHeader sortColumn, SortOrder sortOrder)
                {
                    mGroupColumn = groupColumn;
                    mSortColumn = sortColumn;
                    mGroupOrder = groupOrder;
                    mSortOrder = sortOrder;
                }

                /// <summary>
                /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
                /// </summary>
                public int Compare(ImageListViewItem x, ImageListViewItem y)
                {
                    int result = 0;
                    int sign = (mGroupOrder == SortOrder.Ascending ? 1 : -1);

                    if (mGroupColumn != null)
                    {
                        Utility.Tuple<int, string> xg = GetItemGroup(mGroupColumn, x);
                        Utility.Tuple<int, string> yg = GetItemGroup(mGroupColumn, y);
                        x.group = xg.Item2;
                        y.group = yg.Item2;
                        result = (xg.Item1 < yg.Item1 ? -1 : (xg.Item1 > yg.Item1 ? 1 : 0));
                        if (result != 0)
                            return sign * result;
                    }
                    else
                    {
                        x.group = string.Empty;
                        y.group = string.Empty;
                    }

                    result = 0;
                    sign = (mSortOrder == SortOrder.Ascending ? 1 : -1);
                    if (mSortColumn != null)
                    {
                        switch (mSortColumn.Type)
                        {
                            case ColumnType.DateAccessed:
                                result = DateTime.Compare(x.DateAccessed, y.DateAccessed);
                                break;
                            case ColumnType.DateCreated:
                                result = DateTime.Compare(x.DateCreated, y.DateCreated);
                                break;
                            case ColumnType.DateModified:
                                result = DateTime.Compare(x.DateModified, y.DateModified);
                                break;
                            case ColumnType.Dimensions:
                                long ax = x.Dimensions.Width * x.Dimensions.Height;
                                long ay = y.Dimensions.Width * y.Dimensions.Height;
                                result = (ax < ay ? -1 : (ax > ay ? 1 : 0));
                                break;
                            case ColumnType.FileName:
                                result = string.Compare(x.FileName, y.FileName, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.FilePath:
                                result = string.Compare(x.FilePath, y.FilePath, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.FileSize:
                                result = (x.FileSize < y.FileSize ? -1 : (x.FileSize > y.FileSize ? 1 : 0));
                                break;
                            case ColumnType.FileType:
                                result = string.Compare(x.FileType, y.FileType, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.Name:
                                result = string.Compare(x.Text, y.Text, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.Resolution:
                                float rx = x.Resolution.Width * x.Resolution.Height;
                                float ry = y.Resolution.Width * y.Resolution.Height;
                                result = (rx < ry ? -1 : (rx > ry ? 1 : 0));
                                break;
                            case ColumnType.ImageDescription:
                                result = string.Compare(x.ImageDescription, y.ImageDescription, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.EquipmentModel:
                                result = string.Compare(x.EquipmentModel, y.EquipmentModel, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.DateTaken:
                                result = DateTime.Compare(x.DateTaken, y.DateTaken);
                                break;
                            case ColumnType.Artist:
                                result = string.Compare(x.Artist, y.Artist, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.Copyright:
                                result = string.Compare(x.Copyright, y.Copyright, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.ExposureTime:
                                result = (x.ExposureTime < y.ExposureTime ? -1 : (x.ExposureTime > y.ExposureTime ? 1 : 0));
                                break;
                            case ColumnType.FNumber:
                                result = (x.FNumber < y.FNumber ? -1 : (x.FNumber > y.FNumber ? 1 : 0));
                                break;
                            case ColumnType.ISOSpeed:
                                result = (x.ISOSpeed < y.ISOSpeed ? -1 : (x.ISOSpeed > y.ISOSpeed ? 1 : 0));
                                break;
                            case ColumnType.UserComment:
                                result = string.Compare(x.UserComment, y.UserComment, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.Rating:
                                result = (x.Rating < y.Rating ? -1 : (x.Rating > y.Rating ? 1 : 0));
                                break;
                            case ColumnType.Software:
                                result = string.Compare(x.Software, y.Software, StringComparison.InvariantCultureIgnoreCase);
                                break;
                            case ColumnType.FocalLength:
                                result = (x.FocalLength < y.FocalLength ? -1 : (x.FocalLength > y.FocalLength ? 1 : 0));
                                break;
                            case ColumnType.Custom:
                                result = string.Compare(x.GetSubItemText(mSortColumn.Guid), y.GetSubItemText(mSortColumn.Guid), StringComparison.InvariantCultureIgnoreCase);
                                break;
                            default:
                                result = 0;
                                break;
                        }
                    }

                    return sign * result;
                }

                /// <summary>
                /// Returns the group order and name for the given item.
                /// </summary>
                /// <param name="column">The group column.</param>
                /// <param name="item">The item to create a group for.</param>
                private Utility.Tuple<int, string> GetItemGroup(ImageListViewColumnHeader column, ImageListViewItem item)
                {
                    switch (column.Type)
                    {
                        case ColumnType.DateAccessed:
                            return Utility.GroupTextDate(item.DateAccessed);
                        case ColumnType.DateCreated:
                            return Utility.GroupTextDate(item.DateCreated);
                        case ColumnType.DateModified:
                            return Utility.GroupTextDate(item.DateModified);
                        case ColumnType.Dimensions:
                            return Utility.GroupTextDimension(item.Dimensions);
                        case ColumnType.FileName:
                            return Utility.GroupTextAlpha(item.FileName);
                        case ColumnType.FilePath:
                            return Utility.GroupTextAlpha(item.FilePath);
                        case ColumnType.FileSize:
                            return Utility.GroupTextFileSize(item.FileSize);
                        case ColumnType.FileType:
                            return Utility.GroupTextAlpha(item.FileType);
                        case ColumnType.Name:
                            return Utility.GroupTextAlpha(item.Text);
                        case ColumnType.ImageDescription:
                            return Utility.GroupTextAlpha(item.ImageDescription);
                        case ColumnType.EquipmentModel:
                            return Utility.GroupTextAlpha(item.EquipmentModel);
                        case ColumnType.DateTaken:
                            return Utility.GroupTextDate(item.DateTaken);
                        case ColumnType.Artist:
                            return Utility.GroupTextAlpha(item.Artist);
                        case ColumnType.Copyright:
                            return Utility.GroupTextAlpha(item.Copyright);
                        case ColumnType.UserComment:
                            return Utility.GroupTextAlpha(item.UserComment);
                        case ColumnType.Software:
                            return Utility.GroupTextAlpha(item.Software);
                        case ColumnType.Custom:
                            return Utility.GroupTextAlpha(item.GetSubItemText(column.Guid));
                        case ColumnType.ISOSpeed:
                            return new Utility.Tuple<int, string>(item.ISOSpeed, item.ISOSpeed.ToString());
                        case ColumnType.Rating:
                            return new Utility.Tuple<int, string>(item.Rating / 5, (item.Rating / 5).ToString());
                        case ColumnType.FocalLength:
                            return new Utility.Tuple<int, string>((int)item.FocalLength, item.FocalLength.ToString());
                        case ColumnType.ExposureTime:
                            return new Utility.Tuple<int, string>((int)item.ExposureTime, item.ExposureTime.ToString());
                        case ColumnType.FNumber:
                            return new Utility.Tuple<int, string>((int)item.FNumber, item.FNumber.ToString());
                        case ColumnType.Resolution:
                            return new Utility.Tuple<int, string>((int)item.Resolution.Width, item.Resolution.Width.ToString());
                        default:
                            return new Utility.Tuple<int, string>(0, "Unknown");
                    }
                }
            }
            #endregion

            #region Unsupported Interface
            /// <summary>
            /// Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1"/> to an <see cref="T:System.Array"/>, starting at a particular <see cref="T:System.Array"/> index.
            /// </summary>
            void ICollection<ImageListViewItem>.CopyTo(ImageListViewItem[] array, int arrayIndex)
            {
                mItems.CopyTo(array, arrayIndex);
            }
            /// <summary>
            /// Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1"/>.
            /// </summary>
            [Obsolete("Use ImageListViewItem.Index property instead.")]
            int IList<ImageListViewItem>.IndexOf(ImageListViewItem item)
            {
                return mItems.IndexOf(item);
            }
            /// <summary>
            /// Copies the elements of the <see cref="T:System.Collections.ICollection"/> to an <see cref="T:System.Array"/>, starting at a particular <see cref="T:System.Array"/> index.
            /// </summary>
            void ICollection.CopyTo(Array array, int index)
            {
                if (!(array is ImageListViewItem[]))
                    throw new ArgumentException("An array of ImageListViewItem is required.", "array");
                mItems.CopyTo((ImageListViewItem[])array, index);
            }
            /// <summary>
            /// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
            /// </summary>
            int ICollection.Count
            {
                get { return mItems.Count; }
            }
            /// <summary>
            /// Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection"/> is synchronized (thread safe).
            /// </summary>
            bool ICollection.IsSynchronized
            {
                get { return false; }
            }
            /// <summary>
            /// Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection"/>.
            /// </summary>
            object ICollection.SyncRoot
            {
                get { throw new NotSupportedException(); }
            }
            /// <summary>
            /// Adds an item to the <see cref="T:System.Collections.IList"/>.
            /// </summary>
            int IList.Add(object value)
            {
                if (!(value is ImageListViewItem))
                    throw new ArgumentException("An object of type ImageListViewItem is required.", "value");
                ImageListViewItem item = (ImageListViewItem)value;
                Add(item);
                return mItems.IndexOf(item);
            }
            /// <summary>
            /// Determines whether the <see cref="T:System.Collections.IList"/> contains a specific value.
            /// </summary>
            bool IList.Contains(object value)
            {
                if (!(value is ImageListViewItem))
                    throw new ArgumentException("An object of type ImageListViewItem is required.", "value");
                return mItems.Contains((ImageListViewItem)value);
            }
            /// <summary>
            /// Returns an enumerator that iterates through a collection.
            /// </summary>
            /// <returns>
            /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
            /// </returns>
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return mItems.GetEnumerator();
            }
            /// <summary>
            /// Determines the index of a specific item in the <see cref="T:System.Collections.IList"/>.
            /// </summary>
            int IList.IndexOf(object value)
            {
                if (!(value is ImageListViewItem))
                    throw new ArgumentException("An object of type ImageListViewItem is required.", "value");
                return IndexOf((ImageListViewItem)value);
            }
            /// <summary>
            /// Inserts an item to the <see cref="T:System.Collections.IList"/> at the specified index.
            /// </summary>
            void IList.Insert(int index, object value)
            {
                if (!(value is ImageListViewItem))
                    throw new ArgumentException("An object of type ImageListViewItem is required.", "value");
                Insert(index, (ImageListViewItem)value);
            }
            /// <summary>
            /// Gets a value indicating whether the <see cref="T:System.Collections.IList"/> has a fixed size.
            /// </summary>
            bool IList.IsFixedSize
            {
                get { return false; }
            }
            /// <summary>
            /// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList"/>.
            /// </summary>
            void IList.Remove(object value)
            {
                if (!(value is ImageListViewItem))
                    throw new ArgumentException("An object of type ImageListViewItem is required.", "value");
                ImageListViewItem item = (ImageListViewItem)value;
                Remove(item);
            }
            /// <summary>
            /// Gets or sets the <see cref="System.Object"/> at the specified index.
            /// </summary>
            object IList.this[int index]
            {
                get
                {
                    return this[index];
                }
                set
                {
                    if (!(value is ImageListViewItem))
                        throw new ArgumentException("An object of type ImageListViewItem is required.", "value");
                    this[index] = (ImageListViewItem)value;
                }
            }
            #endregion
        }
    }
}