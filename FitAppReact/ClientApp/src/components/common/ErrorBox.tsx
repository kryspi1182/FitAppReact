import React from "react";

type Props = {
    message: string,
};

const ErrorBox: React.FC<Props> = (props) => {
    return(<>
        <h3>Error</h3>
        <p>Something went wrong while processing your request. Please try again, if the problem persists, contact the administrator and provide them the message below. We apologize for the inconvinience.</p>
        <p>{props.message}</p>
    </>)
};

export default ErrorBox;