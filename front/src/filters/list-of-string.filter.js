
export default function listOfString (list, name) {
  return list.map(element => ' ' + element[name]).join();
};
