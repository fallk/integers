using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A254082
{
public static readonly BigInteger[] Value={ 362880L,18144000L,515592000L,10977120000L,195113318400L,3063348288000L,43943631732000L,588790762560000L,7481812222684800L,91158709273632000L,1073686615986821760L,12301136459932320000UL,BigInteger.Parse("137753173599205449600"),BigInteger.Parse("1513588462073525376000"),BigInteger.Parse("16368017165881385004000") };
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
public class A254082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254082Inst Instance=new A254082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254083
{
public static readonly BigInteger[] Value={ 1L,0L,3L,89L,5100L,510288L,79419060L,17758540440L,5397245411040L,2140495978400640L,1073686615986821760L,BigInteger.Parse("664582969579045104000"),BigInteger.Parse("497566995304189636425600"),BigInteger.Parse("443212653988584641970547200"),BigInteger.Parse("463237380681508395317004249600"),BigInteger.Parse("561422444732790213860667834854400") };
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
public class A254083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254083Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254083.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254083Inst Instance=new A254083Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254084
{
public static readonly BigInteger[] Value={ 512L,37961L,9231485L,7181975282L,17184949015860L,130340161010554804L,BigInteger.Parse("3076463598348748891236"),BigInteger.Parse("227190805931348173384051212"),BigInteger.Parse("52565635830483236304261230301048"),BigInteger.Parse("38007489014178178530213754490084391696") };
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
public class A254084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254084Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254084.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254084Inst Instance=new A254084Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254085
{
public static readonly long[] Value={ 512L,3436L,22728L,148004L,977192L,6446656L,42580424L,281186200L,1857372144L,12268544428L,81040372600L,535313103052L,3536037360504L,23357456516908L,154288871288536L,1019162914084204L,6732132852099864L,44469447874930540L };
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
public class A254085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254085Inst : IEnumerable<long>
{
public static readonly long[] Value=A254085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254085.Bytes);
public long this[int i]=>Value[i];

public static A254085Inst Instance=new A254085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254086
{
public static readonly long[] Value={ 3436L,37961L,438463L,5146916L,60605766L,710699434L,8345076092L,97946001730L,1149838343317L,13497707804263L,158452634496858L,1860069243627167L,21835461223405598L,256327049629318759L,3009034132382588682L };
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
public class A254086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254086Inst : IEnumerable<long>
{
public static readonly long[] Value=A254086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254086.Bytes);
public long this[int i]=>Value[i];

public static A254086Inst Instance=new A254086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254087
{
public static readonly BigInteger[] Value={ 22728L,437412L,9231485L,194642351L,4074710828L,85580284203L,1797518333568L,37753559435660L,792936896367040L,16654877814697296L,349811454916987908L,7347393872504020360L,BigInteger.Parse("154323313614708936148"),BigInteger.Parse("3241384012776367465864") };
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
public class A254087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254087Inst Instance=new A254087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254088
{
public static readonly BigInteger[] Value={ 148004L,5131608L,194360930L,7181975282L,264184393944L,9764722253800L,360366996893272L,13302280322759188L,491039035017014944L,18127539783574725228UL,BigInteger.Parse("669172641370201310864"),BigInteger.Parse("24703085984270258969052") };
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
public class A254088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254088Inst Instance=new A254088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254089
{
public static readonly BigInteger[] Value={ 977192L,60404379L,4070778350L,264423470022L,17184949015860L,1124256442364024L,73410212260111376L,4793743396389995848L,BigInteger.Parse("313099459714042693920"),BigInteger.Parse("20449236628089890619504"),BigInteger.Parse("1335541084997761891256960") };
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
public class A254089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254089Inst Instance=new A254089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254090
{
public static readonly BigInteger[] Value={ 6446656L,708989540L,85504231094L,9772939548082L,1124150631410252L,130340161010554804L,15064294240774906764UL,BigInteger.Parse("1741318040092853882632"),BigInteger.Parse("201385791936229716155204"),BigInteger.Parse("23286669327497271830694856") };
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
public class A254090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254090Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254090.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254090Inst Instance=new A254090Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254091
{
public static readonly BigInteger[] Value={ 42580424L,8324567231L,1795818466078L,360657676510382L,73398834331232444L,15062934487311200100UL,BigInteger.Parse("3076463598348748891236"),BigInteger.Parse("628629303926309241200676"),BigInteger.Parse("128530739245385377895831372"),BigInteger.Parse("26271475649467935061922989468") };
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
public class A254091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254091Inst Instance=new A254091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254092
{
public static readonly long[] Value={ 512L,3436L,3436L,22728L,37961L,22728L,148004L,437412L,438463L,148004L,977192L,5131608L,9231485L,5146916L,977192L,6446656L,60404379L,194360930L,194642351L,60605766L,6446656L,42580424L,708989540L,4070778350L,7181975282L,4074710828L };
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
public class A254092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254092Inst : IEnumerable<long>
{
public static readonly long[] Value=A254092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254092.Bytes);
public long this[int i]=>Value[i];

public static A254092Inst Instance=new A254092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254093
{
public static readonly long[] Value={ 3436L,37961L,437412L,5131608L,60404379L,708989540L,8324567231L,97709705091L,1147050936946L,13465223788702L,158070944683856L,1855595195609302L,21782931509612040L,255710529131800534L,3001796532233949648L };
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
public class A254093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254093Inst : IEnumerable<long>
{
public static readonly long[] Value=A254093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254093.Bytes);
public long this[int i]=>Value[i];

public static A254093Inst Instance=new A254093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254094
{
public static readonly BigInteger[] Value={ 22728L,438463L,9231485L,194360930L,4070778350L,85504231094L,1795818466078L,37718365402050L,792215767435114L,16639696007956962L,349493245126566770L,7340711187673951490L,BigInteger.Parse("154183037847939858274"),BigInteger.Parse("3238437646656851895746") };
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
public class A254094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254094Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254094.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254094Inst Instance=new A254094Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254095
{
public static readonly BigInteger[] Value={ 148004L,5146916L,194642351L,7181975282L,264423470022L,9772939548082L,360657676510382L,13312470384345326L,491420292416575362L,18141299959678267634UL,BigInteger.Parse("669682491875484528210"),BigInteger.Parse("24721843320226189525298") };
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
public class A254095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254095Inst Instance=new A254095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254096
{
public static readonly BigInteger[] Value={ 977192L,60605766L,4074710828L,264184393944L,17184949015860L,1124150631410252L,73398834331232444L,4793100436793492312L,BigInteger.Parse("313066675670374829192"),BigInteger.Parse("20446900686186641221416"),BigInteger.Parse("1335394414007764817183784") };
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
public class A254096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254096Inst Instance=new A254096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254097
{
public static readonly BigInteger[] Value={ 6446656L,710699434L,85580284203L,9764722253800L,1124256442364024L,130340161010554804L,15062934487311200100UL,BigInteger.Parse("1741233750122656726960"),BigInteger.Parse("201376899057386370531640"),BigInteger.Parse("23285440898809512492777532") };
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
public class A254097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254097Inst Instance=new A254097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254098
{
public static readonly BigInteger[] Value={ 42580424L,8345076092L,1797518333568L,360366996893272L,73410212260111376L,15064294240774906764UL,BigInteger.Parse("3076463598348748891236"),BigInteger.Parse("628666550662755790420160"),BigInteger.Parse("128538371787649827712304552"),BigInteger.Parse("26272866780707889640382975008") };
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
public class A254098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254098Inst Instance=new A254098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254099
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,14L,16L,20L,22L,24L,28L,32L,40L,44L,48L,56L,64L,80L,88L,96L,112L,128L,160L,176L,192L,224L,256L,317L,320L,352L,384L,448L,512L,634L,640L,704L,768L,896L,1024L,1268L,1280L,1408L,1536L,1792L,2048L,2536L,2560L,2816L,3072L,3584L,4096L,5072L,5120L,5632L,6144L,7168L,8192L,10144L,10240L,11264L };
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
public class A254099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254099Inst : IEnumerable<long>
{
public static readonly long[] Value=A254099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254099.Bytes);
public long this[int i]=>Value[i];

public static A254099Inst Instance=new A254099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254100
{
public static readonly long[] Value={ 4L,9L,19L,31L,55L,73L,101L,145L,167L,205L,253L,293L,317L,355L,413L,473L,521L,569L,623L,677L,737L,763L,833L,917L,983L,1027L,1051L,1121L,1171L,1273L,1337L,1411L,1471L,1571L,1619L,1663L,1681L,1807L,1957L,1991L,2087L,2113L,2171L,2245L,2275L,2335L,2401L,2497L,2593L,2713L,2771L,2831L,2977L,3047L,3113L };
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
public class A254100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254100Inst : IEnumerable<long>
{
public static readonly long[] Value=A254100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254100.Bytes);
public long this[int i]=>Value[i];

public static A254100Inst Instance=new A254100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254101
{
public static readonly long[] Value={ 1L,3L,1L,1L,1L,5L,3L,11L,23L,7L,7L,17L,1L,17L,41L,9L,5L,25L,95L,203L,61L,5L,13L,59L,149L,71L,19L,365L,3L,29L,77L,11L,223L,851L,1823L,547L,13L,35L,43L,115L,527L,1337L,319L,1367L,3281L,15L,19L,13L,257L,689L,395L,2005L,7655L,16403L,4921L,1L,11L,113L,311L,385L,1033L,4739L,12029L,5741L,6151L,29525L };
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
public class A254101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254101Inst : IEnumerable<long>
{
public static readonly long[] Value=A254101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254101.Bytes);
public long this[int i]=>Value[i];

public static A254101Inst Instance=new A254101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254102
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,4L,8L,3L,3L,6L,1L,6L,14L,1L,2L,9L,32L,68L,21L,2L,5L,20L,50L,24L,7L,122L,1L,10L,26L,4L,75L,284L,608L,183L,5L,12L,15L,39L,176L,446L,107L,456L,1094L,2L,7L,5L,86L,230L,132L,669L,2552L,5468L,1641L,1L,4L,38L,104L,129L,345L,1580L,4010L,1914L,2051L,9842L };
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
public class A254102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254102Inst : IEnumerable<long>
{
public static readonly long[] Value=A254102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254102.Bytes);
public long this[int i]=>Value[i];

public static A254102Inst Instance=new A254102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254103
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,8L,6L,14L,9L,11L,7L,23L,13L,17L,10L,41L,22L,26L,15L,32L,18L,20L,12L,68L,36L,38L,21L,50L,27L,29L,16L,122L,63L,65L,34L,77L,40L,44L,24L,95L,49L,53L,28L,59L,31L,35L,19L,203L,103L,107L,55L,113L,58L,62L,33L,149L,76L,80L,42L,86L,45L,47L,25L,365L,184L,188L,96L,194L,99L,101L,52L,230L,117L,119L,61L,131L,67L,71L,37L,284L,144L,146L,75L,158L,81L,83L,43L };
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
public class A254103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254103Inst : IEnumerable<long>
{
public static readonly long[] Value=A254103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254103.Bytes);
public long this[int i]=>Value[i];

public static A254103Inst Instance=new A254103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254104
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,7L,11L,6L,9L,15L,10L,23L,13L,8L,19L,31L,14L,21L,47L,22L,27L,17L,12L,39L,63L,18L,29L,43L,30L,95L,45L,20L,55L,35L,46L,25L,79L,26L,127L,37L,16L,59L,87L,38L,61L,191L,62L,91L,41L,28L,111L,71L,42L,93L,51L,94L,159L,53L,44L,255L,75L,54L,33L,119L,34L,175L,77L,24L,123L,383L,78L,125L,183L,126L,83L,57L,36L,223L,143L,58L,85L,187L,86L,103L,189L,60L };
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
public class A254104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254104Inst : IEnumerable<long>
{
public static readonly long[] Value=A254104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254104.Bytes);
public long this[int i]=>Value[i];

public static A254104Inst Instance=new A254104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254105
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,12L,13L,9L,7L,27L,28L,20L,14L,8L,58L,59L,43L,29L,17L,10L,121L,122L,90L,60L,36L,21L,11L,248L,249L,185L,123L,75L,44L,24L,15L,503L,504L,376L,250L,154L,91L,51L,30L,16L,1014L,1015L,759L,505L,313L,186L,106L,61L,33L,18L,2037L,2038L,1526L,1016L,632L,377L,217L,124L,68L,37L,19L,4084L,4085L,3061L,2039L,1271L,760L,440L,251L,139L,76L,40L,22L };
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
public class A254105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254105Inst : IEnumerable<long>
{
public static readonly long[] Value=A254105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254105.Bytes);
public long this[int i]=>Value[i];

public static A254105Inst Instance=new A254105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254106
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,5L,10L,15L,9L,21L,28L,7L,8L,14L,36L,45L,20L,55L,66L,13L,27L,78L,91L,35L,105L,120L,11L,12L,19L,44L,136L,153L,54L,171L,190L,26L,65L,210L,231L,77L,253L,276L,18L,34L,90L,300L,325L,104L,351L,378L,43L,119L,406L,435L,135L,465L,496L,16L,17L,25L,53L,152L,528L,561L,170L,595L,630L,64L,189L,666L,703L,209L,741L,780L,33L,76L };
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
public class A254106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254106Inst : IEnumerable<long>
{
public static readonly long[] Value=A254106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254106.Bytes);
public long this[int i]=>Value[i];

public static A254106Inst Instance=new A254106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254107
{
public static readonly long[] Value={ 1L,3L,2L,4L,6L,5L,7L,9L,13L,12L,8L,14L,20L,28L,27L,10L,17L,29L,43L,59L,58L,11L,21L,36L,60L,90L,122L,121L,15L,24L,44L,75L,123L,185L,249L,248L,16L,30L,51L,91L,154L,250L,376L,504L,503L,18L,33L,61L,106L,186L,313L,505L,759L,1015L,1014L,19L,37L,68L,124L,217L,377L,632L,1016L,1526L,2038L,2037L,22L,40L,76L,139L,251L,440L,760L,1271L,2039L,3061L,4085L,4084L };
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
public class A254107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254107Inst : IEnumerable<long>
{
public static readonly long[] Value=A254107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254107.Bytes);
public long this[int i]=>Value[i];

public static A254107Inst Instance=new A254107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254108
{
public static readonly long[] Value={ 1L,3L,2L,4L,6L,5L,7L,11L,8L,16L,22L,10L,9L,12L,29L,37L,17L,46L,56L,13L,23L,67L,79L,30L,92L,106L,15L,14L,18L,38L,121L,137L,47L,154L,172L,24L,57L,191L,211L,68L,232L,254L,19L,31L,80L,277L,301L,93L,326L,352L,39L,107L,379L,407L,122L,436L,466L,21L,20L,25L,48L,138L,497L,529L,155L,562L,596L,58L,173L,631L,667L,192L,704L,742L,32L,69L,212L };
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
public class A254108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254108Inst : IEnumerable<long>
{
public static readonly long[] Value=A254108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254108.Bytes);
public long this[int i]=>Value[i];

public static A254108Inst Instance=new A254108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254109
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,21L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,7L };
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
public class A254109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254109Inst : IEnumerable<long>
{
public static readonly long[] Value=A254109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254109.Bytes);
public long this[int i]=>Value[i];

public static A254109Inst Instance=new A254109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254110
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,3L,2L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,4L,3L,2L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,3L,2L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,5L,4L,3L,2L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,3L,2L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,4L,3L,2L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,3L,2L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,6L,5L,4L,3L,2L,1L,0L,0L };
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
public class A254110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254110Inst : IEnumerable<long>
{
public static readonly long[] Value=A254110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254110.Bytes);
public long this[int i]=>Value[i];

public static A254110Inst Instance=new A254110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254111
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,1L,4L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,1L,5L,4L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,1L,4L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,1L,6L,5L,4L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,1L,4L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,1L,5L,4L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,1L,4L,3L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,1L,7L,6L,5L,4L,3L,2L,1L,1L };
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
public class A254111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254111Inst : IEnumerable<long>
{
public static readonly long[] Value=A254111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254111.Bytes);
public long this[int i]=>Value[i];

public static A254111Inst Instance=new A254111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254112
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,4L,5L,3L,6L,7L,1L,2L,4L,8L,9L,5L,10L,11L,3L,6L,12L,13L,7L,14L,15L,1L,2L,4L,8L,16L,17L,9L,18L,19L,5L,10L,20L,21L,11L,22L,23L,3L,6L,12L,24L,25L,13L,26L,27L,7L,14L,28L,29L,15L,30L,31L,1L,2L,4L,8L,16L,32L,33L,17L,34L,35L,9L,18L,36L,37L,19L,38L,39L,5L,10L,20L,40L,41L,21L,42L,43L,11L,22L,44L,45L,23L,46L,47L,3L,6L,12L,24L,48L,49L,25L,50L };
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
public class A254112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254112Inst : IEnumerable<long>
{
public static readonly long[] Value=A254112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254112.Bytes);
public long this[int i]=>Value[i];

public static A254112Inst Instance=new A254112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254113
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L };
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
public class A254113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254113Inst : IEnumerable<long>
{
public static readonly long[] Value=A254113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254113.Bytes);
public long this[int i]=>Value[i];

public static A254113Inst Instance=new A254113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254114
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L };
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
public class A254114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254114Inst : IEnumerable<long>
{
public static readonly long[] Value=A254114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254114.Bytes);
public long this[int i]=>Value[i];

public static A254114Inst Instance=new A254114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254115
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,13L,10L,11L,12L,9L,14L,21L,16L,15L,26L,23L,20L,43L,22L,19L,24L,63L,18L,33L,28L,31L,42L,47L,32L,55L,30L,127L,52L,27L,46L,87L,40L,17L,86L,39L,44L,107L,38L,29L,48L,75L,126L,91L,36L,95L,66L,191L,56L,53L,62L,45L,84L,35L,94L,1023L,64L,255L,110L,25L,60L,183L,254L,79L,104L,37L,54L,171L,92L,125L,174L,59L,80L,4095L,34L,61L,172L,77L,78L };
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
public class A254115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254115Inst : IEnumerable<long>
{
public static readonly long[] Value=A254115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254115.Bytes);
public long this[int i]=>Value[i];

public static A254115Inst Instance=new A254115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254116
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,13L,10L,11L,12L,9L,14L,17L,16L,41L,26L,23L,20L,15L,22L,19L,24L,67L,18L,37L,28L,47L,34L,29L,32L,27L,82L,61L,52L,73L,46L,43L,40L,89L,30L,21L,44L,59L,38L,31L,48L,111L,134L,107L,36L,57L,74L,33L,56L,149L,94L,79L,68L,83L,58L,25L,64L,359L,54L,181L,164L,193L,122L,101L,104L,229L,146L,49L,92L,85L,86L,71L,80L,185L,178L,139L,60L,95L,42L,39L };
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
public class A254116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254116Inst : IEnumerable<long>
{
public static readonly long[] Value=A254116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254116.Bytes);
public long this[int i]=>Value[i];

public static A254116Inst Instance=new A254116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254117
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,4L,10L,7L,11L,21L,9L,31L,16L,15L,23L,27L,63L,13L,43L,8L,19L,53L,14L,37L,45L,47L,95L,26L,22L,17L,511L,127L,12L,91L,39L,18L,85L,62L,29L,2047L,30L,38L,111L,20L,54L,75L,42L,55L,157L,35L,46L,174L,25L,79L,24L,59L,77L,303L,123L,94L,78L,167L,87L,223L,61L,103L,699L,191L,41L,107L,183L,125L,431L,28L,71L,84L,60L,93L,110L,767L,51L };
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
public class A254117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254117Inst : IEnumerable<long>
{
public static readonly long[] Value=A254117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254117.Bytes);
public long this[int i]=>Value[i];

public static A254117Inst Instance=new A254117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254118
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,4L,8L,20L,11L,7L,9L,33L,18L,23L,14L,13L,30L,36L,21L,44L,10L,29L,15L,55L,53L,28L,16L,74L,39L,41L,12L,179L,90L,96L,50L,114L,24L,42L,35L,92L,69L,47L,19L,86L,25L,51L,26L,236L,153L,110L,81L,101L,22L,45L,48L,221L,113L,119L,56L,77L,65L,38L,17L,546L,182L };
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
public class A254118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254118Inst : IEnumerable<long>
{
public static readonly long[] Value=A254118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254118.Bytes);
public long this[int i]=>Value[i];

public static A254118Inst Instance=new A254118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254119
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,6L,16L,36L,71L,126L,204L,303L,414L,526L,652L,907L,1705L,4213L,11329L,29670L,73408L,171345L,379494L,802875L,1632745L,3210086L,6134908L,11457641L,21020580L,38076142L };
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
public class A254119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254119Inst : IEnumerable<long>
{
public static readonly long[] Value=A254119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254119.Bytes);
public long this[int i]=>Value[i];

public static A254119Inst Instance=new A254119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254120
{
public static readonly long[] Value={ 1L,2L,6L,20L,13L,179L,546L,762L,1816L,14750L,41855L,130334L,184744L,854072L,3087888L,10703601L,15578299L,96694224L,108119693L,514354272L,1569052954L,7807991046L,23534408763L,39516990609L,76222439041L,402903897267L,1860094976924L,5552186457189L,6550591089598L };
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
public class A254120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254120Inst : IEnumerable<long>
{
public static readonly long[] Value=A254120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254120.Bytes);
public long this[int i]=>Value[i];

public static A254120Inst Instance=new A254120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254121
{
public static readonly BigInteger[] Value={ 7L,61L,117643L,793714773254131L,BigInteger.Parse("45671926166590716193865151022383844364247891937"),BigInteger.Parse("403343566675122500462878634623535631588559593930513766350645748813807") };
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
public class A254121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254121Inst Instance=new A254121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254122
{
public static readonly long[] Value={ 4L,6L,7L,9L,10L,11L,14L,15L,16L,18L,22L,23L,24L,25L,26L,29L,35L,36L,37L,39L,40L,42L,47L,56L,57L,58L,60L,63L,64L,65L,68L,76L,90L,91L,92L,94L,97L,102L,104L,105L,110L,123L,145L,146L,147L,149L,152L,157L,165L,168L,169L,170L,178L,199L };
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
public class A254122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254122Inst : IEnumerable<long>
{
public static readonly long[] Value=A254122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254122.Bytes);
public long this[int i]=>Value[i];

public static A254122Inst Instance=new A254122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254123
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,3L,1L,2L,2L,2L,3L,2L,3L,3L,1L,2L,2L,2L,2L,2L,3L,3L,2L,3L,3L,3L,3L,1L,2L,2L,2L,3L,2L,2L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,4L,3L,3L,3L,1L,2L,2L,2L,3L,2L,3L,3L,2L,2L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,4L,4L,3L,3L,3L,3L,3L,1L,2L,2L,2L };
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
public class A254123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254123Inst : IEnumerable<long>
{
public static readonly long[] Value=A254123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254123.Bytes);
public long this[int i]=>Value[i];

public static A254123Inst Instance=new A254123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254124
{
public static readonly ulong[] Value={ 1L,4L,29L,257L,2408L,22873L,217969L,2078716L,19827701L,189133073L,1804125632L,17209452337L,164160078241L,1565914710964L,14937181915469L,142485030313697L,1359157571347928L,12964936038223753L,123671875897903249L,1179699833714208556L,11253097663211943461UL };
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
public class A254124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254124Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A254124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254124.Bytes);
public ulong this[int i]=>Value[i];

public static A254124Inst Instance=new A254124Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254125
{
public static readonly BigInteger[] Value={ 1L,8L,124L,2408L,50128L,1064576L,22734496L,486248000L,10404289216L,222647030144L,4764694602112L,101966374503680L,2182126445631232L,46698521255409152L,999370260391863808L,BigInteger.Parse("21386993399983588352"),BigInteger.Parse("457691719382960757760"),BigInteger.Parse("9794818132582234683392") };
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
public class A254125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254125Inst Instance=new A254125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254126
{
public static readonly BigInteger[] Value={ 1L,16L,533L,22873L,1064576L,50796983L,2441987149L,117656540512L,5672528575545L,273541357254277L,13191518965300160L,636171495829068099L,BigInteger.Parse("30680036092304563369"),BigInteger.Parse("1479579136691648516016"),BigInteger.Parse("71354395560692698401005"),BigInteger.Parse("3441147782121276015384833"),BigInteger.Parse("165953315828852845775456128") };
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
public class A254126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254126Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254126.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254126Inst Instance=new A254126Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254127
{
public static readonly BigInteger[] Value={ 1L,1L,7L,257L,50128L,50796983L,264719566561L,7063448084710944L,BigInteger.Parse("963204439792722969647"),BigInteger.Parse("670733745303300958404439297"),BigInteger.Parse("2384351527902618144856749327661056"),BigInteger.Parse("43263422878945294225852497665519673400479"),BigInteger.Parse("4006622856873663241294794301627790673728956619649") };
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
public class A254127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254127Inst Instance=new A254127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254128
{
public static readonly long[] Value={ 0L,0L,0L,4L,8L,20L,40L,88L,176L,364L,728L,1480L,2960L,5960L,11920L,23920L,47840L,95828L,191656L,383608L,767216L,1535000L,3070000L,6141136L,12282272L,24566776L,49133552L,98271568L,196543136L,393095120L,786190240L,1572398176L,3144796352L,6289627948L,12579255896L };
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
public class A254128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254128Inst : IEnumerable<long>
{
public static readonly long[] Value=A254128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254128.Bytes);
public long this[int i]=>Value[i];

public static A254128Inst Instance=new A254128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254129
{
public static readonly BigInteger[] Value={ 1L,8L,168L,5840L,261800L,13180608L,702273264L,38641656768L,2171652448680L,123938999632448L,7158206751686848L,417418594698260064L,BigInteger.Parse("24535017440445455216"),BigInteger.Parse("1451786144317963971200"),BigInteger.Parse("86396682439552099487040"),BigInteger.Parse("5166936574734171792925440"),BigInteger.Parse("310340697572034456203934120") };
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
public class A254129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254129Inst Instance=new A254129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254130
{
public static readonly long[] Value={ 0L,3L,5L,6L,7L,8L,9L,13L,16L };
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
public class A254130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254130Inst : IEnumerable<long>
{
public static readonly long[] Value=A254130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254130.Bytes);
public long this[int i]=>Value[i];

public static A254130Inst Instance=new A254130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254131
{
public static readonly long[] Value={ 0L,1L,-1L,2L,2L,-2L,41L,13L,3L,-3L,30L,90L,24L,4L,-4L,501L,209L,139L,35L,5L,-5L,322L,1102L,388L,188L,46L,6L,-6L,5041L,2253L,1703L,567L,237L,57L,7L,-7L,3110L,11090L,4184L,2304L,746L,286L,68L,8L,-8L,47501L,21769L,17139L,6115L,2905L,925L,335L,79L,9L,-9L };
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
public class A254131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254131Inst : IEnumerable<long>
{
public static readonly long[] Value=A254131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254131.Bytes);
public long this[int i]=>Value[i];

public static A254131Inst Instance=new A254131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254132
{
public static readonly BigInteger[] Value={ 1L,2L,5L,17L,107L,1943L,209951L,408146687L,85691213438975L,BigInteger.Parse("34974584955819144511487"),BigInteger.Parse("2997014624388697307377363936018956287"),BigInteger.Parse("104819342594514896999066634490728502944926883876041385836543") };
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
public class A254132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254132Inst Instance=new A254132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254133
{
public static readonly long[] Value={ 4L,9L,0L,7L,7L,2L,7L,2L,8L,9L,5L,8L,3L,4L,5L,1L,5L,9L,1L,6L,2L,7L,1L,7L,2L,5L,3L,2L,0L,3L,3L,8L,2L,6L,4L,0L,3L,8L,1L,9L,2L,3L,3L,4L,7L,7L,5L,8L,5L,8L,4L,6L,5L,6L,2L,4L,2L,6L,2L,6L,0L,1L,2L,0L,7L,8L,1L,3L,6L,3L,4L,1L,5L,5L,4L,8L,7L,8L,6L,9L,9L,9L,7L,1L,2L,5L,7L,2L,1L,8L,0L,3L,5L,7L,8L,9L,5L,5L,2L,3L,3L,4L,2L };
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
public class A254133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254133Inst : IEnumerable<long>
{
public static readonly long[] Value=A254133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254133.Bytes);
public long this[int i]=>Value[i];

public static A254133Inst Instance=new A254133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254134
{
public static readonly long[] Value={ 1L,6L,6L,1L,9L,0L,7L,8L,7L,4L,7L,3L,8L,1L,2L,3L,3L,7L,7L,4L,0L,6L,5L,8L,1L,6L,8L,6L,1L,6L,3L,0L,5L,9L,4L,9L,7L,3L,4L,8L,8L,6L,8L,6L,7L,3L,2L,5L,1L,2L,5L,8L,9L,1L,8L,3L,4L,1L,5L,0L,8L,1L,9L,4L,3L,4L,2L,3L,5L,4L,9L,3L,1L,0L,9L,3L,0L,4L,5L,2L,0L,6L,6L,9L,3L,8L,4L,8L,3L,8L,0L,5L,6L,8L,7L,2L,3L,4L,5L,1L,0L,3L,8L };
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
public class A254134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254134Inst : IEnumerable<long>
{
public static readonly long[] Value=A254134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254134.Bytes);
public long this[int i]=>Value[i];

public static A254134Inst Instance=new A254134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254135
{
public static readonly long[] Value={ 6L,9L,2L,6L,6L,0L,8L,1L,5L,1L,5L,2L,6L,4L,7L,5L,0L,6L,5L,0L,9L,4L,3L,1L,1L,8L,5L,8L,8L,4L,2L,7L,2L,4L,5L,8L,4L,6L,7L,1L,3L,4L,8L,3L,2L,8L,0L,7L,6L,6L,8L,8L,4L,2L,5L,8L,0L,7L,2L,0L,4L,5L,6L,9L,7L,1L,4L,9L,0L,6L,3L,0L,2L,1L,6L,3L,0L,0L,7L,0L,5L,2L,1L,4L,3L,3L,9L,1L,1L,7L,7L,2L,8L,2L,0L,4L,4L,2L,8L,6L,8L,3L,9L };
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
public class A254135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254135Inst : IEnumerable<long>
{
public static readonly long[] Value=A254135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254135.Bytes);
public long this[int i]=>Value[i];

public static A254135Inst Instance=new A254135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254136
{
public static readonly BigInteger[] Value={ 1L,73L,889L,84049L,1025713L,96992281L,1183671721L,111929008033L,1365956140129L,129165978277609L,1576312202036953L,149057427003352561L,1819062915194503441L,BigInteger.Parse("172012141595890577593"),BigInteger.Parse("2099197027822254933769"),BigInteger.Parse("198501862344230723189569"),BigInteger.Parse("2422471551043966999065793") };
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
public class A254136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254136Inst Instance=new A254136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254137
{
public static readonly BigInteger[] Value={ 1L,52L,629L,59432L,725289L,68583900L,836982301L,79145760592L,965876849489L,91334139138692L,1114621047327429L,105399517420289400L,1286271722739003001L,BigInteger.Parse("121630951768874828332"),BigInteger.Parse("1484356453419762135149"),BigInteger.Parse("140362012941764131605152"),BigInteger.Parse("1712946060974682764958369") };
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
public class A254137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254137Inst Instance=new A254137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254138
{
public static readonly BigInteger[] Value={ 1L,7957L,1185037L,10596309577L,1578130224697L,14111253811878301L,2101618114050816901L,BigInteger.Parse("18792154258821103289617"),BigInteger.Parse("2798754265133491448134897"),BigInteger.Parse("25025774916617575492416996517"),BigInteger.Parse("3727140237435880812247465267837"),BigInteger.Parse("33327174817289665775049786996211801") };
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
public class A254138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254138Inst Instance=new A254138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254139
{
public static readonly long[] Value={ 9L,28L,15L,66L,49L,232L,45L,190L,121L,276L,169L,1106L };
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
public class A254139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254139Inst : IEnumerable<long>
{
public static readonly long[] Value=A254139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254139.Bytes);
public long this[int i]=>Value[i];

public static A254139Inst Instance=new A254139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254140
{
public static readonly long[] Value={ 2L,9L,7L,3L,2L,0L,9L,5L,9L,8L,2L,4L,7L,3L,7L,8L,7L,0L,2L,5L,2L,8L,1L,8L,5L,6L,6L,7L,6L,3L,9L,5L,7L,1L,7L,9L,8L,0L,1L,9L,7L,4L,5L,4L,7L,9L,2L,1L,0L,6L,1L,0L,8L,7L,8L,7L,7L,7L,6L,0L,9L,4L,5L,0L,6L,2L,5L,8L,6L,5L,4L,3L,2L,2L,7L,1L,9L,6L,1L,6L,3L,2L,8L,6L,7L,6L,4L,4L,1L,8L,8L,5L,3L,7L,5L,0L,2L,0L,7L,4L,4L,4L,6L,9L,4L };
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
public class A254140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254140Inst : IEnumerable<long>
{
public static readonly long[] Value=A254140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254140.Bytes);
public long this[int i]=>Value[i];

public static A254140Inst Instance=new A254140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254141
{
public static readonly long[] Value={ 8L,16L,21L,28L,32L,40L,52L,55L,56L,64L,65L,68L,69L,80L,84L,85L,87L,88L,92L,93L,99L,104L,105L,112L,117L,119L,128L,132L,133L,136L,140L,141L,145L,148L,152L,153L,155L,156L,160L,161L,164L,165L,171L,172L,176L,184L,187L,188L,196L,200L,203L,204L,205L,207L,208L,209L,212L };
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
public class A254141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254141Inst : IEnumerable<long>
{
public static readonly long[] Value=A254141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254141.Bytes);
public long this[int i]=>Value[i];

public static A254141Inst Instance=new A254141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254142
{
public static readonly long[] Value={ 1L,19L,154L,814L,3289L,11011L,32032L,83512L,199342L,442442L,923780L,1830764L,3468374L,6317234L,11113784L,18958808L,31461815L,50930165L,80613390L,125014890L,190285095L,284712285L,419329560L,608658960L,871616460L,1232604516L,1722822024L,2381824984L };
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
public class A254142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254142Inst : IEnumerable<long>
{
public static readonly long[] Value=A254142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254142.Bytes);
public long this[int i]=>Value[i];

public static A254142Inst Instance=new A254142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254143
{
public static readonly long[] Value={ 1L,4L,7L,16L,28L,34L,37L,49L,67L,136L,148L,238L,259L,268L,334L,337L,367L,469L,667L,1156L,1258L,1336L,1348L,1369L,1468L,2278L,2338L,2359L,2479L,2569L,2668L,3334L,3337L,3367L,3667L,4489L,4669L,6667L,11356L,11458L,12358L,12469L,12478L,13336L,13348L,13468L,13579L };
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
public class A254143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254143Inst : IEnumerable<long>
{
public static readonly long[] Value=A254143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254143.Bytes);
public long this[int i]=>Value[i];

public static A254143Inst Instance=new A254143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254144
{
public static readonly long[] Value={ 21L,56L,196L,812L,3724L,18236L,93436L,494732L,2685004L,14851676L,83384476L,473755052L,2717541484L,15709845116L,91395715516L,534498925772L,3139343105164L,18504595174556L,109397060622556L,648335998054892L,3850205790608044L };
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
public class A254144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254144Inst : IEnumerable<long>
{
public static readonly long[] Value=A254144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254144.Bytes);
public long this[int i]=>Value[i];

public static A254144Inst Instance=new A254144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254145
{
public static readonly long[] Value={ 28L,84L,336L,1596L,8400L,47244L,278256L,1695036L,10592400L,67518444L,437200176L,2867080476L,18997064400L,126948964044L,854359702896L,5783851121916L,39350309552400L,268842017200044L,1843254419626416L,12675940450459356L };
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
public class A254145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254145Inst : IEnumerable<long>
{
public static readonly long[] Value=A254145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254145.Bytes);
public long this[int i]=>Value[i];

public static A254145Inst Instance=new A254145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254146
{
public static readonly long[] Value={ 36L,120L,540L,2892L,17172L,109020L,725220L,4992492L,35277012L,254402940L,1864757700L,13850340492L,103996064052L,787943896860L,6015370201380L,46217575406892L,357036252710292L,2770979252910780L,21591510288112260L,168818732978719692L,1323861500735007732L };
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
public class A254146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254146Inst : IEnumerable<long>
{
public static readonly long[] Value=A254146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254146.Bytes);
public long this[int i]=>Value[i];

public static A254146Inst Instance=new A254146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254147
{
public static readonly long[] Value={ 45L,165L,825L,4917L,32505L,229845L,1703625L,13072917L,103008345L,828707925L,6779099625L,56214660117L,471424600185L,3990804658005L,34053173154825L,292542431786517L,2527742384720025L,21950298188288085L,191434401453597225L,1675813243179972117L };
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
public class A254147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254147Inst : IEnumerable<long>
{
public static readonly long[] Value=A254147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254147.Bytes);
public long this[int i]=>Value[i];

public static A254147Inst Instance=new A254147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254148
{
public static readonly long[] Value={ 55L,220L,1210L,7942L,57838L,450670L,3682030L,31153342L,270739678L,2403012910L,21693441550L,198578979742L,1838853136318L,17193665419150L,162090976108270L,1538867288166142L,14698448516729758L,141129617123665390L,1361277292619082190L };
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
public class A254148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254148Inst : IEnumerable<long>
{
public static readonly long[] Value=A254148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254148.Bytes);
public long this[int i]=>Value[i];

public static A254148Inst Instance=new A254148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254149
{
public static readonly long[] Value={ 1L,4L,8L,1L,4L,3L,2L,6L,3L,6L,5L,2L,1L,0L,6L,4L,7L,4L,9L,7L,4L,8L,7L,6L,9L,1L,4L,0L,7L,2L,7L,6L,5L,8L,3L,0L,2L,5L,7L,0L,9L,5L,2L,6L,3L,4L,1L,5L,4L,8L,6L,1L,0L,4L,8L,8L,7L,7L,5L,3L,7L,8L,9L,6L,7L,1L,6L,8L,2L,3L,9L,9L,1L,0L,3L,5L,0L,7L,1L,2L,8L,8L,9L,1L,6L,3L,6L,9L,5L,7L,7L,9L,8L,6L,9L,0L,5L,5L,2L,9L,1L,8L,5L };
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
public class A254149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254149Inst : IEnumerable<long>
{
public static readonly long[] Value=A254149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254149.Bytes);
public long this[int i]=>Value[i];

public static A254149Inst Instance=new A254149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254150
{
public static readonly long[] Value={ 1L,8L,73L,689L,6556L,62501L,596113L,5686112L,54239137L,517383521L,4935293524L,47077513469L };
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
public class A254150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254150Inst : IEnumerable<long>
{
public static readonly long[] Value=A254150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254150.Bytes);
public long this[int i]=>Value[i];

public static A254150Inst Instance=new A254150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254151
{
public static readonly long[] Value={ 1L,16L,314L,6556L,139344L,2976416L,63663808L,1362242592L,29151501760L,623849225024L,13350628082560L,285709494797952L };
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
public class A254151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254151Inst : IEnumerable<long>
{
public static readonly long[] Value=A254151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254151.Bytes);
public long this[int i]=>Value[i];

public static A254151Inst Instance=new A254151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254152
{
public static readonly long[] Value={ 1L,32L,1351L,62501L,2976416L,142999897L,6888568813L,332097693792L,16014193762579L,772279980131297L,37243762479698920L,1796118644459454976L };
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
public class A254152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254152Inst : IEnumerable<long>
{
public static readonly long[] Value=A254152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254152.Bytes);
public long this[int i]=>Value[i];

public static A254152Inst Instance=new A254152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254153
{
public static readonly long[] Value={ 6L,6L,4L,4L,6L,5L };
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
public class A254153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254153Inst : IEnumerable<long>
{
public static readonly long[] Value=A254153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254153.Bytes);
public long this[int i]=>Value[i];

public static A254153Inst Instance=new A254153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254154
{
public static readonly long[] Value={ 5L,9L,7L,1L,9L,1L,9L };
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
public class A254154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254154Inst : IEnumerable<long>
{
public static readonly long[] Value=A254154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254154.Bytes);
public long this[int i]=>Value[i];

public static A254154Inst Instance=new A254154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254155
{
public static readonly long[] Value={ 3L,7L,2L,7L,3L,7L,9L };
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
public class A254155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254155Inst : IEnumerable<long>
{
public static readonly long[] Value=A254155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254155.Bytes);
public long this[int i]=>Value[i];

public static A254155Inst Instance=new A254155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254156
{
public static readonly long[] Value={ 4L,0L,0L,1L,5L,0L,6L,1L,7L,9L };
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
public class A254156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254156Inst : IEnumerable<long>
{
public static readonly long[] Value=A254156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254156.Bytes);
public long this[int i]=>Value[i];

public static A254156Inst Instance=new A254156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254157
{
public static readonly BigInteger[] Value={ 1L,3L,225L,592704L,60037250625L,244217432431215243L,BigInteger.Parse("40928832685064366701940736"),BigInteger.Parse("287432029715751041166252933120000000"),BigInteger.Parse("85609985515193235253656684862285741981771256961"),BigInteger.Parse("1091210761769150876962680951989752349788052377750396728515625") };
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
public class A254157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254157Inst Instance=new A254157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254158
{
public static readonly long[] Value={ 3L,9L,7L,2L,5L,9L,9L,6L,8L };
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
public class A254158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254158Inst : IEnumerable<long>
{
public static readonly long[] Value=A254158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254158.Bytes);
public long this[int i]=>Value[i];

public static A254158Inst Instance=new A254158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254159
{
public static readonly long[] Value={ 1L,4L,9L,2L,4L,1L };
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
public class A254159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254159Inst : IEnumerable<long>
{
public static readonly long[] Value=A254159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254159.Bytes);
public long this[int i]=>Value[i];

public static A254159Inst Instance=new A254159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254160
{
public static readonly BigInteger[] Value={ 512L,23660L,1553720L,191190272L,47722312832L,24789263869340L,27196332026497280L,BigInteger.Parse("62670987439073417464"),BigInteger.Parse("306649596390478314360688"),BigInteger.Parse("3185451673330281289722851308"),BigInteger.Parse("70105876620029167895782015020688") };
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
public class A254160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254160Inst Instance=new A254160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254161
{
public static readonly long[] Value={ 512L,3036L,16240L,76832L,348032L,1511152L,6440848L,27128324L,113712184L,475820928L,1990141264L,8325715216L,34837433912L,145798977252L,610246788472L,2554332033248L,10691962218368L,44754714079088L,187335498849168L };
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
public class A254161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254161Inst : IEnumerable<long>
{
public static readonly long[] Value=A254161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254161.Bytes);
public long this[int i]=>Value[i];

public static A254161Inst Instance=new A254161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254162
{
public static readonly long[] Value={ 3036L,23660L,164684L,1014816L,6159516L,36538548L,217539476L,1297596948L,7773465716L,46667868056L,280531517204L,1687013713288L,10146685732748L,61029056245012L,367072960100780L,2207831773493064L,13279454483043468L };
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
public class A254162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254162Inst : IEnumerable<long>
{
public static readonly long[] Value=A254162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254162.Bytes);
public long this[int i]=>Value[i];

public static A254162Inst Instance=new A254162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254163
{
public static readonly long[] Value={ 16240L,164408L,1553720L,13514192L,119471400L,1054310240L,9378850720L,83642043104L,747838723984L,6692350328688L,59911130123536L,536370198043600L,4802059524173712L,42992172686208464L,384902922582518096L };
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
public class A254163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254163Inst : IEnumerable<long>
{
public static readonly long[] Value=A254163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254163.Bytes);
public long this[int i]=>Value[i];

public static A254163Inst Instance=new A254163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254164
{
public static readonly BigInteger[] Value={ 76832L,1078032L,15016048L,191190272L,2437141776L,31143715804L,399587109728L,5135066242396L,66055387860800L,850097997207468L,10942233760318624L,140853914363177740L,1813183596341937088L,BigInteger.Parse("23340859396990897980") };
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
public class A254164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254164Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254164.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254164Inst Instance=new A254164Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254165
{
public static readonly BigInteger[] Value={ 348032L,6831024L,139009432L,2589374656L,47722312832L,886761490936L,16524431408400L,307997125181376L,5746900683155904L,107280164731745488L,2002796615748790976L,BigInteger.Parse("37391100588451055760"),BigInteger.Parse("698081587720476379072") };
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
public class A254165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254165Inst Instance=new A254165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254166
{
public static readonly BigInteger[] Value={ 1511152L,41678024L,1263003480L,34167243308L,910592737776L,24789263869340L,676750215074144L,18480715303252452L,505390499990828432L,13826872992791323340UL,BigInteger.Parse("378264415847818916192"),BigInteger.Parse("10348392913354433560800") };
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
public class A254166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254166Inst Instance=new A254166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254167
{
public static readonly BigInteger[] Value={ 6440848L,251430924L,11377995944L,443654425392L,17154177879840L,684072377169008L,27196332026497280L,1080962116495110480L,BigInteger.Parse("43035049375564396528"),BigInteger.Parse("1714089719759716209888"),BigInteger.Parse("68251517989933263549920") };
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
public class A254167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254167Inst Instance=new A254167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254168
{
public static readonly long[] Value={ 512L,3036L,3036L,16240L,23660L,16240L,76832L,164408L,164684L,76832L,348032L,1078032L,1553720L,1014816L,348032L,1511152L,6831024L,15016048L,13514192L,6159516L,1511152L,6440848L,41678024L,139009432L,191190272L,119471400L,36538548L };
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
public class A254168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254168Inst : IEnumerable<long>
{
public static readonly long[] Value=A254168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254168.Bytes);
public long this[int i]=>Value[i];

public static A254168Inst Instance=new A254168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254169
{
public static readonly long[] Value={ 3036L,23660L,164408L,1078032L,6831024L,41678024L,251430924L,1509107876L,9050890564L,54337026684L,326446356700L,1962472283332L,11801023646284L,70973760221804L,426874983655444L,2567503678416152L,15442742976914288L };
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
public class A254169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254169Inst : IEnumerable<long>
{
public static readonly long[] Value=A254169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254169.Bytes);
public long this[int i]=>Value[i];

public static A254169Inst Instance=new A254169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254170
{
public static readonly long[] Value={ 16240L,164684L,1553720L,15016048L,139009432L,1263003480L,11377995944L,101942555352L,912087664152L,8157975853920L,72998908371792L,653365654458064L,5848836175265568L,52361520959776576L,468779045407612304L };
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
public class A254170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254170Inst : IEnumerable<long>
{
public static readonly long[] Value=A254170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254170.Bytes);
public long this[int i]=>Value[i];

public static A254170Inst Instance=new A254170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254171
{
public static readonly BigInteger[] Value={ 76832L,1014816L,13514192L,191190272L,2589374656L,34167243308L,443654425392L,5720473079212L,73617021646416L,947269263443756L,12190444367623280L,156900818355391996L,2019616532033996096L,BigInteger.Parse("25997546502044733452") };
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
public class A254171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254171Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254171.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254171Inst Instance=new A254171Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254172
{
public static readonly BigInteger[] Value={ 348032L,6159516L,119471400L,2437141776L,47722312832L,910592737776L,17154177879840L,320795556150368L,5990669265231248L,111829906812254944L,2087633151218299392L,BigInteger.Parse("38972776946929655072"),BigInteger.Parse("727593935236788680400") };
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
public class A254172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254172Inst Instance=new A254172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254173
{
public static readonly BigInteger[] Value={ 1511152L,36538548L,1054310240L,31143715804L,886761490936L,24789263869340L,684072377169008L,18738106424812380L,512823923719769272L,14030281670008005564UL,BigInteger.Parse("383831267774223029112"),BigInteger.Parse("10500422875690342522680") };
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
public class A254173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254173Inst Instance=new A254173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254174
{
public static readonly BigInteger[] Value={ 6440848L,217539476L,9378850720L,399587109728L,16524431408400L,676750215074144L,27196332026497280L,1084445796373438616L,BigInteger.Parse("43207926374198188784"),BigInteger.Parse("1720925651447157696832"),BigInteger.Parse("68523513350608477133408") };
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
public class A254174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A254174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A254174Inst Instance=new A254174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254175
{
public static readonly long[] Value={ 3L,4L,2L,3L,1L,7L,7L,6L,8L };
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
public class A254175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254175Inst : IEnumerable<long>
{
public static readonly long[] Value=A254175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254175.Bytes);
public long this[int i]=>Value[i];

public static A254175Inst Instance=new A254175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254176
{
public static readonly long[] Value={ 2L,2L,5L,2L,3L,4L,2L,7L,1L };
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
public class A254176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254176Inst : IEnumerable<long>
{
public static readonly long[] Value=A254176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254176.Bytes);
public long this[int i]=>Value[i];

public static A254176Inst Instance=new A254176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254177
{
public static readonly long[] Value={ 7L,5L,1L,3L,0L,0L,6L };
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
public class A254177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254177Inst : IEnumerable<long>
{
public static readonly long[] Value=A254177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254177.Bytes);
public long this[int i]=>Value[i];

public static A254177Inst Instance=new A254177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254178
{
public static readonly long[] Value={ 1L,0L,8L,0L,9L,5L };
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
public class A254178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254178Inst : IEnumerable<long>
{
public static readonly long[] Value=A254178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254178.Bytes);
public long this[int i]=>Value[i];

public static A254178Inst Instance=new A254178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254179
{
public static readonly long[] Value={ 2L,4L,1L,8L,8L,8L,4L,3L,2L,6L };
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
public class A254179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254179Inst : IEnumerable<long>
{
public static readonly long[] Value=A254179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254179.Bytes);
public long this[int i]=>Value[i];

public static A254179Inst Instance=new A254179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254180
{
public static readonly long[] Value={ 2L,1L,8L,7L,6L,9L,1L,2L,6L };
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
public class A254180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254180Inst : IEnumerable<long>
{
public static readonly long[] Value=A254180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254180.Bytes);
public long this[int i]=>Value[i];

public static A254180Inst Instance=new A254180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A254181
{
public static readonly long[] Value={ 1L,0L,5L,4L,5L,7L,1L };
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
public class A254181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A254181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A254181Inst : IEnumerable<long>
{
public static readonly long[] Value=A254181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A254181.Bytes);
public long this[int i]=>Value[i];

public static A254181Inst Instance=new A254181Inst();

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