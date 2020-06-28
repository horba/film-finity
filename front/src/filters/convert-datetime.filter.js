import { format } from 'date-fns';
const defaultFormat = 'dd.MM.yyyy kk:mm';
export default function convertDateTime (DateTime, dataFormat) {
  return typeof dataFormat === 'string' ? format(new Date(DateTime), dataFormat)
    : format(new Date(DateTime), defaultFormat);
};
