
export default function fullName (source) {
  return source && Array.isArray(source)
    ? source.map(({ firstName, lastName }) => `${firstName} ${lastName}`)
    : `${source.firstName} ${source.lastName}`;
};
