//Program powstał na Wydziale Informatyki Politechniki Białostockiej

import * as React from "react";
import {
  Collapse,
  Container,
  Navbar,
  NavbarBrand,
  NavbarToggler,
  NavItem,
  NavLink,
} from "reactstrap";
import { Link } from "react-router-dom";

import { makeStyles } from "@material-ui/styles";

import "./NavMenu.css";
import { selectUser } from "../store/User/UserSlice";
import { useSelector } from "react-redux";
import { ApplicationPaths } from "./api-authorization/ApiAuthorizationConstants";

const useStyles = makeStyles({
  customLink: {
    color: "#fff !important",
    backgroundColor: "#000",
    border: "1px solid",
    borderColor: "#000",
    borderRadius: "5px",
    margin: "5px",
    "&:hover": {
      color: "#000 !important",
      backgroundColor: "#fff",
      border: "1px solid",
      borderColor: "#000",
    },
    "&:active": {
      color: "#fff !important",
      backgroundColor: "#000",
      border: "1px solid",
      borderColor: "#000",
    },
  },
});

const NavMenuFc: React.FC = () => {
  const classes = useStyles();
  const [isOpen, setIsOpen] = React.useState(false);

  const toggle = () => {
    setIsOpen(!isOpen);
  };

  const user = useSelector(selectUser);
  const showLogout = user.id !== "0";

  return (
    <header>
      <Navbar
        className="navbar-expand-sm navbar-toggleable-sm border-bottom box-shadow mb-3"
        light
      >
        <Container>
          <NavbarBrand tag={Link} to="/">
            FitAppReact
          </NavbarBrand>
          <NavbarToggler onClick={toggle} className="mr-2" />
          <Collapse
            className="d-sm-inline-flex flex-sm-row-reverse"
            isOpen={isOpen}
            navbar
          >
            <ul className="navbar-nav flex-grow">
              <NavItem>
                <NavLink tag={Link} className={classes.customLink} to="/">
                  Home
                </NavLink>
              </NavItem>
              <NavItem>
                <NavLink
                  tag={Link}
                  className={classes.customLink}
                  to="/user-hub"
                >
                  User hub
                </NavLink>
              </NavItem>
              <NavItem>
                <NavLink
                  tag={Link}
                  className={classes.customLink}
                  to={ApplicationPaths.Profile}
                >
                  My profile
                </NavLink>
              </NavItem>
            </ul>
          </Collapse>
        </Container>
      </Navbar>
    </header>
  );
};

export default NavMenuFc;
