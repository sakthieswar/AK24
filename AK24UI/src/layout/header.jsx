import React from 'react';
import '/node_modules/bootstrap/dist/css/bootstrap.css';
//import Button from 'react-bootstrap/Button';
import logo from '../assets/logo.jpg';
import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Form from 'react-bootstrap/Form';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
/*import NavDropdown from 'react-bootstrap/NavDropdown';*/

// importing components from react-router-dom package


function Header() {
    return (
        <>
            
            <Navbar expand="lg" fixed="top" className="bg-body-tertiary">
                <> <Container fluid>
                    <Navbar.Brand href="#"> <img src={logo} alt="Logo" style={{ width: '30px', height: '30px' }} /> C M Doors And Windows</Navbar.Brand>
                    <Navbar.Toggle aria-controls="navbarScroll" />
                    <Navbar.Collapse id="navbarScroll">
                        <Nav
                            className="me-auto my-2 my-lg-0"
                            style={{ maxHeight: '100px' }}
                            navbarScroll
                        >
                            {/*<Nav.Link href="#action1">Home</Nav.Link>*/}
                            {/*<Nav.Link href="#action2">Link</Nav.Link>*/}
                            {/*<NavDropdown title="Link" id="navbarScrollingDropdown">*/}
                            {/*    <NavDropdown.Item href="#action3">Action</NavDropdown.Item>*/}
                            {/*    <NavDropdown.Item href="#action4">*/}
                            {/*        Another action*/}
                            {/*    </NavDropdown.Item>*/}
                            {/*    <NavDropdown.Divider />*/}
                            {/*    <NavDropdown.Item href="#action5">*/}
                            {/*        Something else here*/}
                            {/*    </NavDropdown.Item>*/}
                            {/*</NavDropdown>*/}
                            {/*<Nav.Link href="#" disabled>*/}
                            {/*    Link*/}
                            {/*</Nav.Link>*/}
                        </Nav>
                        <Form className="d-flex">
                            <Form.Control
                                type="search"
                                placeholder="Search"
                                className="me-2"
                                aria-label="Search"
                            />
                            <Button variant="outline-success">Search</Button>
                        </Form>
                    </Navbar.Collapse>
                </Container>
                    <br></br>
                    
                </>
            </Navbar>
            <Container fixed="top" className="bg-body-tertiary" fluid style={{ marginTop: '5%', padding: '0'}}>
                
                <Nav activeKey="/home" bg="dark" data-bs-theme="dark" style={{ backgroundColor: 'currentcolor' }}>
                    <Nav.Item>
                        <Nav.Link></Nav.Link>
                    </Nav.Item>
                    <Nav.Item>
                        <Nav.Link href="/home">Home</Nav.Link>
                    </Nav.Item>
                    <Nav.Item>
                        <Nav.Link href="/about">About</Nav.Link>
                    </Nav.Item>
                    {/* <Nav.Item>
                        <Nav.Link href="/product">Product</Nav.Link>
                    </Nav.Item> */}
                    <Nav.Item>
                        <Nav.Link href="/services">Services</Nav.Link>
                    </Nav.Item>
                    <Nav.Item>
                        <Nav.Link href="/contact">Contact</Nav.Link>
                    </Nav.Item>
                </Nav >
            </Container>
        </>
    );
}
export default Header;