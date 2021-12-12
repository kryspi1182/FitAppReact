import * as React from 'react';
import { Container, Row, Col } from 'reactstrap';

import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';
import Modal from '@material-ui/core/Modal';
import Backdrop from '@material-ui/core/Backdrop';
import Fade from '@material-ui/core/Fade';
import Button from '@material-ui/core/Button';

import CloseIcon from '@material-ui/icons/Close';

type Props = {
    title: string,
    content: React.ReactNode
};

const useStyles = makeStyles({
    modal: {
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
      },
      paper: {
        border: '2px solid #000',
        backgroundColor: '#fff',
        padding: '10px',
        borderRadius: '5px'
        
      },
      column: {
        marginLeft: "auto",
        marginRight: "auto"
      },
      closeColumn: {
        float: "right"
      },
      content: {
        overflowY: "auto",
        maxHeight: "80vh",
        maxWidth: "inherit"
      },
      exitButton: {
        float: 'right'
      }
});

const ModalWithContent: React.FC<Props> = (props) => {
    const classes = useStyles();
    const [open, setOpen] = React.useState(false);

    const handleOpen = () => {
        setOpen(true);
    };

    const handleClose = () => {
        setOpen(false);
    };

    return (
        <div>
          <Button type="button" onClick={handleOpen} variant="outlined" color="secondary">
            {props.title}
          </Button>
          <Modal
            aria-labelledby="transition-modal-title"
            aria-describedby="transition-modal-description"
            className={classes.modal}
            open={open}
            onClose={handleClose}
            closeAfterTransition
            BackdropComponent={Backdrop}
            BackdropProps={{
              timeout: 500,
            }}
          >
            <Fade in={open}>
              <Container className={classes.paper}>
                <Row>
                  <Col className={classes.closeColumn}>
                    <Button onClick={handleClose} className={classes.exitButton}>
                      <CloseIcon />
                    </Button>
                  </Col>
                </Row>
                <Row className={classes.content}>
                  <Col className={classes.column}>
                    {props.content}
                  </Col>
                </Row>
              </Container>
            </Fade>
          </Modal>
        </div>
      );
};

export default ModalWithContent;