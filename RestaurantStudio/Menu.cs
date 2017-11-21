using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantStudio
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; }
        public DateTime LastUpdated { get; private set; }

        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            //prevent adding duplicate menuItems
            if (!this.MenuItems.Contains(menuItem))
            {
                this.MenuItems.Add(menuItem);
                // Update LastUpdated anytime we add a new menuItem
                this.LastUpdated = DateTime.Now;
            }
        }

        public void RemoveMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Remove(menuItem);
            // Update LastUpdated anytime we remove a menuItem
            this.LastUpdated = DateTime.Now;
        }

        public override string ToString()
        {
            string menuString = String.Format("Last Update ({0}):{1}", this.LastUpdated, Environment.NewLine);
            foreach (var menuItem in this.MenuItems)
            {
                menuString = menuString + menuItem.ToString() + Environment.NewLine;
            }
            return menuString;
        }
    }
}
