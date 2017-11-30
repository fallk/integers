using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A279142
{
public static readonly BigInteger[] Value={ 1L,0L,101L,0L,10101L,0L,1010101L,0L,101110101L,10100000L,10000010101L,1110000000L,1010101110101L,10100000L,101010000010101L,1110000000L,10101010101110101L,10100000L,1010101110000010101L,10101110000000L,BigInteger.Parse("101010000010101110101"),1110000010100000L };
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
public class A279142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279142Inst Instance=new A279142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279143
{
public static readonly long[] Value={ 1L,0L,5L,0L,21L,0L,85L,0L,349L,20L,1345L,28L,5589L,320L,21525L,448L,89429L,5120L,344533L,7488L,1430549L,82368L,5510485L,114688L,22894037L,1311040L,88200213L,1917376L,366220629L,21086208L,1410684373L,29360448L,5860873237L,335626688L,22579254613L,490848256L };
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
public class A279143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279143Inst : IEnumerable<long>
{
public static readonly long[] Value=A279143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279143.Bytes);
public long this[int i]=>Value[i];

public static A279143Inst Instance=new A279143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279144
{
public static readonly long[] Value={ 1L,0L,5L,0L,21L,0L,85L,0L,373L,160L,1045L,896L,5493L,160L,21525L,896L,87413L,160L,351253L,11136L,1377653L,57504L,5592085L,896L,22500725L,655520L,88169493L,3681152L,357893493L,57504L,1440044053L,41943936L,5642868085L,235536544L,22905183253L,3681152L };
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
public class A279144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279144Inst : IEnumerable<long>
{
public static readonly long[] Value=A279144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279144.Bytes);
public long this[int i]=>Value[i];

public static A279144Inst Instance=new A279144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279145
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1100L,111L,111100L,111L,11111100L,111L,1111110100L,10011L,111111000110L,1111110L,11111111000010L,1100100L,1111111111100011L,110010L,111111111111110000L,10011L,11111111111111100010UL,111000L,BigInteger.Parse("1111111111111111101111"),101000L,BigInteger.Parse("111111111111111101000111") };
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
public class A279145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279145Inst Instance=new A279145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279146
{
public static readonly long[] Value={ 1L,1L,10L,11L,11100L,1111L,1110000L,111111L,111000000L,10111111L,11001000000L,11000111111L,111111000000L,1000011111111L,1001100000000L,1100011111111111L,1001100000000000L,11111111111111L,1100100000000000000L,1000111111111111111L,111000000000000000L };
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
public class A279146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279146Inst : IEnumerable<long>
{
public static readonly long[] Value=A279146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279146.Bytes);
public long this[int i]=>Value[i];

public static A279146Inst Instance=new A279146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279147
{
public static readonly long[] Value={ 1L,2L,2L,12L,7L,60L,7L,252L,7L,1012L,19L,4038L,126L,16322L,100L,65507L,50L,262128L,19L,1048546L,56L,4194287L,40L,16777031L,284L,67108471L,980L,268428867L,10042L,1073710568L,57635L,4294948430L,47002L,17179817208L,127887L,68719416056L,106639L,274877748008L };
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
public class A279147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279147Inst : IEnumerable<long>
{
public static readonly long[] Value=A279147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279147.Bytes);
public long this[int i]=>Value[i];

public static A279147Inst Instance=new A279147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279148
{
public static readonly long[] Value={ 1L,1L,2L,3L,28L,15L,112L,63L,448L,191L,1600L,1599L,4032L,4351L,4864L,51199L,38912L,16383L,409600L,294911L,229376L,4063231L,655360L,14876671L,7405568L,62521343L,22937600L,203849727L,194805760L,99123199L,1648590848L,1919811583L,3017408512L,2092171263L };
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
public class A279148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279148Inst : IEnumerable<long>
{
public static readonly long[] Value=A279148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279148.Bytes);
public long this[int i]=>Value[i];

public static A279148Inst Instance=new A279148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279149
{
public static readonly BigInteger[] Value={ 1L,0L,101L,10L,10000L,111L,1010100L,101001L,100000000L,1111111L,10101000000L,1010011111L,1000000010000L,11111000111L,101010001010100L,10100100101001L,10000000000000000L,111111111111111L,1010100000000000000L,101001111111111111L,BigInteger.Parse("100000001000000000000") };
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
public class A279149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279149Inst Instance=new A279149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279150
{
public static readonly long[] Value={ 1L,0L,5L,2L,16L,7L,84L,41L,256L,127L,1344L,671L,4112L,1991L,21588L,10537L,65536L,32767L,344064L,172031L,1052672L,509951L,5526528L,2697727L,16777472L,8387711L,88081728L,44036767L,269488144L,130533319L,1414812756L,690563369L,4294967296L,2147483647L,22548578304L };
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
public class A279150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279150Inst : IEnumerable<long>
{
public static readonly long[] Value=A279150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279150.Bytes);
public long this[int i]=>Value[i];

public static A279150Inst Instance=new A279150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279151
{
public static readonly long[] Value={ 1L,0L,5L,4L,1L,56L,21L,148L,1L,1016L,21L,3988L,257L,14584L,5397L,38036L,1L,262136L,21L,1048468L,257L,4192504L,5397L,16749716L,65537L,66650104L,1376277L,261422996L,16843009L,955840760L,353703189L,2492765332L,1L,17179869176L,21L,68719476628L,257L,274877905144L };
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
public class A279151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279151Inst : IEnumerable<long>
{
public static readonly long[] Value=A279151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279151.Bytes);
public long this[int i]=>Value[i];

public static A279151Inst Instance=new A279151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279152
{
public static readonly long[] Value={ 0L,0L,4L,12L,30L,72L,162L,356L,766L,1616L,3378L,7004L,14406L,29480L,60090L,122036L,247150L,499456L,1007458L,2029068L,4081686L,8202456L,16469642L,33046628L,66271166L,132836784L,266160818L,533127612L,1067587174L,2137374088L,4278378970L };
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
public class A279152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279152Inst : IEnumerable<long>
{
public static readonly long[] Value=A279152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279152.Bytes);
public long this[int i]=>Value[i];

public static A279152Inst Instance=new A279152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279153
{
public static readonly long[] Value={ 2L,4L,20L,72L,255L,874L,2903L,9336L,29578L,92528L,285992L,875912L,2662819L,8042606L,24156735L,72211820L,214959872L,637526372L,1884571600L,5554575752L,16328272725L,47884030342L,140118979793L,409205295972L,1192876666588L,3471548282192L };
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
public class A279153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279153Inst : IEnumerable<long>
{
public static readonly long[] Value=A279153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279153.Bytes);
public long this[int i]=>Value[i];

public static A279153Inst Instance=new A279153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279154
{
public static readonly long[] Value={ 2L,12L,72L,428L,2294L,11932L,60304L,297092L,1443498L,6930508L,32917852L,155025096L,724982468L,3370079700L,15584464186L,71742003424L,328950577598L,1503015006696L,6845967619642L,31094637435220L,140875688981220L,636779907204164L };
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
public class A279154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279154Inst : IEnumerable<long>
{
public static readonly long[] Value=A279154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279154.Bytes);
public long this[int i]=>Value[i];

public static A279154Inst Instance=new A279154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279155
{
public static readonly long[] Value={ 5L,30L,255L,2294L,20104L,166552L,1331471L,10508084L,81594334L,624717186L,4739157622L,35661603332L,266406928267L,1978392492492L,14617489508922L,107516403089962L,787701900591720L,5750928990829306L,41856485102494388L };
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
public class A279155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279155Inst : IEnumerable<long>
{
public static readonly long[] Value=A279155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279155.Bytes);
public long this[int i]=>Value[i];

public static A279155Inst Instance=new A279155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279172
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-3L,3L,17L,-17L,-155L,155L,2073L,-2073L,-38227L,38227L,929569L,-929569L,-28820619L,28820619L,1109652905L,-1109652905L,-51943281731L,51943281731L,2905151042481L,-2905151042481L,-191329672483963L,191329672483963L,14655626154768697L,-14655626154768697L };
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
public class A279172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279172Inst : IEnumerable<long>
{
public static readonly long[] Value=A279172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279172.Bytes);
public long this[int i]=>Value[i];

public static A279172Inst Instance=new A279172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279173
{
public static readonly long[] Value={ 1L,1L,101L,111L,10000L,10111L,1010100L,1111101L,100000001L,101111101L,10101000101L,11111010111L,1000000010000L,1011111010111L,101010001000100L,111110101010101L,10000000100000001L,10111110101111101L,1010100010001000101L,1111101010101010111L };
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
public class A279173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279173Inst : IEnumerable<long>
{
public static readonly long[] Value=A279173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279173.Bytes);
public long this[int i]=>Value[i];

public static A279173Inst Instance=new A279173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279174
{
public static readonly ulong[] Value={ 1L,10L,101L,1110L,1L,111010L,10101L,10111110L,100000001L,1011111010L,10100010101L,111010111110L,100000001L,11101011111010L,1000100010101L,1010101010111110L,10000000100000001L,101111101011111010L,1010001000100010101L,11101010101010111110UL,100000001L };
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
public class A279174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279174Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279174.Bytes);
public ulong this[int i]=>Value[i];

public static A279174Inst Instance=new A279174Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279175
{
public static readonly long[] Value={ 1L,1L,5L,7L,16L,23L,84L,125L,257L,381L,1349L,2007L,4112L,6103L,21572L,32085L,65793L,97661L,345157L,513367L,1052672L,1562623L,5526528L,8224255L,16843008L,25001343L,88425536L,131585375L,269488128L,400021503L,1413760000L,2102744575L,4311810048L,6400344063L };
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
public class A279175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279175Inst : IEnumerable<long>
{
public static readonly long[] Value=A279175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279175.Bytes);
public long this[int i]=>Value[i];

public static A279175Inst Instance=new A279175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279176
{
public static readonly long[] Value={ 1L,2L,5L,14L,1L,58L,21L,190L,257L,762L,1301L,3774L,257L,15098L,4373L,43710L,65793L,195322L,332053L,961214L,257L,4193018L,5397L,16760510L,65793L,66779898L,1119509L,262848190L,65793L,1073412858L,1118485L,4289374910L,65793L,17179540218L,1380629L,68715195070L };
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
public class A279176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279176Inst : IEnumerable<long>
{
public static readonly long[] Value=A279176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279176.Bytes);
public long this[int i]=>Value[i];

public static A279176Inst Instance=new A279176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279177
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1100L,101L,111010L,1000L,11110011L,10110L,1111101000L,100011L,111111001000L,1010111L,11111110101100L,10001011L,1111111100110110L,101111100L,111111111010000011L,1000111010L,11111111110010001100UL,10101100101L,BigInteger.Parse("1111111111101011111010"),100010001100L };
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
public class A279177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279177Inst Instance=new A279177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279178
{
public static readonly BigInteger[] Value={ 1L,1L,10L,11L,10100L,10111L,1000L,11001111L,11010000L,1011111L,11000100000L,100111111L,1110101000000L,110101111111L,110100010000000L,110110011111111L,111110100000000L,110000010111111111L,101110001000000000L,110001001111111111L,BigInteger.Parse("101001101010000000000") };
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
public class A279178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279178Inst Instance=new A279178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279179
{
public static readonly long[] Value={ 1L,2L,2L,12L,5L,58L,8L,243L,22L,1000L,35L,4040L,87L,16300L,139L,65334L,380L,261763L,570L,1047692L,1381L,4193018L,2188L,16774007L,6104L,67102747L,9206L,268421132L,22507L,1073719298L,33784L,4294917135L,91632L,17179777823L,138720L,68719265327L,373640L };
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
public class A279179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279179Inst : IEnumerable<long>
{
public static readonly long[] Value=A279179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279179.Bytes);
public long this[int i]=>Value[i];

public static A279179Inst Instance=new A279179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279180
{
public static readonly long[] Value={ 1L,1L,2L,3L,20L,23L,8L,207L,208L,95L,1568L,319L,7488L,3455L,26752L,27903L,32000L,198143L,188928L,201727L,1364992L,1562623L,1607680L,15650815L,3657728L,56647679L,58597376L,50413567L,452804608L,268795903L,266371072L,4030529535L,525139968L,16700014591L };
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
public class A279180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279180Inst : IEnumerable<long>
{
public static readonly long[] Value=A279180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279180.Bytes);
public long this[int i]=>Value[i];

public static A279180Inst Instance=new A279180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279181
{
public static readonly BigInteger[] Value={ 1L,1L,11L,301L,15371L,1261501L,21692333L,2291003591L,5515342166891L,219856146354043L,533289474412481051L,BigInteger.Parse("224671379367784281901"),BigInteger.Parse("112978424972711121811"),BigInteger.Parse("3528028730755504686511279"),BigInteger.Parse("46211522130188693681603906171"),BigInteger.Parse("5237381988676259999443664085643") };
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
public class A279181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279181Inst Instance=new A279181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279182
{
public static readonly BigInteger[] Value={ 1L,1L,12L,360L,20160L,1814400L,34214400L,3962649600L,10461394944000L,457312407552000L,1216451004088320000L,BigInteger.Parse("562000363888803840000"),BigInteger.Parse("309914286580039680000"),BigInteger.Parse("10612933187542253568000000"),BigInteger.Parse("152444172305856930250752000000"),BigInteger.Parse("18946632843727932759736320000000") };
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
public class A279182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279182Inst Instance=new A279182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279183
{
public static readonly long[] Value={ 1L,2L,12L,152L,222L,362L,432L,992L,1517L,2532L,2567L,8472L,34732L,44092L,69312L,82752L,105852L,114392L,128672L,336992L,350082L,393132L,393552L,462747L,497712L,559872L,665817L,714502L,931432L,968952L,1126602L,1281867L,1389337L,1449992L,1638712L,1694292L };
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
public class A279183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279183Inst : IEnumerable<long>
{
public static readonly long[] Value=A279183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279183.Bytes);
public long this[int i]=>Value[i];

public static A279183Inst Instance=new A279183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279184
{
public static readonly long[] Value={ 268L,723L,9718L,9858L,13498L,15738L,35898L,60363L,75168L,75973L,87208L,88888L,98198L,126848L,135368L,141093L,161268L,221223L,233788L,301513L,328358L,330633L,419148L,507648L,527928L,543468L,551238L,556418L,586018L,725958L,772508L,964588L,985728L };
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
public class A279184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279184Inst : IEnumerable<long>
{
public static readonly long[] Value=A279184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279184.Bytes);
public long this[int i]=>Value[i];

public static A279184Inst Instance=new A279184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279185
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,4L,4L,4L,4L,4L,4L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L };
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
public class A279185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279185Inst : IEnumerable<long>
{
public static readonly long[] Value=A279185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279185.Bytes);
public long this[int i]=>Value[i];

public static A279185Inst Instance=new A279185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279186
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,2L,2L,1L,1L,1L,2L,6L,1L,2L,4L,10L,1L,4L,2L,6L,2L,3L,1L,4L,1L,4L,1L,2L,2L,6L,6L,2L,1L,4L,2L,6L,4L,2L,10L,11L,1L,6L,4L,1L,2L,12L,6L,4L,2L,6L,3L,28L,1L,4L,4L,2L,1L,2L,4L,10L,1L,10L,2L,12L,2L,6L,6L,4L,6L,4L,2L,12L,1L,18L,4L,20L,2L,1L,6L,3L,4L };
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
public class A279186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279186Inst : IEnumerable<long>
{
public static readonly long[] Value=A279186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279186.Bytes);
public long this[int i]=>Value[i];

public static A279186Inst Instance=new A279186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279187
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,4L,1L,4L,2L,6L,2L,1L,1L,4L,1L,2L,2L,6L,2L,1L,2L,4L,2L,10L,1L,6L,4L,1L,2L,6L,4L,2L,6L,3L,1L,4L,2L,1L,2L,4L,1L,10L,2L,2L,6L,4L,6L,4L,2L,1L,18L,4L,2L,1L,6L,3L,4L,2L,2L,10L,4L,11L,6L,1L,6L,4L,4L,1L,2L,2L,12L,6L,4L,6L,2L,6L,10L,3L,2L };
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
public class A279187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279187Inst : IEnumerable<long>
{
public static readonly long[] Value=A279187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279187.Bytes);
public long this[int i]=>Value[i];

public static A279187Inst Instance=new A279187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279204
{
public static readonly long[] Value={ 1234L,2345L,3456L,4567L,5678L,6789L,78910L,891011L,9101112L,10111213L,11121314L,12131415L,13141516L,14151617L,15161718L,16171819L,17181920L,18192021L,19202122L,20212223L,21222324L,22232425L,23242526L,24252627L,25262728L,26272829L,27282930L,28293031L,29303132L,30313233L,31323334L };
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
public class A279204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279204Inst : IEnumerable<long>
{
public static readonly long[] Value=A279204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279204.Bytes);
public long this[int i]=>Value[i];

public static A279204Inst Instance=new A279204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279205
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,3L,4L,1L,3L,2L,1L,6L,1L,2L,1L,4L,7L,5L,2L,3L,1L,4L,2L,1L,1L,5L,2L,1L,3L,1L,1L,3L,3L,3L,3L,8L,2L,1L,2L,2L,1L,3L,2L,2L,1L,1L,1L,1L,3L,2L,1L,1L,2L,1L,4L,1L,2L,4L,1L,2L,3L,1L,1L,1L,2L,1L,1L,5L,1L,1L,1L,5L,4L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,3L,2L,2L,1L,1L };
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
public class A279205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279205Inst : IEnumerable<long>
{
public static readonly long[] Value=A279205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279205.Bytes);
public long this[int i]=>Value[i];

public static A279205Inst Instance=new A279205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279206
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,4L,1L,1L,2L,5L,2L,2L,1L,1L,2L,4L,1L,3L,1L,4L,1L,1L,2L,2L,3L,4L,2L,1L,3L,1L,2L,3L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,3L,1L,1L,2L,8L,1L,1L,2L,3L,5L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,6L,1L,3L,2L,1L,1L,2L,6L,1L,1L,1L,2L,2L,2L,3L,6L,1L,1L,1L,1L,1L,1L };
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
public class A279206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279206Inst : IEnumerable<long>
{
public static readonly long[] Value=A279206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279206.Bytes);
public long this[int i]=>Value[i];

public static A279206Inst Instance=new A279206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279207
{
public static readonly long[] Value={ 1L,2L,5L,18L,102L,817L,7641L };
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
public class A279207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279207Inst : IEnumerable<long>
{
public static readonly long[] Value=A279207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279207.Bytes);
public long this[int i]=>Value[i];

public static A279207Inst Instance=new A279207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279208
{
public static readonly long[] Value={ 1L,2L,5L,17L,76L,499L,4132L };
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
public class A279208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279208Inst : IEnumerable<long>
{
public static readonly long[] Value=A279208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279208.Bytes);
public long this[int i]=>Value[i];

public static A279208Inst Instance=new A279208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279209
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,1L,0L,3L,2L,1L,1L,2L,1L,1L,0L,4L,3L,2L,2L,1L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,0L,5L,4L,3L,3L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,4L,3L,2L,2L,1L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,0L,6L,5L,4L,4L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A279209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279209Inst : IEnumerable<long>
{
public static readonly long[] Value=A279209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279209.Bytes);
public long this[int i]=>Value[i];

public static A279209Inst Instance=new A279209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279210
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,2L,0L,1L,0L,0L,0L,1L,1L,2L,1L,1L,2L,3L,0L,1L,1L,2L,0L,1L,0L,0L,0L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,2L,2L,3L,4L,0L,1L,1L,2L,1L,1L,2L,3L,0L,1L,1L,2L,0L,1L,0L,0L,0L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,2L,2L,3L,4L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,5L,0L,1L,1L,2L,1L };
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
public class A279210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279210Inst : IEnumerable<long>
{
public static readonly long[] Value=A279210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279210.Bytes);
public long this[int i]=>Value[i];

public static A279210Inst Instance=new A279210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279211
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,4L,3L,5L,6L,6L,4L,6L,8L,8L,8L,5L,7L,9L,10L,10L,10L,6L,8L,10L,12L,12L,12L,12L,7L,9L,11L,13L,14L,14L,14L,14L,8L,10L,12L,14L,16L,16L,16L,16L,16L,9L,11L,13L,15L,17L,18L,18L,18L,18L,18L,10L,12L,14L,16L,18L,20L,20L,20L,20L,20L,20L,11L,13L,15L,17L };
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
public class A279211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279211Inst : IEnumerable<long>
{
public static readonly long[] Value=A279211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279211.Bytes);
public long this[int i]=>Value[i];

public static A279211Inst Instance=new A279211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279212
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,11L,4L,15L,39L,72L,8L,37L,119L,293L,543L,16L,88L,330L,976L,2364L,4403L,32L,204L,870L,2944L,8373L,20072L,37527L,64L,464L,2209L,8334L,26683L,74150L,176609L,331072L,128L,1040L,5454L,22579L,79534L,246035L,673156L,1595909L,2997466L,256L,2304L,13176L,59185L,226106L,762221L,2303159L,6231191L,14721429L,27690124L };
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
public class A279212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279212Inst : IEnumerable<long>
{
public static readonly long[] Value=A279212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279212.Bytes);
public long this[int i]=>Value[i];

public static A279212Inst Instance=new A279212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279213
{
public static readonly long[] Value={ 41L,107L,1613L,2017L,3229L,4441L,4643L,5653L,7673L,9491L,106103L,116113L,124121L,130127L,136133L,170167L,172169L,182179L,184181L,196193L,206203L,212209L,214211L,220217L,224221L,230227L,272269L,274271L,280277L,302299L,304301L,320317L,322319L,326323L,334331L };
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
public class A279213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279213Inst : IEnumerable<long>
{
public static readonly long[] Value=A279213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279213.Bytes);
public long this[int i]=>Value[i];

public static A279213Inst Instance=new A279213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279214
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,40L,792L,15374L,281434L,5089060L };
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
public class A279214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279214Inst : IEnumerable<long>
{
public static readonly long[] Value=A279214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279214.Bytes);
public long this[int i]=>Value[i];

public static A279214Inst Instance=new A279214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279215
{
public static readonly long[] Value={ 1L,1L,6L,20L,65L,190L,571L,1616L,4555L,12439L,33515L,88517L,230738L,592321L,1502384L,3763946L,9328899L,22880511L,55585077L,133806273L,319373068L,756124040L,1776497540L,4143489680L,9597505006L,22083821765L,50494638926L,114758996621L,259303832735L,582655202940L,1302234303910L,2895530963661L,6406348746390L };
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
public class A279215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279215Inst : IEnumerable<long>
{
public static readonly long[] Value=A279215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279215.Bytes);
public long this[int i]=>Value[i];

public static A279215Inst Instance=new A279215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279216
{
public static readonly long[] Value={ 1L,1L,7L,25L,86L,269L,862L,2606L,7812L,22704L,64989L,182356L,504414L,1373694L,3693367L,9804435L,25733084L,66808578L,171719539L,437183839L,1103143657L,2760037810L,6850400668L,16873338215L,41260373472L,100196920196L,241712863504L,579416535973L,1380517695672L,3270075208145L,7702580246941L };
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
public class A279216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279216Inst : IEnumerable<long>
{
public static readonly long[] Value=A279216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279216.Bytes);
public long this[int i]=>Value[i];

public static A279216Inst Instance=new A279216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279217
{
public static readonly long[] Value={ 1L,1L,8L,30L,108L,357L,1205L,3838L,12083L,36896L,110828L,326281L,946086L,2700026L,7602642L,21128513L,58028309L,157588912L,423534324L,1127102360L,2971764946L,7766890826L,20131080168L,51766513279L,132117237595L,334770353022L,842462217948L,2106183375971L,5232414548275L,12920429411759L,31719180847831L };
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
public class A279217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279217Inst : IEnumerable<long>
{
public static readonly long[] Value=A279217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279217.Bytes);
public long this[int i]=>Value[i];

public static A279217Inst Instance=new A279217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279218
{
public static readonly long[] Value={ 1L,1L,9L,35L,131L,454L,1601L,5325L,17467L,55588L,173858L,532809L,1607056L,4769263L,13957660L,40302923L,114962909L,324157109L,904247056L,2496917319L,6829241131L,18510038697L,49741367504L,132582175873L,350655140642L,920568519505L,2399692063845L,6213105691838L,15982216140168L,40855658807127L,103814659491641L };
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
public class A279218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279218Inst : IEnumerable<long>
{
public static readonly long[] Value=A279218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279218.Bytes);
public long this[int i]=>Value[i];

public static A279218Inst Instance=new A279218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279219
{
public static readonly long[] Value={ 1L,1L,10L,40L,155L,560L,2051L,7080L,24064L,79370L,257067L,815593L,2545201L,7812699L,23639459L,70551216L,207932549L,605611061L,1744513262L,4973116444L,14038641287L,39263308551L,108849552289L,299248060986L,816159923366L,2209102273109L,5936069692320L,15840122529455L,41987363787469L,110584436073149L };
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
public class A279219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279219Inst : IEnumerable<long>
{
public static readonly long[] Value=A279219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279219.Bytes);
public long this[int i]=>Value[i];

public static A279219Inst Instance=new A279219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279332
{
public static readonly BigInteger[] Value={ 0L,1L,1L,11L,17L,187L,901L,61403L,19849L,11566657L,18712297L,1110228313L,5389037609L,1360276717489L,2200966584493L,747861093416219L,1210064076159749L,59172849569407033L,34467722993604601L,BigInteger.Parse("476833062569954186123"),BigInteger.Parse("771532094165273524673"),BigInteger.Parse("524313365828795638534321") };
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
public class A279332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279332Inst Instance=new A279332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279333
{
public static readonly BigInteger[] Value={ 1L,1L,1L,6L,6L,40L,120L,5040L,1008L,362880L,362880L,13305600L,39916800L,6227020800L,6227020800L,1307674368000L,1307674368000L,39520825344000L,14227497123840L,121645100408832000L,121645100408832000L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("51090942171709440000") };
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
public class A279333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279333Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279333.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279333Inst Instance=new A279333Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279334
{
public static readonly BigInteger[] Value={ 1L,2L,7L,17L,221L,893L,17347L,98221L,2542969L,2645039L,599172671L,5332129721L,207061905877L,2177714624677L,98661276360571L,1197279643886453L,8855950704414791L,5962161748599967L,BigInteger.Parse("49662655090649112439"),BigInteger.Parse("69398245985290595843"),BigInteger.Parse("2906296303998501464573") };
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
public class A279334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279334Inst Instance=new A279334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279335
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,24L,60L,720L,2520L,40320L,25920L,3628800L,19958400L,479001600L,3113510400L,87178291200L,653837184000L,2988969984000L,1243662336000L,6402373705728000L,5529322745856000L,143111882833920000L,115590366904320000L,BigInteger.Parse("1124000727777607680000") };
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
public class A279335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279335Inst Instance=new A279335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279336
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,8L,15L,11L,10L,12L,14L,25L,27L,16L,35L,13L,18L,20L,21L,45L,22L,33L,49L,24L,26L,28L,30L,125L,81L,32L,77L,17L,34L,36L,75L,63L,38L,55L,175L,40L,42L,44L,39L,65L,46L,121L,135L,48L,50L,51L,99L,52L,105L,343L,54L,56L,58L,60L,62L,625L,243L,64L,143L,19L,66L,68L,57L,225L,70L,245L,275L,72L,74L,76L,69L,91L,78L,539L,189L,80L };
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
public class A279336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279336Inst : IEnumerable<long>
{
public static readonly long[] Value=A279336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279336.Bytes);
public long this[int i]=>Value[i];

public static A279336Inst Instance=new A279336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279337
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,8L,12L,11L,13L,19L,14L,10L,17L,35L,20L,67L,21L,22L,24L,131L,27L,15L,28L,16L,29L,259L,30L,515L,33L,25L,36L,18L,37L,1027L,40L,46L,43L,2051L,44L,4099L,45L,23L,48L,8195L,51L,26L,52L,53L,55L,16387L,58L,41L,59L,70L,60L,32771L,61L,65539L,62L,39L,65L,47L,68L,131075L,69L,78L,72L,262147L,75L,524291L,76L,38L,77L,34L,80L };
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
public class A279337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279337Inst : IEnumerable<long>
{
public static readonly long[] Value=A279337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279337.Bytes);
public long this[int i]=>Value[i];

public static A279337Inst Instance=new A279337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279338
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,9L,10L,15L,11L,8L,12L,14L,25L,21L,18L,35L,13L,20L,30L,27L,45L,22L,33L,49L,16L,24L,28L,50L,55L,75L,42L,77L,17L,36L,70L,63L,105L,26L,125L,175L,40L,60L,54L,39L,65L,90L,121L,81L,44L,66L,135L,99L,98L,147L,91L,32L,48L,56L,100L,110L,245L,165L,150L,143L,19L,84L,154L,225L,231L,34L,275L,385L,72L,140L,126L,51L,343L,210L,539L,189L,52L };
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
public class A279338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279338Inst : IEnumerable<long>
{
public static readonly long[] Value=A279338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279338.Bytes);
public long this[int i]=>Value[i];

public static A279338Inst Instance=new A279338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279339
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,12L,8L,9L,11L,13L,19L,14L,10L,27L,35L,17L,67L,20L,16L,24L,131L,28L,15L,40L,22L,29L,259L,21L,515L,58L,25L,72L,18L,36L,1027L,136L,46L,43L,2051L,33L,4099L,51L,23L,264L,8195L,59L,26L,30L,78L,83L,16387L,45L,31L,60L,142L,520L,32771L,44L,65539L,1032L,38L,121L,47L,52L,131075L,147L,270L,37L,262147L,75L,524291L,2056L,32L,275L,34L,93L };
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
public class A279339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279339Inst : IEnumerable<long>
{
public static readonly long[] Value=A279339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279339.Bytes);
public long this[int i]=>Value[i];

public static A279339Inst Instance=new A279339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279340
{
public static readonly long[] Value={ 3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,3L };
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
public class A279340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279340Inst : IEnumerable<long>
{
public static readonly long[] Value=A279340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279340.Bytes);
public long this[int i]=>Value[i];

public static A279340Inst Instance=new A279340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279341
{
public static readonly long[] Value={ 0L,1L,3L,7L,2L,6L,15L,5L,14L,13L,31L,4L,12L,30L,11L,29L,10L,27L,63L,28L,26L,9L,25L,62L,61L,23L,8L,24L,60L,22L,59L,21L,58L,55L,127L,20L,54L,57L,53L,126L,19L,51L,56L,52L,18L,125L,123L,50L,47L,17L,124L,122L,49L,121L,46L,45L,119L,16L,48L,120L,44L,118L,43L,117L,42L,111L,255L,116L,110L,41L,109L,254L,115L,107L,40L,108L,114L,253L,39L,106L,103L };
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
public class A279341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279341Inst : IEnumerable<long>
{
public static readonly long[] Value=A279341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279341.Bytes);
public long this[int i]=>Value[i];

public static A279341Inst Instance=new A279341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279342
{
public static readonly long[] Value={ 1L,2L,5L,3L,12L,8L,6L,4L,27L,22L,17L,15L,13L,10L,9L,7L,58L,50L,45L,41L,36L,32L,30L,26L,28L,23L,21L,18L,20L,16L,14L,11L,121L,112L,103L,97L,92L,86L,84L,79L,75L,70L,65L,63L,61L,56L,55L,49L,59L,53L,48L,42L,44L,39L,37L,34L,43L,38L,33L,31L,29L,25L,24L,19L,248L,237L,227L,221L,210L,201L,196L,191L,187L,180L,175L,168L,171L,165L,160L,153L,154L,146L,141L };
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
public class A279342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279342Inst : IEnumerable<long>
{
public static readonly long[] Value=A279342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279342.Bytes);
public long this[int i]=>Value[i];

public static A279342Inst Instance=new A279342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279343
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,5L,8L,6L,9L,10L,16L,7L,11L,17L,12L,18L,13L,20L,32L,19L,21L,14L,22L,33L,34L,24L,15L,23L,35L,25L,36L,26L,37L,40L,64L,27L,41L,38L,42L,65L,28L,44L,39L,43L,29L,66L,68L,45L,48L,30L,67L,69L,46L,70L,49L,50L,72L,31L,47L,71L,51L,73L,52L,74L,53L,80L,128L,75L,81L,54L,82L,129L,76L,84L,55L,83L,77L,130L,56L,85L,88L,78L,131L,57L,86L };
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
public class A279343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279343Inst : IEnumerable<long>
{
public static readonly long[] Value=A279343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279343.Bytes);
public long this[int i]=>Value[i];

public static A279343Inst Instance=new A279343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279344
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,8L,12L,7L,9L,10L,13L,15L,17L,22L,27L,11L,14L,16L,20L,18L,21L,23L,28L,26L,30L,32L,36L,41L,45L,50L,58L,19L,24L,25L,29L,31L,33L,38L,43L,34L,37L,39L,44L,42L,48L,53L,59L,49L,55L,56L,61L,63L,65L,70L,75L,79L,84L,86L,92L,97L,103L,112L,121L,35L,40L,46L,51L,47L,52L,54L,60L,57L,62L,64L,68L,73L,77L,82L,90L,66L,69L,71L,76L,74L,80L };
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
public class A279344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279344Inst : IEnumerable<long>
{
public static readonly long[] Value=A279344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279344.Bytes);
public long this[int i]=>Value[i];

public static A279344Inst Instance=new A279344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279345
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,4L,2L,3L,3L,5L,1L,2L,4L,3L,4L,2L,4L,6L,3L,3L,2L,3L,5L,5L,4L,1L,2L,4L,3L,5L,3L,4L,5L,7L,2L,4L,4L,4L,6L,3L,4L,3L,3L,2L,6L,6L,3L,5L,2L,5L,5L,3L,5L,4L,4L,6L,1L,2L,4L,3L,5L,4L,5L,3L,6L,8L,4L,5L,3L,5L,7L,5L,5L,2L,4L,4L,7L,4L,4L,5L,4L,6L,3L,4L,3L,4L,7L,7L,3L,3L,2L,6L,4L,6L,6L,3L,6L,3L,5L,6L,4L,2L,6L,5L,5L,5L,3L,5L,7L,5L,2L,3L,4L,4L,5L,4L,6L,6L,5L };
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
public class A279345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279345Inst : IEnumerable<long>
{
public static readonly long[] Value=A279345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279345.Bytes);
public long this[int i]=>Value[i];

public static A279345Inst Instance=new A279345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279346
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,3L,3L,2L,2L,2L,3L,2L,1L,3L,3L,3L,3L,2L,2L,2L,4L,4L,3L,3L,2L,3L,3L,2L,1L,4L,3L,3L,3L,2L,3L,3L,4L,4L,4L,2L,2L,4L,2L,4L,3L,3L,4L,3L,3L,3L,2L,5L,5L,4L,4L,3L,3L,3L,4L,2L,1L,4L,3L,4L,3L,2L,3L,3L,5L,4L,4L,2L,3L,4L,3L,4L,3L,4L,4L,4L,4L,2L,2L,5L,5L,5L,3L,4L,2L,3L,4L,3L,5L,3L,3L,4L,5L,3L,3L,4L,4L,5L,3L,2L,4L,5L,5L,4L,4L,4L,4L,3L,3L,3L };
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
public class A279346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279346Inst : IEnumerable<long>
{
public static readonly long[] Value=A279346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279346.Bytes);
public long this[int i]=>Value[i];

public static A279346Inst Instance=new A279346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279347
{
public static readonly long[] Value={ 1L,2L,5L,12L,3L,8L,27L,6L,22L,17L,58L,4L,15L,50L,13L,45L,10L,36L,121L,41L,32L,9L,30L,112L,103L,28L,7L,26L,97L,23L,92L,21L,86L,75L,248L,18L,70L,84L,65L,237L,20L,61L,79L,63L,16L,227L,210L,56L,59L,14L,221L,201L,55L,196L,53L,48L,187L,11L,49L,191L,42L,180L,44L,175L,39L,154L,503L,168L,146L,37L,141L,491L,171L,132L,34L,137L,165L,478L,43L,128L };
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
public class A279347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279347Inst : IEnumerable<long>
{
public static readonly long[] Value=A279347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279347.Bytes);
public long this[int i]=>Value[i];

public static A279347Inst Instance=new A279347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279509
{
public static readonly long[] Value={ 12L,60L,180L,240L,420L,480L,840L,462L,1260L,1680L,1440L,690L,2520L,2100L,2160L,2310L,3360L,2400L,3780L,5040L,4620L,3600L,3300L,1410L,5460L,4080L,6300L,7560L,5880L,4140L,9240L,2646L,10080L,6600L,6480L,7200L,10920L,8820L,9360L,2370L,13860L,8640L,8160L,15120L };
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
public class A279509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279509Inst : IEnumerable<long>
{
public static readonly long[] Value=A279509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279509.Bytes);
public long this[int i]=>Value[i];

public static A279509Inst Instance=new A279509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279510
{
public static readonly long[] Value={ 1L,3L,5L,27L,7L,15L,11L,243L,125L,21L,13L,135L,17L,33L,35L,7625597484987L,19L,375L,23L,189L,55L,39L,29L,1215L,343L,51L,3125L,297L,31L,105L,37L,2187L,65L,57L,77L,3375L,41L,69L,85L,1701L,43L,165L,47L,351L,875L,87L,53L,38127987424935L,1331L,1029L,95L,459L,59L };
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
public class A279510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279510Inst : IEnumerable<long>
{
public static readonly long[] Value=A279510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279510.Bytes);
public long this[int i]=>Value[i];

public static A279510Inst Instance=new A279510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279511
{
public static readonly long[] Value={ 5L,14L,55L,252L,1221L,6034L,30035L,149912L,749041L,3744174L,18718815L,93589972L,467941661L,2339691914L,11698426795L,58492068432L,292460211081L,1462300793254L,7311503441975L,36557516161292L,182787578709301L,913937889352194L,4569689438372355L,22848447175084552L };
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
public class A279511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279511Inst : IEnumerable<long>
{
public static readonly long[] Value=A279511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279511.Bytes);
public long this[int i]=>Value[i];

public static A279511Inst Instance=new A279511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279512
{
public static readonly long[] Value={ 6L,19L,85L,457L,2641L,15649L,93505L,560257L,3360001L,20156929L,120935425L,725600257L,4353576961L,26121412609L,156728377345L,940370067457L,5642220011521L,33853319282689L,203119914123265L,1218719481593857L,7312316883271681L,43873901287047169L };
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
public class A279512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279512Inst : IEnumerable<long>
{
public static readonly long[] Value=A279512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279512.Bytes);
public long this[int i]=>Value[i];

public static A279512Inst Instance=new A279512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279513
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,6L,6L,10L,11L,12L,13L,14L,15L,8L,17L,12L,19L,20L,21L,22L,23L,18L,10L,26L,9L,28L,29L,30L,31L,10L,33L,34L,35L,24L,37L,38L,39L,30L,41L,42L,43L,44L,30L,46L,47L,24L,14L,20L,51L,52L,53L,18L,55L,42L,57L,58L,59L,60L,61L,62L,42L,12L,65L,66L,67L,68L };
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
public class A279513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279513Inst : IEnumerable<long>
{
public static readonly long[] Value=A279513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279513.Bytes);
public long this[int i]=>Value[i];

public static A279513Inst Instance=new A279513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279514
{
public static readonly long[] Value={ 1L,0L,3L,0L,1L,0L,12L,8L,0L,9L,6L,0L,0L,1L,0L,96L,0L,204L,0L,160L,0L,67L,0L,36L,0L,12L,0L,0L,0L,1L,0L,2400L,1680L,480L,1824L,1200L,1300L,2300L,1600L,100L,400L,400L,225L,300L,70L,0L,100L,0L,0L,20L,0L,0L,0L,0L,1L,0L,34560L,0L,87840L,0L,153840L,0L,77616L,0L,61020L,0L,56048L,0L,28500L,0L,9900L,0L,4075L,0L,3225L,0L,1350L,0L,170L,0L,225L,0L,0L,0L,30L,0L,0L,0L,0L,0L,1L,0L,2540160L,2338560L,1058400L,1522080L,1582560L,1225440L,1905120L,3605616L,2342592L,1605240L };
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
public class A279514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279514Inst : IEnumerable<long>
{
public static readonly long[] Value=A279514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279514.Bytes);
public long this[int i]=>Value[i];

public static A279514Inst Instance=new A279514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279515
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,2L,5L,6L,6L,6L,9L,9L,7L,7L,7L,8L,12L,12L,16L,16L,16L,16L,19L,19L,14L,14L,19L,19L,25L,25L,25L,26L,26L,26L,26L,26L,25L,25L,25L,25L,33L,33L,32L,32L,32L,32L,29L,29L,32L,32L,32L,32L,35L,35L,35L,35L,35L,35L,46L,46L,45L };
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
public class A279515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279515Inst : IEnumerable<long>
{
public static readonly long[] Value=A279515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279515.Bytes);
public long this[int i]=>Value[i];

public static A279515Inst Instance=new A279515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279516
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,9L,11L,13L,17L,19L,21L,27L,35L,37L,41L,43L,53L,69L,73L,75L,83L,85L,107L,139L,147L,149L,165L,171L,213L,275L,277L,293L,299L,331L,339L,341L,427L,549L,555L,587L,595L,597L,661L,677L,683L,853L,1099L,1107L,1109L,1171L,1173L,1189L,1195L,1323L,1355L };
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
public class A279516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279516Inst : IEnumerable<long>
{
public static readonly long[] Value=A279516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279516.Bytes);
public long this[int i]=>Value[i];

public static A279516Inst Instance=new A279516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279517
{
public static readonly long[] Value={ -1L,0L,1L,3L,7L,8L,13L,17L,18L,21L,30L,35L,37L,47L,58L,59L,70L,73L,87L,94L,113L,121L,134L,139L,166L,189L,211L,221L,251L,259L,271L,304L,339L,389L,410L,419L,461L,474L,479L,553L,621L,640L,705L,740L,741L,835L,856L,868L,899L,991L,996L,1109L,1120L,1264L,1327L,1339L };
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
public class A279517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279517Inst : IEnumerable<long>
{
public static readonly long[] Value=A279517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279517.Bytes);
public long this[int i]=>Value[i];

public static A279517Inst Instance=new A279517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279518
{
public static readonly long[] Value={ 4L,8L,8L,1909L,558031L,783975L,185363811L,1584002413L };
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
public class A279518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279518Inst : IEnumerable<long>
{
public static readonly long[] Value=A279518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279518.Bytes);
public long this[int i]=>Value[i];

public static A279518Inst Instance=new A279518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279519
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,9L,11L,14L,14L,23L,23L,42L,42L,42L,46L,79L,79L,48L,48L,48L,48L,95L,95L,125L,125L,180L,180L,182L,182L,307L,320L,320L,320L,320L,320L,365L,365L,365L,365L,390L,390L,451L,451L,451L,451L,360L,360L,564L,564L,564L,564L,582L,582L,582L,582L,582L,582L,745L,745L,804L,804L,804L,822L,822L,822L,866L };
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
public class A279519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279519Inst : IEnumerable<long>
{
public static readonly long[] Value=A279519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279519.Bytes);
public long this[int i]=>Value[i];

public static A279519Inst Instance=new A279519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279520
{
public static readonly long[] Value={ 6L,105L,1001L,2945L,240485L,1671414L,22551962L,22551962L };
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
public class A279520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279520Inst : IEnumerable<long>
{
public static readonly long[] Value=A279520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279520.Bytes);
public long this[int i]=>Value[i];

public static A279520Inst Instance=new A279520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279521
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,4L,5L,6L,7L,7L,7L,7L,7L,8L,9L,10L,11L,12L,13L,14L,15L,15L,15L,15L,15L,15L,15L,15L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,32L,33L,34L,35L,36L,37L,38L };
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
public class A279521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279521Inst : IEnumerable<long>
{
public static readonly long[] Value=A279521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279521.Bytes);
public long this[int i]=>Value[i];

public static A279521Inst Instance=new A279521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279522
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,1L,1L,2L,2L,2L,1L,3L,5L,2L,2L,5L,4L,1L,1L,2L,4L,1L,0L,7L,3L,1L,1L,1L,4L,6L,4L,5L,4L,4L,3L,3L,5L,2L,3L,5L,4L,2L,1L,4L,8L,5L,1L,5L,12L,1L,1L,2L,6L,3L,4L,3L,3L,9L,1L,6L,4L,2L,3L,8L,8L,2L,3L,7L,7L,7L,3L,8L,14L,3L,2L };
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
public class A279522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279522Inst : IEnumerable<long>
{
public static readonly long[] Value=A279522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279522.Bytes);
public long this[int i]=>Value[i];

public static A279522Inst Instance=new A279522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279523
{
public static readonly long[] Value={ 0L,4L,46L,384L,2894L,20444L,138944L,918744L,5954690L,38005496L,239638474L,1496190304L,9265675104L,56988880140L,348469302678L,2120061738416L,12841720934726L,77485235860420L,465936438401536L,2793228811996384L };
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
public class A279523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279523Inst : IEnumerable<long>
{
public static readonly long[] Value=A279523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279523.Bytes);
public long this[int i]=>Value[i];

public static A279523Inst Instance=new A279523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279524
{
public static readonly ulong[] Value={ 2L,46L,1168L,23610L,456846L,8451524L,152161078L,2683339202L,46585256882L,798803549422L,13560625665130L,228309753887084L,3817243895220652L,63445894677315538L,1049156236360318398L,17272132042718733138UL };
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
public class A279524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279524Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279524.Bytes);
public ulong this[int i]=>Value[i];

public static A279524Inst Instance=new A279524Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279573
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,102L,499L,2625L,14601L,84847L,510614L,3161964L,20050770L,129718404L,853689031L,5701759424L,38574689104L,263936457042L,1824032887177L,12718193293888L,89386742081688L,632746535420834L,4508140253686638L,32308561883462867L,232790342330880572L };
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
public class A279573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279573Inst : IEnumerable<long>
{
public static readonly long[] Value=A279573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279573.Bytes);
public long this[int i]=>Value[i];

public static A279573Inst Instance=new A279573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279574
{
public static readonly long[] Value={ 0L,4L,40L,352L,3008L,25280L,209792L,1723392L,14039040L,113562624L,913131520L,7304519680L,58170228736L,461421658112L,3647369216000L,28741570396160L,225854805245952L,1770332698705920L,13844879799484416L,108048964894326784L };
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
public class A279574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279574Inst : IEnumerable<long>
{
public static readonly long[] Value=A279574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279574.Bytes);
public long this[int i]=>Value[i];

public static A279574Inst Instance=new A279574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279575
{
public static readonly BigInteger[] Value={ 2L,36L,944L,23072L,547168L,12701248L,290067328L,6540226304L,145949741056L,3229393518592L,70948621604864L,1549301789257728L,33656105642434560L,727817498719862784L,15676632552910815232UL,BigInteger.Parse("336475872266838999040") };
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
public class A279575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279575Inst Instance=new A279575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279576
{
public static readonly BigInteger[] Value={ 4L,304L,20776L,1356120L,86246944L,5385546376L,331573929104L,20185283466808L,1217559111188832L,72881432768564104L,4334414771180477232L,BigInteger.Parse("256350873834571829720"),BigInteger.Parse("15088730814780904713600"),BigInteger.Parse("884394788795879442352680") };
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
public class A279576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279576Inst Instance=new A279576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279577
{
public static readonly BigInteger[] Value={ 14L,2212L,406200L,72177144L,12490527012L,2121871518232L,355347019237332L,58835479020749472L,9651371153656703340UL,BigInteger.Parse("1571020467270689259744"),BigInteger.Parse("254061714988118013529260"),BigInteger.Parse("40857315122339646469304952") };
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
public class A279577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279577Inst Instance=new A279577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279578
{
public static readonly BigInteger[] Value={ 40L,15428L,7630156L,3684310576L,1732429706176L,800037452999320L,364333887872124232L,BigInteger.Parse("164074884296083732404"),BigInteger.Parse("73218680852147959341596"),BigInteger.Parse("32426575421603630303208340"),BigInteger.Parse("14268836326027631533574123696") };
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
public class A279578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279578Inst Instance=new A279578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279579
{
public static readonly BigInteger[] Value={ 120L,103648L,138602548L,181962323164L,232705351295280L,292348743305295404L,BigInteger.Parse("362240737115414208512"),BigInteger.Parse("443908439955965894569796"),BigInteger.Parse("539089978278089902916659088"),BigInteger.Parse("649762606192081418497682913752") };
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
public class A279579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279579Inst Instance=new A279579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279580
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,0L,4L,36L,40L,0L,14L,304L,944L,352L,0L,40L,2212L,20776L,23072L,3008L,0L,120L,15428L,406200L,1356120L,547168L,25280L,0L,352L,103648L,7630156L,72177144L,86246944L,12701248L,209792L,0L,1032L,680052L,138602548L,3684310576L,12490527012L };
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
public class A279580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279580Inst : IEnumerable<long>
{
public static readonly long[] Value=A279580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279580.Bytes);
public long this[int i]=>Value[i];

public static A279580Inst Instance=new A279580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279581
{
public static readonly long[] Value={ 0L,4L,36L,304L,2212L,15428L,103648L,680052L,4380964L,27829504L,174806900L,1087994628L,6720111376L,41240210276L,251687871332L,1528700226512L,9246173840644L,55718099241732L,334660112687936L,2004174865390100L };
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
public class A279581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279581Inst : IEnumerable<long>
{
public static readonly long[] Value=A279581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279581.Bytes);
public long this[int i]=>Value[i];

public static A279581Inst Instance=new A279581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279582
{
public static readonly ulong[] Value={ 0L,40L,944L,20776L,406200L,7630156L,138602548L,2461556084L,42965101580L,739900893296L,12604712050308L,212833814657368L,3567237354560504L,59415173946814708L,984289294203593368L,16229966112949514160UL };
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
public class A279582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279582Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279582.Bytes);
public ulong this[int i]=>Value[i];

public static A279582Inst Instance=new A279582Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279583
{
public static readonly BigInteger[] Value={ 0L,352L,23072L,1356120L,72177144L,3684310576L,181962323164L,8787026600092L,417085943095700L,19534107020719616L,905081723458584548L,BigInteger.Parse("41566958473756323604"),BigInteger.Parse("1894986340410192048268"),BigInteger.Parse("85851638573599652691500") };
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
public class A279583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279583Inst Instance=new A279583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279584
{
public static readonly BigInteger[] Value={ 0L,3008L,547168L,86246944L,12490527012L,1732429706176L,232705351295280L,30571024321366804L,3948460628685790836L,BigInteger.Parse("503258449385912281884"),BigInteger.Parse("63463648917297433694668"),BigInteger.Parse("7933378997893481856831644") };
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
public class A279584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279584Inst Instance=new A279584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279585
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,11L,12L,12L,21L,21L,22L,41L,42L,42L,63L,63L,64L,74L,75L,75L,79L,79L,80L,80L,80L,83L,83L,83L,84L,152L,153L,153L,153L,158L,158L,158L,159L,159L,163L,163L,164L,189L,190L,190L,193L,193L,194L,194L,194L,197L,197L,197L,205L,205L,205L,210L,210L,210L,211L,223L };
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
public class A279585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279585Inst : IEnumerable<long>
{
public static readonly long[] Value=A279585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279585.Bytes);
public long this[int i]=>Value[i];

public static A279585Inst Instance=new A279585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279586
{
public static readonly long[] Value={ 2L,-1L,2L,-4L,7L,-12L,21L,-36L,61L,-104L,177L,-300L,508L,-860L,1455L,-2460L,4158L,-7027L,11873L,-20058L,33884L,-57237L,96679L,-163296L,275811L,-465843L,786796L,-1328867L,2244390L,-3790645L,6402161L,-10812825L,18262114L,-30843412L,52092289L,-87980053L };
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
public class A279586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279586Inst : IEnumerable<long>
{
public static readonly long[] Value=A279586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279586.Bytes);
public long this[int i]=>Value[i];

public static A279586Inst Instance=new A279586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279587
{
public static readonly long[] Value={ 1L,-2L,0L,3L,-3L,0L,4L,-7L,5L,5L,-16L,15L,2L,-26L,39L,-19L,-38L,92L,-77L,-34L,178L,-220L,48L,293L,-537L,343L,363L,-1129L,1146L,94L,-2050L,3029L,-1290L,-3039L,6855L,-5577L,-2738L,13513L,-16417L,3007L,22633L,-40108L,24584L,28535L,-85117L,84600L,10247L,-156524L };
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
public class A279587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279587Inst : IEnumerable<long>
{
public static readonly long[] Value=A279587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279587.Bytes);
public long this[int i]=>Value[i];

public static A279587Inst Instance=new A279587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279588
{
public static readonly long[] Value={ 1L,-3L,4L,-3L,-1L,8L,-15L,18L,-13L,-3L,29L,-57L,72L,-56L,-3L,99L,-201L,256L,-204L,7L,316L,-665L,864L,-711L,75L,987L,-2148L,2830L,-2373L,350L,3060L,-6813L,9062L,-7695L,1337L,9463L,-21405L,28636L,-24466L,4546L,29388L,-66931L,89675L,-76646L,14298L,91775L };
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
public class A279588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279588Inst : IEnumerable<long>
{
public static readonly long[] Value=A279588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279588.Bytes);
public long this[int i]=>Value[i];

public static A279588Inst Instance=new A279588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279669
{
public static readonly BigInteger[] Value={ 1L,10L,10L,1100L,101L,111000L,1011L,11110010L,10100L,1111100101L,101000L,111111001111L,1011000L,11111110001111L,10110000L,1111111100111111L,101001100L,111111111001011101L,1010000000L,11111111110011111111UL,10110000000L,BigInteger.Parse("1111111111100010111111"),101111100000L };
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
public class A279669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A279669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A279669Inst Instance=new A279669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279670
{
public static readonly ulong[] Value={ 1L,1L,10L,11L,10100L,111L,1101000L,1001111L,1010000L,1010011111L,10100000L,111100111111L,1101000000L,11110001111111L,11010000000L,1111110011111111L,110010100000000L,101110100111111111L,101000000000L,11111111001111111111UL,11010000000000L };
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
public class A279670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279670Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A279670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279670.Bytes);
public ulong this[int i]=>Value[i];

public static A279670Inst Instance=new A279670Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279671
{
public static readonly long[] Value={ 1L,2L,2L,12L,5L,56L,11L,242L,20L,997L,40L,4047L,88L,16271L,176L,65343L,332L,261725L,640L,1047807L,1408L,4192447L,3040L,16773695L,5344L,67102143L,10464L,268423039L,22880L,1073712719L,45944L,4294916687L,82776L,17179761327L,170656L,68719271951L,372724L };
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
public class A279671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279671Inst : IEnumerable<long>
{
public static readonly long[] Value=A279671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279671.Bytes);
public long this[int i]=>Value[i];

public static A279671Inst Instance=new A279671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279672
{
public static readonly long[] Value={ 1L,1L,2L,3L,20L,7L,104L,79L,80L,671L,160L,3903L,832L,15487L,1664L,64767L,25856L,190975L,2560L,1045503L,13312L,4147199L,256000L,16535551L,937984L,66494463L,3710976L,267337727L,13844480L,1016889343L,258375680L,4066181119L,897908736L,16465395711L,717881344L };
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
public class A279672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279672Inst : IEnumerable<long>
{
public static readonly long[] Value=A279672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279672.Bytes);
public long this[int i]=>Value[i];

public static A279672Inst Instance=new A279672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279673
{
public static readonly long[] Value={ 1L,3L,9L,19L,41L,99L,233L,531L,1225L,2851L,6601L,15251L,35305L,81763L,189225L,437907L,1013641L,2346275L,5430537L,12569363L,29093289L,67339363L,155862889L,360759571L,835013705L,1932719395L,4473463369L,10354262163L,23965938537L,55471468387L,128394046889L };
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
public class A279673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279673Inst : IEnumerable<long>
{
public static readonly long[] Value=A279673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279673.Bytes);
public long this[int i]=>Value[i];

public static A279673Inst Instance=new A279673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A279674
{
public static readonly long[] Value={ 1L,3L,5L,11L,29L,67L,149L,347L,813L,1875L,4325L,10027L,23229L,53731L,124341L,287867L,666317L,1542131L,3569413L,8261963L,19123037L,44261763L,102448341L,237127067L,548852845L,1270371987L,2940399397L,6805838187L,15752764925L,36461289251L,84393166325L,195336103099L };
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
public class A279674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A279674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A279674Inst : IEnumerable<long>
{
public static readonly long[] Value=A279674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A279674.Bytes);
public long this[int i]=>Value[i];

public static A279674Inst Instance=new A279674Inst();

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