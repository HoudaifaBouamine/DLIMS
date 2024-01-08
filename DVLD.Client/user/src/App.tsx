import './App.css'

function App() {

  return (
    
    <Container/>
    
  )
}

function Container(){
  return (
    <div className="container">
      
      <SideBare/>
      <MainContent/>
    </div>
  )
}

function SideBare(){
  return (
    <div className="side-bare">

    </div>
  )
}

function MainContent(){
  return (

    <div className="main-content">
      <SearchBar/>
      <Content/>
    </div>
  )

  function SearchBar(){
    return (

      <div className="search-bar">
        
      </div>

    )
  }

  function Content(){
    return (
      <div className="content">
        <LeftContent/>
        <RightContent/>
      </div>
    )
  }
}

function RightContent(){
  return (
    <div className="right-content">
      <RecentActivities/>  
      <ProfileOverview/>  
    </div>
  )
}

function LeftContent(){
  return (
    <div className="left-content">
      <UpContent/>
      <DownContent/>
    </div>
  )
}

function UpContent(){
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



function DownContent(){
  return (
    <div className="down-content">

    </div>
  )
}

function RecentActivities(){
  return (
    <div className="recent-activities">

    </div>
  )
}

function ProfileOverview(){
  return(
    <div className="profile-overview">

    </div>
  )
}

export default App
