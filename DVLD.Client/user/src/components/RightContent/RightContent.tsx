import ProfileOverview from '../ProfileOverView/ProfileOverview'
import RecentActivities from '../RecentActivities/RecentActivities'
import './RightContent.css'

export default  function RightContent(){
    return (
      <div className="right-content">
        <RecentActivities/>  
        <ProfileOverview/>  
      </div>
    )
  }
  