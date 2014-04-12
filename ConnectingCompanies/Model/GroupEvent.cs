using System;
using System.Collections.Generic;

namespace Adatkezel�
{
    public class GroupEvent : Event
    {

        private Group group;
        private List<Group> groups;

        public GroupEvent()
        {

        }

        public Group Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }

        public List<Group> Groups
        {
            get
            {
                return groups;
            }
            set
            {
                groups = value;
            }
        }

    }
}