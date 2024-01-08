import './UpContent.css'
export default  function UpContent(){
    return (
  
      <div className="up-content">
        <UpLeftContent/>
        <UpLeftContent/>
      </div>
    )
  
    function UpLeftContent(){
      return (
        <div className="content-item">
  
        </div>
      )
    }
  }