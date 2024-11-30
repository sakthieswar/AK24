import React from 'react';
import { Container, Row, Col, Stack, Nav, NavLink } from 'react-bootstrap';
function Footer() {
    return (
        <footer>
            <Container fluid>
                <Row className="bg-primary text-white p-4" style={{ marginTop: '1%' }} >
                    <Col className="mx-5">
                        <Stack>
                            {/*<Image*/}
                            {/*src="https://www.shutterstock.com/image-vector/abstract-initial-letter-d-logo-600nw-2055050639.jpg"*/}
                            {/*alt="company logo"*/}
                            {/*rounded*/}
                            {/*width={150}*/}
                            {/*height={150}></Image>*/}

                            <h2>Brand name</h2>
                            <p>Address</p>
                            <p> Contact No</p>
                            <p> website name</p>
                            <p> email</p>
                        </Stack>
                    </Col>
                    <Col>
                        <Nav className="flex-column fs-5">
                            Useful Links
                            <NavLink href="#" className="text-white">Home</NavLink>
                            <NavLink href="#" className="text-white">About</NavLink>
                            <NavLink href="#" className="text-white">Products</NavLink>
                        </Nav>
                    </Col>
                    <Col>
                        <h4>Contact us !</h4>
                        <p>email@fakeemail.com</p>
                        <p>Phone: +1(234)867-2134</p>
                    </Col>
                </Row>
            </Container>
        </footer>
    )
}

export default Footer;