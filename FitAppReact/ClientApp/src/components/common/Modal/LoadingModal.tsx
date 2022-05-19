

import * as React from "react";
import { Container, Col, Row } from "reactstrap";

import { makeStyles, Theme, createStyles } from "@material-ui/core/styles";
import Button from "@material-ui/core/Button";
import Modal from "@material-ui/core/Modal";
import Backdrop from "@material-ui/core/Backdrop";
import CloseIcon from "@material-ui/icons/Close";
import CircularProgress from "@material-ui/core/CircularProgress";
import CheckCircleOutlineIcon from "@material-ui/icons/CheckCircleOutline";

type Props = {
  loaded: boolean;
  open: boolean;
  setOpen: Function;
};

const useStyles = makeStyles({
  formControl: {
    display: "block",
  },
  container: {
    //padding: '10px'
  },
  column: {
    textAlign: "center",
  },
  formInput: {
    width: "100%",
  },
  row: {
    marginBottom: "10px",
    paddingBottom: "10px",
  },
  title: {
    textAlign: "center",
  },
  submitButton: {
    float: "right",
  },
  modal: {
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
  },
  paper: {
    border: "2px solid #000",
    backgroundColor: "#fff",
    padding: "10px",
    borderRadius: "5px",
    minHeight: "400px",
    width: "50%",
  },
  content: {
    overflowY: "auto",
    maxHeight: "80vh",
    maxWidth: "inherit",
  },
  exitButton: {
    float: "right",
  },
  spinner: {
    color: "#000",
  },
});

const LoadingModal: React.FC<Props> = (props) => {
  const classes = useStyles();
  const handleClose = () => {
    props.setOpen(false);
  };
  return (
    <Modal
      aria-labelledby="transition-modal-title"
      aria-describedby="transition-modal-description"
      className={classes.modal}
      open={props.open}
      onClose={handleClose}
      closeAfterTransition
      BackdropComponent={Backdrop}
      BackdropProps={{
        timeout: 500,
      }}
    >
      <Container className={classes.paper}>
        <Row>
          <Col>
            <Button onClick={handleClose} className={classes.exitButton}>
              <CloseIcon />
            </Button>
          </Col>
        </Row>
        <Row>
          {!props.loaded && (
            <Col className={classes.column}>
              <CircularProgress
                className={classes.spinner}
                size={200}
                thickness={4}
              />
            </Col>
          )}
          {props.loaded && (
            <Col className={classes.column}>
              <Row>
                <Col>
                  <CheckCircleOutlineIcon style={{ fontSize: 300 }} />
                </Col>
              </Row>
              <Row>
                <Col>
                  <h4>Done</h4>
                </Col>
              </Row>
            </Col>
          )}
        </Row>
      </Container>
    </Modal>
  );
};

export default LoadingModal;
