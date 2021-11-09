import * as React from 'react';
import { connect } from 'react-redux';

const Home = () => (
  <div>
    <h1>Hello, world!</h1>
    <p>
      <span>Here will be a robust yet understandable description of what to expect while using this website and what it is for. </span>
      <span>One day, it will appear. <br /></span>
      <span>BUT IT IS NOT THIS DAY! </span>
      <span>THIS DAY!...is a lorem ipsum placeholder because I have no idea what should be here, it's late and I need sleep. <br /></span>
      <span>Not the perfect conditions for creative thinking as you can guess. So rejoice, the almighty lorem ipsum. <br /></span>
      <span>I wonder if somewhere in it is an ancient spell used to summon the Old Ones. <br /></span>
    </p>
    <p>
      <span>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec convallis quis magna ut rutrum. Fusce molestie viverra dignissim. Nulla sed auctor sem. Integer sit amet maximus diam. In hac habitasse platea dictumst. Phasellus purus justo, facilisis ac placerat a, porta non nulla. Nullam eleifend egestas lacus, et rhoncus nibh ornare nec. Vestibulum vitae libero eget arcu commodo faucibus sit amet sed mi.

        Nullam in ipsum dictum, convallis sem ut, accumsan nulla. Vivamus consequat magna at augue tempor, in ullamcorper dui finibus. Proin enim nulla, vehicula ac metus vel, dictum lacinia tellus. Suspendisse id dictum ipsum, sit amet suscipit dui. Phasellus dapibus sem accumsan accumsan rutrum. Sed mauris dolor, lacinia id sollicitudin sit amet, interdum a sapien. Vivamus vitae augue auctor, suscipit neque ac, vulputate sapien. Vivamus non nisi quis ante mollis tristique. Proin molestie et lectus sed efficitur. Nullam facilisis ante egestas, elementum nisi sed, pellentesque metus. In ultrices enim augue, sit amet imperdiet ex consectetur vitae. Cras tempor, ante sit amet rhoncus viverra, quam erat suscipit libero, pulvinar auctor tortor ex non justo.
      </span>
    </p>
  </div>
);

export default connect()(Home);
