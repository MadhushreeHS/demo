using System;
using Systems;
namespace BusinessEntity.Modules.Admin
{
    [Serializable()]
    class DashboardBe
    {
    }
    [Serializable]
    public class SessionDashboard
    {
        private String _dateRange;
        public String DateRange
        {
            get { return _dateRange; }
            set { _dateRange = value; }
        }
        private String _scheduleID;
        public String ScheduleID
        {
            get { return _scheduleID; }
            set { _scheduleID = value; }
        }
        private String _scheduleDetailID;
        public String ScheduleDetailID
        {
            get { return _scheduleDetailID; }
            set { _scheduleDetailID = value; }
        }
        private String _groupID;
        public String GroupID
        {
            get { return _groupID; }
            set { _groupID = value; }
        }
        private String _groupName;
        public String GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }
        private Int32 _schSelectedIndex;
        public Int32 SchSelectedIndex
        {
            get { return _schSelectedIndex; }
            set { _schSelectedIndex = value; }
        }
        private String _Type;
        public String Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        private Boolean _dvZonalIdleStatus_Visibility;
        public Boolean dvZonalIdleStatus_Visibility
        {
            get { return _dvZonalIdleStatus_Visibility; }
            set { _dvZonalIdleStatus_Visibility = value; }
        }
        private Boolean _dvZonalTests_Visibility;
        public Boolean dvZonalTests_Visibility
        {
            get { return _dvZonalTests_Visibility; }
            set { _dvZonalTests_Visibility = value; }
        }
        private Boolean _dvZonalUsers_Visibility;
        public Boolean dvZonalUsers_Visibility
        {
            get { return _dvZonalUsers_Visibility; }
            set { _dvZonalUsers_Visibility = value; }
        }
        private Boolean _dvZonalDetails_Visibility;
        public Boolean dvZonalDetails_Visibility
        {
            get { return _dvZonalDetails_Visibility; }
            set { _dvZonalDetails_Visibility = value; }
        }
        private Boolean _RVGroupUserActivity_Visibility;
        public Boolean RVGroupUserActivity_Visibility
        {
            get { return _RVGroupUserActivity_Visibility; }
            set { _RVGroupUserActivity_Visibility = value; }
        }
    }
}
