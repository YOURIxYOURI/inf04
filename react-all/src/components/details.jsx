
import { useLocation, useNavigate} from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.css';

function Details() {
    const navigate = useNavigate()
    const location = useLocation()
    const data = location.state.Data

    const goBack = () =>{

        navigate('/')
    }
  return (
    <div>
         <div className='mb-3'>
            <p>imie: {data.Name}</p>
            <p>Wiek: {data.Age}</p>
            <p>Płeć: {data.Sex}</p>
            <p>Stanowisko: {data.Job}</p>
            <p>Data dołączenia: {data.Date}</p>
        </div>
        <div className='mb-3'>
            <button className='btn btn-primary' onClick={goBack}>Wróć</button>
        </div>
    </div>  
  )
}

export default Details
