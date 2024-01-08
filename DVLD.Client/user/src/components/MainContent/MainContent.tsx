import LeftContent from '../LeftContent/LeftContent'
import RightContent from '../RightContent/RightContent'
import SearchBar from '../search-bar/SearchBar'
import './MainContent.css'

export default  function MainContent(){
    
    return (
  
      <div className="main-content">
        <SearchBar/>
        <Content/>
      </div>
    )
  
    function Content(){
      return (
        <div className="content">
          <LeftContent/>
          <RightContent/>
        </div>
      )
    }
  }