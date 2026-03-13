
import http from 'k6/http';
import { sleep } from 'k6';

export default function () {
  http.post('http://localhost:5050/api/v1/simulacao/vgbl', JSON.stringify({aporte:700000}), {
    headers: { 'Content-Type': 'application/json' }
  });
  sleep(1);
}
