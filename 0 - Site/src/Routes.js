import {  Route, BrowserRouter } from 'react-router-dom';
import React from 'react';
import resultado from './components/resultado/resultado';
import Root from './components/Root';






const Routes = () => (
    
        <BrowserRouter>
           <div>
               <Route  exact path="/" component={Root} />
                <Route path="/resultado" component={resultado} />

            </div>
    </BrowserRouter>
  
)
export default Routes;
