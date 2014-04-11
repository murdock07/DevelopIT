using System;

namespace Adatkezelõ
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

        public String getgroupPostAddress()
        {

            return "";
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

        /// 
        /// <param name="newVal"></param>
        public void setgroupPostAddress(String newVal)
        {

        }

    }
}