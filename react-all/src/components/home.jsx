import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import "../App.css";
import logo from "../assets/react.svg";

function Home() {
    const navigate = useNavigate();
    const [data, setData] = useState([]);
    const [name, setName] = useState("");
    const [age, setAge] = useState(0);
    const [sex, setSex] = useState("Mężczyzna");
    const [job, setJob] = useState("");
    const [date, setDate] = useState("");

    const onSubmit = () => {
        var employe = {
            Id: data.length,
            Name: name,
            Age: age,
            Sex: sex,
            Job: job,
            JoinDate: date,
        };
        setData([...data, employe]);
    };

    const goToDetails = (data) => {
        navigate("/details", { state: { Data: data } });
    };

    const jobs = ["Praca 1", "Praca 2", "Praca 3"];

    return (
        <div>
            <h2>Strona testowa</h2>

            <div className="form-group mb-2">
                <label htmlFor="name">Imię</label>
                <input
                    id="name"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                    className="form-control"
                ></input>
            </div>
            <div className="form-group mb-2">
                <label htmlFor="age">wiek</label>
                <input
                    type="number"
                    name="age"
                    min="0"
                    max="99"
                    value={age}
                    onChange={(e) => setAge(Number(e.target.value))}
                    className="form-control"
                />
            </div>
            <div className="form-group mb-2">
                <input
                    style={{ margin: "10px" }}
                    type="radio"
                    name="radioGroup"
                    id="male"
                    value="Mężczyzna"
                    checked={sex === "Mężczyzna"}
                    onChange={(e) => setSex(e.target.value)}
                ></input>
                <label htmlFor="male" style={{ margin: "10px" }}>
                    Mężczyna
                </label>

                <input
                    type="radio"
                    style={{ margin: "10px" }}
                    name="radioGroup"
                    id="female"
                    value="Kobieta"
                    checked={sex === "Kobieta"}
                    onChange={(e) => setSex(e.target.value)}
                ></input>
                <label htmlFor="female">Kobieta</label>
            </div>
            <div className="form-group mb-2">
                <label htmlFor="jobSelect" style={{ margin: "10px" }}>
                    Stanowisko
                </label>
                <select
                    id="jobSelect"
                    value={job}
                    onChange={(e) => setJob(e.target.value)}
                    className="form-control"
                >
                    <option hidden defaultChecked></option>
                    {jobs.map((index, key) => (
                        <option key={key}>{index}</option>
                    ))}
                </select>
            </div>
            <div className="form-group mb-2">
                <label htmlFor="datePicker">Data dołączenia</label>
                <input
                    type="date"
                    id="datePicker"
                    value={date}
                    onChange={(e) => setDate(e.target.value)}
                    className="form-control"
                ></input>
            </div>
            <div>
                <button className="btn btn-primary" onClick={onSubmit}>
                    Wyślij
                </button>
                <img
                    src={logo}
                    style={{ width: "10vw", height: "10vh" }}
                    alt="obraz"
                ></img>
            </div>
            <div>
                <ul className="list-group">
                    {data.map((index, key) => (
                        <li className="list-group-item" key={key}>
                            <a style={{ margin: "10px" }}>{index.Name}</a>
                            <button onClick={() => goToDetails(index)}>
                                Szczegóły
                            </button>
                        </li>
                    ))}
                </ul>
            </div>
        </div>
    );
}

export default Home;
