import React, { useEffect, useState } from "react";
import api from "./api";

function App() {
  const [deployment, setDeployment] = useState(null);

  useEffect(() => {
    api.get("/deployment")
      .then(res => setDeployment(res.data))
      .catch(err => console.log(err));
  }, []);

  return (
    <div style={{ padding: "40px" }}>
      <h1>Azure DevOps CI/CD Dashboard</h1>

      {deployment && (
        <div>
          <h3>{deployment.applicationName}</h3>
          <p>Environment: {deployment.environment}</p>
          <p>Version: {deployment.version}</p>
        </div>
      )}
    </div>
  );
}

export default App;