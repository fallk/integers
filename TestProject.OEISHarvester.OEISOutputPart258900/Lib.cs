using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A193270
{
public static readonly BigInteger[] Value={ 1L,2L,41L,5913L,3218949L,5746014471L,33346758707039L,629041120985307133L,BigInteger.Parse("38569311842617827824519"),BigInteger.Parse("7686740212720656511786911885"),BigInteger.Parse("4979434019923682892902923543291527") };
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
public class A193270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193270Inst Instance=new A193270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193271
{
public static readonly BigInteger[] Value={ 1L,2L,42L,10455L,17957112L,139031457162L,4542089826393987L,BigInteger.Parse("623345036311461259086"),BigInteger.Parse("359303834921251677870936120"),BigInteger.Parse("869870085407321787861592624745847") };
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
public class A193271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193271Inst Instance=new A193271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193272
{
public static readonly BigInteger[] Value={ 1L,2L,42L,12422L,46043957L,1141280241767L,150904343382960765L,BigInteger.Parse("103330870123503516426952"),BigInteger.Parse("365608923633974657544208900050"),BigInteger.Parse("6683711936086156432904840085269243480") };
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
public class A193272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193272Inst Instance=new A193272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193273
{
public static readonly BigInteger[] Value={ 1L,2L,42L,12806L,71531470L,4359452409293L,1840118598465187309L,BigInteger.Parse("4839010680027431179628037"),BigInteger.Parse("78256880677789721019902991767596") };
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
public class A193273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193273Inst Instance=new A193273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193274
{
public static readonly BigInteger[] Value={ 0L,0L,1L,10L,105L,1326L,20503L,384126L,8567730L,223587231L,6725042325L,230228283165L,8877197732406L,382107434701266L,18221275474580181L,956287167902779240L,BigInteger.Parse("54916689705422813731"),BigInteger.Parse("3433293323775503064306"),BigInteger.Parse("232614384749689991763561"),BigInteger.Parse("17010440815323680947084096") };
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
public class A193274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193274Inst Instance=new A193274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193275
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,-2L,1L,0L,-2L,0L,0L,0L,1L,-2L,0L,0L,0L,2L,0L,2L,-1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,2L,-1L,-2L,-2L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,-2L,0L,1L,0L,0L,2L,0L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,2L,0L,1L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,-2L,0L,-2L,2L,2L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L };
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
public class A193275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193275Inst : IEnumerable<long>
{
public static readonly long[] Value=A193275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193275.Bytes);
public long this[int i]=>Value[i];

public static A193275Inst Instance=new A193275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193436
{
public static readonly BigInteger[] Value={ 1L,1L,5L,71L,2276L,144724L,16688884L,3249507820L,1005334796864L,468967172341824L,315409074574480704L,BigInteger.Parse("294510517409159769024"),BigInteger.Parse("369877735410388416241920"),BigInteger.Parse("608401340784471133062837504"),BigInteger.Parse("1281569707473914769353921666304"),BigInteger.Parse("3391681347749396029674738480747264") };
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
public class A193436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193436Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193436.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193436Inst Instance=new A193436Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193437
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,7L,31L,91L,931L,7441L,38017L,507241L,5864761L,43501591L,713059711L,10776989587L,105784464331L,2052437475361L,38263122487681L,469863736958161L,10518597616325617L,232980391759702951L,3446848352553524191L,BigInteger.Parse("87385257330831947851") };
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
public class A193437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193437Inst Instance=new A193437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193438
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,25L,145L,505L,1345L,43345L,481825L,3027025L,13679425L,528618025L,8796735025L,81517983625L,529655946625L,23619691278625L,526089195906625L,6512769913326625L,55783484692170625L,2802281186570685625L,BigInteger.Parse("78369733286598300625"),BigInteger.Parse("1221751619270220585625") };
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
public class A193438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193438Inst Instance=new A193438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193439
{
public static readonly BigInteger[] Value={ 1L,1L,5L,68L,1936L,99336L,8326912L,1063584640L,196475565312L,50403792222720L,17382740425346304L,7847087503671023616L,BigInteger.Parse("4535069738055660564480"),BigInteger.Parse("3292828639234241171484672"),BigInteger.Parse("2955617286961757422869504000"),BigInteger.Parse("3233957295970672142211481337856") };
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
public class A193439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193439Inst Instance=new A193439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193440
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,145L,10489L,4182481L,10893144241L,213590500341121L,BigInteger.Parse("35762619247862532481"),BigInteger.Parse("57146369032805384396332801"),BigInteger.Parse("963199581177063129894232882156801"),BigInteger.Parse("187554502919537918586035198740350553881601"),BigInteger.Parse("458564976873147078680542618033293809080455988300801") };
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
public class A193440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193440Inst Instance=new A193440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193441
{
public static readonly BigInteger[] Value={ 1L,1L,7L,111L,3089L,131985L,7977687L,645443295L,67165412385L,8722553971041L,1380689271177255L,261365482010524815L,BigInteger.Parse("58252017195624969009"),BigInteger.Parse("15086874107373899187825"),BigInteger.Parse("4490370671139664566269175"),BigInteger.Parse("1521257907398602231501780095"),BigInteger.Parse("581762614758928225569542394945") };
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
public class A193441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193441Inst Instance=new A193441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193442
{
public static readonly BigInteger[] Value={ 1L,2L,24L,624L,27744L,1857600L,173256192L,21357471744L,3350185712640L,649812612225024L,152385461527633920L,BigInteger.Parse("42429768718712094720"),BigInteger.Parse("13819620038445598408704"),BigInteger.Parse("5199913478124022299033600"),BigInteger.Parse("2236448840442614178722611200"),BigInteger.Parse("1089467246881095674146487009280") };
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
public class A193442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193442Inst Instance=new A193442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193443
{
public static readonly BigInteger[] Value={ 1L,1L,9L,177L,6081L,320625L,23901993L,2382903873L,305213701185L,48729724204833L,9471295552801545L,2198860046959656465L,BigInteger.Parse("600311814859681301889"),BigInteger.Parse("190227653770262659729425"),BigInteger.Parse("69194247433728324962214825"),BigInteger.Parse("28616922449430718198313413665"),BigInteger.Parse("13345389352004839017903164910465") };
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
public class A193443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193443Inst Instance=new A193443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193444
{
public static readonly BigInteger[] Value={ 1L,1L,5L,51L,857L,21045L,702597L,30379839L,1642718865L,108171928521L,8495805003525L,782625366185355L,83400601634195049L,10163125433194019325UL,BigInteger.Parse("1402348965454767334725"),BigInteger.Parse("217258436356989650347095"),BigInteger.Parse("37513434482581646048138145"),BigInteger.Parse("7172552434209226974773867025") };
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
public class A193444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193444Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193444.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193444.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193444Inst Instance=new A193444Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193445
{
public static readonly BigInteger[] Value={ 1L,6L,22L,154L,548L,7488L,26136L,471168L,3272832L,46114560L,241087680L,10152587520L,39605518080L,1245053859840L,19626466406400L,402874746624000L,2446811181158400L,156604969130803200L,863130293635276800L,BigInteger.Parse("62029933697765376000") };
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
public class A193445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193445Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193445.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193445.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193445Inst Instance=new A193445Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193446
{
public static readonly BigInteger[] Value={ 2L,18L,142L,1160L,10208L,97720L,1018008L,11507472L,140581872L,1848236544L,26041957632L,391738883328L,6268657962240L,106361504663040L,1907768564282880L,36075270482058240L,717379367864693760L,14967427450111488000UL,BigInteger.Parse("326956068509511168000") };
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
public class A193446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193446Inst Instance=new A193446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193447
{
public static readonly BigInteger[] Value={ 3L,3299L,255877L,4807626353L,1040021719579L,100970241446066087L,BigInteger.Parse("13409937746820630739862069"),BigInteger.Parse("9507270961010432209186683871"),BigInteger.Parse("7757618593382991688938927430572972973"),BigInteger.Parse("12437732976339904486975781548721278876097561"),BigInteger.Parse("18522993694996570934756402022946152638511627907") };
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
public class A193447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193447Inst Instance=new A193447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193448
{
public static readonly long[] Value={ 4L,44L,124L,244L,404L,604L,844L,1124L,1444L,1804L,2204L,2644L,3124L,3644L,4204L,4804L,5444L,6124L,6844L,7604L,8404L,9244L,10124L,11044L,12004L,13004L,14044L,15124L,16244L,17404L,18604L,19844L,21124L,22444L,23804L,25204L,26644L,28124L,29644L,31204L,32804L };
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
public class A193448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193448Inst : IEnumerable<long>
{
public static readonly long[] Value=A193448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193448.Bytes);
public long this[int i]=>Value[i];

public static A193448Inst Instance=new A193448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193449
{
public static readonly long[] Value={ 0L,1L,6L,15L,44L,105L,258L,595L,1368L,3069L,6830L,15015L,32772L,70993L,152922L,327675L,699056L,1485477L,3145734L,6640975L,13981020L,29360121L,61516466L,128625315L,268435464L,559240525L,1163220318L,2415919095L,5010795188L,10379504289L,21474836490L,44381328715L };
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
public class A193449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193449Inst : IEnumerable<long>
{
public static readonly long[] Value=A193449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193449.Bytes);
public long this[int i]=>Value[i];

public static A193449Inst Instance=new A193449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193450
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,2L,3L,6L,6L,0L,4L,12L,16L,8L,4L,5L,20L,35L,30L,15L,0L,6L,30L,66L,78L,54L,18L,6L,7L,42L,112L,168L,154L,84L,28L,0L,8L,56L,176L,320L,368L,272L,128L,32L,8L,9L,72L,261L,558L,774L,720L,450L,180L,45L,0L,10L,90L,370L,910L,1480L,1660L,1300L,700L,250L,50L,10L };
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
public class A193450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193450Inst : IEnumerable<long>
{
public static readonly long[] Value=A193450.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193450.Bytes);
public long this[int i]=>Value[i];

public static A193450Inst Instance=new A193450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193451
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,3L,0L,5L,8L,2L,0L,7L,17L,14L,6L,0L,9L,30L,39L,24L,3L,0L,11L,47L,83L,75L,33L,9L,0L,13L,68L,152L,184L,126L,48L,4L,0L,15L,93L,252L,384L,354L,198L,60L,12L,0L,17L,122L,389L,716L,830L,620L,290L,80L,5L,0L,19L,155L,569L,1229L,1718L,1610L,1010L,410L,95L,15L };
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
public class A193451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193451Inst : IEnumerable<long>
{
public static readonly long[] Value=A193451.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193451.Bytes);
public long this[int i]=>Value[i];

public static A193451Inst Instance=new A193451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193900
{
public static readonly long[] Value={ 1L,2L,1L,10L,5L,2L,42L,21L,10L,4L,170L,85L,42L,20L,8L,682L,341L,170L,84L,40L,16L,2730L,1365L,682L,340L,168L,80L,32L,10922L,5461L,2730L,1364L,680L,336L,160L,64L,43690L,21845L,10922L,5460L,2728L,1360L,672L,320L,128L,174762L,87381L,43690L,21844L,10920L };
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
public class A193900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193900Inst : IEnumerable<long>
{
public static readonly long[] Value=A193900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193900.Bytes);
public long this[int i]=>Value[i];

public static A193900Inst Instance=new A193900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193901
{
public static readonly long[] Value={ 1L,2L,5L,29L,56L,56L,59L,424L,424L,1351L,1353L,1353L,4004L,4004L,4004L,15212L,40725L,64098L,76662L,76662L,192998L,251887L,489989L,489991L,1013057L,4143368L,4431511L,4431511L,4431511L,8309350L,30951255L,35867405L,55131136L,102123612L,144869833L,148753758L };
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
public class A193901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193901Inst : IEnumerable<long>
{
public static readonly long[] Value=A193901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193901.Bytes);
public long this[int i]=>Value[i];

public static A193901Inst Instance=new A193901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193902
{
public static readonly long[] Value={ 1L,2L,1L,4L,6L,3L,8L,12L,14L,7L,16L,24L,28L,30L,15L,32L,48L,56L,60L,62L,31L,64L,96L,112L,120L,124L,126L,63L,128L,192L,224L,240L,248L,252L,254L,127L,256L,384L,448L,480L,496L,504L,508L,510L,255L,512L,768L,896L,960L,992L,1008L,1016L,1020L,1022L,511L,1024L,1536L,1792L,1920L,1984L,2016L,2032L,2040L,2044L,2046L,1023L,2048L,3072L,3584L,3840L };
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
public class A193902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193902Inst : IEnumerable<long>
{
public static readonly long[] Value=A193902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193902.Bytes);
public long this[int i]=>Value[i];

public static A193902Inst Instance=new A193902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193903
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,4L,7L,14L,12L,8L,15L,30L,28L,24L,16L,31L,62L,60L,56L,48L,32L,63L,126L,124L,120L,112L,96L,64L,127L,254L,252L,248L,240L,224L,192L,128L,255L,510L,508L,504L,496L,480L,448L,384L,256L,511L,1022L,1020L,1016L,1008L,992L,960L,896L,768L,512L,1023L,2046L };
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
public class A193903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193903Inst : IEnumerable<long>
{
public static readonly long[] Value=A193903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193903.Bytes);
public long this[int i]=>Value[i];

public static A193903Inst Instance=new A193903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193904
{
public static readonly long[] Value={ 1L,2L,1L,8L,6L,3L,32L,24L,14L,7L,128L,96L,56L,30L,15L,512L,384L,224L,120L,62L,31L,2048L,1536L,896L,480L,248L,126L,63L,8192L,6144L,3584L,1920L,992L,504L,254L,127L,32768L,24576L,14336L,7680L,3968L,2016L,1016L,510L,255L,131072L,98304L,57344L,30720L,15872L };
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
public class A193904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193904Inst : IEnumerable<long>
{
public static readonly long[] Value=A193904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193904.Bytes);
public long this[int i]=>Value[i];

public static A193904Inst Instance=new A193904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193905
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,7L,14L,24L,32L,15L,30L,56L,96L,128L,31L,62L,120L,224L,384L,512L,63L,126L,248L,480L,896L,1536L,2048L,127L,254L,504L,992L,1920L,3584L,6144L,8192L,255L,510L,1016L,2016L,3968L,7680L,14336L,24576L,32768L,511L,1022L,2040L,4064L,8064L,15872L };
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
public class A193905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193905Inst : IEnumerable<long>
{
public static readonly long[] Value=A193905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193905.Bytes);
public long this[int i]=>Value[i];

public static A193905Inst Instance=new A193905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193906
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,8L,3L,8L,14L,23L,5L,13L,23L,39L,63L,8L,21L,37L,63L,103L,167L,13L,34L,60L,102L,167L,272L,440L,21L,55L,97L,165L,270L,440L,713L,1154L,34L,89L,157L,267L,437L,712L,1154L,1869L,3024L,55L,144L,254L,432L,707L,1152L,1867L,3024L,4894L,7919L,89L,233L };
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
public class A193906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193906Inst : IEnumerable<long>
{
public static readonly long[] Value=A193906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193906.Bytes);
public long this[int i]=>Value[i];

public static A193906Inst Instance=new A193906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193907
{
public static readonly long[] Value={ 1L,2L,1L,8L,5L,2L,23L,14L,8L,3L,63L,39L,23L,13L,5L,167L,103L,63L,37L,21L,8L,440L,272L,167L,102L,60L,34L,13L,1154L,713L,440L,270L,165L,97L,55L,21L,3024L,1869L,1154L,712L,437L,267L,157L,89L,34L,7919L,4894L,3024L,1867L,1152L,707L,432L,254L,144L,55L,20735L,12815L };
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
public class A193907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193907Inst : IEnumerable<long>
{
public static readonly long[] Value=A193907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193907.Bytes);
public long this[int i]=>Value[i];

public static A193907Inst Instance=new A193907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193908
{
public static readonly long[] Value={ 1L,2L,1L,8L,6L,3L,24L,20L,12L,6L,80L,64L,40L,22L,11L,256L,208L,128L,72L,38L,19L,832L,672L,416L,232L,124L,64L,32L,2688L,2176L,1344L,752L,400L,208L,106L,53L,8704L,7040L,4352L,2432L,1296L,672L,344L,174L,87L,28160L,22784L,14080L,7872L,4192L,2176L,1112L,564L };
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
public class A193908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193908Inst : IEnumerable<long>
{
public static readonly long[] Value=A193908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193908.Bytes);
public long this[int i]=>Value[i];

public static A193908Inst Instance=new A193908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193909
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,6L,12L,20L,24L,11L,22L,40L,64L,80L,19L,38L,72L,128L,208L,256L,32L,64L,124L,232L,416L,672L,832L,53L,106L,208L,400L,752L,1344L,2176L,2688L,87L,174L,344L,672L,1296L,2432L,4352L,7040L,8704L,142L,284L,564L,1112L,2176L,4192L,7872L,14080L,22784L };
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
public class A193909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193909Inst : IEnumerable<long>
{
public static readonly long[] Value=A193909.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193909.Bytes);
public long this[int i]=>Value[i];

public static A193909Inst Instance=new A193909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193910
{
public static readonly long[] Value={ 2L,6L,11L,15L,20L,24L,29L,33L,38L,42L,47L,51L,56L,60L,65L,69L,74L,78L,83L,87L,92L,96L,101L,105L,110L,114L,119L,123L,128L,132L,137L,141L,146L,150L,155L,159L,164L,168L,173L,177L,182L,186L,191L,195L,200L,204L,209L,213L,218L,222L,227L,231L,236L,240L,245L,249L };
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
public class A193910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193910Inst : IEnumerable<long>
{
public static readonly long[] Value=A193910.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193910.Bytes);
public long this[int i]=>Value[i];

public static A193910Inst Instance=new A193910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193911
{
public static readonly long[] Value={ 1L,3L,7L,14L,25L,43L,69L,110L,167L,255L,375L,558L,805L,1179L,1681L,2438L,3451L,4975L,7011L,10070L,14153L,20283L,28461L,40734L,57103L,81663L,114415L,163550L,229069L,327355L,458409L,654998L,917123L,1310319L,1834587L,2620998L,3669553L,5242395L,7339525L,10485230L };
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
public class A193911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193911Inst : IEnumerable<long>
{
public static readonly long[] Value=A193911.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193911.Bytes);
public long this[int i]=>Value[i];

public static A193911Inst Instance=new A193911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193912
{
public static readonly long[] Value={ 1L,4L,11L,25L,50L,93L,162L,272L,439L,694L,1069L,1627L,2432L,3611L,5292L,7730L,11181L,16156L,23167L,33237L,47390L,67673L,96134L,136868L,193971L,275634L,390049L,553599L,782668L,1110023L,1568432L,2223430L,3140553L,4450872L,6285459L,8906457L,12576010L,17818405L };
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
public class A193912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193912Inst : IEnumerable<long>
{
public static readonly long[] Value=A193912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193912.Bytes);
public long this[int i]=>Value[i];

public static A193912Inst Instance=new A193912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193913
{
public static readonly long[] Value={ 1L,3L,15L,79L,425L,2317L,12749L,70631L,393379L,2200203L,12348645L,69507969L,392211153L,2217824883L,12564291759L,71294454543L,405135974649L,2305189276605L,13131574749357L,74883034577575L,427430124521651L,2441889639394043L,13961588736578245L,79884779408549249L };
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
public class A193913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193913Inst : IEnumerable<long>
{
public static readonly long[] Value=A193913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193913.Bytes);
public long this[int i]=>Value[i];

public static A193913Inst Instance=new A193913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193914
{
public static readonly BigInteger[] Value={ 1L,4L,52L,9082L,98800528L,1489760354451679L,BigInteger.Parse("42284543959225995963195839122"),BigInteger.Parse("9219047900683729245890381510225803761616665179387562897871") };
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
public class A193914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193914Inst Instance=new A193914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193915
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,2L,16L,12L,8L,4L,48L,40L,24L,14L,7L,160L,128L,80L,44L,24L,12L,512L,416L,256L,144L,76L,40L,20L,1664L,1344L,832L,464L,248L,128L,66L,33L,5376L,4352L,2688L,1504L,800L,416L,212L,108L,54L,17408L,14080L,8704L,4864L,2592L,1344L,688L,348L,176L,88L };
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
public class A193915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193915Inst : IEnumerable<long>
{
public static readonly long[] Value=A193915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193915.Bytes);
public long this[int i]=>Value[i];

public static A193915Inst Instance=new A193915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193948
{
public static readonly long[] Value={ 4L,6L,10L,12L,16L,22L,24L,30L,34L,36L,40L,184L,527L,4896L,11658L,12874L,18904L,41919L,45998L,48504L,50688L,51982L,356207L,426851L,960750L,1961725L,4604094L,8418495L,10811745L,32963628L,45249999L,569800611L,7374557947L,121153257533L };
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
public class A193948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193948Inst : IEnumerable<long>
{
public static readonly long[] Value=A193948.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193948.Bytes);
public long this[int i]=>Value[i];

public static A193948Inst Instance=new A193948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193949
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,13L,8L,19L,32L,45L,15L,38L,64L,92L,120L,30L,75L,128L,184L,242L,300L,56L,142L,243L,352L,464L,578L,692L,104L,264L,454L,659L,872L,1088L,1306L,1524L,189L,482L,831L,1210L,1604L,2006L,2411L,2818L,3225L,340L,869L,1502L,2191L,2910L,3644L,4386L };
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
public class A193949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193949Inst : IEnumerable<long>
{
public static readonly long[] Value=A193949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193949.Bytes);
public long this[int i]=>Value[i];

public static A193949Inst Instance=new A193949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193950
{
public static readonly long[] Value={ 1L,4L,2L,13L,8L,3L,45L,32L,19L,8L,120L,92L,64L,38L,15L,300L,242L,184L,128L,75L,30L,692L,578L,464L,352L,243L,142L,56L,1524L,1306L,1088L,872L,659L,454L,264L,104L,3225L,2818L,2411L,2006L,1604L,1210L,831L,482L,189L,6625L,5878L,5131L,4386L,3644L,2910L,2191L };
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
public class A193950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193950Inst : IEnumerable<long>
{
public static readonly long[] Value=A193950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193950.Bytes);
public long this[int i]=>Value[i];

public static A193950Inst Instance=new A193950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193951
{
public static readonly long[] Value={ 1L,1L,1L,4L,6L,10L,9L,15L,27L,42L,16L,28L,52L,84L,136L,25L,45L,85L,140L,230L,370L,36L,66L,126L,210L,348L,564L,912L,49L,91L,175L,294L,490L,798L,1295L,2093L,64L,120L,232L,392L,656L,1072L,1744L,2824L,4568L,81L,153L,297L,504L,846L,1386L,2259L,3663L,5931L,9594L };
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
public class A193951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193951Inst : IEnumerable<long>
{
public static readonly long[] Value=A193951.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193951.Bytes);
public long this[int i]=>Value[i];

public static A193951Inst Instance=new A193951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193952
{
public static readonly long[] Value={ 1L,1L,1L,10L,6L,4L,42L,27L,15L,9L,136L,84L,52L,28L,16L,370L,230L,140L,85L,45L,25L,912L,564L,348L,210L,126L,66L,36L,2093L,1295L,798L,490L,294L,175L,91L,49L,4568L,2824L,1744L,1072L,656L,392L,232L,120L,64L,9594L,5931L,3663L,2259L,1386L,846L,504L,297L,153L };
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
public class A193952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193952Inst : IEnumerable<long>
{
public static readonly long[] Value=A193952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193952.Bytes);
public long this[int i]=>Value[i];

public static A193952Inst Instance=new A193952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193953
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,2L,5L,9L,13L,3L,8L,14L,21L,28L,5L,13L,23L,34L,46L,58L,8L,21L,37L,55L,74L,94L,114L,13L,34L,60L,89L,120L,152L,185L,218L,21L,55L,97L,144L,194L,246L,299L,353L,407L,34L,89L,157L,233L,314L,398L,484L,571L,659L,747L,55L,144L,254L,377L,508L,644L,783L };
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
public class A193953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193953Inst : IEnumerable<long>
{
public static readonly long[] Value=A193953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193953.Bytes);
public long this[int i]=>Value[i];

public static A193953Inst Instance=new A193953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193954
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,13L,9L,5L,2L,28L,21L,14L,8L,3L,58L,46L,34L,23L,13L,5L,114L,94L,74L,55L,37L,21L,8L,218L,185L,152L,120L,89L,60L,34L,13L,407L,353L,299L,246L,194L,144L,97L,55L,21L,747L,659L,571L,484L,398L,314L,233L,157L,89L,34L,1352L,1209L,1066L,924L,783L,644L };
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
public class A193954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193954Inst : IEnumerable<long>
{
public static readonly long[] Value=A193954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193954.Bytes);
public long this[int i]=>Value[i];

public static A193954Inst Instance=new A193954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193955
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,13L,2L,9L,23L,45L,3L,14L,36L,71L,120L,5L,23L,59L,116L,196L,300L,8L,37L,95L,187L,316L,484L,692L,13L,60L,154L,303L,512L,784L,1121L,1524L,21L,97L,249L,490L,828L,1268L,1813L,2465L,3225L,34L,157L,403L,793L,1340L,2052L,2934L,3989L,5219L,6625L,55L };
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
public class A193955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193955Inst : IEnumerable<long>
{
public static readonly long[] Value=A193955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193955.Bytes);
public long this[int i]=>Value[i];

public static A193955Inst Instance=new A193955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193956
{
public static readonly long[] Value={ 1L,4L,1L,13L,5L,1L,45L,23L,9L,2L,120L,71L,36L,14L,3L,300L,196L,116L,59L,23L,5L,692L,484L,316L,187L,95L,37L,8L,1524L,1121L,784L,512L,303L,154L,60L,13L,3225L,2465L,1813L,1268L,828L,490L,249L,97L,21L,6625L,5219L,3989L,2934L,2052L,1340L,793L,403L,157L,34L,13280L };
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
public class A193956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193956Inst : IEnumerable<long>
{
public static readonly long[] Value=A193956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193956.Bytes);
public long this[int i]=>Value[i];

public static A193956Inst Instance=new A193956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193957
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,3L,5L,9L,14L,4L,7L,13L,21L,34L,5L,9L,17L,28L,46L,74L,6L,11L,21L,35L,58L,94L,152L,7L,13L,25L,42L,70L,114L,185L,299L,8L,15L,29L,49L,82L,134L,218L,353L,571L,9L,17L,33L,56L,94L,154L,251L,407L,659L,1066L,10L,19L,37L,63L,106L,174L,284L,461L,747L,1209L };
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
public class A193957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193957Inst : IEnumerable<long>
{
public static readonly long[] Value=A193957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193957.Bytes);
public long this[int i]=>Value[i];

public static A193957Inst Instance=new A193957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193958
{
public static readonly long[] Value={ 1L,1L,1L,5L,3L,2L,14L,9L,5L,3L,34L,21L,13L,7L,4L,74L,46L,28L,17L,9L,5L,152L,94L,58L,35L,21L,11L,6L,299L,185L,114L,70L,42L,25L,13L,7L,571L,353L,218L,134L,82L,49L,29L,15L,8L,1066L,659L,407L,251L,154L,94L,56L,33L,17L,9L,1956L,1209L,747L,461L,284L,174L,106L,63L,37L };
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
public class A193958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193958Inst : IEnumerable<long>
{
public static readonly long[] Value=A193958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193958.Bytes);
public long this[int i]=>Value[i];

public static A193958Inst Instance=new A193958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193959
{
public static readonly long[] Value={ 1L,1L,4L,5L,9L,9L,13L,23L,36L,16L,25L,45L,71L,116L,25L,41L,75L,120L,196L,316L,36L,61L,113L,183L,300L,484L,784L,49L,85L,159L,260L,428L,692L,1121L,1813L,64L,113L,213L,351L,580L,940L,1524L,2465L,3989L,81L,145L,275L,456L,756L,1228L,1993L,3225L,5219L,8444L };
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
public class A193959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193959Inst : IEnumerable<long>
{
public static readonly long[] Value=A193959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193959.Bytes);
public long this[int i]=>Value[i];

public static A193959Inst Instance=new A193959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193960
{
public static readonly long[] Value={ 1L,1L,1L,9L,5L,4L,36L,23L,13L,9L,116L,71L,45L,25L,16L,316L,196L,120L,75L,41L,25L,784L,484L,300L,183L,113L,61L,36L,1813L,1121L,692L,428L,260L,159L,85L,49L,3989L,2465L,1524L,940L,580L,351L,213L,113L,64L,8444L,5219L,3225L,1993L,1228L,756L,456L,275L,145L,81L };
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
public class A193960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193960Inst : IEnumerable<long>
{
public static readonly long[] Value=A193960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193960.Bytes);
public long this[int i]=>Value[i];

public static A193960Inst Instance=new A193960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193961
{
public static readonly long[] Value={ 1L,1L,4L,4L,17L,40L,9L,40L,98L,184L,16L,73L,184L,354L,584L,25L,116L,298L,584L,979L,1484L,36L,169L,440L,874L,1484L,2275L,3248L,49L,232L,610L,1224L,2099L,3248L,4676L,6384L,64L,305L,808L,1634L,2824L,4403L,6384L,8772L,11568L,81L,388L,1034L,2104L,3659L };
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
public class A193961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193961Inst : IEnumerable<long>
{
public static readonly long[] Value=A193961.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193961.Bytes);
public long this[int i]=>Value[i];

public static A193961Inst Instance=new A193961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193962
{
public static readonly long[] Value={ 1L,4L,1L,40L,17L,4L,184L,98L,40L,9L,584L,354L,184L,73L,16L,1484L,979L,584L,298L,116L,25L,3248L,2275L,1484L,874L,440L,169L,36L,6384L,4676L,3248L,2099L,1224L,610L,232L,49L,11568L,8772L,6384L,4403L,2824L,1634L,808L,305L,64L,19668L,15333L,11568L,8372L };
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
public class A193962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193962Inst : IEnumerable<long>
{
public static readonly long[] Value=A193962.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193962.Bytes);
public long this[int i]=>Value[i];

public static A193962Inst Instance=new A193962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193963
{
public static readonly long[] Value={ 1L,4L,1L,9L,20L,5L,16L,45L,56L,14L,25L,80L,126L,120L,30L,36L,125L,224L,270L,220L,55L,49L,180L,350L,480L,495L,364L,91L,64L,245L,504L,750L,880L,819L,560L,140L,81L,320L,686L,1080L,1375L,1456L,1260L,816L,204L,100L,405L,896L,1470L,1980L,2275L,2240L,1836L,1140L };
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
public class A193963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193963Inst : IEnumerable<long>
{
public static readonly long[] Value=A193963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193963.Bytes);
public long this[int i]=>Value[i];

public static A193963Inst Instance=new A193963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194204
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,6L,6L,7L,7L,7L,8L,9L,9L,9L,10L,11L,11L,12L,13L,13L,13L,14L,15L,15L,15L,16L,16L,17L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,22L,23L,23L,23L,24L,25L,25L,25L,26L,27L,27L,27L,28L,28L,29L,30L,30L,31L,32L,32L,33L,33L,33L,34L,34L,34L,35L,36L };
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
public class A194204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194204Inst : IEnumerable<long>
{
public static readonly long[] Value=A194204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194204.Bytes);
public long this[int i]=>Value[i];

public static A194204Inst Instance=new A194204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194205
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,10L,13L,17L,21L,26L,32L,38L,44L,51L,58L,65L,73L,82L,91L,100L,110L,121L,132L,144L,157L,170L,183L,197L,212L,227L,242L,258L,274L,291L,309L,327L,346L,365L,384L,404L,424L,444L,465L,486L,508L,531L,554L,577L,601L,626L,651L,676L,702L,729L,756L };
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
public class A194205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194205Inst : IEnumerable<long>
{
public static readonly long[] Value=A194205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194205.Bytes);
public long this[int i]=>Value[i];

public static A194205Inst Instance=new A194205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194206
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,3L,4L,4L,4L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,13L,13L,14L,15L,15L,15L,16L,16L,17L,18L,19L,19L,19L,19L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,26L,26L,26L,27L,27L,28L,29L,29L,30L,30L,30L,31L,31L,32L,33L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L };
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
public class A194206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194206Inst : IEnumerable<long>
{
public static readonly long[] Value=A194206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194206.Bytes);
public long this[int i]=>Value[i];

public static A194206Inst Instance=new A194206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194207
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,5L,8L,12L,16L,20L,25L,31L,37L,44L,51L,59L,67L,76L,85L,95L,106L,117L,129L,141L,154L,167L,181L,196L,211L,226L,242L,258L,275L,293L,312L,331L,350L,369L,389L,410L,431L,453L,475L,498L,521L,545L,569L,594L,620L,646L,672L,699L,726L,754L,783L,812L,842L };
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
public class A194207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194207Inst : IEnumerable<long>
{
public static readonly long[] Value=A194207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194207.Bytes);
public long this[int i]=>Value[i];

public static A194207Inst Instance=new A194207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194208
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,4L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,14L,14L,15L,16L,16L,17L,17L,18L,18L,19L,20L,20L,20L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,27L,27L,27L,28L,28L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,35L,35L,36L,36L,37L,37L,38L,38L,39L };
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
public class A194208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194208Inst : IEnumerable<long>
{
public static readonly long[] Value=A194208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194208.Bytes);
public long this[int i]=>Value[i];

public static A194208Inst Instance=new A194208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194209
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,6L,9L,13L,17L,22L,27L,33L,39L,46L,54L,62L,71L,80L,90L,100L,111L,123L,135L,148L,161L,175L,189L,204L,220L,236L,253L,270L,288L,306L,325L,345L,365L,385L,406L,428L,450L,473L,496L,520L,544L,569L,594L,620L,647L,674L,701L,729L,757L,786L,816L,846L };
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
public class A194209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194209Inst : IEnumerable<long>
{
public static readonly long[] Value=A194209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194209.Bytes);
public long this[int i]=>Value[i];

public static A194209Inst Instance=new A194209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194210
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,7L,8L,8L,9L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,20L,21L,21L,21L,21L,22L,22L,22L,22L,23L,23L,24L,24L,25L,25L,26L,27L,27L,28L,29L,30L,31L,32L,32L,32L,32L,32L,32L,32L,33L,33L,34L,34L };
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
public class A194210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194210Inst : IEnumerable<long>
{
public static readonly long[] Value=A194210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194210.Bytes);
public long this[int i]=>Value[i];

public static A194210Inst Instance=new A194210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194211
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,4L,6L,9L,12L,16L,20L,25L,31L,38L,46L,54L,63L,73L,83L,94L,105L,116L,127L,138L,150L,162L,174L,187L,200L,214L,229L,244L,260L,277L,294L,312L,331L,351L,372L,393L,414L,435L,457L,479L,501L,523L,546L,569L,593L,617L,642L,667L,693L,720L,747L,775L };
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
public class A194211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194211Inst : IEnumerable<long>
{
public static readonly long[] Value=A194211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194211.Bytes);
public long this[int i]=>Value[i];

public static A194211Inst Instance=new A194211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194212
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,9L,9L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,18L,18L,19L,19L,19L,20L,20L,21L,21L,22L,23L,23L,23L,24L,24L,25L,25L,26L,26L,26L,27L,27L,28L,28L,29L,30L,30L,31L,31L,32L,32L,33L,34L,34L,34L,35L,35L,36L,36L };
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
public class A194212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194212Inst : IEnumerable<long>
{
public static readonly long[] Value=A194212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194212.Bytes);
public long this[int i]=>Value[i];

public static A194212Inst Instance=new A194212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194213
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,6L,9L,13L,17L,22L,27L,33L,39L,46L,53L,61L,70L,79L,88L,98L,109L,120L,132L,144L,157L,170L,184L,198L,213L,228L,244L,260L,276L,293L,311L,329L,348L,367L,386L,406L,426L,447L,468L,490L,513L,536L,559L,583L,607L,632L,657L,683L,709L,735L,762L,789L,817L };
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
public class A194213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194213Inst : IEnumerable<long>
{
public static readonly long[] Value=A194213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194213.Bytes);
public long this[int i]=>Value[i];

public static A194213Inst Instance=new A194213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194214
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,4L,5L,5L,5L,5L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,11L,11L,12L,12L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,18L,19L,20L,21L,21L,21L,21L,22L,22L,23L,23L,24L,25L,26L,26L,26L,26L,26L,27L,27L,28L,28L,29L,30L,31L,31L,31L,31L,32L,32L,32L,33L,34L,35L,35L };
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
public class A194214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194214Inst : IEnumerable<long>
{
public static readonly long[] Value=A194214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194214.Bytes);
public long this[int i]=>Value[i];

public static A194214Inst Instance=new A194214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194215
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,4L,7L,11L,16L,21L,26L,31L,36L,42L,48L,55L,63L,71L,80L,90L,100L,111L,122L,133L,145L,157L,170L,184L,198L,213L,228L,243L,259L,275L,291L,308L,325L,343L,362L,382L,403L,424L,445L,466L,488L,510L,533L,556L,580L,605L,631L,657L,683L,709L,735L,762L };
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
public class A194215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194215Inst : IEnumerable<long>
{
public static readonly long[] Value=A194215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194215.Bytes);
public long this[int i]=>Value[i];

public static A194215Inst Instance=new A194215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194216
{
public static readonly BigInteger[] Value={ BigInteger.Parse("3512911982806776822251393039617"),BigInteger.Parse("2211377674535255285545615254209921"),BigInteger.Parse("476961452964007550415682034114910337"),BigInteger.Parse("46677208572152524490331633250547044320123137") };
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
public class A194216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194216Inst Instance=new A194216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194217
{
public static readonly long[] Value={ 0L,8L,4L,10L,10L,4L,6L,6L,0L,24L,0L,4L,18L,36L,12L,10L,6L,0L,36L,36L,34L,0L,0L,12L,0L,10L,24L,18L,34L,0L,14L,0L,22L,0L,0L,10L,0L,0L,18L,24L,0L,4L,60L,48L,10L,0L,0L,0L,0L,28L,24L,0L,0L,0L,16L,36L,36L,6L,8L,12L,36L,10L,0L,0L,24L,0L,22L,54L,30L,0L,14L,12L,18L,22L };
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
public class A194217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194217Inst : IEnumerable<long>
{
public static readonly long[] Value=A194217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194217.Bytes);
public long this[int i]=>Value[i];

public static A194217Inst Instance=new A194217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194218
{
public static readonly long[] Value={ 1L,8L,20L,30L,98L,88L,494L,998L,494L,744L,238L,2450L,2550L,28L,5288L,6048L,9998L,3008L,4938L,1518L,60494L,68320L,90480L,99998L,20408L,21948L,33058L,35010L,43470L,101558L,108878L,123448L,127194L,152344L,213018L,217930L,249500L,250500L,284270L,289940L,371718L };
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
public class A194218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194218Inst : IEnumerable<long>
{
public static readonly long[] Value=A194218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194218.Bytes);
public long this[int i]=>Value[i];

public static A194218Inst Instance=new A194218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194219
{
public static readonly long[] Value={ 0L,1L,25L,25L,1L,209L,209L,1L,1729L,1984L,4641L,2500L,2500L,5264L,1984L,1729L,1L,14336L,17284L,37444L,17284L,14336L,4641L,1L,122449L,126201L,148761L,152100L,165025L,217124L,221089L,227904L,229449L,237969L,248521L,248900L,250000L,250000L,248900L,248521L };
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
public class A194219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194219Inst : IEnumerable<long>
{
public static readonly long[] Value=A194219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194219.Bytes);
public long this[int i]=>Value[i];

public static A194219Inst Instance=new A194219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194348
{
public static readonly long[] Value={ 1L,7L,6L,0L,8L,3L,9L,5L,5L,5L,8L,8L,0L,0L,2L,8L,0L,9L,0L,7L,5L,6L,6L,4L,9L,8L,9L,5L,6L,3L,8L,3L,7L,2L,7L,4L,8L,0L,7L,9L,8L,0L,4L,0L,9L,4L,3L,1L,8L,5L,0L,9L,9L,0L,4L,6L,4L,6L,3L,8L,8L,2L,2L,5L,0L,5L,3L,4L,2L,8L,4L,1L,6L,8L,7L,5L,4L,5L,4L,6L,5L,8L,1L,1L,9L,0L,4L,6L,3L,5L,1L,1L,5L,2L,6L,3L,0L,5L,9L,8L,4L };
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
public class A194348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194348Inst : IEnumerable<long>
{
public static readonly long[] Value=A194348.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194348.Bytes);
public long this[int i]=>Value[i];

public static A194348Inst Instance=new A194348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194349
{
public static readonly BigInteger[] Value={ 1L,2L,5L,24L,129L,960L,7965L,80640L,903105L,11612160L,163451925L,2554675200L,43259364225L,797058662400L,15764670046125L,334764638208000L,7571150452490625L,182111963185152000L,4634731528895593125L,BigInteger.Parse("124564582818643968000") };
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
public class A194349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194349Inst Instance=new A194349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194350
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,10L,20L,50L,100L,100L,200L,500L,1000L,1000L,2000L,5000L,10000L,10000L,20000L,50000L,100000L,100000L,200000L,500000L,1000000L,1000000L,2000000L,5000000L,10000000L,10000000L,20000000L,50000000L };
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
public class A194350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194350Inst : IEnumerable<long>
{
public static readonly long[] Value=A194350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194350.Bytes);
public long this[int i]=>Value[i];

public static A194350Inst Instance=new A194350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194351
{
public static readonly long[] Value={ 1L,6L,2L,11L,40L,15L,22L,148L,1750L,1842L,12735L,26862L,27372L,2943L,37619L,39587L,106920L,820238L,76875L,47887L,6150809L,3660438L,17376657L,15416321L,162454456L,132295965L,265234498L,33844308L,4847933000L,671531549L,1122335995L,2894348872L,763748417L };
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
public class A194351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194351Inst : IEnumerable<long>
{
public static readonly long[] Value=A194351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194351.Bytes);
public long this[int i]=>Value[i];

public static A194351Inst Instance=new A194351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194352
{
public static readonly long[] Value={ 7839L,8739L,11248L,12148L,21148L,44488L,44489L,44939L,49439L,70839L,78039L,80739L,87039L,94439L,101248L,102148L,110248L,112048L,120148L,121048L,201148L,210148L,211048L,222688L,222689L,226288L,226289L,236839L,238639L,258598L,258599L,262288L,262289L,263839L };
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
public class A194352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194352Inst : IEnumerable<long>
{
public static readonly long[] Value=A194352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194352.Bytes);
public long this[int i]=>Value[i];

public static A194352Inst Instance=new A194352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194353
{
public static readonly long[] Value={ 1L,1L,3L,9L,32L,114L,431L,1633L,6306L,24466L,95604L,374920L,1475731L,5822941L,23027817L,91225983L,361945480L,1437855016L,5718242653L,22762417519L,90684186378L,361540944078L,1442313708600L,5757140994990L,22991764612516L,91861397186492L };
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
public class A194353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194353Inst : IEnumerable<long>
{
public static readonly long[] Value=A194353.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194353.Bytes);
public long this[int i]=>Value[i];

public static A194353Inst Instance=new A194353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194354
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,2L,0L,3L,2L,0L,8L,8L,0L,15L,38L,8L,0L,48L,176L,48L,0L,105L,692L,540L,48L,0L,384L,3584L,3584L,384L,0L,945L,13884L,26204L,9104L,384L,0L,3840L,78848L,188416L,78848L,3840L,0L,109L,315294L,1194380L,997576L,181280L,3840L };
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
public class A194354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194354Inst : IEnumerable<long>
{
public static readonly long[] Value=A194354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194354.Bytes);
public long this[int i]=>Value[i];

public static A194354Inst Instance=new A194354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194355
{
public static readonly long[] Value={ 44488L,222688L,226288L,258598L,262288L,285598L,404488L,440488L,444088L,528598L,582598L,622288L,825598L,852598L,1113688L,1116388L,1131688L,1136188L,1161388L,1163188L,1233588L,1235388L,1253388L,1311688L,1316188L,1323588L,1325388L,1332588L,1335288L,1352388L };
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
public class A194355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194355Inst : IEnumerable<long>
{
public static readonly long[] Value=A194355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194355.Bytes);
public long this[int i]=>Value[i];

public static A194355Inst Instance=new A194355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194356
{
public static readonly long[] Value={ 1L,2L,5L,10L,4L,20L,25L,50L,100L,8L,40L,125L,200L,250L,500L,1000L,16L,80L,400L,625L,1250L,2000L,2500L,5000L,10000L,32L,160L,800L,3125L,4000L,6250L,12500L,20000L,25000L,50000L,100000L,64L,320L,1600L,8000L,15625L,31250L,40000L,62500L,125000L,200000L,250000L };
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
public class A194356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194356Inst : IEnumerable<long>
{
public static readonly long[] Value=A194356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194356.Bytes);
public long this[int i]=>Value[i];

public static A194356Inst Instance=new A194356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194357
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,9L,12L,18L,36L,8L,24L,27L,54L,72L,108L,216L,16L,48L,81L,144L,162L,324L,432L,648L,1296L,32L,96L,243L,288L,486L,864L,972L,1944L,2592L,3888L,7776L,64L,192L,576L,729L,1458L,1728L,2916L,5184L,5832L,11664L,15552L,23328L,46656L,128L,384L,1152L,2187L };
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
public class A194357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194357Inst : IEnumerable<long>
{
public static readonly long[] Value=A194357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194357.Bytes);
public long this[int i]=>Value[i];

public static A194357Inst Instance=new A194357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194358
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,10L,15L,30L,4L,9L,12L,18L,20L,25L,36L,45L,50L,60L,75L,90L,100L,150L,180L,225L,300L,450L,900L,8L,24L,27L,40L,54L,72L,108L,120L,125L,135L,200L,216L,250L,270L,360L,375L,500L,540L,600L,675L,750L,1000L,1080L,1125L,1350L,1500L,1800L,2250L,2700L,3000L };
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
public class A194358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194358Inst : IEnumerable<long>
{
public static readonly long[] Value=A194358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194358.Bytes);
public long this[int i]=>Value[i];

public static A194358Inst Instance=new A194358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194359
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,14L,15L,21L,30L,35L,42L,70L,105L,210L,4L,9L,12L,18L,20L,25L,28L,36L,45L,49L,50L,60L,63L,75L,84L,90L,98L,100L,126L,140L,147L,150L,175L,180L,196L,225L,245L,252L,294L,300L,315L,350L,420L,441L,450L,490L,525L,588L,630L,700L,735L,882L,900L };
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
public class A194359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194359Inst : IEnumerable<long>
{
public static readonly long[] Value=A194359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194359.Bytes);
public long this[int i]=>Value[i];

public static A194359Inst Instance=new A194359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194360
{
public static readonly long[] Value={ 1L,3L,5L,7L,15L,21L,35L,105L,9L,25L,45L,49L,63L,75L,147L,175L,225L,245L,315L,441L,525L,735L,1225L,1575L,2205L,3675L,11025L,27L,125L,135L,189L,343L,375L,675L,875L,945L,1029L,1125L,1323L,1715L,2625L,3087L,3375L,4725L,5145L,6125L,6615L,7875L,8575L,9261L,15435L };
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
public class A194360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194360Inst : IEnumerable<long>
{
public static readonly long[] Value=A194360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194360.Bytes);
public long this[int i]=>Value[i];

public static A194360Inst Instance=new A194360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194361
{
public static readonly long[] Value={ 1L,7L,4L,7L,1L,7L,1L,1L,7L,1L,6L,9L,3L,0L,4L,1L,4L,6L,3L,3L,2L,0L,0L,0L,0L,9L,7L,3L,0L,7L,5L,4L,2L,5L,6L,9L,2L,4L,2L,0L,3L,9L,1L,1L,6L,1L,7L,3L,7L,7L,9L,6L,6L,3L,3L,2L,3L,6L,0L,2L,5L,5L,1L,1L,7L,8L,1L,4L,5L,6L,5L,7L,6L,2L,2L,0L,5L,0L,4L,1L,0L,3L,2L,2L,7L,0L,1L,1L,4L,5L,1L,3L,0L,9L,6L,6L,9L,1L,9L,6L,5L,1L,0L,3L,2L };
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
public class A194361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194361Inst : IEnumerable<long>
{
public static readonly long[] Value=A194361.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194361.Bytes);
public long this[int i]=>Value[i];

public static A194361Inst Instance=new A194361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194362
{
public static readonly long[] Value={ 1L,5L,4L,7L,7L,7L,7L,1L,0L,8L,7L,1L,4L,1L,9L,7L,6L,2L,4L,8L,1L,5L,0L,3L,2L,6L,5L,3L,2L,2L,5L,5L,3L,4L,8L,0L,7L,4L,4L,1L,1L,4L,5L,3L,8L,5L,3L,5L,9L,0L,4L,6L,2L,7L,4L,1L,8L,6L,1L,1L,3L,5L,2L,1L,0L,0L,6L,6L,5L,6L,9L,2L,1L,1L,3L,6L,3L,2L,6L,4L,2L,1L,9L,3L,1L,7L,8L,4L,9L,3L,4L,5L,1L,3L,1L,6L,7L,3L,3L,6L,9L,3L,7L,7L,1L };
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
public class A194362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194362Inst : IEnumerable<long>
{
public static readonly long[] Value=A194362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194362.Bytes);
public long this[int i]=>Value[i];

public static A194362Inst Instance=new A194362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194363
{
public static readonly long[] Value={ 0L,2L,-1L,4L,5L,-1L,-1L,9L,12L,7L,15L,-1L,10L,22L,8L,-1L,29L,-1L,34L,35L,-1L,39L,42L,-1L,-1L,25L,52L,18L,-1L,-1L,64L,65L,-1L,23L,-1L,25L,-1L,82L,84L,-1L,89L,45L,95L,-1L,-1L,11L,21L,112L,114L,57L,-1L,119L,60L,125L,-1L,44L,-1L,135L,-1L,14L,142L,-1L,22L,155L,-1L };
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
public class A194363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194363Inst : IEnumerable<long>
{
public static readonly long[] Value=A194363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194363.Bytes);
public long this[int i]=>Value[i];

public static A194363Inst Instance=new A194363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228432
{
public static readonly long[] Value={ 0L,0L,2L,2L,7L,14L,24L,25L,37L,70L,71L,114L,140L,143L,170L,234L,274L,310L,357L,399L,444L,498L,552L,660L,784L,850L,856L,926L,990L,1064L,1310L,1395L,1564L,1574L,1850L,1859L,2054L,2173L,2277L,2494L,2623L,2730L,2986L,3104L,3234L,3246L,3656L,4085L,4235L,4370L };
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
public class A228432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228432Inst : IEnumerable<long>
{
public static readonly long[] Value=A228432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228432.Bytes);
public long this[int i]=>Value[i];

public static A228432Inst Instance=new A228432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228433
{
public static readonly long[] Value={ 24L,114L,114L,228L,1242L,221355126L };
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
public class A228433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228433Inst : IEnumerable<long>
{
public static readonly long[] Value=A228433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228433.Bytes);
public long this[int i]=>Value[i];

public static A228433Inst Instance=new A228433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228434
{
public static readonly long[] Value={ 2L,7L,11L,23L,127L,167L,137L,269L,547L,547L,383L,547L,269L,431L,547L,547L,293L,383L,431L,1171L,1039L,1171L,641L,1039L,1103L,1171L,887L,1361L,2551L,1861L,3001L,2753L,1193L,2963L,1499L,2153L,2753L,2551L,2963L,4327L,5281L,1823L,2963L,4219L,4327L,3593L,3583L,6763L };
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
public class A228434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228434Inst : IEnumerable<long>
{
public static readonly long[] Value=A228434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228434.Bytes);
public long this[int i]=>Value[i];

public static A228434Inst Instance=new A228434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228435
{
public static readonly long[] Value={ 6L,14L,24L,54L,56L,84L,96L,112L,124L,126L,130L,150L,154L,156L,210L,216L,224L,266L,294L,336L,342L,344L,350L,366L,384L,436L,448L,456L,486L,496L,504L,520L,531L,546L,570L,600L,616L,624L,630L,660L,686L,726L,756L,814L,840L,864L,896L,924L,1008L,1014L,1064L,1116L,1134L };
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
public class A228435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228435Inst : IEnumerable<long>
{
public static readonly long[] Value=A228435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228435.Bytes);
public long this[int i]=>Value[i];

public static A228435Inst Instance=new A228435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228436
{
public static readonly long[] Value={ 1L,3L,7L,11L,15L,19L,31L,41L,53L,59L,63L,67L,79L,83L,91L,97L,103L,105L,117L,127L,131L,141L,157L,167L,173L,179L,181L,185L,193L,217L,219L,223L,227L,229L,237L,239L,251L,255L,269L,271L,277L,281L,283L,291L,293L,303L,307L,311L,313L,317L,337L,347L,351L,359L,377L };
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
public class A228436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228436Inst : IEnumerable<long>
{
public static readonly long[] Value=A228436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228436.Bytes);
public long this[int i]=>Value[i];

public static A228436Inst Instance=new A228436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228437
{
public static readonly long[] Value={ 1L,24L,12L,8L,6L,24L,4L,24L,3L,8L,12L,24L,2L,24L,12L,8L,3L,24L,4L,24L,6L,8L,12L,24L,1L,24L,12L,8L,6L,24L,4L,24L,3L,8L,12L,24L,2L,24L,12L,8L,3L,24L,4L,24L,6L,8L,12L,24L,1L,24L,12L,8L,6L,24L,4L,24L,3L,8L,12L,24L,2L,24L,12L,8L,3L,24L,4L,24L,6L,8L,12L,24L,1L };
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
public class A228437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228437Inst : IEnumerable<long>
{
public static readonly long[] Value=A228437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228437.Bytes);
public long this[int i]=>Value[i];

public static A228437Inst Instance=new A228437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228438
{
public static readonly long[] Value={ 1L,8L,0L,8L,3L,1L,7L,7L,4L,3L,0L,8L,7L,2L,2L,9L,4L,0L,0L,3L,0L,0L,6L,5L,6L,5L,4L,3L,4L,9L,5L,1L,4L,5L,9L,1L,2L,8L,1L,3L,9L,2L,2L,8L,3L,6L,1L,0L,6L,7L,3L,0L,7L,4L,1L,5L,9L,8L,2L,3L,5L,3L,5L,5L,6L,3L,9L,7L,9L,4L,4L,8L,9L,9L,7L,0L,2L,2L,8L,6L,9L,8L,2L,1L,1L,1L,5L,6L,8L,7L,7L,7L,8L,3L,6L,8L,6L,1L,7L,8L,8L,1L,3L,0L,2L };
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
public class A228438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228438Inst : IEnumerable<long>
{
public static readonly long[] Value=A228438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228438.Bytes);
public long this[int i]=>Value[i];

public static A228438Inst Instance=new A228438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228439
{
public static readonly long[] Value={ 1L,7L,49L,343L,2401L,4753L,16807L,33271L,76783L,117649L,232897L,461041L,537481L,823543L,1630279L,3227287L,3762367L,5764801L };
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
public class A228439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228439Inst : IEnumerable<long>
{
public static readonly long[] Value=A228439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228439.Bytes);
public long this[int i]=>Value[i];

public static A228439Inst Instance=new A228439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228440
{
public static readonly long[] Value={ 1L,11L,121L,253L,1331L,2783L,5819L,11891L,14641L,29161L,30613L,64009L,130801L,133837L,161051L,273493L,320771L,336743L,558877L,640343L,670703L,704099L,895873L,1438811L,1472207L,1771561L,3008423L,3078251L,3528481L,3544453L,3704173L,6147647L,6290339L,7027801L };
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
public class A228440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228440Inst : IEnumerable<long>
{
public static readonly long[] Value=A228440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228440.Bytes);
public long this[int i]=>Value[i];

public static A228440Inst Instance=new A228440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228441
{
public static readonly long[] Value={ 1L,-2L,2L,-1L,2L,-4L,2L,0L,3L,-4L,2L,-2L,2L,-4L,4L,1L,2L,-6L,2L,-2L,4L,-4L,2L,0L,3L,-4L,4L,-2L,2L,-8L,2L,2L,4L,-4L,4L,-3L,2L,-4L,4L,0L,2L,-8L,2L,-2L,6L,-4L,2L,2L,3L,-6L,4L,-2L,2L,-8L,4L,0L,4L,-4L,2L,-4L,2L,-4L,6L,3L,4L,-8L,2L,-2L,4L,-8L,2L,0L,2L,-4L,6L,-2L,4L };
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
public class A228441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228441Inst : IEnumerable<long>
{
public static readonly long[] Value=A228441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228441.Bytes);
public long this[int i]=>Value[i];

public static A228441Inst Instance=new A228441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228442
{
public static readonly long[] Value={ 1L,6L,7L,9L,19L,900L,1000L,13L,901L,16L,905L,5L,15L,906L,17L,907L,908L,1001L,600L,1005L,500L,1006L,601L,605L,501L,606L,607L,909L,910L,911L,505L,506L,608L,1007L,912L,57L,913L,914L,915L,916L,917L,918L,919L,9000L,300L,1008L,1009L,9001L,609L,9005L,508L,1010L,9006L,610L,9007L };
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
public class A228442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228442Inst : IEnumerable<long>
{
public static readonly long[] Value=A228442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228442.Bytes);
public long this[int i]=>Value[i];

public static A228442Inst Instance=new A228442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228443
{
public static readonly long[] Value={ 1L,2L,6L,6L,7L,10L,14L,12L,18L,18L,12L,22L,31L,20L,30L,30L,20L,36L,38L,28L,42L,42L,42L,46L,43L,36L,54L,60L,36L,58L,62L,42L,84L,66L,44L,70L,74L,62L,60L,78L,61L,82L,108L,60L,90L,84L,60L,108L,98L,70L,102L,102L,72L,106L,110L,76L,114L,132L,98L,108L,111L,84L,156L };
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
public class A228443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228443Inst : IEnumerable<long>
{
public static readonly long[] Value=A228443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228443.Bytes);
public long this[int i]=>Value[i];

public static A228443Inst Instance=new A228443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228444
{
public static readonly long[] Value={ 11L,23L,43L,67L,127L,631L,839L,3631L,1831L,4831L,3691L,6491L,108127L,80363L,108127L,336403L,132961L,288403L,144961L,504403L,384403L,192961L,384403L,384403L,384403L,432511L,864511L,384961L,432961L,640847L,864511L,640847L,720961L,5441651L,7681651L,8641651L,8641651L };
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
public class A228444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228444Inst : IEnumerable<long>
{
public static readonly long[] Value=A228444.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228444.Bytes);
public long this[int i]=>Value[i];

public static A228444Inst Instance=new A228444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A228445
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,19L,37L,41L,43L,53L,73L,83L,89L,101L,107L,109L,149L,173L,179L,181L,211L,293L,307L,331L,347L,409L,421L,587L,601L,613L,617L,619L,659L,661L,677L,683L,691L,809L,811L,821L,853L,857L,859L,877L,1171L,1193L,1229L,1237L,1321L,1381L,1427L,1429L,1433L,1451L,1453L,1459L,1609L,1613L,1619L,1621L,1627L,1637L,1709L,1741L };
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
public class A228445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A228445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A228445Inst : IEnumerable<long>
{
public static readonly long[] Value=A228445.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A228445.Bytes);
public long this[int i]=>Value[i];

public static A228445Inst Instance=new A228445Inst();

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