# DivisibleByEleven

Use HTTP GET with URI http://localhost:38920/divisiblebyeleven
Body should include a JSON:

`
{
  "numbers": [
    "112233",
    "30800",
    "2937.66",
    "-323455693",
    "5038297a",
    "112234",
    "4611686018427387903307445734561825860223058430092136939511844674407370"
  ]
}
`

It'll only return for valid UInt64 values.
