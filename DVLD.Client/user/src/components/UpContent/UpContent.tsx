import './UpContent.css'
export default  function UpContent(){
  return (

    <div className="up-content">
      <UpLeftContent title='License added in' hours={24} count={73}/>
      <UpLeftContent title='Driver added in' hours={24} count={194}/>
      
    </div>
    )

    type UpLeftConentParams = {
      title:string;
      hours:number;
      count:number;
    }

    function UpLeftContent({title,hours,count}:UpLeftConentParams){
      return (
        <div className="content-item">
          <h6 className='title'>{title}</h6>
          <div className="splite-conteiner">
            <div className="numbers">
              <p className='time'>{hours}h</p>
              <p className='number'>{count}</p>
            </div>
          </div>
        </div>
      )
  }
}