import 'bootstrap/dist/css/bootstrap.css'
import './App.css';
import { useState } from 'react';


function App() {

  const[title, setTitle] = useState("");
  const[category, setCategory] = useState(0);

  const formSubmit = () => {
    console.log(`tytuł: ${title}; rodzaj: ${category}`)
  }

  return (
    <div className="App">
      <form action={formSubmit}>
        <div className='form-group'>
          <label htmlFor='TitleInput'>
            Tytuł filmu:
          </label>
          <input id='TitleInput' type='text' className='form-control mt-1' value={title} onChange={(e) => {setTitle(e.target.value)}}>
          </input>
        </div>
        <div className='form-group'>
          <label htmlFor='CategorySelect'>
            Rodzaj:
          </label>
          <select id='CategorySelect' className='form-select mt-1' onChange={(e)=>{setCategory(e.target.value)}}>
            <option value="0" defaultChecked></option>
            <option value="1">Komedia </option>
            <option value="2">Obyczajowy </option>
            <option value="3">Sensacyjny </option>
            <option value="4">Horror </option>
          </select>
        </div>
        <button type='submit' className='btn btn-primary mt-3'>Dodaj</button>
      </form>
    </div>
  );
}

export default App;
