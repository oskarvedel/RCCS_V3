import React, { Component } from 'react';
//import '../CSS/WelcomeStyleSheet.css'

export class Welcome extends Component {
    static displayName = Welcome.name;

    render() {
        return (
            <div>
                <h1> Welcome to RCCS: Respite Care Communication System</h1>
                <p><strong>Som Plejepersonale:</strong></p>
                <ul>
                    <li>Er det muligt at finde en liste over de Borger eller Boliger der er.</li>
                    <li>Samt kan du oprette nye rapporter eller opdatere allerede eksisterende.</li>
                </ul>
                <p><strong>Som Koordinator:</strong></p>
                <ul>
                    <li>Er det muligt at finde en liste over de Borger eller Boliger der er.</li>
                    <li>Samt laese de rapporter der er blevet oprettet af plejepersonale.</li>
                </ul>
            </div>
        );
    }
}