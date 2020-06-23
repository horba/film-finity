
export default function fullName (source) {
  return source.length
    ? source.map(({ firstName, lastName }) => `${firstName} ${lastName}`)
    : null;
};
