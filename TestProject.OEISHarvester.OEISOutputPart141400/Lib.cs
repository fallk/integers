using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A170705
{
public static readonly BigInteger[] Value={ 1L,24L,552L,12696L,292008L,6716184L,154472232L,3552861336L,81715810728L,1879463646744L,43227663875112L,994236269127576L,22867434189934248L,525950986368487704L,12096872686475217192UL,BigInteger.Parse("278228071788929995416") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170705Inst Instance=new A170705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170706
{
public static readonly BigInteger[] Value={ 1L,25L,600L,14400L,345600L,8294400L,199065600L,4777574400L,114661785600L,2751882854400L,66045188505600L,1585084524134400L,38042028579225600L,913008685901414400L,BigInteger.Parse("21912208461633945600"),BigInteger.Parse("525893003079214694400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170706Inst Instance=new A170706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170707
{
public static readonly BigInteger[] Value={ 1L,26L,650L,16250L,406250L,10156250L,253906250L,6347656250L,158691406250L,3967285156250L,99182128906250L,2479553222656250L,61988830566406250L,1549720764160156250L,BigInteger.Parse("38743019104003906250"),BigInteger.Parse("968575477600097656250") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170707Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170707.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170707Inst Instance=new A170707Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170708
{
public static readonly BigInteger[] Value={ 1L,27L,702L,18252L,474552L,12338352L,320797152L,8340725952L,216858874752L,5638330743552L,146596599332352L,3811511582641152L,99099301148669952L,2576581829865418752L,BigInteger.Parse("66991127576500887552"),BigInteger.Parse("1741769316989023076352") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170708Inst Instance=new A170708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170709
{
public static readonly BigInteger[] Value={ 1L,28L,756L,20412L,551124L,14880348L,401769396L,10847773692L,292889889684L,7908027021468L,213516729579636L,5764951698650172L,155653695863554644L,4202649788315975388L,BigInteger.Parse("113471544284531335476"),BigInteger.Parse("3063731695682346057852") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170709Inst Instance=new A170709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170710
{
public static readonly BigInteger[] Value={ 1L,29L,812L,22736L,636608L,17825024L,499100672L,13974818816L,391294926848L,10956257951744L,306775222648832L,8589706234167296L,240511774556684288L,6734329687587160064L,BigInteger.Parse("188561231252440481792"),BigInteger.Parse("5279714475068333490176") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170710Inst Instance=new A170710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170711
{
public static readonly BigInteger[] Value={ 1L,30L,870L,25230L,731670L,21218430L,615334470L,17844699630L,517496289270L,15007392388830L,435214379276070L,12621216999006030L,366015292971174870L,10614443496164071230UL,BigInteger.Parse("307818861388758065670"),BigInteger.Parse("8926746980273983904430") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170711Inst Instance=new A170711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170712
{
public static readonly BigInteger[] Value={ 1L,31L,930L,27900L,837000L,25110000L,753300000L,22599000000L,677970000000L,20339100000000L,610173000000000L,18305190000000000L,549155700000000000L,16474671000000000000UL,BigInteger.Parse("494240130000000000000"),BigInteger.Parse("14827203900000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170712Inst Instance=new A170712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170713
{
public static readonly BigInteger[] Value={ 1L,32L,992L,30752L,953312L,29552672L,916132832L,28400117792L,880403651552L,27292513198112L,846067909141472L,26228105183385632L,813071260684954592L,BigInteger.Parse("25205209081233592352"),BigInteger.Parse("781361481518241362912"),BigInteger.Parse("24222205927065482250272") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170713Inst Instance=new A170713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170714
{
public static readonly BigInteger[] Value={ 1L,33L,1056L,33792L,1081344L,34603008L,1107296256L,35433480192L,1133871366144L,36283883716608L,1161084278931456L,37154696925806592L,1188950301625810944L,BigInteger.Parse("38046409652025950208"),BigInteger.Parse("1217485108864830406656"),BigInteger.Parse("38959523483674573012992") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170714Inst Instance=new A170714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170715
{
public static readonly BigInteger[] Value={ 1L,34L,1122L,37026L,1221858L,40321314L,1330603362L,43909910946L,1449027061218L,47817893020194L,1577990469666402L,52073685498991266L,1718431621466711778L,BigInteger.Parse("56708243508401488674"),BigInteger.Parse("1871372035777249126242"),BigInteger.Parse("61755277180649221165986") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170715Inst Instance=new A170715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170716
{
public static readonly BigInteger[] Value={ 1L,35L,1190L,40460L,1375640L,46771760L,1590239840L,54068154560L,1838317255040L,62502786671360L,2125094746826240L,72253221392092160L,2456609527331133440L,BigInteger.Parse("83524723929258536960"),BigInteger.Parse("2839840613594790256640"),BigInteger.Parse("96554580862222868725760") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170716Inst Instance=new A170716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170717
{
public static readonly BigInteger[] Value={ 1L,36L,1260L,44100L,1543500L,54022500L,1890787500L,66177562500L,2316214687500L,81067514062500L,2837362992187500L,99307704726562500L,3475769665429687500L,BigInteger.Parse("121651938290039062500"),BigInteger.Parse("4257817840151367187500"),BigInteger.Parse("149023624405297851562500") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170717Inst Instance=new A170717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170718
{
public static readonly BigInteger[] Value={ 1L,37L,1332L,47952L,1726272L,62145792L,2237248512L,80540946432L,2899474071552L,104381066575872L,3757718396731392L,135277862282330112L,4870003042163884032L,BigInteger.Parse("175320109517899825152"),BigInteger.Parse("6311523942644393705472") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170718Inst Instance=new A170718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170719
{
public static readonly BigInteger[] Value={ 1L,38L,1406L,52022L,1924814L,71218118L,2635070366L,97497603542L,3607411331054L,133474219248998L,4938546112212926L,182726206151878262L,6760869627619495694L,BigInteger.Parse("250152176221921340678"),BigInteger.Parse("9255630520211089605086") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170719Inst Instance=new A170719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170720
{
public static readonly BigInteger[] Value={ 1L,39L,1482L,56316L,2140008L,81320304L,3090171552L,117426518976L,4462207721088L,169563893401344L,6443427949251072L,244850262071540736L,9304309958718547968UL,BigInteger.Parse("353563778431304822784"),BigInteger.Parse("13435423580389583265792") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170720Inst Instance=new A170720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170721
{
public static readonly BigInteger[] Value={ 1L,40L,1560L,60840L,2372760L,92537640L,3608967960L,140749750440L,5489240267160L,214080370419240L,8349134446350360L,325616243407664040L,12699033492898897560UL,BigInteger.Parse("495262306223057004840"),BigInteger.Parse("19315229942699223188760") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170721Inst Instance=new A170721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170722
{
public static readonly BigInteger[] Value={ 1L,41L,1640L,65600L,2624000L,104960000L,4198400000L,167936000000L,6717440000000L,268697600000000L,10747904000000000L,429916160000000000L,17196646400000000000UL,BigInteger.Parse("687865856000000000000"),BigInteger.Parse("27514634240000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170722Inst Instance=new A170722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170723
{
public static readonly BigInteger[] Value={ 1L,42L,1722L,70602L,2894682L,118681962L,4865960442L,199504378122L,8179679503002L,335366859623082L,13750041244546362L,563751691026400842L,BigInteger.Parse("23113819332082434522"),BigInteger.Parse("947666592615379815402"),BigInteger.Parse("38854330297230572431482") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170723Inst Instance=new A170723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170724
{
public static readonly BigInteger[] Value={ 1L,43L,1806L,75852L,3185784L,133802928L,5619722976L,236028364992L,9913191329664L,416354035845888L,17486869505527296L,734448519232146432L,BigInteger.Parse("30846837807750150144"),BigInteger.Parse("1295567187925506306048"),BigInteger.Parse("54413821892871264854016") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170724Inst Instance=new A170724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170725
{
public static readonly BigInteger[] Value={ 1L,44L,1892L,81356L,3498308L,150427244L,6468371492L,278139974156L,11960018888708L,514280812214444L,22114074925221092L,950905221784506956L,BigInteger.Parse("40888924536733799108"),BigInteger.Parse("1758223755079553361644"),BigInteger.Parse("75603621468420794550692") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170725Inst Instance=new A170725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170726
{
public static readonly BigInteger[] Value={ 1L,45L,1980L,87120L,3833280L,168664320L,7421230080L,326534123520L,14367501434880L,632170063134720L,27815482777927680L,1223881242228817920L,BigInteger.Parse("53850774658067988480"),BigInteger.Parse("2369434084954991493120"),BigInteger.Parse("104255099738019625697280") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170726Inst Instance=new A170726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170727
{
public static readonly BigInteger[] Value={ 1L,46L,2070L,93150L,4191750L,188628750L,8488293750L,381973218750L,17188794843750L,773495767968750L,34807309558593750L,1566328930136718750L,BigInteger.Parse("70484801856152343750"),BigInteger.Parse("3171816083526855468750"),BigInteger.Parse("142731723758708496093750") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170727Inst Instance=new A170727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170728
{
public static readonly BigInteger[] Value={ 1L,47L,2162L,99452L,4574792L,210440432L,9680259872L,445291954112L,20483429889152L,942237774900992L,43342937645445632L,1993775131690499072L,BigInteger.Parse("91713656057762957312"),BigInteger.Parse("4218828178657096036352"),BigInteger.Parse("194066096218226417672192") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170728Inst Instance=new A170728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170729
{
public static readonly BigInteger[] Value={ 1L,48L,2256L,106032L,4983504L,234224688L,11008560336L,517402335792L,24317909782224L,1142941759764528L,53718262708932816L,2524758347319842352L,BigInteger.Parse("118663642324032590544"),BigInteger.Parse("5577191189229531755568"),BigInteger.Parse("262127985893787992511696") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170729Inst Instance=new A170729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170730
{
public static readonly BigInteger[] Value={ 1L,49L,2352L,112896L,5419008L,260112384L,12485394432L,599298932736L,28766348771328L,1380784741023744L,66277667569139712L,3181328043318706176L,BigInteger.Parse("152703746079297896448"),BigInteger.Parse("7329779811806299029504"),BigInteger.Parse("351829430966702353416192") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170730Inst Instance=new A170730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170731
{
public static readonly BigInteger[] Value={ 1L,50L,2450L,120050L,5882450L,288240050L,14123762450L,692064360050L,33911153642450L,1661646528480050L,81420679895522450L,3989613314880600050L,BigInteger.Parse("195491052429149402450"),BigInteger.Parse("9579061569028320720050"),BigInteger.Parse("469374016882387715282450") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170731Inst Instance=new A170731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170732
{
public static readonly BigInteger[] Value={ 1L,13L,156L,1872L,22464L,269568L,3234816L,38817792L,465813504L,5589762048L,67077144576L,804925734912L,9659108818944L,115909305827328L,1390911669927936L,16690940039135232L,200291280469622784L,2403495365635473408L,BigInteger.Parse("28841944387625680896"),BigInteger.Parse("346103332651508170752") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170732Inst Instance=new A170732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170733
{
public static readonly BigInteger[] Value={ 1L,14L,182L,2366L,30758L,399854L,5198102L,67575326L,878479238L,11420230094L,148462991222L,1930018885886L,25090245516518L,326173191714734L,4240251492291542L,55123269399790046L,716602502197270598L,9315832528564517774UL,BigInteger.Parse("121105822871338731062"),BigInteger.Parse("1574375697327403503806") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170733Inst Instance=new A170733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170734
{
public static readonly BigInteger[] Value={ 1L,15L,210L,2940L,41160L,576240L,8067360L,112943040L,1581202560L,22136835840L,309915701760L,4338819824640L,60743477544960L,850408685629440L,11905721598812160L,166680102383370240L,2333521433367183360L,BigInteger.Parse("32669300067140567040"),BigInteger.Parse("457370200939967938560"),BigInteger.Parse("6403182813159551139840") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170734Inst Instance=new A170734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170735
{
public static readonly BigInteger[] Value={ 1L,16L,240L,3600L,54000L,810000L,12150000L,182250000L,2733750000L,41006250000L,615093750000L,9226406250000L,138396093750000L,2075941406250000L,31139121093750000L,467086816406250000L,7006302246093750000L,BigInteger.Parse("105094533691406250000"),BigInteger.Parse("1576418005371093750000"),BigInteger.Parse("23646270080566406250000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170735Inst Instance=new A170735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170736
{
public static readonly BigInteger[] Value={ 1L,17L,272L,4352L,69632L,1114112L,17825792L,285212672L,4563402752L,73014444032L,1168231104512L,18691697672192L,299067162755072L,4785074604081152L,76561193665298432L,1224979098644774912L,BigInteger.Parse("19599665578316398592"),BigInteger.Parse("313594649253062377472"),BigInteger.Parse("5017514388048998039552") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170736Inst Instance=new A170736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170737
{
public static readonly BigInteger[] Value={ 1L,18L,306L,5202L,88434L,1503378L,25557426L,434476242L,7386096114L,125563633938L,2134581776946L,36287890208082L,616894133537394L,10487200270135698L,178282404592306866L,3030800878069216722L,BigInteger.Parse("51523614927176684274"),BigInteger.Parse("875901453762003632658"),BigInteger.Parse("14890324713954061755186") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170737Inst Instance=new A170737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170738
{
public static readonly BigInteger[] Value={ 1L,19L,342L,6156L,110808L,1994544L,35901792L,646232256L,11632180608L,209379250944L,3768826516992L,67838877305856L,1221099791505408L,21979796247097344L,395636332447752192L,7121453984059539456L,BigInteger.Parse("128186171713071710208"),BigInteger.Parse("2307351090835290783744"),BigInteger.Parse("41532319635035234107392") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170738Inst Instance=new A170738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170739
{
public static readonly BigInteger[] Value={ 1L,20L,380L,7220L,137180L,2606420L,49521980L,940917620L,17877434780L,339671260820L,6453753955580L,122621325156020L,2329805177964380L,44266298381323220L,841059669245141180L,15980133715657682420UL,BigInteger.Parse("303622540597495965980"),BigInteger.Parse("5768828271352423353620"),BigInteger.Parse("109607737155696043718780") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170739Inst Instance=new A170739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170740
{
public static readonly BigInteger[] Value={ 1L,21L,420L,8400L,168000L,3360000L,67200000L,1344000000L,26880000000L,537600000000L,10752000000000L,215040000000000L,4300800000000000L,86016000000000000L,1720320000000000000L,BigInteger.Parse("34406400000000000000"),BigInteger.Parse("688128000000000000000"),BigInteger.Parse("13762560000000000000000"),BigInteger.Parse("275251200000000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170740Inst Instance=new A170740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170741
{
public static readonly BigInteger[] Value={ 1L,22L,462L,9702L,203742L,4278582L,89850222L,1886854662L,39623947902L,832102905942L,17474161024782L,366957381520422L,7706105011928862L,161828205250506102L,3398392310260628142L,BigInteger.Parse("71366238515473190982"),BigInteger.Parse("1498691008824937010622"),BigInteger.Parse("31472511185323677223062"),BigInteger.Parse("660922734891797221684302") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170741Inst Instance=new A170741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170742
{
public static readonly BigInteger[] Value={ 1L,23L,506L,11132L,244904L,5387888L,118533536L,2607737792L,57370231424L,1262145091328L,27767192009216L,610878224202752L,13439320932460544L,295665060514131968L,6504631331310903296L,BigInteger.Parse("143101889288839872512"),BigInteger.Parse("3148241564354477195264"),BigInteger.Parse("69261314415798498295808"),BigInteger.Parse("1523748917147566962507776") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170742Inst Instance=new A170742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170743
{
public static readonly BigInteger[] Value={ 1L,24L,552L,12696L,292008L,6716184L,154472232L,3552861336L,81715810728L,1879463646744L,43227663875112L,994236269127576L,22867434189934248L,525950986368487704L,12096872686475217192UL,BigInteger.Parse("278228071788929995416"),BigInteger.Parse("6399245651145389894568"),BigInteger.Parse("147182649976343967575064") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170743Inst Instance=new A170743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170744
{
public static readonly BigInteger[] Value={ 1L,25L,600L,14400L,345600L,8294400L,199065600L,4777574400L,114661785600L,2751882854400L,66045188505600L,1585084524134400L,38042028579225600L,913008685901414400L,BigInteger.Parse("21912208461633945600"),BigInteger.Parse("525893003079214694400"),BigInteger.Parse("12621432073901152665600"),BigInteger.Parse("302914369773627663974400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170744Inst Instance=new A170744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170745
{
public static readonly BigInteger[] Value={ 1L,26L,650L,16250L,406250L,10156250L,253906250L,6347656250L,158691406250L,3967285156250L,99182128906250L,2479553222656250L,61988830566406250L,1549720764160156250L,BigInteger.Parse("38743019104003906250"),BigInteger.Parse("968575477600097656250"),BigInteger.Parse("24214386940002441406250"),BigInteger.Parse("605359673500061035156250") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170745Inst Instance=new A170745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170746
{
public static readonly BigInteger[] Value={ 1L,27L,702L,18252L,474552L,12338352L,320797152L,8340725952L,216858874752L,5638330743552L,146596599332352L,3811511582641152L,99099301148669952L,2576581829865418752L,BigInteger.Parse("66991127576500887552"),BigInteger.Parse("1741769316989023076352"),BigInteger.Parse("45286002241714599985152"),BigInteger.Parse("1177436058284579599613952") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170746Inst Instance=new A170746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170747
{
public static readonly BigInteger[] Value={ 1L,28L,756L,20412L,551124L,14880348L,401769396L,10847773692L,292889889684L,7908027021468L,213516729579636L,5764951698650172L,155653695863554644L,4202649788315975388L,BigInteger.Parse("113471544284531335476"),BigInteger.Parse("3063731695682346057852"),BigInteger.Parse("82720755783423343562004"),BigInteger.Parse("2233460406152430276174108") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170747Inst Instance=new A170747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170748
{
public static readonly BigInteger[] Value={ 1L,29L,812L,22736L,636608L,17825024L,499100672L,13974818816L,391294926848L,10956257951744L,306775222648832L,8589706234167296L,240511774556684288L,6734329687587160064L,BigInteger.Parse("188561231252440481792"),BigInteger.Parse("5279714475068333490176"),BigInteger.Parse("147832005301913337724928") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170748Inst Instance=new A170748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170749
{
public static readonly BigInteger[] Value={ 1L,30L,870L,25230L,731670L,21218430L,615334470L,17844699630L,517496289270L,15007392388830L,435214379276070L,12621216999006030L,366015292971174870L,10614443496164071230UL,BigInteger.Parse("307818861388758065670"),BigInteger.Parse("8926746980273983904430"),BigInteger.Parse("258875662427945533228470") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170749Inst Instance=new A170749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170750
{
public static readonly BigInteger[] Value={ 1L,31L,930L,27900L,837000L,25110000L,753300000L,22599000000L,677970000000L,20339100000000L,610173000000000L,18305190000000000L,549155700000000000L,16474671000000000000UL,BigInteger.Parse("494240130000000000000"),BigInteger.Parse("14827203900000000000000"),BigInteger.Parse("444816117000000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170750Inst Instance=new A170750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170751
{
public static readonly BigInteger[] Value={ 1L,32L,992L,30752L,953312L,29552672L,916132832L,28400117792L,880403651552L,27292513198112L,846067909141472L,26228105183385632L,813071260684954592L,BigInteger.Parse("25205209081233592352"),BigInteger.Parse("781361481518241362912"),BigInteger.Parse("24222205927065482250272"),BigInteger.Parse("750888383739029949758432") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170751Inst Instance=new A170751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170752
{
public static readonly BigInteger[] Value={ 1L,33L,1056L,33792L,1081344L,34603008L,1107296256L,35433480192L,1133871366144L,36283883716608L,1161084278931456L,37154696925806592L,1188950301625810944L,BigInteger.Parse("38046409652025950208"),BigInteger.Parse("1217485108864830406656"),BigInteger.Parse("38959523483674573012992"),BigInteger.Parse("1246704751477586336415744") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170752Inst Instance=new A170752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170753
{
public static readonly BigInteger[] Value={ 1L,34L,1122L,37026L,1221858L,40321314L,1330603362L,43909910946L,1449027061218L,47817893020194L,1577990469666402L,52073685498991266L,1718431621466711778L,BigInteger.Parse("56708243508401488674"),BigInteger.Parse("1871372035777249126242"),BigInteger.Parse("61755277180649221165986"),BigInteger.Parse("2037924146961424298477538") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170753Inst Instance=new A170753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170754
{
public static readonly BigInteger[] Value={ 1L,35L,1190L,40460L,1375640L,46771760L,1590239840L,54068154560L,1838317255040L,62502786671360L,2125094746826240L,72253221392092160L,2456609527331133440L,BigInteger.Parse("83524723929258536960"),BigInteger.Parse("2839840613594790256640"),BigInteger.Parse("96554580862222868725760"),BigInteger.Parse("3282855749315577536675840") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170754Inst Instance=new A170754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170755
{
public static readonly BigInteger[] Value={ 1L,36L,1260L,44100L,1543500L,54022500L,1890787500L,66177562500L,2316214687500L,81067514062500L,2837362992187500L,99307704726562500L,3475769665429687500L,BigInteger.Parse("121651938290039062500"),BigInteger.Parse("4257817840151367187500"),BigInteger.Parse("149023624405297851562500") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170755Inst Instance=new A170755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170756
{
public static readonly BigInteger[] Value={ 1L,37L,1332L,47952L,1726272L,62145792L,2237248512L,80540946432L,2899474071552L,104381066575872L,3757718396731392L,135277862282330112L,4870003042163884032L,BigInteger.Parse("175320109517899825152"),BigInteger.Parse("6311523942644393705472"),BigInteger.Parse("227214861935198173396992") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170756Inst Instance=new A170756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170757
{
public static readonly BigInteger[] Value={ 1L,38L,1406L,52022L,1924814L,71218118L,2635070366L,97497603542L,3607411331054L,133474219248998L,4938546112212926L,182726206151878262L,6760869627619495694L,BigInteger.Parse("250152176221921340678"),BigInteger.Parse("9255630520211089605086"),BigInteger.Parse("342458329247810315388182") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170757Inst Instance=new A170757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170758
{
public static readonly BigInteger[] Value={ 1L,39L,1482L,56316L,2140008L,81320304L,3090171552L,117426518976L,4462207721088L,169563893401344L,6443427949251072L,244850262071540736L,9304309958718547968UL,BigInteger.Parse("353563778431304822784"),BigInteger.Parse("13435423580389583265792"),BigInteger.Parse("510546096054804164100096") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170758Inst Instance=new A170758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170759
{
public static readonly BigInteger[] Value={ 1L,40L,1560L,60840L,2372760L,92537640L,3608967960L,140749750440L,5489240267160L,214080370419240L,8349134446350360L,325616243407664040L,12699033492898897560UL,BigInteger.Parse("495262306223057004840"),BigInteger.Parse("19315229942699223188760"),BigInteger.Parse("753293967765269704361640") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170759Inst Instance=new A170759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170760
{
public static readonly BigInteger[] Value={ 1L,41L,1640L,65600L,2624000L,104960000L,4198400000L,167936000000L,6717440000000L,268697600000000L,10747904000000000L,429916160000000000L,17196646400000000000UL,BigInteger.Parse("687865856000000000000"),BigInteger.Parse("27514634240000000000000"),BigInteger.Parse("1100585369600000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170760Inst Instance=new A170760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170761
{
public static readonly BigInteger[] Value={ 1L,42L,1722L,70602L,2894682L,118681962L,4865960442L,199504378122L,8179679503002L,335366859623082L,13750041244546362L,563751691026400842L,BigInteger.Parse("23113819332082434522"),BigInteger.Parse("947666592615379815402"),BigInteger.Parse("38854330297230572431482"),BigInteger.Parse("1593027542186453469690762") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170761Inst Instance=new A170761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170762
{
public static readonly BigInteger[] Value={ 1L,43L,1806L,75852L,3185784L,133802928L,5619722976L,236028364992L,9913191329664L,416354035845888L,17486869505527296L,734448519232146432L,BigInteger.Parse("30846837807750150144"),BigInteger.Parse("1295567187925506306048"),BigInteger.Parse("54413821892871264854016"),BigInteger.Parse("2285380519500593123868672") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170762Inst Instance=new A170762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170763
{
public static readonly BigInteger[] Value={ 1L,44L,1892L,81356L,3498308L,150427244L,6468371492L,278139974156L,11960018888708L,514280812214444L,22114074925221092L,950905221784506956L,BigInteger.Parse("40888924536733799108"),BigInteger.Parse("1758223755079553361644"),BigInteger.Parse("75603621468420794550692"),BigInteger.Parse("3250955723142094165679756") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170763Inst Instance=new A170763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170764
{
public static readonly BigInteger[] Value={ 1L,45L,1980L,87120L,3833280L,168664320L,7421230080L,326534123520L,14367501434880L,632170063134720L,27815482777927680L,1223881242228817920L,BigInteger.Parse("53850774658067988480"),BigInteger.Parse("2369434084954991493120"),BigInteger.Parse("104255099738019625697280"),BigInteger.Parse("4587224388472863530680320") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170764Inst Instance=new A170764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170765
{
public static readonly BigInteger[] Value={ 1L,46L,2070L,93150L,4191750L,188628750L,8488293750L,381973218750L,17188794843750L,773495767968750L,34807309558593750L,1566328930136718750L,BigInteger.Parse("70484801856152343750"),BigInteger.Parse("3171816083526855468750"),BigInteger.Parse("142731723758708496093750"),BigInteger.Parse("6422927569141882324218750") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170765Inst Instance=new A170765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170766
{
public static readonly BigInteger[] Value={ 1L,47L,2162L,99452L,4574792L,210440432L,9680259872L,445291954112L,20483429889152L,942237774900992L,43342937645445632L,1993775131690499072L,BigInteger.Parse("91713656057762957312"),BigInteger.Parse("4218828178657096036352"),BigInteger.Parse("194066096218226417672192"),BigInteger.Parse("8927040426038415212920832") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170766Inst Instance=new A170766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170767
{
public static readonly BigInteger[] Value={ 1L,48L,2256L,106032L,4983504L,234224688L,11008560336L,517402335792L,24317909782224L,1142941759764528L,53718262708932816L,2524758347319842352L,BigInteger.Parse("118663642324032590544"),BigInteger.Parse("5577191189229531755568"),BigInteger.Parse("262127985893787992511696"),BigInteger.Parse("12320015337008035648049712") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170767Inst Instance=new A170767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170768
{
public static readonly BigInteger[] Value={ 1L,49L,2352L,112896L,5419008L,260112384L,12485394432L,599298932736L,28766348771328L,1380784741023744L,66277667569139712L,3181328043318706176L,BigInteger.Parse("152703746079297896448"),BigInteger.Parse("7329779811806299029504"),BigInteger.Parse("351829430966702353416192"),BigInteger.Parse("16887812686401712963977216") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170768Inst Instance=new A170768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170769
{
public static readonly BigInteger[] Value={ 1L,50L,2450L,120050L,5882450L,288240050L,14123762450L,692064360050L,33911153642450L,1661646528480050L,81420679895522450L,3989613314880600050L,BigInteger.Parse("195491052429149402450"),BigInteger.Parse("9579061569028320720050"),BigInteger.Parse("469374016882387715282450"),BigInteger.Parse("22999326827236998048840050") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170769Inst Instance=new A170769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170770
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,0L,0L,0L,4L,2L,0L,2L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,6L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,4L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,8L,0L,4L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170770Inst : IEnumerable<long>
{
public static readonly long[] Value=A170770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170770.Bytes);
public long this[int i]=>Value[i];

public static A170770Inst Instance=new A170770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170771
{
public static readonly long[] Value={ 4L,0L,16L,0L,16L,0L,0L,0L,32L,16L,32L,16L,0L,0L,16L,0L,64L,32L,16L,32L,0L,0L,48L,16L,0L,0L,96L,0L,16L,16L,0L,32L,48L,0L,64L,0L,80L,32L,32L,0L,128L,64L,0L,64L,208L,32L,112L,32L,0L,0L,240L,0L,160L,48L,128L,96L,32L,0L,144L,32L,0L,96L,96L,16L,208L,64L,0L,64L,288L,0L,32L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170771Inst : IEnumerable<long>
{
public static readonly long[] Value=A170771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170771.Bytes);
public long this[int i]=>Value[i];

public static A170771Inst Instance=new A170771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170772
{
public static readonly long[] Value={ 4L,0L,16L,0L,16L,0L,0L,0L,32L,16L,64L,48L,0L,32L,16L,0L,96L,64L,48L,64L,96L,0L,80L,48L,0L,64L,128L,64L,16L,80L,0L,96L,144L,0L,128L,0L,112L,96L,128L,0L,224L,160L,0L,128L,240L,96L,208L,160L,0L,0L,304L,0L,256L,112L,192L,224L,32L,0L,240L,128L,0L,192L,224L,16L,336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170772Inst : IEnumerable<long>
{
public static readonly long[] Value=A170772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170772.Bytes);
public long this[int i]=>Value[i];

public static A170772Inst Instance=new A170772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170773
{
public static readonly long[] Value={ 1L,0L,4L,0L,4L,0L,0L,0L,8L,4L,16L,12L,0L,8L,4L,0L,24L,16L,12L,16L,24L,0L,20L,12L,0L,16L,32L,16L,4L,20L,0L,24L,36L,0L,32L,0L,28L,24L,32L,0L,56L,40L,0L,32L,60L,24L,52L,40L,0L,0L,76L,0L,64L,28L,48L,56L,8L,0L,60L,32L,0L,48L,56L,4L,84L,48L,0L,48L,88L,0L,16L,36L,60L,40L,80L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170773Inst : IEnumerable<long>
{
public static readonly long[] Value=A170773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170773.Bytes);
public long this[int i]=>Value[i];

public static A170773Inst Instance=new A170773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170774
{
public static readonly long[] Value={ 0L,1L,640L,32805L,557056L,5078125L,31072896L,144120025L,545259520L,1764915561L,5050000000L,13075891741L,31173672960L,69337111285L,145365222016L,289606640625L,551903297536L,1011484828945L,1790743593600L,3074024910421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170774Inst : IEnumerable<long>
{
public static readonly long[] Value=A170774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170774.Bytes);
public long this[int i]=>Value[i];

public static A170774Inst Instance=new A170774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170775
{
public static readonly long[] Value={ 0L,1L,1152L,91854L,2129920L,24609375L,182238336L,991545772L,4303355904L,15712053165L,50050000000L,142763014746L,371719176192L,896488062379L,2025520479360L,4326159375000L,8798240505856L,17139436032537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170775Inst : IEnumerable<long>
{
public static readonly long[] Value=A170775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170775.Bytes);
public long this[int i]=>Value[i];

public static A170775Inst Instance=new A170775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170776
{
public static readonly long[] Value={ 0L,1L,2176L,269001L,8421376L,122265625L,1089230976L,6923526001L,34368126976L,141236291601L,500050000000L,1569321367801L,4458265214976L,11649450426601L,28347694082176L,64874450390625L,140739635838976L,291314606493601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170776Inst : IEnumerable<long>
{
public static readonly long[] Value=A170776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170776.Bytes);
public long this[int i]=>Value[i];

public static A170776Inst Instance=new A170776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170777
{
public static readonly long[] Value={ 0L,1L,4224L,800442L,33587200L,610546875L,6531186816L,48447387604L,274886295552L,1270954437525L,5000050000000L,17261463251406L,53496817680384L,151437961161487L,396858124521600L,973098815625000L,2251801961168896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170777Inst : IEnumerable<long>
{
public static readonly long[] Value=A170777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170777.Bytes);
public long this[int i]=>Value[i];

public static A170777Inst Instance=new A170777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170778
{
public static readonly long[] Value={ 0L,1L,8320L,2394765L,134250496L,3051953125L,39182921856L,339114418825L,2199031644160L,11438417750841L,50000050000000L,189875023971061L,641959447265280L,1968688600715005L,5556004150673536L,14596464294140625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170778Inst : IEnumerable<long>
{
public static readonly long[] Value=A170778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170778.Bytes);
public long this[int i]=>Value[i];

public static A170778Inst Instance=new A170778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170779
{
public static readonly long[] Value={ 0L,1L,16512L,7177734L,536903680L,15258984375L,235093332096L,2373783637372L,17592194433024L,102945587570685L,500000050000000L,2088624191887266L,7703511002284032L,25592946914910739L,77784048516800640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170779Inst : IEnumerable<long>
{
public static readonly long[] Value=A170779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170779.Bytes);
public long this[int i]=>Value[i];

public static A170779Inst Instance=new A170779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170780
{
public static readonly long[] Value={ 0L,1L,32896L,21526641L,2147516416L,76294140625L,1410555793536L,16616468167201L,140737496743936L,926510115949281L,5000000050000000L,22974865038965521L,92442129662509056L,332708304999455281L,1088976669642580096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170780Inst : IEnumerable<long>
{
public static readonly long[] Value=A170780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170780.Bytes);
public long this[int i]=>Value[i];

public static A170780Inst Instance=new A170780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170781
{
public static readonly long[] Value={ 0L,1L,65664L,64573362L,8589967360L,381469921875L,8463330562176L,116315259876004L,1125899915231232L,8338590871356645L,50000000050000000L,252723514356826326L,1109305553585209344L,4325207960098534327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170781Inst : IEnumerable<long>
{
public static readonly long[] Value=A170781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170781.Bytes);
public long this[int i]=>Value[i];

public static A170781Inst Instance=new A170781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170782
{
public static readonly BigInteger[] Value={ 0L,1L,131200L,193713525L,34359771136L,1907348828125L,50779979174016L,814206801837625L,9007199263129600L,75047317670022921L,500000000050000000L,2779958656853295181L,13311666640657612800UL,BigInteger.Parse("56227703476386561925") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170782Inst Instance=new A170782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170783
{
public static readonly long[] Value={ 0L,1L,768L,39366L,655360L,5859375L,35271936L,161414428L,603979776L,1937102445L,5500000000L,14147686146L,33538572288L,74231495611L,154957850880L,307546875000L,584115552256L,1067290888473L,1884413258496L,3226876977790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170783Inst : IEnumerable<long>
{
public static readonly long[] Value=A170783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170783.Bytes);
public long this[int i]=>Value[i];

public static A170783Inst Instance=new A170783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170784
{
public static readonly long[] Value={ 0L,1L,1280L,98415L,2228224L,25390625L,186437376L,1008840175L,4362076160L,15884240049L,50500000000L,143834809151L,374084075520L,901382446705L,2035113108224L,4344099609375L,8830452760576L,17195242092065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170784Inst : IEnumerable<long>
{
public static readonly long[] Value=A170784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170784.Bytes);
public long this[int i]=>Value[i];

public static A170784Inst Instance=new A170784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170785
{
public static readonly long[] Value={ 0L,1L,2304L,275562L,8519680L,123046875L,1093430016L,6940820404L,34426847232L,141408478485L,500500000000L,1570393162206L,4460630114304L,11654344810927L,28357286711040L,64892390625000L,140771848093696L,291370412553129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170785Inst : IEnumerable<long>
{
public static readonly long[] Value=A170785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170785.Bytes);
public long this[int i]=>Value[i];

public static A170785Inst Instance=new A170785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170786
{
public static readonly long[] Value={ 0L,1L,4352L,807003L,33685504L,611328125L,6535385856L,48464682007L,274945015808L,1271126624409L,5000500000000L,17262535045811L,53499182579712L,151442855545813L,396867717150464L,973116755859375L,2251834173423616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170786Inst : IEnumerable<long>
{
public static readonly long[] Value=A170786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170786.Bytes);
public long this[int i]=>Value[i];

public static A170786Inst Instance=new A170786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170787
{
public static readonly long[] Value={ 0L,1L,8448L,2401326L,134348800L,3052734375L,39187120896L,339131713228L,2199090364416L,11438589937725L,50000500000000L,189876095765466L,641961812164608L,1968693495099331L,5556013743302400L,14596482234375000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170787Inst : IEnumerable<long>
{
public static readonly long[] Value=A170787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170787.Bytes);
public long this[int i]=>Value[i];

public static A170787Inst Instance=new A170787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170788
{
public static readonly long[] Value={ 0L,1L,16640L,7184295L,537001984L,15259765625L,235097531136L,2373800931775L,17592253153280L,102945759757569L,500000500000000L,2088625263681671L,7703513367183360L,25592951809295065L,77784058109429504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170788Inst : IEnumerable<long>
{
public static readonly long[] Value=A170788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170788.Bytes);
public long this[int i]=>Value[i];

public static A170788Inst Instance=new A170788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170789
{
public static readonly long[] Value={ 0L,1L,33024L,21533202L,2147614720L,76294921875L,1410559992576L,16616485461604L,140737555464192L,926510288136165L,5000000500000000L,22974866110759926L,92442132027408384L,332708309893839607L,1088976679235208960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170789Inst : IEnumerable<long>
{
public static readonly long[] Value=A170789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170789.Bytes);
public long this[int i]=>Value[i];

public static A170789Inst Instance=new A170789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170790
{
public static readonly long[] Value={ 0L,1L,65792L,64579923L,8590065664L,381470703125L,8463334761216L,116315277170407L,1125899973951488L,8338591043543529L,50000000500000000L,252723515428620731L,1109305555950108672L,4325207964992918653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170790Inst : IEnumerable<long>
{
public static readonly long[] Value=A170790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170790.Bytes);
public long this[int i]=>Value[i];

public static A170790Inst Instance=new A170790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170791
{
public static readonly BigInteger[] Value={ 0L,1L,131328L,193720086L,34359869440L,1907349609375L,50779983373056L,814206819132028L,9007199321849856L,75047317842209805L,500000000500000000L,2779958657925089586L,13311666643022512128UL,BigInteger.Parse("56227703481280946251") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170791Inst Instance=new A170791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170792
{
public static readonly BigInteger[] Value={ 0L,1L,262400L,581140575L,137439084544L,9536744140625L,304679875044096L,5699447612863375L,72057594105036800L,675425859030206289L,5000000000500000000L,BigInteger.Parse("30579545225386246991"),BigInteger.Parse("159739999687891353600") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170792Inst Instance=new A170792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170793
{
public static readonly long[] Value={ 0L,1L,1536L,118098L,2621440L,29296875L,211631616L,1129900996L,4831838208L,17433922005L,55000000000L,155624547606L,402462867456L,965009442943L,2169409912320L,4613203125000L,9345848836096L,18143945104041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170793Inst : IEnumerable<long>
{
public static readonly long[] Value=A170793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170793.Bytes);
public long this[int i]=>Value[i];

public static A170793Inst Instance=new A170793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170794
{
public static readonly long[] Value={ 0L,1L,2560L,295245L,8912896L,126953125L,1118624256L,7061881225L,34896609280L,142958160441L,505000000000L,1582182900661L,4489008906240L,11717971807165L,28491583515136L,65161494140625L,141287244169216L,292319115565105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170794Inst : IEnumerable<long>
{
public static readonly long[] Value=A170794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170794.Bytes);
public long this[int i]=>Value[i];

public static A170794Inst Instance=new A170794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170795
{
public static readonly long[] Value={ 0L,1L,4608L,826686L,34078720L,615234375L,6560580096L,48585742828L,275414777856L,1272676306365L,5005000000000L,17274324784266L,53527561371648L,151506482542051L,397002013954560L,973385859375000L,2252349569499136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170795Inst : IEnumerable<long>
{
public static readonly long[] Value=A170795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170795.Bytes);
public long this[int i]=>Value[i];

public static A170795Inst Instance=new A170795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170796
{
public static readonly long[] Value={ 0L,1L,8704L,2421009L,134742016L,3056640625L,39212315136L,339252774049L,2199560126464L,11440139619681L,50005000000000L,189887885503921L,641990190956544L,1968757122095569L,5556148040106496L,14596751337890625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170796Inst : IEnumerable<long>
{
public static readonly long[] Value=A170796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170796.Bytes);
public long this[int i]=>Value[i];

public static A170796Inst Instance=new A170796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170797
{
public static readonly long[] Value={ 0L,1L,16896L,7203978L,537395200L,15263671875L,235122725376L,2373921992596L,17592722915328L,102947309439525L,500005000000000L,2088637053420126L,7703541745975296L,25593015436291303L,77784192406233600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170797Inst : IEnumerable<long>
{
public static readonly long[] Value=A170797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170797.Bytes);
public long this[int i]=>Value[i];

public static A170797Inst Instance=new A170797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170798
{
public static readonly long[] Value={ 0L,1L,33280L,21552885L,2148007936L,76298828125L,1410585186816L,16616606522425L,140738025226240L,926511837818121L,5000005000000000L,22974877900498381L,92442160406200320L,332708373520835845L,1088976813532013056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170798Inst : IEnumerable<long>
{
public static readonly long[] Value=A170798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170798.Bytes);
public long this[int i]=>Value[i];

public static A170798Inst Instance=new A170798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170799
{
public static readonly long[] Value={ 0L,1L,66048L,64599606L,8590458880L,381474609375L,8463359955456L,116315398231228L,1125900443713536L,8338592593225485L,50000005000000000L,252723527218359186L,1109305584328900608L,4325208028619914891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170799Inst : IEnumerable<long>
{
public static readonly long[] Value=A170799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170799.Bytes);
public long this[int i]=>Value[i];

public static A170799Inst Instance=new A170799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170800
{
public static readonly BigInteger[] Value={ 0L,1L,131584L,193739769L,34360262656L,1907353515625L,50780008567296L,814206940192849L,9007199791611904L,75047319391891761L,500000005000000000L,2779958669714828041L,13311666671401304064UL,BigInteger.Parse("56227703544907942489") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170800Inst Instance=new A170800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170801
{
public static readonly BigInteger[] Value={ 0L,1L,262656L,581160258L,137439477760L,9536748046875L,304679900238336L,5699447733924196L,72057594574798848L,675425860579888245L,5000000005000000000L,BigInteger.Parse("30579545237175985446"),BigInteger.Parse("159739999716270145536") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170801Inst Instance=new A170801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170802
{
public static readonly BigInteger[] Value={ 0L,1L,524800L,1743421725L,549756338176L,47683720703125L,1828079250264576L,39896133290043625L,576460752840294400L,6078832731271856601L,BigInteger.Parse("50000000005000000000"),BigInteger.Parse("336374997479248716901"),BigInteger.Parse("1916879996254696243200") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170802Inst Instance=new A170802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170803
{
public static readonly long[] Value={ 1L,3L,6L,10L,18L,27L,43L,70L,102L,166L,247L,375L,618L,874L,1386L,2115L,3139L,5187L,7374L,11470L,18031L,26223L,42607L,62290L,95058L,154107L,219643L,350715L,527862L,790006L,1314294L,1845735L,2894311L,4488634L,6585786L,10780090L,15563059L,23951667L,38300574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170803Inst : IEnumerable<long>
{
public static readonly long[] Value=A170803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170803.Bytes);
public long this[int i]=>Value[i];

public static A170803Inst Instance=new A170803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170804
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,19L,28L,44L,71L,103L,167L,248L,376L,619L,875L,1387L,2116L,3140L,5188L,7375L,11471L,18032L,26224L,42608L,62291L,95059L,154108L,219644L,350716L,527863L,790007L,1314295L,1845736L,2894312L,4488635L,6585787L,10780091L,15563060L,23951668L,38300575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170804Inst : IEnumerable<long>
{
public static readonly long[] Value=A170804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170804.Bytes);
public long this[int i]=>Value[i];

public static A170804Inst Instance=new A170804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}