import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler'


function BowlerList(){

    const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

    useEffect (() => {

        const fetchBowlerData = async () =>{
            const rsp = await fetch('http://localhost:5105/Bowler')
            const f  = await rsp.json();
            setBowlerData(f);
        };
    fetchBowlerData();
    }, []);
    
    const filteredBowlerData = bowlerData.filter(
        (f) => f.teamName === 'Marlins' || f.teamName === 'Sharks',
      );

    return (
        <>
        <div className='row'>
            <h4 className="text-center">Bowlers</h4>
        </div>
        <table className="table table-bordered">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Middle initial</th>
                    <th>Last Name</th>
                    <th>Team Name</th>
                    <th>Address</th>
                    <th>City</th>
                    <th>State</th>
                    <th>Zip</th>
                    <th>Phone Number</th>
                </tr>
            </thead>
            <tbody>
                {filteredBowlerData.map((f) => (

                    <tr key={f.id}>
                    <td>{f.firstName}</td>
                    <td>{f.middleInitial}</td>
                    <td>{f.lastName}</td>
                    <td>{f.teamName}</td>
                    <td>{f.address}</td>
                    <td>{f.city}</td>
                    <td>{f.state}</td>
                    <td>{f.zip}</td>
                    <td>{f.phoneNumber}</td>
                    

                    </tr>

                ))}
               
            </tbody>

        </table>
        </>
    );
}

export default BowlerList;