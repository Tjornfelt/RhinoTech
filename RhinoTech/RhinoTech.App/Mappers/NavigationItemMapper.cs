﻿using APE.Umbraco;
using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace RhinoTech.App.Mappers
{
    public static class NavigationItemMapper
    {
        /// <summary>
        /// Returns a collection of NavigationItems starting from the root. Currentpage helps to determine if the current navigation item is active.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        public static IEnumerable<T> Map<T>(IPublishedContent root, IPublishedContent currentPage) where T : NavigationItem
        {
            List<T> navigationItems = new List<T>();
            if (root != null)
            {
                foreach (var child in root.Children.Where(x => x.DocumentTypeAlias != DocTypes.Error404))
                {
                    if(UH.UmbracoHelper.MemberHasAccess(child.Id, child.Path))
                    {
                        NavigationItem navItem = new NavigationItem()
                        {
                            NodeID = child.Id,
                            Name = child.Name,
                            Url = child.Url,
                            Active = currentPage.Id == child.Id,
                            Children = Map<NavigationItem>(child, currentPage)
                        };

                        navigationItems.Add((T)navItem);
                    }
                }
            }

            if (navigationItems.Any())
            {
                return navigationItems;
            }
            return null;
        }

        public static IEnumerable<T> Map<T>(IEnumerable<IPublishedContent> items, IPublishedContent currentPage) where T : NavigationItem
        {
            List<T> navigationItems = new List<T>();
            if (items != null && items.Any())
            {
                foreach (var item in items)
                {
                    if (UH.UmbracoHelper.MemberHasAccess(item.Id, item.Path))
                    {
                        NavigationItem navItem = new NavigationItem()
                        {
                            NodeID = item.Id,
                            Name = item.Name,
                            Url = item.Url,
                            Active = currentPage.Id == item.Id,
                            Children = Map<NavigationItem>(item, currentPage)
                        };

                        navigationItems.Add((T)navItem);
                    }
                }
            }

            if (navigationItems.Any())
            {
                return navigationItems;
            }
            return null;
        }

        /*
        public static IEnumerable<T> Map<T>(IEnumerable<IPublishedContent> content, IPublishedContent currentNode)
            where T : NavigationItem, new()
        {
            
            foreach (var item in content)
            {
                yield return Map<IEnumerable<T>>(item, currentNode);
            }
        }*/

        /*
        /// <summary>
        /// Returns a single NavigationItem mapped from the node provided.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        public static T MapSingle<T>(IPublishedContent content) where T : NavigationItem
        {
            if (content != null)
            {
                NavigationItem navItem = new NavigationItem{
                    Name = content.Name,
                    Url = content.Url
                };
                return (T)navItem;
            }
            return null;
        }
         */
    }
}