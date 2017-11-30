using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A159605
{
public static readonly BigInteger[] Value={ 1L,3L,63L,3465L,363825L,62214075L,15740160975L,5524796502225L,2569030373534625L,1528573072253101875L,BigInteger.Parse("1132672646539548489375"),BigInteger.Parse("1022803399825212285905625"),BigInteger.Parse("1105650475211054481063980625"),BigInteger.Parse("1409704355894094463356575296875") };
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
public class A159605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159605Inst Instance=new A159605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159606
{
public static readonly long[] Value={ 1L,1L,-3L,16L,-115L,996L,-9870L,108816L,-1312227L,17116900L,-239641798L,3580451040L,-56837970358L,955277226736L,-16948413979080L,316615678469856L,-6213840704926947L,127857371413743540L,-2753054722318717950L };
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
public class A159606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159606Inst : IEnumerable<long>
{
public static readonly long[] Value=A159606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159606.Bytes);
public long this[int i]=>Value[i];

public static A159606Inst Instance=new A159606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159607
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,123L,1221L,14724L,207908L,3355803L,60873595L,1225319163L,27097430328L,653052022740L,17036213760892L,478306368143880L,14381009543824236L,461038595072589531L,15699544671941958663UL,BigInteger.Parse("565927686301436324649") };
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
public class A159607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159607Inst Instance=new A159607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159608
{
public static readonly BigInteger[] Value={ 1L,1L,5L,46L,597L,9791L,191876L,4348394L,111561125L,3192096511L,100729014305L,3474750994936L,130094553648612L,5254546985647116L,227771218849108212L,10548385893161367506UL,BigInteger.Parse("519835256567911242341"),BigInteger.Parse("27164324421130818956039") };
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
public class A159608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159608Inst Instance=new A159608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159609
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,57L,304L,1778L,11329L,79293L,626614L,5911340L,72622218L,1271963335L,33126504453L,1266054182987L,69124699233986L,5301840148829273L,566953161970598904L,BigInteger.Parse("84240794164243627206"),BigInteger.Parse("17363983133374688843928") };
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
public class A159609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159609Inst Instance=new A159609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159610
{
public static readonly long[] Value={ 1L,3L,2L,11L,11L,9L,53L,53L,53L,44L,309L,309L,309L,309L,265L,2119L,2119L,2119L,2119L,2119L,1854L,16687L,16687L,16687L,16687L,16687L,14833L,148329L,148329L,148329L,148329L,148329L,148329L,148329L,133496L };
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
public class A159610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159610Inst : IEnumerable<long>
{
public static readonly long[] Value=A159610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159610.Bytes);
public long this[int i]=>Value[i];

public static A159610Inst Instance=new A159610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159611
{
public static readonly long[] Value={ 2L,3L,7L,55L,6543L };
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
public class A159611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159611Inst : IEnumerable<long>
{
public static readonly long[] Value=A159611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159611.Bytes);
public long this[int i]=>Value[i];

public static A159611Inst Instance=new A159611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159612
{
public static readonly long[] Value={ 1L,4L,8L,24L,56L,152L,376L,984L,2488L,6424L,16376L,42072L,107576L,275864L,706168L,1809624L,4634296L,11872792L,30409976L,77901144L,199541048L,511145624L,1309309816L,3353892312L,8591131576L,22006700824L,56371227128L,144398030424L,369882938936L,947475060632L,2427006816376L };
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
public class A159612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159612Inst : IEnumerable<long>
{
public static readonly long[] Value=A159612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159612.Bytes);
public long this[int i]=>Value[i];

public static A159612Inst Instance=new A159612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159613
{
public static readonly long[] Value={ 11L,101L,131L,151L,181L,191L,313L,10301L,10501L,10601L,11311L,11411L,16061L,30103L,30203L,30403L,30703L,30803L,31013L,35053L,38083L,70207L,70507L,70607L,73037L,74047L,90709L,91019L,94049L,1003001L,1008001L,1022201L,1028201L,1035301L };
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
public class A159613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159613Inst : IEnumerable<long>
{
public static readonly long[] Value=A159613.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159613.Bytes);
public long this[int i]=>Value[i];

public static A159613Inst Instance=new A159613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159614
{
public static readonly long[] Value={ 13L,17L,31L,71L,107L,113L,311L,701L,709L,907L,1009L,1021L,1031L,1033L,1061L,1069L,1091L,1097L,1103L,1109L,1151L,1181L,1201L,1213L,1231L,1301L,1321L,1409L,1511L,1601L,1811L,1901L,3011L,3019L,3023L,3049L,3067L,3083L,3089L,3109L,3121L,3203L,3301L,3407L,3803L };
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
public class A159614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159614Inst : IEnumerable<long>
{
public static readonly long[] Value=A159614.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159614.Bytes);
public long this[int i]=>Value[i];

public static A159614Inst Instance=new A159614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159615
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,10L,11L,13L,15L,17L,19L,20L,21L,22L,23L,25L,27L,29L,31L,33L,35L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,97L,99L,101L,103L,105L,107L,109L,111L };
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
public class A159615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159615Inst : IEnumerable<long>
{
public static readonly long[] Value=A159615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159615.Bytes);
public long this[int i]=>Value[i];

public static A159615Inst Instance=new A159615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159616
{
public static readonly long[] Value={ 1L,4L,22L,110L,562L,2854L,14514L,73782L,375106L,1906982L,9694866L,49287446L,250571106L,1273871494L,6476200114L,32924174710L,167382301826L,850950257638L,4326122494162L,21993454571478L,111811915784610L,568437508112710L };
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
public class A159616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159616Inst : IEnumerable<long>
{
public static readonly long[] Value=A159616.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159616.Bytes);
public long this[int i]=>Value[i];

public static A159616Inst Instance=new A159616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159617
{
public static readonly long[] Value={ 1L,7L,64L,560L,4936L,43456L,382656L,3369408L,29668864L,261244928L,2300355072L,20255449088L,178356473856L,1570492542976L,13828748541952L,121767076888576L,1072202663100416L,9441127931576320L,83132508142305280L,732011467286249472L };
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
public class A159617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159617Inst : IEnumerable<long>
{
public static readonly long[] Value=A159617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159617.Bytes);
public long this[int i]=>Value[i];

public static A159617Inst Instance=new A159617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159618
{
public static readonly BigInteger[] Value={ 1L,4L,-706L,-8600L,1494796L,30815984L,-5272949624L,-154586641184L,26031140834960L,997017002818624L,-165162285134295584L,-7859111900887647616L,BigInteger.Parse("1280282420933024937664"),BigInteger.Parse("73212475193022678695680"),BigInteger.Parse("-11723880902105281350131584"),BigInteger.Parse("-786927222859494361656459776") };
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
public class A159618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159618Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159618.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159618.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159618Inst Instance=new A159618Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159619
{
public static readonly long[] Value={ 4L,7L,9L,11L,12L,15L,16L,19L,20L,23L,25L,27L,28L,31L,33L,35L,36L,39L,41L,43L,44L,47L,48L,51L,52L,55L,57L,59L,60L,63L,64L,67L,68L,71L,73L,75L,76L,79L,80L,83L,84L,87L,89L,91L,92L,95L,97L,99L,100L,103L,105L,107L,108L,111L,112L,115L,116L,119L,121L,123L,124L,127L,129L,131L,132L,135L,137L };
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
public class A159619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159619Inst : IEnumerable<long>
{
public static readonly long[] Value=A159619.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159619.Bytes);
public long this[int i]=>Value[i];

public static A159619Inst Instance=new A159619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159620
{
public static readonly BigInteger[] Value={ 1L,6L,-686L,-12780L,1409196L,45363816L,-4815014664L,-225406138896L,22982647278480L,1439841741934176L,-140702191563957984L,BigInteger.Parse("-11239870526148498624"),BigInteger.Parse("1050017582244063317184"),BigInteger.Parse("103682343732014971981440"),BigInteger.Parse("-9233370964550688463200384"),BigInteger.Parse("-1103421356230511467567597824") };
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
public class A159620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159620.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159620Inst Instance=new A159620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159621
{
public static readonly BigInteger[] Value={ 1L,8L,-658L,-16816L,1290700L,58890208L,-4188305336L,-288618823744L,18858744578192L,1817932282570880L,-108000664008524576L,BigInteger.Parse("-13989476392229950208"),BigInteger.Parse("745825462417862580928"),BigInteger.Parse("127171427161623189249536"),BigInteger.Parse("-5982946372961072670593920"),BigInteger.Parse("-1333312356733375778299061248") };
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
public class A159621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159621.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159621Inst Instance=new A159621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159622
{
public static readonly BigInteger[] Value={ 1L,10L,-622L,-20660L,1140652L,71072600L,-3407027720L,-341956780400L,13799550292880L,2113137866519200L,-68538099137942240L,BigInteger.Parse("-15942236387648046400"),BigInteger.Parse("384907219477056806080"),BigInteger.Parse("141972608257353242070400"),BigInteger.Parse("-2193013079438122761162880"),BigInteger.Parse("-1456989255059707798459232000") };
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
public class A159622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159622.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159622Inst Instance=new A159622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159623
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,12L,4L,1L,1L,5L,20L,20L,5L,1L,1L,6L,30L,120L,30L,6L,1L,1L,7L,42L,210L,210L,42L,7L,1L,1L,8L,56L,336L,1680L,336L,56L,8L,1L,1L,9L,72L,504L,3024L,3024L,504L,72L,9L,1L,1L,10L,90L,720L,5040L,30240L,5040L,720L,90L,10L,1L };
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
public class A159623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159623Inst : IEnumerable<long>
{
public static readonly long[] Value=A159623.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159623.Bytes);
public long this[int i]=>Value[i];

public static A159623Inst Instance=new A159623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159624
{
public static readonly long[] Value={ 3L,4L,5L,6L,6L,7L,9L,10L,10L,10L,10L,11L,13L,15L,17L,18L,18L,18L,18L,18L,18L,18L,18L,19L,21L,23L,25L,27L,29L,31L,33L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,35L,37L,39L,41L,43L,45L,47L };
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
public class A159624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159624Inst : IEnumerable<long>
{
public static readonly long[] Value=A159624.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159624.Bytes);
public long this[int i]=>Value[i];

public static A159624Inst Instance=new A159624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159625
{
public static readonly long[] Value={ 1679L,1743L,4980L,4982L,5314L,5513L,5695L,6100L,6578L,7251L,7406L,7642L,8218L,8331L,9475L,9578L,9749L,10735L };
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
public class A159625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159625Inst : IEnumerable<long>
{
public static readonly long[] Value=A159625.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159625.Bytes);
public long this[int i]=>Value[i];

public static A159625Inst Instance=new A159625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159626
{
public static readonly long[] Value={ 545L,577L,613L,2657L,2885L,3133L,15397L,16733L,18185L,89725L,97513L,105977L,522953L,568345L,617677L,3047993L,3312557L,3600085L,17765005L,19306997L,20982833L,103542037L,112529425L,122296913L,603487217L,655869553L,712798645L,3517381265L };
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
public class A159626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159626Inst : IEnumerable<long>
{
public static readonly long[] Value=A159626.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159626.Bytes);
public long this[int i]=>Value[i];

public static A159626Inst Instance=new A159626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159627
{
public static readonly long[] Value={ 1L,0L,8L,6L,7L,9L,9L,4L,1L,2L,6L,8L,7L,4L,9L,6L,0L,6L,8L,7L,3L,3L,5L,4L,8L,3L,8L,2L,3L,6L,2L,4L,4L,3L,2L,1L,4L,3L,3L,5L,1L,2L,7L,9L,7L,8L,7L,9L,1L,7L,0L,9L,2L,4L,5L,2L,1L,3L,1L,8L,3L,9L,0L,1L,3L,7L,2L,0L,7L,0L,8L,9L,1L,2L,7L,8L,5L,2L,9L,7L,0L,4L,1L,9L,5L,6L,9L,0L,0L,8L,0L,0L,1L,2L,3L,7L,4L,0L,2L,6L,8L,1L,6L,2L,7L };
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
public class A159627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159627Inst : IEnumerable<long>
{
public static readonly long[] Value=A159627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159627.Bytes);
public long this[int i]=>Value[i];

public static A159627Inst Instance=new A159627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159628
{
public static readonly long[] Value={ 4L,9L,3L,4L,6L,0L,7L,1L,1L,4L,7L,4L,8L,7L,6L,0L,8L,8L,0L,6L,4L,4L,3L,7L,9L,4L,3L,9L,7L,5L,3L,0L,9L,9L,7L,0L,8L,2L,9L,3L,7L,2L,4L,9L,0L,1L,9L,0L,4L,6L,2L,9L,2L,3L,7L,1L,0L,0L,6L,3L,9L,6L,1L,7L,6L,4L,6L,5L,7L,9L,5L,5L,0L,5L,3L,0L,6L,2L,0L,6L,4L,1L,5L,4L,6L,0L,2L,7L,3L,8L,9L,4L,5L,8L,8L,7L,2L,8L,5L,1L,5L,6L,1L,9L,7L };
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
public class A159628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159628Inst : IEnumerable<long>
{
public static readonly long[] Value=A159628.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159628.Bytes);
public long this[int i]=>Value[i];

public static A159628Inst Instance=new A159628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159629
{
public static readonly long[] Value={ 4L,5L,6L,9L,10L,11L,15L,17L,25L,26L,27L,30L,32L,33L,39L,49L,50L,52L,54L,58L,59L,62L,63L,66L,81L,82L,83L,87L,89L,91L,92L,97L,99L,101L,102L,121L,122L,123L,124L,125L,128L,129L,131L,132L,136L,138L,143L,147L,169L,170L,171L,173L,178L,179L,183L,184L,186L,193L,195L,199L,200L,201L,207L };
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
public class A159629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159629Inst : IEnumerable<long>
{
public static readonly long[] Value=A159629.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159629.Bytes);
public long this[int i]=>Value[i];

public static A159629Inst Instance=new A159629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159630
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,5L,4L,6L,6L,6L,5L,10L,5L,7L,10L,10L,6L,12L,7L,12L,12L,9L,8L,16L,12L,10L,15L,14L,9L,18L,10L,16L,16L,12L,16L,24L,11L,13L,18L,20L,12L,22L,13L,18L,24L,15L,14L,28L,20L,24L,22L,20L,15L,27L,22L,24L,24L,18L,17L,36L,17L,19L,32L,28L,24L,30L,19L,24L,28L,30L,20L,40L,20L,22L,42L };
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
public class A159630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159630Inst : IEnumerable<long>
{
public static readonly long[] Value=A159630.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159630.Bytes);
public long this[int i]=>Value[i];

public static A159630Inst Instance=new A159630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159631
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,3L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,2L,2L,1L,1L,1L,3L,3L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,2L,2L,4L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,3L };
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
public class A159631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159631Inst : IEnumerable<long>
{
public static readonly long[] Value=A159631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159631.Bytes);
public long this[int i]=>Value[i];

public static A159631Inst Instance=new A159631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159632
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,2L,2L,3L,1L,3L,2L,4L,2L,5L,4L,5L,2L,2L,5L,5L,4L,6L,7L,7L,3L,9L,7L,9L,4L,8L,8L,11L,6L,9L,11L,10L,8L,10L,10L,11L,7L,6L,8L,15L,10L,12L,11L,15L,10L,17L,13L,14L,14L,14L,14L,18L,8L,17L,19L,16L,14L,21L,19L,17L,12L,17L,17L,20L,16L,21L,23L,19L,15L,15L,19L,20L,22L,23L };
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
public class A159632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159632Inst : IEnumerable<long>
{
public static readonly long[] Value=A159632.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159632.Bytes);
public long this[int i]=>Value[i];

public static A159632Inst Instance=new A159632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159633
{
public static readonly long[] Value={ 2L,3L,4L,6L,4L,6L,4L,8L,8L,6L,4L,12L,4L,6L,8L,12L,4L,12L,4L,12L,8L,6L,4L,16L,12L,6L,12L,12L,4L,12L,4L,16L,8L,6L,8L,24L,4L,6L,8L,16L,4L,12L,4L,12L,16L,6L,4L,24L,16L,18L,8L,12L,4L,18L,8L,16L,8L,6L,4L,24L,4L,6L,16L,24L,8L,12L,4L,12L,8L,12L,4L,32L,4L,6L,24L,12L,8L,12L,4L,24L,24L,6L,4L,24L,8L,6L,8L,16L,4L };
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
public class A159633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159633Inst : IEnumerable<long>
{
public static readonly long[] Value=A159633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159633.Bytes);
public long this[int i]=>Value[i];

public static A159633Inst Instance=new A159633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159634
{
public static readonly long[] Value={ 1L,2L,4L,4L,6L,8L,8L,8L,12L,12L,12L,16L,14L,16L,24L,16L,18L,24L,20L,24L,32L,24L,24L,32L,30L,28L,36L,32L,30L,48L,32L,32L,48L,36L,48L,48L,38L,40L,56L,48L,42L,64L,44L,48L,72L,48L,48L,64L,56L,60L,72L,56L,54L,72L,72L,64L,80L,60L,60L,96L,62L,64L,96L,64L,84L,96L,68L,72L,96L,96L };
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
public class A159634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159634Inst : IEnumerable<long>
{
public static readonly long[] Value=A159634.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159634.Bytes);
public long this[int i]=>Value[i];

public static A159634Inst Instance=new A159634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159635
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,8L,10L,14L,12L,11L,18L,13L,15L,22L,18L,16L,24L,17L,24L,28L,21L,20L,32L,30L,24L,33L,30L,25L,42L,26L,32L,40L,30L,40L,48L,31L,33L,46L,44L,34L,54L,35L,42L,64L,39L,38L,60L,52L,54L,58L,48L,43L,63L,58L,56L,64L,48L,47L,84L };
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
public class A159635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159635Inst : IEnumerable<long>
{
public static readonly long[] Value=A159635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159635.Bytes);
public long this[int i]=>Value[i];

public static A159635Inst Instance=new A159635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159636
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,3L,4L,2L,6L,6L,7L,6L,9L,9L,14L,6L,12L,12L,13L,12L,20L,15L,16L,16L,18L,18L,21L,18L,21L,30L,22L,16L,32L,24L,32L,24L,27L,27L,38L,28L,30L,42L,31L,30L,48L,33L,34L,36L,36L,36L,50L,36L,39L,45L,50L,40L,56L,42L,43L,60L };
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
public class A159636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159636Inst : IEnumerable<long>
{
public static readonly long[] Value=A159636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159636.Bytes);
public long this[int i]=>Value[i];

public static A159636Inst Instance=new A159636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159637
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L };
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
public class A159637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159637Inst : IEnumerable<long>
{
public static readonly long[] Value=A159637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159637.Bytes);
public long this[int i]=>Value[i];

public static A159637Inst Instance=new A159637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159638
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L };
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
public class A159638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159638Inst : IEnumerable<long>
{
public static readonly long[] Value=A159638.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159638.Bytes);
public long this[int i]=>Value[i];

public static A159638Inst Instance=new A159638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159639
{
public static readonly long[] Value={ 154L,2183L,4002L,8635L,19203L,93017L,96298L,122414L,166762L,182090L,201354L,241237L,337645L,346495L,406813L,456729L,574678L,668811L,781635L,799006L,929442L,952150L,1014194L,1379625L,1455259L,1513549L,1558110L,1573089L,1938354L,2028842L };
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
public class A159639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159639Inst : IEnumerable<long>
{
public static readonly long[] Value=A159639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159639.Bytes);
public long this[int i]=>Value[i];

public static A159639Inst Instance=new A159639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159640
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,234L,7020L,498420L,84731400L,34655142600L,34169970603600L,81290360065964400L,BigInteger.Parse("466769247498767584800"),BigInteger.Parse("6469888539580417492912800"),BigInteger.Parse("216495410311439930147848113600"),BigInteger.Parse("17489148731189051877133614160948800"),BigInteger.Parse("3410838720448876031389860235353200668800") };
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
public class A159640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159640Inst Instance=new A159640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159641
{
public static readonly long[] Value={ 613L,647L,685L,2993L,3235L,3497L,17345L,18763L,20297L,101077L,109343L,118285L,589117L,637295L,689413L,3433625L,3714427L,4018193L,20012633L,21649267L,23419745L,116642173L,126181175L,136500277L,679840405L,735437783L,795581917L };
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
public class A159641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159641Inst : IEnumerable<long>
{
public static readonly long[] Value=A159641.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159641.Bytes);
public long this[int i]=>Value[i];

public static A159641Inst Instance=new A159641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159642
{
public static readonly long[] Value={ 1L,0L,8L,1L,7L,8L,0L,0L,4L,3L,6L,5L,5L,9L,9L,9L,1L,0L,6L,2L,7L,0L,2L,6L,3L,9L,7L,8L,4L,7L,2L,2L,5L,5L,2L,2L,5L,3L,9L,1L,8L,2L,1L,0L,0L,0L,7L,9L,3L,7L,7L,1L,4L,5L,3L,8L,3L,9L,8L,1L,5L,2L,5L,5L,9L,0L,0L,5L,6L,6L,2L,5L,8L,4L,6L,1L,5L,7L,0L,0L,9L,7L,9L,8L,8L,5L,8L,4L,1L,5L,9L,5L,6L,0L,7L,3L,4L,3L,0L,6L,9L,8L,3L,7L,1L };
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
public class A159642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159642Inst : IEnumerable<long>
{
public static readonly long[] Value=A159642.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159642.Bytes);
public long this[int i]=>Value[i];

public static A159642Inst Instance=new A159642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159643
{
public static readonly long[] Value={ 4L,9L,8L,0L,5L,0L,5L,6L,8L,0L,5L,9L,8L,9L,6L,5L,1L,0L,5L,1L,7L,5L,5L,0L,3L,1L,7L,0L,9L,3L,8L,4L,8L,6L,3L,6L,8L,3L,6L,8L,4L,3L,6L,9L,5L,1L,8L,7L,0L,1L,3L,1L,3L,6L,5L,6L,9L,2L,8L,7L,7L,1L,2L,4L,0L,3L,2L,4L,9L,8L,4L,3L,3L,4L,5L,2L,3L,4L,2L,0L,2L,6L,8L,0L,0L,2L,8L,8L,1L,9L,8L,6L,7L,3L,3L,2L,5L,9L,5L,2L,9L,4L,3L,9L,0L };
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
public class A159643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159643Inst : IEnumerable<long>
{
public static readonly long[] Value=A159643.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159643.Bytes);
public long this[int i]=>Value[i];

public static A159643Inst Instance=new A159643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159644
{
public static readonly BigInteger[] Value={ 1L,12L,-578L,-24264L,960780L,81603792L,-2489170296L,-383377670496L,7979734630032L,2310146240345280L,-24130560741804576L,BigInteger.Parse("-16968822584194576512"),BigInteger.Parse("-11980957598922975552"),BigInteger.Parse("146874107378274735193344"),BigInteger.Parse("1874942556562787870851200"),BigInteger.Parse("-1462104166700847568884106752") };
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
public class A159644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159644.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159644Inst Instance=new A159644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159645
{
public static readonly BigInteger[] Value={ 1L,14L,-526L,-27580L,753196L,90195784L,-1456296584L,-411116288464L,1604494897040L,2397070610726624L,23132980709206816L,BigInteger.Parse("-16982988079517329856"),BigInteger.Parse("-421483965905763150656"),BigInteger.Parse("141239833198257461763200"),BigInteger.Parse("5933406168767097396742016"),BigInteger.Parse("-1344584547605247059948037376") };
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
public class A159645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159645Inst Instance=new A159645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159646
{
public static readonly BigInteger[] Value={ 1L,16L,-466L,-30560L,520396L,96583616L,-333291704L,-423732891776L,-5095269996400L,2365956862955776L,70964374243899616L,BigInteger.Parse("-15946778562638308864"),BigInteger.Parse("-818747517247263692096"),BigInteger.Parse("125062929190742088924160"),BigInteger.Parse("9685771063934690436799616"),BigInteger.Parse("-1109163751237065987856615424") };
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
public class A159646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159646Inst Instance=new A159646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159647
{
public static readonly BigInteger[] Value={ 1L,18L,-398L,-33156L,265260L,100529208L,851937144L,-420157660464L,-11868528214128L,2213197138985760L,116959244837147424L,BigInteger.Parse("-13874016936408533568"),BigInteger.Parse("-1178622627351978445632"),BigInteger.Parse("98989275444707922811776"),BigInteger.Parse("12844358938330412301313920"),BigInteger.Parse("-769385135305160262357781248") };
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
public class A159647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159647.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159647Inst Instance=new A159647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159648
{
public static readonly BigInteger[] Value={ 1L,20L,-322L,-35320L,-8948L,101825200L,2068806280L,-399730640800L,-18450359755120L,1939836986158400L,158687177411937760L,BigInteger.Parse("-10831879491824892800"),BigInteger.Parse("-1476931152842107545920"),BigInteger.Parse("64308780860328720300800"),BigInteger.Parse("15148651417782595832021120"),BigInteger.Parse("-347060128580550788160064000") };
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
public class A159648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159648Inst Instance=new A159648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159649
{
public static readonly BigInteger[] Value={ 1L,22L,-238L,-37004L,-298580L,100298792L,3284447224L,-362236528016L,-24568799886448L,1551764588318560L,193786882605147424L,-6940428910346759872L,BigInteger.Parse("-1691744857677709558592"),BigInteger.Parse("22913489210334717241984"),BigInteger.Parse("16382813996790345696268160"),BigInteger.Parse("128812358991324283435925248") };
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
public class A159649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159649.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159649Inst Instance=new A159649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159650
{
public static readonly BigInteger[] Value={ 1L,24L,-146L,-38160L,-599604L,95815584L,4464144456L,-307933642944L,-29952193511280L,1059772077373824L,220063883293269216L,-2370021199600548096L,BigInteger.Parse("-1804627869905557267776"),BigInteger.Parse("-22777205204394225722880"),BigInteger.Parse("16391584262028099097996416"),BigInteger.Parse("623630012494691211958785024") };
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
public class A159650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159650Inst Instance=new A159650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159651
{
public static readonly BigInteger[] Value={ 1L,26L,-46L,-38740L,-907604L,88283416L,5571819256L,-237576457456L,-34336962413680L,479480595510176L,235588077247357216L,2663440108847816896L,BigInteger.Parse("-1801791066668467770176"),BigInteger.Parse("-69922612836437647611520"),BigInteger.Parse("15093623018002859652972416"),BigInteger.Parse("1099211969018786093034526976") };
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
public class A159651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159651Inst Instance=new A159651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159652
{
public static readonly BigInteger[] Value={ 1L,28L,62L,-38696L,-1217780L,77656208L,6570559624L,-152431023584L,-37475677000048L,-168877363780160L,238788382960467424L,7905369289385843072L,BigInteger.Parse("-1675106997369228675392"),BigInteger.Parse("-115395115449577347286784"),BigInteger.Parse("12491491044719414623199360"),BigInteger.Parse("1516175576216471435824394752") };
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
public class A159652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159652Inst Instance=new A159652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159653
{
public static readonly BigInteger[] Value={ 1L,30L,178L,-37980L,-1524948L,63937800L,7423196280L,-54282661200L,-39145313835120L,-860822763962400L,228541566381737760L,13071387347260660800UL,BigInteger.Parse("-1422935499785941465920"),BigInteger.Parse("-155938564970244609148800"),BigInteger.Parse("8677515651883508324661120"),BigInteger.Parse("1836552484275737759015904000") };
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
public class A159653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159653Inst Instance=new A159653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159654
{
public static readonly BigInteger[] Value={ 1L,32L,302L,-36544L,-1823540L,47185792L,8092924744L,54564740864L,-39155569948528L,-1568144181583360L,204252279714867424L,17858073941907616768UL,BigInteger.Parse("-1050713239354433344832"),BigInteger.Parse("-188345176292029458712576"),BigInteger.Parse("3834948823235768695790720"),BigInteger.Parse("2026511404303378366932021248") };
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
public class A159654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159654Inst Instance=new A159654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159655
{
public static readonly BigInteger[] Value={ 1L,34L,434L,-34340L,-2107604L,27515384L,8543973496L,171298455376L,-37357094566000L,-2259561093495776L,165921323311011616L,BigInteger.Parse("21955356087613897664"),BigInteger.Parse("-571265042757181733696"),BigInteger.Parse("-209644216596830988306560"),BigInteger.Parse("-1766009672973345849952384"),BigInteger.Parse("2059039412479673870904327424") };
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
public class A159655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159655Inst Instance=new A159655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159656
{
public static readonly BigInteger[] Value={ 1L,36L,574L,-31320L,-2370804L,5103216L,8742318216L,292616324064L,-33649488597360L,-2901533477298624L,114199171722894816L,BigInteger.Parse("25060241888120278656"),-4801113850900597056L,BigInteger.Parse("-217294775817306515769600"),BigInteger.Parse("-7777548674818481563737984"),BigInteger.Parse("1916423841667868925104549376") };
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
public class A159656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159656Inst Instance=new A159656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159657
{
public static readonly BigInteger[] Value={ 1L,1L,-199L,-599L,118801L,598001L,-118202999L,-835804199L,164648394401L,1501935112801L,-294865174808999L,-3298735400410999L,645404649179386801L,8562369610165784401L,BigInteger.Parse("-1669489718256239898199"),BigInteger.Parse("-25644124626720436220999"),BigInteger.Parse("4982825030141999258376001") };
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
public class A159657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159657Inst Instance=new A159657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159658
{
public static readonly BigInteger[] Value={ 1L,3L,-191L,-1773L,109281L,1746243L,-104042271L,-2407618413L,138436324161L,4267498433283L,-236382888189951L,-9244145531135853L,492309917424484641L,BigInteger.Parse("23662879026999501123"),BigInteger.Parse("-1209017148222661563231"),BigInteger.Parse("-69883112720266587834093"),BigInteger.Parse("3417402106507184926190721") };
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
public class A159658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159658Inst Instance=new A159658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159659
{
public static readonly BigInteger[] Value={ 1L,7L,-151L,-3857L,63601L,3530807L,-38885351L,-4509165857L,22875330401L,7374792684007L,10447954066249L,-14676449689550257L,-125720646772599599L,BigInteger.Parse("34343434727512419607"),BigInteger.Parse("567277724701345894649"),BigInteger.Parse("-92190673164125353637057"),BigInteger.Parse("-2347167886252915159406399") };
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
public class A159659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159659.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159659Inst Instance=new A159659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159660
{
public static readonly BigInteger[] Value={ 1L,9L,-119L,-4671L,29361L,4001049L,6648441L,-4741422831L,-51980622879L,7118450923689L,157631179495401L,-12818221231919391L,-462152585977156719L,BigInteger.Parse("26604357682812127929"),BigInteger.Parse("1441035942685916620761"),BigInteger.Parse("-61522878027700708614351"),BigInteger.Parse("-4876813730307056239812159") };
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
public class A159660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159660Inst Instance=new A159660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159661
{
public static readonly BigInteger[] Value={ 1L,25L,599L,14351L,343825L,8237449L,197354951L,4728281375L,113281398049L,2714025271801L,65023325125175L,1557845777732399L,37323275340452401L,894200762393125225L,BigInteger.Parse("21423495022094552999"),BigInteger.Parse("513269679767876146751"),BigInteger.Parse("12297048819406932969025"),BigInteger.Parse("294615901985998515109849") };
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
public class A159661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159661Inst Instance=new A159661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159662
{
public static readonly long[] Value={ 1L,1L,3L,13L,77L,572L,5114L,53406L,637818L,8572434L,128041458L,2103949314L,37716766350L,732505270152L,15320768312784L,343335554738328L,8207083694470392L,208444177385240472L,5605513502234263272L };
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
public class A159662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159662Inst : IEnumerable<long>
{
public static readonly long[] Value=A159662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159662.Bytes);
public long this[int i]=>Value[i];

public static A159662Inst Instance=new A159662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159663
{
public static readonly BigInteger[] Value={ 1L,11L,-79L,-5269L,-10559L,4099051L,55648561L,-4306727029L,-125281982719L,5512661436491L,286146844695601L,-7877707581330389L,-716177841724956479L,11028541936218412331UL,BigInteger.Parse("1983376349783289381041"),BigInteger.Parse("-9062777573795371335349"),BigInteger.Parse("-6049819602661617227811839") };
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
public class A159663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159663Inst Instance=new A159663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159664
{
public static readonly BigInteger[] Value={ 1L,23L,551L,13201L,316273L,7577351L,181540151L,4349386273L,104203730401L,2496540143351L,59812759710023L,1433009692897201L,34332419869822801L,822545067182850023L,BigInteger.Parse("19706749192518577751"),BigInteger.Parse("472139435553263016001"),BigInteger.Parse("11311639704085793806273"),BigInteger.Parse("271007213462505788334551") };
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
public class A159664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159664Inst Instance=new A159664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159665
{
public static readonly BigInteger[] Value={ 0L,48L,27600L,15842400L,9093510048L,5219658925200L,2996075129554800L,1719741904705530048L,BigInteger.Parse("987128857225844692800"),BigInteger.Parse("566610244305730148137200"),BigInteger.Parse("325233293102631879186060048"),BigInteger.Parse("186683343630666392922650330400"),BigInteger.Parse("107155914010709406905722103589600") };
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
public class A159665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159665Inst Instance=new A159665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159666
{
public static readonly long[] Value={ 1L,1L,4L,18L,104L,665L,5430L,45647L,457008L,4903380L,58782190L,735362309L,10577094600L,153445432699L,2462688382448L,41517435884340L,752130797186176L,13961847566945787L,284698729314200574L,5855054339061479491L };
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
public class A159666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159666Inst : IEnumerable<long>
{
public static readonly long[] Value=A159666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159666.Bytes);
public long this[int i]=>Value[i];

public static A159666Inst Instance=new A159666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159667
{
public static readonly long[] Value={ 1L,2L,6L,26L,133L,905L,6521L,57126L,544820L,5878219L,66851119L,881424550L,11803494823L,175906313032L,2767829058956L,47008174824136L,821285150996811L,15816596073011143L,308160754687446289L,6498330632792677804L };
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
public class A159667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159667Inst : IEnumerable<long>
{
public static readonly long[] Value=A159667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159667.Bytes);
public long this[int i]=>Value[i];

public static A159667Inst Instance=new A159667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159668
{
public static readonly BigInteger[] Value={ 1L,27L,755L,21113L,590409L,16510339L,461699083L,12911063985L,361048092497L,10096435525931L,282339146633571L,7895399670214057L,220788851619360025L,6174192445671866643L,BigInteger.Parse("172656599627192905979"),BigInteger.Parse("4828210597115729500769"),BigInteger.Parse("135017240119613233115553") };
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
public class A159668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159668Inst Instance=new A159668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159669
{
public static readonly BigInteger[] Value={ 1L,29L,811L,22679L,634201L,17734949L,495944371L,13868707439L,387827863921L,10845311482349L,303280893641851L,8481019710489479L,237165271000063561L,6632146568291290229L,BigInteger.Parse("185462938641156062851"),BigInteger.Parse("5186330135384078469599"),BigInteger.Parse("145031780852113041085921") };
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
public class A159669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159669Inst Instance=new A159669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159670
{
public static readonly BigInteger[] Value={ 1L,13L,-31L,-5603L,-54239L,3777293L,103343809L,-3189282083L,-186141999679L,2683005336973L,369934668802849L,-556859979508963L,-821095451099884319L,BigInteger.Parse("-9337776913476984947"),BigInteger.Parse("2013457072984498425089"),BigInteger.Parse("52320717306534037377757"),BigInteger.Parse("-5360201893968552789356159") };
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
public class A159670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159670Inst Instance=new A159670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159671
{
public static readonly long[] Value={ 0L,1L,1L,5L,3L,1L,1L,2L,1L,1L,6L,3L,1L,8L,11L,2L,1L,1L,27L,4L,1L,1L,2L,3L,3L,3L,1L,1L,4L,1L,3L,11L,1L,1L,3L,1L,1L,1L,2L,3L,26L,10L,3L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,1L,7L,4L,1L,2L,2L,1L,1L,6L,2L,10L,2L,6L,6L,1L,3L,1L,2L,4L,2L,1L,2L,5L,1L,1L,1L,1L,1L,4L,11L,9L,1L,1L,1L,2L,1L,2L,5L,2L,4L,1L,48L,1L,8L,1L,8L,7L,1L,3L };
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
public class A159671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159671Inst : IEnumerable<long>
{
public static readonly long[] Value=A159671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159671.Bytes);
public long this[int i]=>Value[i];

public static A159671Inst Instance=new A159671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159672
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,2L,13L,2L,3L,4L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,3L,1L,90L,4L,52L,5L,1L,3L,1L,1L,2L,1L,12L,2L,1L,1L,2L,2L,2L,1L,1L,3L,10L,75L,15L,1L,2L,2L,3L,1L,1L,2L,1L,1L,1L,9L,4L,9L,1L,1L,1L,3L,3L,1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,3L,4L,2L,4L,7L,1L,78L,1L,1L,1L,1L,1L,44L,1L,2L,1L,9L,37L,1L,2L,1L,10L,8L,1L,14L };
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
public class A159672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159672Inst : IEnumerable<long>
{
public static readonly long[] Value=A159672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159672.Bytes);
public long this[int i]=>Value[i];

public static A159672Inst Instance=new A159672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159673
{
public static readonly BigInteger[] Value={ 0L,56L,43848L,34289136L,26814060560L,20968561068840L,16397387941772376L,12822736401904929248UL,BigInteger.Parse("10027363468901712899616"),BigInteger.Parse("7841385409944737582570520"),BigInteger.Parse("6131953363213315887857247080"),BigInteger.Parse("4795179688647403079566784646096"),BigInteger.Parse("3749824384568905994905337736000048") };
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
public class A159673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159673Inst Instance=new A159673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159674
{
public static readonly BigInteger[] Value={ 1L,31L,991L,31681L,1012801L,32377951L,1035081631L,33090234241L,1057852414081L,33818187016351L,1081124132109151L,34562154040476481L,1104907805163138241L,BigInteger.Parse("35322487611179947231"),BigInteger.Parse("1129214695752595173151"),BigInteger.Parse("36099547776471865593601"),BigInteger.Parse("1154056314151347103822081") };
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
public class A159674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159674Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159674.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159674.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159674Inst Instance=new A159674Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159675
{
public static readonly BigInteger[] Value={ 1L,33L,1055L,33727L,1078209L,34468961L,1101928543L,35227244415L,1126169892737L,36002209323169L,1150944528448671L,36794222701034303L,1176264181904649025L,BigInteger.Parse("37603659598247734497"),BigInteger.Parse("1202140842962022854879"),BigInteger.Parse("38430903315186483621631"),BigInteger.Parse("1228586765243005453037313") };
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
public class A159675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159675Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159675.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159675Inst Instance=new A159675Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159676
{
public static readonly BigInteger[] Value={ 1L,17L,89L,-5287L,-143279L,1793857L,173774569L,801539273L,-229658228959L,-5186652729103L,325211715731449L,15901904625640633L,-445133395973297039L,BigInteger.Parse("-45731838833083568863"),BigInteger.Parse("379905569368151630729"),BigInteger.Parse("134507543411892570538793"),BigInteger.Parse("1146911529897718806972481") };
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
public class A159676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159676Inst Instance=new A159676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159677
{
public static readonly BigInteger[] Value={ 0L,0L,64L,65472L,66912384L,68384391040L,69888780730560L,71426265522241344L,BigInteger.Parse("72997573474949923072"),BigInteger.Parse("74603448665133299138304"),BigInteger.Parse("76244651538192756769423680"),BigInteger.Parse("77921959268584332285051862720"),BigInteger.Parse("79636166127841649402566234276224"),BigInteger.Parse("81388083860694897105090406378438272") };
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
public class A159677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159677Inst Instance=new A159677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159678
{
public static readonly BigInteger[] Value={ 1L,17L,271L,4319L,68833L,1097009L,17483311L,278635967L,4440692161L,70772438609L,1127918325583L,17975920770719L,286486814005921L,4565813103324017L,72766522839178351L,1159698552323529599L,BigInteger.Parse("18482410314337295233"),BigInteger.Parse("294558866477073194129"),BigInteger.Parse("4694459453318833810831") };
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
public class A159678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159678Inst Instance=new A159678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159679
{
public static readonly BigInteger[] Value={ 0L,32L,8160L,2072640L,526442432L,133714305120L,33962907058080L,8626444678447232L,2191082985418538880L,BigInteger.Parse("556526451851630428320"),BigInteger.Parse("141355527687328710254432"),BigInteger.Parse("35903747506129640774197440"),BigInteger.Parse("9119410511029241427935895360"),BigInteger.Parse("2316294366053921193054943224032") };
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
public class A159679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159679Inst Instance=new A159679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159680
{
public static readonly BigInteger[] Value={ 0L,40L,15960L,6352080L,2528111920L,1006182192120L,400457984351880L,159381271589856160L,BigInteger.Parse("63433345634778399840"),BigInteger.Parse("25246312181370213280200"),BigInteger.Parse("10047968814839710107119800"),BigInteger.Parse("3999066341994023252420400240"),BigInteger.Parse("1591618356144806414753212175760"),BigInteger.Parse("633460106679290959048526025552280") };
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
public class A159680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159680Inst Instance=new A159680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159681
{
public static readonly BigInteger[] Value={ 0L,24L,3432L,487344L,69199440L,9825833160L,1395199109304L,198108447688032L,28130004372591264L,3994262512460271480L,BigInteger.Parse("567157146764985958920"),BigInteger.Parse("80532320578115545895184"),BigInteger.Parse("11435022364945642531157232"),BigInteger.Parse("1623692643501703123878431784"),BigInteger.Parse("230552920354876897948206156120") };
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
public class A159681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159681Inst Instance=new A159681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159682
{
public static readonly BigInteger[] Value={ 1L,19L,161L,-4541L,-182879L,158099L,185882881L,3342055939L,-196736970559L,-9085291943021L,181506000088801L,21619197887729219L,11451559671492961L,BigInteger.Parse("-51668495296791759341"),BigInteger.Parse("-1011475465784925126079"),BigInteger.Parse("125453752981103348759299"),BigInteger.Parse("5418047703995739004663681") };
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
public class A159682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159682Inst Instance=new A159682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159683
{
public static readonly BigInteger[] Value={ 0L,16L,1008L,62496L,3873760L,240110640L,14882985936L,922505017408L,57180428093376L,3544264036771920L,219687189851765680L,13617061506772700256UL,BigInteger.Parse("844038126230055650208"),BigInteger.Parse("52316746764756677612656"),BigInteger.Parse("3242794261288683956334480"),BigInteger.Parse("201000927453133648615125120") };
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
public class A159683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159683Inst Instance=new A159683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159684
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L };
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
public class A159684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159684Inst : IEnumerable<long>
{
public static readonly long[] Value=A159684.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159684.Bytes);
public long this[int i]=>Value[i];

public static A159684Inst Instance=new A159684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159685
{
public static readonly long[] Value={ 1L,2L,3L,3L,6L,6L,10L,15L,15L,30L,30L,42L,42L,70L,105L,105L,210L,210L,210L,210L,330L,330L,462L,462L,770L,1155L,1155L,2310L,2310L,2730L,2730L,2730L,2730L,4290L,4290L,6006L,6006L,10010L,15015L,15015L,30030L,30030L,30030L,30030L,39270L,39270L,46410L,46410L };
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
public class A159685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159685Inst : IEnumerable<long>
{
public static readonly long[] Value=A159685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159685.Bytes);
public long this[int i]=>Value[i];

public static A159685Inst Instance=new A159685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159686
{
public static readonly long[] Value={ 0L,508L,33551L,2751328L,216056493L,18084221125L,1548424793743L,135655041210402L,12054551765023934L,1084635554912125542L };
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
public class A159686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159686Inst : IEnumerable<long>
{
public static readonly long[] Value=A159686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159686.Bytes);
public long this[int i]=>Value[i];

public static A159686Inst Instance=new A159686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159687
{
public static readonly long[] Value={ 0L,10L,73L,574L,4543L,37723L,320991L,2796946L,24758534L,222126290L,201400162L };
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
public class A159687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159687Inst : IEnumerable<long>
{
public static readonly long[] Value=A159687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159687.Bytes);
public long this[int i]=>Value[i];

public static A159687Inst Instance=new A159687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159688
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,6L,4L,2L,4L,5L,2L,3L,-30L,6L,2L,12L,-12L,7L,2L,2L,-6L,42L,8L,2L,12L,-24L,12L,9L,2L,3L,-15L,9L,-30L,10L,2L,4L,-10L,2L,-20L,11L,2L,6L,-1L,1L,-2L,66L,12L,2L,12L,-8L,6L,-8L,12L,13L,2L,1L,-6L,7L,-10L,3L,-2730L,14L,2L,12L,-60L,28L,-20L,12L,-420L,15L,2L,6L,-30L,18L,-10L,6L,-90L,6L,16L,2L,4L,-24L,12L,-16L,12L,-24L,4L };
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
public class A159688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159688Inst : IEnumerable<long>
{
public static readonly long[] Value=A159688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159688.Bytes);
public long this[int i]=>Value[i];

public static A159688Inst Instance=new A159688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159689
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L };
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
public class A159689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159689Inst : IEnumerable<long>
{
public static readonly long[] Value=A159689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159689.Bytes);
public long this[int i]=>Value[i];

public static A159689Inst Instance=new A159689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159690
{
public static readonly long[] Value={ 841L,881L,925L,4121L,4405L,4709L,23885L,25549L,27329L,139189L,148889L,159265L,811249L,867785L,928261L,4728305L,5057821L,5410301L,27558581L,29479141L,31533545L,160623181L,171817025L,183790969L,936180505L,1001423009L,1071212269L };
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
public class A159690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159690Inst : IEnumerable<long>
{
public static readonly long[] Value=A159690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159690.Bytes);
public long this[int i]=>Value[i];

public static A159690Inst Instance=new A159690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159691
{
public static readonly long[] Value={ 1L,0L,6L,9L,6L,9L,0L,0L,9L,0L,3L,7L,4L,1L,9L,9L,7L,6L,3L,9L,6L,1L,0L,3L,3L,9L,6L,8L,6L,9L,1L,0L,4L,1L,2L,2L,5L,0L,8L,5L,0L,4L,6L,7L,8L,6L,3L,4L,0L,3L,3L,1L,2L,3L,6L,1L,7L,8L,6L,8L,3L,9L,3L,7L,5L,6L,5L,9L,6L,0L,0L,0L,4L,6L,4L,8L,5L,9L,0L,8L,0L,0L,9L,4L,4L,0L,5L,9L,3L,3L,7L,6L,1L,8L,3L,4L,3L,8L,6L,6L,1L,2L,3L,5L,7L };
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
public class A159691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159691Inst : IEnumerable<long>
{
public static readonly long[] Value=A159691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159691.Bytes);
public long this[int i]=>Value[i];

public static A159691Inst Instance=new A159691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159692
{
public static readonly long[] Value={ 5L,0L,9L,3L,7L,2L,4L,1L,9L,1L,6L,5L,2L,6L,6L,6L,3L,3L,0L,5L,6L,2L,1L,7L,4L,4L,8L,0L,3L,7L,5L,1L,3L,9L,9L,8L,0L,4L,3L,6L,0L,1L,3L,0L,0L,1L,7L,0L,0L,4L,6L,8L,4L,6L,0L,2L,9L,0L,3L,9L,9L,9L,0L,4L,2L,9L,9L,5L,3L,2L,1L,9L,8L,8L,4L,7L,7L,1L,0L,6L,7L,7L,8L,5L,9L,0L,2L,0L,3L,7L,6L,3L,8L,9L,0L,9L,3L,7L,6L,6L,8L,1L,7L,5L,7L };
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
public class A159692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159692Inst : IEnumerable<long>
{
public static readonly long[] Value=A159692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159692.Bytes);
public long this[int i]=>Value[i];

public static A159692Inst Instance=new A159692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159693
{
public static readonly long[] Value={ 1L,2L,4L,8L,11L,20L,24L,40L,45L,70L,76L,112L,119L,168L,176L,240L,249L,330L,340L,440L,451L,572L,584L,728L,741L,910L,924L,1120L,1135L,1360L,1376L,1632L,1649L,1938L,1956L,2280L,2299L,2660L,2680L,3080L,3101L,3542L,3564L,4048L,4071L,4600L,4624L,5200L,5225L,5850L };
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
public class A159693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159693Inst : IEnumerable<long>
{
public static readonly long[] Value=A159693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159693.Bytes);
public long this[int i]=>Value[i];

public static A159693Inst Instance=new A159693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159694
{
public static readonly long[] Value={ 6L,13L,28L,60L,128L,272L,576L,1216L,2560L,5376L,11264L,23552L,49152L,102400L,212992L,442368L,917504L,1900544L,3932160L,8126464L,16777216L,34603008L,71303168L,146800640L,301989888L,620756992L,1275068416L,2617245696L,5368709120L };
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
public class A159694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159694Inst : IEnumerable<long>
{
public static readonly long[] Value=A159694.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159694.Bytes);
public long this[int i]=>Value[i];

public static A159694Inst Instance=new A159694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159695
{
public static readonly long[] Value={ 7L,15L,32L,68L,144L,304L,640L,1344L,2816L,5888L,12288L,25600L,53248L,110592L,229376L,475136L,983040L,2031616L,4194304L,8650752L,17825792L,36700160L,75497472L,155189248L,318767104L,654311424L,1342177280L,2751463424L,5637144576L };
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
public class A159695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159695Inst : IEnumerable<long>
{
public static readonly long[] Value=A159695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159695.Bytes);
public long this[int i]=>Value[i];

public static A159695Inst Instance=new A159695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159696
{
public static readonly long[] Value={ 8L,17L,36L,76L,160L,336L,704L,1472L,3072L,6400L,13312L,27648L,57344L,118784L,245760L,507904L,1048576L,2162688L,4456448L,9175040L,18874368L,38797312L,79691776L,163577856L,335544320L,687865856L,1409286144L,2885681152L,5905580032L };
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
public class A159696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159696Inst : IEnumerable<long>
{
public static readonly long[] Value=A159696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159696.Bytes);
public long this[int i]=>Value[i];

public static A159696Inst Instance=new A159696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159697
{
public static readonly long[] Value={ 9L,19L,40L,84L,176L,368L,768L,1600L,3328L,6912L,14336L,29696L,61440L,126976L,262144L,540672L,1114112L,2293760L,4718592L,9699328L,19922944L,40894464L,83886080L,171966464L,352321536L,721420288L,1476395008L,3019898880L };
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
public class A159697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159697Inst : IEnumerable<long>
{
public static readonly long[] Value=A159697.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159697.Bytes);
public long this[int i]=>Value[i];

public static A159697Inst Instance=new A159697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159698
{
public static readonly long[] Value={ 4L,5L,7L,8L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,29L,30L,32L,33L,37L,38L,39L,40L,42L,44L,47L,48L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,67L,68L,71L,72L,74L,75L,79L,80L,81L,82L,84L,85L,89L,90L,91L,92L,93L,94L,97L,98L,101L,102L,104L,105L,106L,108L,109L,110L,111L,112L };
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
public class A159698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159698Inst : IEnumerable<long>
{
public static readonly long[] Value=A159698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159698.Bytes);
public long this[int i]=>Value[i];

public static A159698Inst Instance=new A159698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159699
{
public static readonly long[] Value={ 0L,2L,5L,7L,12L,14L,17L,19L,28L,30L,33L,35L,40L,42L,45L,47L,64L,66L,69L,71L,76L,78L,81L,83L,92L,94L,97L,99L,104L,106L,109L,111L,144L,146L,149L,151L,156L,158L,161L,163L,172L,174L,177L,179L,184L,186L,189L,191L,208L,210L,213L,215L,220L,222L,225L,227L,236L,238L,241L,243L };
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
public class A159699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159699Inst : IEnumerable<long>
{
public static readonly long[] Value=A159699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159699.Bytes);
public long this[int i]=>Value[i];

public static A159699Inst Instance=new A159699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159700
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,2L,3L,4L,2L,1L,2L,1L,1L,2L,2L,2L,2L,1L,2L,4L,3L,3L,4L,2L,1L,2L,1L,2L,4L,2L,0L,0L,0L,2L,4L,3L,2L,2L,2L,4L,6L,3L,2L,4L,2L,1L,2L,1L,2L,4L,2L,1L,2L,2L,3L,4L,2L,2L,4L,3L,3L,4L,2L,2L,4L,2L,3L,6L,3L,1L,2L,1L,3L,6L,4L,2L,2L,1L,2L,4L,3L,4L,6L,4L,3L,4L,2L,6L,12L };
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
public class A159700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159700Inst : IEnumerable<long>
{
public static readonly long[] Value=A159700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159700.Bytes);
public long this[int i]=>Value[i];

public static A159700Inst Instance=new A159700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159701
{
public static readonly long[] Value={ 925L,967L,1013L,4537L,4835L,5153L,26297L,28043L,29905L,153245L,163423L,174277L,893173L,952495L,1015757L,5205793L,5551547L,5920265L,30341585L,32356787L,34505833L,176843717L,188589175L,201114733L,1030720717L,1099178263L };
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
public class A159701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159701Inst : IEnumerable<long>
{
public static readonly long[] Value=A159701.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159701.Bytes);
public long this[int i]=>Value[i];

public static A159701Inst Instance=new A159701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159702
{
public static readonly long[] Value={ 1L,0L,6L,6L,4L,1L,7L,1L,6L,3L,1L,2L,7L,6L,2L,7L,9L,0L,2L,9L,4L,4L,4L,4L,0L,8L,5L,1L,9L,8L,0L,5L,8L,6L,0L,5L,5L,2L,8L,1L,3L,5L,0L,1L,1L,6L,3L,5L,6L,3L,4L,5L,1L,0L,3L,6L,3L,9L,8L,9L,0L,2L,8L,7L,9L,7L,4L,7L,5L,9L,2L,8L,5L,4L,7L,2L,9L,3L,9L,7L,2L,0L,4L,8L,5L,4L,3L,6L,4L,5L,4L,5L,0L,9L,2L,2L,0L,5L,0L,5L,8L,9L,4L,8L,7L };
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
public class A159702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159702Inst : IEnumerable<long>
{
public static readonly long[] Value=A159702.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159702.Bytes);
public long this[int i]=>Value[i];

public static A159702Inst Instance=new A159702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159703
{
public static readonly long[] Value={ 5L,1L,2L,5L,0L,3L,8L,3L,3L,8L,2L,0L,5L,0L,1L,4L,6L,7L,2L,7L,0L,9L,6L,9L,1L,1L,2L,7L,9L,6L,0L,2L,0L,1L,0L,2L,1L,8L,8L,8L,5L,8L,9L,9L,6L,9L,5L,9L,9L,8L,1L,2L,2L,2L,8L,6L,4L,0L,2L,8L,0L,7L,3L,3L,6L,6L,7L,2L,7L,1L,5L,9L,6L,6L,3L,0L,3L,3L,6L,9L,5L,9L,6L,5L,8L,7L,1L,0L,6L,9L,2L,5L,9L,0L,6L,5L,8L,8L,7L,5L,5L,9L,5L,9L,7L };
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
public class A159703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159703Inst : IEnumerable<long>
{
public static readonly long[] Value=A159703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159703.Bytes);
public long this[int i]=>Value[i];

public static A159703Inst Instance=new A159703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159704
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,2L,1L,1L,2L,0L,1L,0L,1L,0L,2L,2L,1L,4L,2L,2L,4L,1L,2L,2L,0L,1L,0L,1L,0L,2L,2L,1L,4L,2L,2L,4L,1L,2L,2L,1L,1L,2L,2L,1L,4L,3L,2L,6L,4L,3L,8L,3L,4L,6L,1L,3L,2L,2L,1L,4L,3L,2L,6L,4L,3L,8L,1L,4L,2L,0L,1L,0L,2L,0L,4L,3L,2L,6L,3L,3L,6L,2L,3L,4L,1L,2L,2L,1L,1L,2L,3L,1L,6L,4L,3L,8L };
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
public class A159704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159704Inst : IEnumerable<long>
{
public static readonly long[] Value=A159704.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159704.Bytes);
public long this[int i]=>Value[i];

public static A159704Inst Instance=new A159704Inst();

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