import {useState} from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';

function App() {

  const courses = ["Programowanie w C#","Angular dla początkujących","Kurs Django"]
  const[name, setName] = useState("")
  const[courseNumber, setCourseNumber] = useState()

  const onSubmit = () => {
    console.log(name)
    if(courseNumber < 0 || courseNumber > courses.length)
      console.log("Nieprawidłowy numer kursu")
    else
      console.log(courses[courseNumber-1])
  }

  return (
    <div style={{width: '90%', padding: '15px'}}>
      <h2>Liczba kursów: {courses.length}</h2>
      <ol>
        {courses.map((index, key)=>(
          <li key={key}>{index}</li>
        ))}
      </ol>
      <div className='form-group' style={{marginTop:'10px'}}>
        <label htmlFor="name">Imię i nazwisko:</label>
        <input type="text" id="name" value={name} onChange={(e)=>{setName(e.target.value)}} className='form-control'></input>
      </div>
      <div className='form-group' style={{marginTop:'10px'}}>
        <label htmlFor="nr">Numer kursu:</label>
        <input type="number" id="nr" value={courseNumber} onChange={(e)=>{setCourseNumber(e.target.value)}} className='form-control'></input>
      </div>
      <button onClick={onSubmit} className='btn btn-primary' style={{marginTop:'10px'}}>Zapisz do kursu</button>
    </div>
  );
}

export default App;
