import './SideBar.css'

export default function SideBare(){
    return (
      <div className="side-bare">
        <h1>Hi</h1>
        <Button name='Dashboard' img_url='d'/>
        <Button name='People' img_url='p'/>
        <Button name='Drivers' img_url='d'/>
        <Button name='Application' img_url='a'/>
        <Button name='Licenses' img_url='l'/>
        <Button name='Settings' img_url='s'/>
        
        <Button name='Logout' img_url='s'/>
      </div>
    )
  }

  type Programmer = {
    name: string;
    img_url:string;
  };
    


function Button({name,img_url}:Programmer)
{
  return (
    <button className="btn">
      <img src={img_url} className="pic" />
      {name}
    </button>
  )
}