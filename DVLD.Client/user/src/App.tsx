import './App.css'
import MainContent from './components/MainContent/MainContent'
import SideBare from './components/side-bar/SideBar'

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

export default App
