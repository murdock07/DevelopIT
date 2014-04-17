using System;

namespace Adatkezel�
{
    public class GroupProfile : Profile
    {
        private Group group;
        private String groupAddress;
        private String groupBoss;
        private String groupName;
        private String groupPostAddress;

        public GroupProfile()
        {

        }

        public Group Group
        {
            get { return group; }
            set { group = value; }
        }
        public String GroupAddress
        {
            get { return groupAddress; }
            set { groupAddress = value; }
        }
        public String GroupBoss
        {
            get { return groupBoss; }
            set { groupBoss = value; }
        }
        public String GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
        public String GroupPostAddress
        {
            get { return groupPostAddress; }
            set { groupPostAddress = value; }
        }

        internal void SetAttributesFromDB(ConnectingCompanies.csoportok cs)
        {
            this.group = new Group();
            this.group.SetAttributesFromDB(cs);
            //this
        }
    }
}