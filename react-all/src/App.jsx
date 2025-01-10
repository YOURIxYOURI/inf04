
import { Route, BrowserRouter, Routes} from "react-router-dom"
import  Home  from "./components/home"
import  Details  from "./components/details"
import './App.css'
import 'bootstrap/dist/css/bootstrap.css';

function App() {

  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/details" element={<Details />} />
      </Routes>
    </BrowserRouter>
  )
}

export default App
