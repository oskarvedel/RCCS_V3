import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Button } from 'reactstrap';

export class BoligListe extends React.Component {
    static displayName = BoligListe.name;
    
    constructor(props) {
        super(props);
        this.state = { boligliste: [], loading: true, available: null };
        this.func = this.func.bind(this);
    }

    func(e, a) {
        if (a === 1) {
            e.preventDefault();
        }
    }

    componentDidMount() {
        this.populateBoligData();
    }

    static renderBoligTable(boligliste, available) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Type</th>
                        <th>Address</th>
                        <th>Available Spaces</th>
                        <th>Max Spaces</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                {boligliste.map(bolig =>
                    <tr key={bolig.respiteCareHome}>
                        <td>{bolig.respiteCareHome}</td>
                        <td>{bolig.type}</td>
                        <td>{bolig.address}</td>
                        <td>{bolig.availableRespiteCareRooms}</td>
                        <td>{bolig.respiteCareRoomsTotal}</td>
                        <td>

                            <Link to={{ pathname: "./opretborger", state: { type: bolig.type, name: bolig.respiteCareHome } }} className="btn btn-primary" color="white" >Opret Borger</Link>
                            
                        </td>  
                    </tr>
                )}
                </tbody>
            </table>
        );
    }


    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : BoligListe.renderBoligTable(this.state.boligliste, this.state.available);
        

        return (
            <div>
                <h1 id="tabelLabel" >Bolig liste</h1>
                <p>Her kan der ses en liste over boliger i systemet.</p>
                {contents}
            </div>
        );
    }

    async populateBoligData() {
        const response = await fetch('https://localhost:44356/rccsdb/RespiteCareHomeList');
        const data = await response.json();
        
        this.setState({ boligliste: data, loading: false });
    }

}


