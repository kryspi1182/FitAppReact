import { copyFile, watch, readdirSync, watchFile, readFile } from "fs";

const __filename = "../../FitAppReact.Common/Resources/ResourceMappingToJs.js";
const updateResources = () => {
  copyFile(__filename, "./src/consts/Resources.js", (err) => {
    if (err) throw err;
    console.log("source was copied to destination");
  });
};

console.log("Watching for changes in resources");
watchFile(__filename, (curr, prev) => {
  if (curr.mtime > prev.mtime) {
    readFile(__filename, (err, data) => {
      if (err) throw err;
      updateResources();
    });
  }
});
