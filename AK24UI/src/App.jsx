import logo from './logo.svg';
import React from 'react';
import './App.css';
import Header from './layout/header';
import Footer from './layout/footer';
// import ItemTile from './pages/item';
// import Product from "./pages/product";
// import ProductDetails from "./pages/productdetails";
import Home from "./pages/home";
import Contact from "./pages/contact";
import Services from "./pages/services";
import About from "./pages/about";
import { BrowserRouter as Router, Routes, Route, } from "react-router-dom";

function App() {
  return (
    <div><Header />
    <h1>
            We are currently using react version{" "}
            {React.version}
        </h1>
        <Router>
     <Routes>
         <Route path="/home" element={<Home />} />
         <Route path="/contact" element={<Contact />} />
         <Route path="/services" element={<Services />} />
         <Route path="/about" element={<About />} />
     </Routes>
 </Router>
    <Footer />
</div>
    // <div className="App">
    //   <header className="App-header">
    //     <img src={logo} className="App-logo" alt="logo" />
    //     <p>
    //       Edit <code>src/App.js</code> and save to reload.
    //     </p>
    //   </header>
    // </div>
  );
}

export default App;
