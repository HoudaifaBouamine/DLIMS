import DownContent from '../Recent-Drivers/RecentDrivers'
import UpContent from '../UpContent/UpContent'
import './LeftContent.css'

export default  function LeftContent(){
    return (
      <div className="left-content">
        <UpContent/>
        <DownContent/>
      </div>
    )
  }
  