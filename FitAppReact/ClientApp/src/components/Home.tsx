

import * as React from "react";
import { connect } from "react-redux";

import Disclaimer from "./Sections/HomePage/Disclaimer";

const Home = () => (
  <div>
    <Disclaimer />
  </div>
);

export default connect()(Home);
