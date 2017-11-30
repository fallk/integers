using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A232077
{
public static readonly long[] Value={ 3L,15L,46L,161L,601L,2208L,8053L,29415L,107534L,393061L,1436589L,5250624L,19190841L,70141747L,256364934L,937002409L,3424702513L,12517136672L,45749581901L,167212702063L,611155044830L,2233744710845L,8164238313221L,29839930638080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232077Inst : IEnumerable<long>
{
public static readonly long[] Value=A232077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232077.Bytes);
public long this[int i]=>Value[i];

public static A232077Inst Instance=new A232077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232078
{
public static readonly long[] Value={ 11L,87L,520L,3681L,26587L,189404L,1348429L,9607995L,68462448L,487805049L,3475683907L,24764857724L,176453944877L,1257264924795L,8958230513184L,63828946109201L,454792310901883L,3240474086774308L,23088939844648997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232078Inst : IEnumerable<long>
{
public static readonly long[] Value=A232078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232078.Bytes);
public long this[int i]=>Value[i];

public static A232078Inst Instance=new A232078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232079
{
public static readonly long[] Value={ 34L,602L,6624L,91636L,1313477L,18480458L,259478100L,3648082844L,51295928745L,721205855171L,10139874360108L,142563684195350L,2004404663282803L,28181342842446164L,396221424711381995L,5570757356145256130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232079Inst : IEnumerable<long>
{
public static readonly long[] Value=A232079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232079.Bytes);
public long this[int i]=>Value[i];

public static A232079Inst Instance=new A232079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232192
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,44L,519L,7590L,132347L,2689046L,62644234L,1651650774L,48731341965L,1592908456996L,57173688136781L,2235773294509565L,94608603077007214L,4306708055122614542L,BigInteger.Parse("209823573154587335730"),BigInteger.Parse("10892496561736261641371"),BigInteger.Parse("600171728539156939466278") };
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
public class A232192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232192Inst Instance=new A232192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232193
{
public static readonly BigInteger[] Value={ 1L,3L,23L,55L,1901L,4277L,198721L,16083L,14097247L,4325321L,2132509567L,4527766399L,13064406523627L,905730205L,13325653738373L,362555126427073L,14845854129333883L,57424625956493833L,BigInteger.Parse("333374427829017307697"),922050973293317L,BigInteger.Parse("236387355420350878139797") };
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
public class A232193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232193Inst Instance=new A232193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232194
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,2L,2L,3L,3L,3L,2L,3L,4L,2L,4L,2L,3L,1L,5L,4L,4L,1L,4L,3L,8L,3L,7L,2L,6L,3L,7L,4L,9L,3L,5L,4L,6L,3L,8L,4L,7L,5L,8L,3L,7L,4L,6L,3L,8L,3L,8L,2L,12L,4L,9L,4L,9L,4L,10L,3L,9L,7L,10L,5L,9L,4L,10L,4L,6L,5L,8L,3L,7L,5L,11L,7L,9L,8L,11L,5L,11L,8L,13L,4L,9L,5L,8L,7L,12L,6L,9L,5L,15L,7L,10L,5L,15L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232194Inst : IEnumerable<long>
{
public static readonly long[] Value=A232194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232194.Bytes);
public long this[int i]=>Value[i];

public static A232194Inst Instance=new A232194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232195
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,0L,1L,4L,1L,0L,1L,0L,12L,0L,0L,4L,16L,0L,1L,0L,0L,0L,1L,0L,24L,0L,9L,0L,28L,0L,1L,0L,0L,0L,0L,0L,36L,0L,0L,0L,40L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,52L,0L,0L,0L,0L,0L,1L,0L,60L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,72L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232195Inst : IEnumerable<long>
{
public static readonly long[] Value=A232195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232195.Bytes);
public long this[int i]=>Value[i];

public static A232195Inst Instance=new A232195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232196
{
public static readonly BigInteger[] Value={ 15L,2129L,2064527L,16237318767L,1024215443152687L,BigInteger.Parse("515298827433540888151"),BigInteger.Parse("2068734726208811311397436981"),BigInteger.Parse("66293423431894237647538826697163203") };
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
public class A232196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232196Inst Instance=new A232196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232197
{
public static readonly long[] Value={ 15L,109L,685L,4483L,29469L,193531L,1270657L,8343063L,54780825L,359691769L,2361740413L,15507217849L,101820594071L,668555339287L,4389743011111L,28823109441929L,189252909756115L,1242637055605621L,8159170994793111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232197Inst : IEnumerable<long>
{
public static readonly long[] Value=A232197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232197.Bytes);
public long this[int i]=>Value[i];

public static A232197Inst Instance=new A232197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232198
{
public static readonly BigInteger[] Value={ 109L,2129L,39651L,745157L,14015499L,263553379L,4955798535L,93188421223L,1752307388503L,32950235075335L,619593351859825L,11650779532851601L,219080245401618255L,4119565886810925283L,BigInteger.Parse("77463958767778856465") };
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
public class A232198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232198Inst Instance=new A232198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232199
{
public static readonly BigInteger[] Value={ 685L,39651L,2064527L,108997581L,5765893981L,304936615565L,16125727718291L,852771317084487L,45096907001517677L,2384848436844497369L,BigInteger.Parse("126117335748613488379"),BigInteger.Parse("6669431203519450134085"),BigInteger.Parse("352697845770250504989279") };
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
public class A232199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232199Inst Instance=new A232199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232200
{
public static readonly BigInteger[] Value={ 4483L,745157L,108997581L,16237318767L,2425888162725L,362285582855051L,54098452658673021L,8078379401440126991L,BigInteger.Parse("1206326901993417809943"),BigInteger.Parse("180138093804741886040287"),BigInteger.Parse("26899615671950715433420665") };
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
public class A232200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232200Inst Instance=new A232200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232201
{
public static readonly BigInteger[] Value={ 29469L,14015499L,5765893981L,2425888162725L,1024215443152687L,432206209011195289L,BigInteger.Parse("182361235082538718699"),BigInteger.Parse("76945195575153563783331"),BigInteger.Parse("32466258660231745630472925"),BigInteger.Parse("13698805812966842808611663457") };
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
public class A232201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232201Inst Instance=new A232201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232202
{
public static readonly BigInteger[] Value={ 193531L,263553379L,304936615565L,362285582855051L,432206209011195289L,BigInteger.Parse("515298827433540888151"),BigInteger.Parse("614268969565470965614819"),BigInteger.Parse("732263215190697986858274293"),BigInteger.Parse("872927312848248139397338258365") };
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
public class A232202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232202Inst Instance=new A232202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232203
{
public static readonly BigInteger[] Value={ 1270657L,4955798535L,16125727718291L,54098452658673021L,BigInteger.Parse("182361235082538718699"),BigInteger.Parse("614268969565470965614819"),BigInteger.Parse("2068734726208811311397436981"),BigInteger.Parse("6967263753083738967913587093853") };
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
public class A232203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232203Inst Instance=new A232203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232204
{
public static readonly long[] Value={ 15L,109L,109L,685L,2129L,685L,4483L,39651L,39651L,4483L,29469L,745157L,2064527L,745157L,29469L,193531L,14015499L,108997581L,108997581L,14015499L,193531L,1270657L,263553379L,5765893981L,16237318767L,5765893981L,263553379L,1270657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232204Inst : IEnumerable<long>
{
public static readonly long[] Value=A232204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232204.Bytes);
public long this[int i]=>Value[i];

public static A232204Inst Instance=new A232204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232205
{
public static readonly BigInteger[] Value={ 1L,2L,4L,24L,96L,960L,5760L,80640L,645120L,11612160L,116121600L,2554675200L,30656102400L,797058662400L,11158821273600L,334764638208000L,5356234211328000L,182111963185152000L,3278015337332736000L,BigInteger.Parse("124564582818643968000"),BigInteger.Parse("2491291656372879360000"),BigInteger.Parse("104634249567660933120000"),BigInteger.Parse("2301953490488540528640000") };
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
public class A232205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232205Inst Instance=new A232205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232206
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,5L,8L,3L,1L,8L,22L,20L,6L,1L,11L,46L,73L,49L,11L,1L,15L,87L,206L,233L,119L,23L,1L,19L,147L,485L,807L,689L,288L,46L,1L,24L,236L,1021L,2320L,2891L,1988L,696L,98L,1L,29L,356L,1960L,5795L,9800L,9737L,5561L,1681L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232206Inst : IEnumerable<long>
{
public static readonly long[] Value=A232206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232206.Bytes);
public long this[int i]=>Value[i];

public static A232206Inst Instance=new A232206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232207
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,13L,29L,48L,114L,301L,579L,1462L,4198L,9295L,24184L,73489L,179879L,488616L,1540939L,4086226L,11540851L,37515163L,106101932L,311122047L,1037973223L,3097496100L,9407708340L,32130072122L,100356356885L,314999307749L,1099302983248L,3571869566808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232207Inst : IEnumerable<long>
{
public static readonly long[] Value=A232207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232207.Bytes);
public long this[int i]=>Value[i];

public static A232207Inst Instance=new A232207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232256
{
public static readonly BigInteger[] Value={ 272417L,379188715L,526801789327L,736185965972615L,1028773221352198121L,BigInteger.Parse("1437630006838652764923"),BigInteger.Parse("2008977605538697290717011"),BigInteger.Parse("2807392800304444226523889915"),BigInteger.Parse("3923117101757165454921811549965") };
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
public class A232256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232256Inst Instance=new A232256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232257
{
public static readonly long[] Value={ 9L,37L,37L,215L,421L,163L,1287L,6189L,4711L,723L,7673L,96999L,175431L,52779L,3209L,45709L,1532151L,7258599L,4987471L,591181L,14245L,272417L,24091773L,304291873L,544777651L,141815403L,6622029L,63235L,1623601L,379188715L,12652519297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232257Inst : IEnumerable<long>
{
public static readonly long[] Value=A232257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232257.Bytes);
public long this[int i]=>Value[i];

public static A232257Inst Instance=new A232257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232258
{
public static readonly long[] Value={ 9L,37L,215L,1287L,7673L,45709L,272417L,1623601L,9676571L,57671897L,343721665L,2048564473L,12209345763L,72767112987L,433688490081L,2584762523789L,15405060215819L,91813417313133L,547203547448227L,3261306801365497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232258Inst : IEnumerable<long>
{
public static readonly long[] Value=A232258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232258.Bytes);
public long this[int i]=>Value[i];

public static A232258Inst Instance=new A232258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232259
{
public static readonly BigInteger[] Value={ 37L,421L,6189L,96999L,1532151L,24091773L,379188715L,5968365535L,93937508717L,1478515964441L,23270869263099L,366268254468541L,5764822631732253L,90734534111164597L,1428102170660550681L,BigInteger.Parse("22477393302841813171") };
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
public class A232259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232259Inst Instance=new A232259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232260
{
public static readonly BigInteger[] Value={ 163L,4711L,175431L,7258599L,304291873L,12652519297L,526801789327L,21934670001645L,913277468672577L,38025499509371263L,1583240469955789117L,BigInteger.Parse("65920270839189410847"),BigInteger.Parse("2744676006495753336981"),BigInteger.Parse("114278144013102793338431") };
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
public class A232260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232260Inst Instance=new A232260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232261
{
public static readonly BigInteger[] Value={ 723L,52779L,4987471L,544777651L,60698037193L,6678855359891L,736185965972615L,81157499885585233L,8946595022473277457L,BigInteger.Parse("986241983067967479191"),BigInteger.Parse("108719927841904034425147"),BigInteger.Parse("11984921734705824859993765") };
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
public class A232261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232261Inst Instance=new A232261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232262
{
public static readonly BigInteger[] Value={ 3209L,591181L,141815403L,40896843985L,12109668893083L,3525883938158361L,1028773221352198121L,BigInteger.Parse("300257692620940074459"),BigInteger.Parse("87630614228503641330187"),BigInteger.Parse("25574534124528893439716193"),BigInteger.Parse("7463801896068471338516369509") };
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
public class A232262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232262Inst Instance=new A232262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232263
{
public static readonly BigInteger[] Value={ 14245L,6622029L,4032714105L,3070212041183L,2416017612073105L,1861384207351560027L,BigInteger.Parse("1437630006838652764923"),BigInteger.Parse("1110849590415358455178169"),BigInteger.Parse("858320162004849610044349969"),BigInteger.Parse("663171459536775469204769938307") };
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
public class A232263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232263Inst Instance=new A232263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232264
{
public static readonly BigInteger[] Value={ 63235L,74175439L,114676900023L,230487644229167L,482023848904207049L,BigInteger.Parse("982662236299437938725"),BigInteger.Parse("2008977605538697290717011"),BigInteger.Parse("4109772937808323696090366149"),BigInteger.Parse("8407091606181191851456912746227") };
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
public class A232264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232264Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232264.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232264Inst Instance=new A232264Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232265
{
public static readonly BigInteger[] Value={ 1L,10L,135L,2100L,35475L,632502L,11714745L,223198440L,4346520750L,86128357150L,1731030945644L,35202562937100L,723029038312230L,14976976398326250L,312522428615310000L,6563314391270476752L,BigInteger.Parse("138617681440915119975"),BigInteger.Parse("2942332729799060033100"),BigInteger.Parse("62735156704285184848950") };
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
public class A232265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232265Inst Instance=new A232265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232266
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,11L,7L,3L,1L,124L,88L,30L,5L,1L,2870L,2024L,710L,124L,11L,1L,133462L,94137L,33033L,5767L,502L,22L,1L,12477207L,8800750L,3088365L,539192L,46832L,2024L,43L,1L,2344649612L,1653790807L,580347968L,101321507L,8800750L,380315L,8176L,88L,1L,885591183971L,624648802700L,219201637352L,38269865019L,3324109524L,143647802L,3088365L,33033L,175L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232266Inst : IEnumerable<long>
{
public static readonly long[] Value=A232266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232266.Bytes);
public long this[int i]=>Value[i];

public static A232266Inst Instance=new A232266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232267
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,10L,3L,21L,8L,0L,15L,55L,6L,78L,35L,15L,0L,136L,27L,171L,10L,42L,99L,253L,10L,0L,143L,81L,42L,406L,15L,465L,64L,88L,255L,35L,0L,666L,323L,91L,3L,820L,21L,903L,55L,66L,483L,1081L,48L,0L,125L,85L,39L,1378L,81L,165L,28L,76L,783L,1711L,15L,1830L,899L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232267Inst : IEnumerable<long>
{
public static readonly long[] Value=A232267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232267.Bytes);
public long this[int i]=>Value[i];

public static A232267Inst Instance=new A232267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232268
{
public static readonly long[] Value={ 1L,3L,4L,6L,10L,19L,28L,30L,31L,40L,60L,63L,64L,66L,87L,88L,93L,96L,100L,129L,132L,135L,138L,141L,144L,184L,190L,274L,279L,280L,283L,285L,292L,294L,297L,300L,303L,310L,393L,399L,400L,402L,433L,436L,439L,589L,597L,598L,600L,612L,616L,621L,628L,630L,639L,640L,642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232268Inst : IEnumerable<long>
{
public static readonly long[] Value=A232268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232268.Bytes);
public long this[int i]=>Value[i];

public static A232268Inst Instance=new A232268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232269
{
public static readonly long[] Value={ 1L,3L,1L,2L,3L,2L,1L,6L,4L,1L,4L,6L,3L,8L,1L,1L,6L,1L,1L,9L,2L,4L,5L,3L,1L,2L,7L,4L,5L,8L,1L,12L,4L,4L,12L,3L,4L,9L,10L,1L,5L,9L,5L,11L,7L,4L,9L,2L,4L,19L,1L,1L,14L,4L,6L,16L,8L,5L,8L,7L,2L,11L,8L,1L,16L,3L,5L,9L,4L,3L,8L,8L,6L,16L,4L,3L,12L,13L,5L,11L,5L,3L,10L,10L,7L,12L,7L,4L,17L,20L,1L,17L,5L,6L,15L,4L,5L,18L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232269Inst : IEnumerable<long>
{
public static readonly long[] Value=A232269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232269.Bytes);
public long this[int i]=>Value[i];

public static A232269Inst Instance=new A232269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232270
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,2L,2L,2L,5L,3L,3L,2L,3L,3L,3L,2L,3L,4L,3L,1L,2L,3L,4L,2L,2L,3L,3L,3L,6L,3L,3L,4L,5L,5L,4L,2L,2L,4L,5L,3L,5L,3L,3L,2L,4L,2L,6L,5L,2L,6L,3L,6L,5L,2L,6L,5L,4L,4L,6L,3L,1L,5L,4L,6L,6L,2L,8L,6L,5L,4L,5L,3L,5L,4L,6L,2L,3L,8L,3L,5L,6L,4L,5L,4L,3L,5L,3L,4L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232270Inst : IEnumerable<long>
{
public static readonly long[] Value=A232270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232270.Bytes);
public long this[int i]=>Value[i];

public static A232270Inst Instance=new A232270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232271
{
public static readonly long[] Value={ 1L,1L,2L,4L,3L,6L,7L,1L,8L,10L,11L,6L,13L,7L,15L,16L,9L,12L,30L,10L,14L,11L,23L,24L,25L,4L,27L,28L,29L,-11L,31L,16L,22L,34L,21L,36L,37L,19L,39L,40L,41L,42L,43L,44L,45L,23L,47L,8L,49L,25L,51L,52L,53L,27L,34L,-1L,38L,29L,59L,60L,61L,31L,63L,64L,65L,66L,67L,34L,307L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232271Inst : IEnumerable<long>
{
public static readonly long[] Value=A232271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232271.Bytes);
public long this[int i]=>Value[i];

public static A232271Inst Instance=new A232271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232752
{
public static readonly long[] Value={ 0L,1L,3L,2L,12L,5L,7L,4L,114L,16L,26L,8L,45L,10L,18L,6L,7562L,127L,191L,21L,462L,32L,56L,11L,1285L,53L,83L,14L,236L,23L,35L,9L,29172079L,7677L,9314L,141L,20528L,208L,312L,27L,115291L,489L,679L,39L,1943L,65L,98L,15L,865555L,1331L,1751L,62L,4111L,94L,150L,19L,30983L,255L,369L,29L,802L,42L,69L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232752Inst : IEnumerable<long>
{
public static readonly long[] Value=A232752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232752.Bytes);
public long this[int i]=>Value[i];

public static A232752Inst Instance=new A232752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232753
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232753Inst : IEnumerable<long>
{
public static readonly long[] Value=A232753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232753.Bytes);
public long this[int i]=>Value[i];

public static A232753Inst Instance=new A232753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232754
{
public static readonly long[] Value={ 86L,561L,2799L,11642L,42136L,135738L,398282L,1080962L,2742442L,6562552L,14924881L,32441051L,67731876L,136394979L,265881588L,503206400L,927099641L,1666476136L,2928247968L,5038451724L,8502451244L,14091189678L,22963981249L,36840064368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232754Inst : IEnumerable<long>
{
public static readonly long[] Value=A232754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232754.Bytes);
public long this[int i]=>Value[i];

public static A232754Inst Instance=new A232754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232755
{
public static readonly long[] Value={ 561L,14229L,268376L,3995189L,49913678L,534194881L,5028662366L,42441753755L,325352545067L,2290263041978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232755Inst : IEnumerable<long>
{
public static readonly long[] Value=A232755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232755.Bytes);
public long this[int i]=>Value[i];

public static A232755Inst Instance=new A232755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232756
{
public static readonly long[] Value={ 86L,561L,561L,2799L,14229L,2799L,11642L,268376L,268376L,11642L,42136L,3995189L,21120269L,3995189L,42136L,135738L,49913678L,1275396109L,1275396109L,49913678L,135738L,398282L,534194881L,63029738888L,318928128419L,63029738888L,534194881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232756Inst : IEnumerable<long>
{
public static readonly long[] Value=A232756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232756.Bytes);
public long this[int i]=>Value[i];

public static A232756Inst Instance=new A232756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232757
{
public static readonly BigInteger[] Value={ 1L,23L,997L,44855L,2023309L,91286913L,4118731453L,185831471351L,8384460804153L,378295365602127L,17068167803123941L,770092310699262519L,BigInteger.Parse("34745508355302417387"),BigInteger.Parse("1567669659985973646979"),BigInteger.Parse("70731103937531908893003"),BigInteger.Parse("3191290354032154992708783"),BigInteger.Parse("143986641757115568305530757") };
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
public class A232757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232757Inst Instance=new A232757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232758
{
public static readonly BigInteger[] Value={ 1L,454L,800290L,1601437357L,3241461223149L,6567785027546670L,13308739956169022829UL,BigInteger.Parse("26968602201880345700924"),BigInteger.Parse("54648749693738816337819872"),BigInteger.Parse("110739369582262512718466467943"),BigInteger.Parse("224400523235840773380469046439552"),BigInteger.Parse("454721704049686545819883721501971896") };
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
public class A232758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232758Inst Instance=new A232758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232759
{
public static readonly BigInteger[] Value={ 1L,9157L,657253434L,58480141962875L,5316709999497259059L,BigInteger.Parse("484393789403397886429249"),BigInteger.Parse("44141190389848159904786733934"),BigInteger.Parse("4022519784390988451174562198889336"),BigInteger.Parse("366566828291367228800261059891047626895"),BigInteger.Parse("33404748935117787113145811582089363383972226") };
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
public class A232759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232759Inst Instance=new A232759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232760
{
public static readonly long[] Value={ 86L,561L,2834L,11863L,42958L,138943L,407544L,1105315L,2802289L,6705803L,15253456L,33149048L,69203489L,139365681L,271624913L,513974476L,946613483L,1700901689L,2987599393L,5138621445L,8668817851L,14363420954L,23402083437L,37534342033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232760Inst : IEnumerable<long>
{
public static readonly long[] Value=A232760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232760.Bytes);
public long this[int i]=>Value[i];

public static A232760Inst Instance=new A232760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232761
{
public static readonly long[] Value={ 561L,14178L,272646L,4107458L,50948495L,542603388L,5073736773L,42351563420L,320412472035L,2223547835774L,14281327683414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232761Inst : IEnumerable<long>
{
public static readonly long[] Value=A232761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232761.Bytes);
public long this[int i]=>Value[i];

public static A232761Inst Instance=new A232761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232762
{
public static readonly long[] Value={ 2834L,272646L,21416968L,1310062990L,64405241459L,2666649336535L,95402269790999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232762Inst : IEnumerable<long>
{
public static readonly long[] Value=A232762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232762.Bytes);
public long this[int i]=>Value[i];

public static A232762Inst Instance=new A232762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232763
{
public static readonly long[] Value={ 86L,561L,561L,2834L,14178L,2834L,11863L,272646L,272646L,11863L,42958L,4107458L,21416968L,4107458L,42958L,138943L,50948495L,1310062990L,1310062990L,50948495L,138943L,407544L,542603388L,64405241459L,337676326496L,64405241459L,542603388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232763Inst : IEnumerable<long>
{
public static readonly long[] Value=A232763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232763.Bytes);
public long this[int i]=>Value[i];

public static A232763Inst Instance=new A232763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232764
{
public static readonly long[] Value={ 11L,31L,53L,101L,110L,131L,149L,159L,169L,189L,223L,231L,243L,249L,283L,297L,301L,310L,311L,313L,327L,331L,361L,381L,397L,429L,437L,453L,463L,503L,513L,530L,533L,561L,627L,641L,651L,657L,691L,779L,813L,861L,937L,941L,951L,961L,973L,1001L,1010L,1031L,1049L,1059L,1069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232764Inst : IEnumerable<long>
{
public static readonly long[] Value=A232764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232764.Bytes);
public long this[int i]=>Value[i];

public static A232764Inst Instance=new A232764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232765
{
public static readonly long[] Value={ 0L,1L,4L,9L,28L,73L,144L,409L,1036L,2025L,5716L,14449L,28224L,79633L,201268L,393129L,1109164L,2803321L,5475600L,15448681L,39045244L,76265289L,215172388L,543830113L,1062238464L,2996964769L,7574576356L,14795073225L,41742334396L,105500238889L,206068786704L,581395716793L,1469428768108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232765Inst : IEnumerable<long>
{
public static readonly long[] Value=A232765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232765.Bytes);
public long this[int i]=>Value[i];

public static A232765Inst Instance=new A232765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232766
{
public static readonly long[] Value={ 28L,32L,44L,50L,55L,58L,97L,100L,107L,112L,130L,149L,152L,154L,179L,193L,208L,233L,259L,265L,271L,287L,310L,314L,320L,326L,341L,359L,365L,376L,404L,413L,421L,439L,449L,455L,457L,466L,469L,491L,499L,536L,538L,545L,547L,548L,557L,565L,568L,574L,593L,614L,616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232766Inst : IEnumerable<long>
{
public static readonly long[] Value=A232766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232766.Bytes);
public long this[int i]=>Value[i];

public static A232766Inst Instance=new A232766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232767
{
public static readonly long[] Value={ 97L,107L,149L,179L,193L,233L,271L,359L,421L,439L,449L,457L,491L,499L,547L,557L,593L,673L,677L,701L,769L,821L,839L,947L,971L,1019L,1021L,1051L,1069L,1087L,1091L,1093L,1103L,1117L,1163L,1297L,1301L,1307L,1327L,1399L,1409L,1439L,1453L,1483L,1493L,1579L,1597L,1609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232767Inst : IEnumerable<long>
{
public static readonly long[] Value=A232767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232767.Bytes);
public long this[int i]=>Value[i];

public static A232767Inst Instance=new A232767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232816
{
public static readonly long[] Value={ 4L,1L,8L,8L,0L,7L,7L,9L,4L,8L,6L,2L,3L,1L,3L,8L,1L,2L,8L,7L,2L,5L,5L,9L,7L,2L,0L,5L,9L,3L,6L,6L,8L,8L,1L,1L,9L,4L,4L,0L,5L,2L,7L,5L,8L,8L,7L,0L,4L,3L,4L,9L,6L,8L,6L,2L,1L,2L,8L,3L,0L,5L,7L,4L,3L,1L,7L,8L,2L,3L,9L,8L,3L,2L,7L,7L,8L,7L,2L,3L,9L,4L,2L,9L,5L,1L,8L,6L,8L,5L,8L,9L,7L,9L,0L,0L,8L,7L,3L,2L,1L,4L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232816Inst : IEnumerable<long>
{
public static readonly long[] Value=A232816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232816.Bytes);
public long this[int i]=>Value[i];

public static A232816Inst Instance=new A232816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232817
{
public static readonly long[] Value={ 3L,6L,9L,0L,5L,4L,0L,2L,9L,7L,2L,8L,8L,0L,5L,6L,8L,3L,8L,1L,9L,3L,6L,0L,7L,7L,5L,9L,1L,7L,7L,9L,7L,6L,0L,5L,3L,5L,6L,0L,0L,7L,2L,5L,3L,2L,4L,3L,1L,9L,0L,3L,3L,2L,5L,4L,5L,1L,0L,1L,7L,9L,4L,6L,6L,6L,9L,5L,3L,5L,8L,8L,7L,6L,7L,5L,1L,9L,9L,3L,0L,1L,3L,1L,0L,6L,1L,8L,9L,5L,7L,2L,7L,7L,3L,8L,7L,5L,6L,9L,3L,6L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232817Inst : IEnumerable<long>
{
public static readonly long[] Value=A232817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232817.Bytes);
public long this[int i]=>Value[i];

public static A232817Inst Instance=new A232817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232818
{
public static readonly long[] Value={ 1L,6L,4L,216L,198L,36L,23040L,24640L,7200L,576L,5400000L,6375000L,2362500L,328800L,14400L,2351462400L,2982873600L,1285956000L,238533120L,19051200L,518400L,1707698764800L,2291162509440L,1100516981760L,245735819280L,27025656000L,1383117120L,25401600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232818Inst : IEnumerable<long>
{
public static readonly long[] Value=A232818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232818.Bytes);
public long this[int i]=>Value[i];

public static A232818Inst Instance=new A232818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232819
{
public static readonly BigInteger[] Value={ 1L,0L,-144L,-2568L,-28200L,0L,15203328L,675195936L,16696909080L,0L,-25789252433472L,-1612260342054360L,-54804262577596532L,0L,BigInteger.Parse("161017938434267136000"),BigInteger.Parse("13718166932451951573120"),BigInteger.Parse("621130358284578576358416"),0L,BigInteger.Parse("-3008072527724272784969384000"),BigInteger.Parse("-320196271193421334219630013080") };
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
public class A232819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232819Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232819.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232819Inst Instance=new A232819Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232820
{
public static readonly BigInteger[] Value={ 1L,18L,144L,0L,-28200L,-814968L,-15203328L,0L,16696909080L,893794451000L,25789252433472L,0L,-54804262577596532L,-4044941639317807200L,BigInteger.Parse("-161017938434267136000"),0L,BigInteger.Parse("621130358284578576358416"),BigInteger.Parse("59512584052525004199214632"),BigInteger.Parse("3008072527724272784969384000"),0L };
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
public class A232820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232820Inst Instance=new A232820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232821
{
public static readonly BigInteger[] Value={ 1L,1L,6L,52L,549L,7075L,109172L,1971026L,40823443L,954730001L,24892154602L,716025676088L,22528094057193L,769646697066375L,28375143175948712L,1122910795732014438L,BigInteger.Parse("47478259662185188967"),BigInteger.Parse("2136067435649547983973"),BigInteger.Parse("101891594614083396452878") };
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
public class A232821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232821Inst Instance=new A232821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232822
{
public static readonly long[] Value={ 2L,191L,12599173L,53029063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232822Inst : IEnumerable<long>
{
public static readonly long[] Value=A232822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232822.Bytes);
public long this[int i]=>Value[i];

public static A232822Inst Instance=new A232822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232823
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,15L,16L,20L,24L,28L,30L,32L,37L,39L,40L,45L,48L,60L,64L,80L,90L,96L,100L,104L,120L,133L,160L,168L,174L,180L,205L,211L,240L,247L,320L,360L,456L,480L,512L,540L,560L,563L,580L,676L,692L,735L,820L,864L,930L,960L,1215L,1216L,1368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232823Inst : IEnumerable<long>
{
public static readonly long[] Value=A232823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232823.Bytes);
public long this[int i]=>Value[i];

public static A232823Inst Instance=new A232823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232824
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,23L,29L,37L,47L,53L,71L,89L,107L,113L,131L,157L,167L,173L,197L,223L,281L,311L,409L,463L,503L,541L,569L,659L,751L,941L,997L,1033L,1069L,1259L,1297L,1511L,1567L,2129L,2423L,3221L,3413L,3671L,3907L,4057L,4091L,4231L,5051L,5197L,5569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232824Inst : IEnumerable<long>
{
public static readonly long[] Value=A232824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232824.Bytes);
public long this[int i]=>Value[i];

public static A232824Inst Instance=new A232824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232825
{
public static readonly long[] Value={ 7L,14L,23L,36L,54L,76L,104L,138L,179L,227L,283L,349L,423L,507L,602L,707L,823L,953L,1097L,1253L,1424L,1611L,1812L,2028L,2261L,2512L,2780L,3068L,3377L,3703L,4049L,4418L,4808L,5220L,5656L,6117L,6600L,7108L,7641L,8199L,8785L,9398L,10041L,10711L,11411L,12142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232825Inst : IEnumerable<long>
{
public static readonly long[] Value=A232825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232825.Bytes);
public long this[int i]=>Value[i];

public static A232825Inst Instance=new A232825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232826
{
public static readonly long[] Value={ 14L,48L,128L,316L,760L,1736L,3843L,8263L,17414L,36175L,74367L,151657L,307760L,622363L,1252908L,2517273L,5054285L,10135115L,20312547L,40696305L,81494762L,163130913L,326436190L,653032643L,1306255533L,2613178341L,5226868694L,10452686889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232826Inst : IEnumerable<long>
{
public static readonly long[] Value=A232826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232826.Bytes);
public long this[int i]=>Value[i];

public static A232826Inst Instance=new A232826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232827
{
public static readonly long[] Value={ 23L,128L,578L,2329L,8898L,32279L,111609L,367415L,1156446L,3507097L,10298283L,29408921L,81999117L,223720287L,598317070L,1572579642L,4069639443L,10383180004L,26154898488L,65117553622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232827Inst : IEnumerable<long>
{
public static readonly long[] Value=A232827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232827.Bytes);
public long this[int i]=>Value[i];

public static A232827Inst Instance=new A232827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232828
{
public static readonly long[] Value={ 36L,316L,2329L,16684L,111870L,706823L,4251357L,24298903L,132106886L,687220332L,3437408202L,16607221811L,77820433157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232828Inst : IEnumerable<long>
{
public static readonly long[] Value=A232828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232828.Bytes);
public long this[int i]=>Value[i];

public static A232828Inst Instance=new A232828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232829
{
public static readonly long[] Value={ 54L,760L,8898L,111870L,1366233L,15664761L,170427953L,1758001316L,17221574143L,160878299711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232829Inst : IEnumerable<long>
{
public static readonly long[] Value=A232829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232829.Bytes);
public long this[int i]=>Value[i];

public static A232829Inst Instance=new A232829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232830
{
public static readonly long[] Value={ 76L,1736L,32279L,706823L,15664761L,330749381L,6633342932L,126048354885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232830Inst : IEnumerable<long>
{
public static readonly long[] Value=A232830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232830.Bytes);
public long this[int i]=>Value[i];

public static A232830Inst Instance=new A232830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232831
{
public static readonly long[] Value={ 7L,14L,14L,23L,48L,23L,36L,128L,128L,36L,54L,316L,578L,316L,54L,76L,760L,2329L,2329L,760L,76L,104L,1736L,8898L,16684L,8898L,1736L,104L,138L,3843L,32279L,111870L,111870L,32279L,3843L,138L,179L,8263L,111609L,706823L,1366233L,706823L,111609L,8263L,179L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232831Inst : IEnumerable<long>
{
public static readonly long[] Value=A232831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232831.Bytes);
public long this[int i]=>Value[i];

public static A232831Inst Instance=new A232831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232928
{
public static readonly long[] Value={ 2L,3L,2L,5L,3L,5L,2L,3L,2L,7L,2L,3L,7L,5L,3L,5L,2L,11L,5L,7L,5L,13L,2L,5L,2L,5L,2L,11L,3L,5L,5L,3L,3L,7L,2L,3L,7L,11L,3L,11L,3L,7L,7L,5L,5L,13L,3L,3L,5L,5L,2L,5L,3L,11L,5L,3L,2L,13L,2L,3L,5L,5L,3L,7L,2L,5L,5L,19L,7L,13L,5L,5L,7L,7L,3L,7L,3L,11L,2L,5L,2L,13L,3L,3L,5L,7L,3L,11L,3L,5L,11L,5L,7L,13L,5L,3L,5L,11L,2L,7L,3L,11L,13L,3L,2L,7L,3L,7L,11L,11L,3L,13L,7L,7L,7L,11L,11L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232928Inst : IEnumerable<long>
{
public static readonly long[] Value=A232928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232928.Bytes);
public long this[int i]=>Value[i];

public static A232928Inst Instance=new A232928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232929
{
public static readonly long[] Value={ 2L,3L,6L,5L,11L,11L,10L,9L,18L,17L,22L,15L,19L,23L,31L,25L,34L,29L,25L,31L,45L,47L,38L,39L,34L,35L,54L,53L,63L,47L,41L,45L,47L,57L,70L,51L,51L,61L,79L,61L,84L,61L,51L,65L,93L,87L,83L,57L,71L,75L,102L,85L,79L,81L,73L,81L,114L,119L,118L,87L,85L,95L,97L,97L,130L,95L,89L,85L,143L,127L,151L,107L,83L,109L,119L,125L,155L,125L,106L,125L,162L,135L,133L,123L,113L,125L,181L,165L,147L,131L,139L,137L,147L,167L,193L,123L,121L,125L,198L,157L,203L,161L,123L,153L,210L,177L,216L,121L,151L,153L,225L,183L,179L,169L,159L,179L,201L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232929Inst : IEnumerable<long>
{
public static readonly long[] Value=A232929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232929.Bytes);
public long this[int i]=>Value[i];

public static A232929Inst Instance=new A232929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232930
{
public static readonly long[] Value={ 2L,3L,6L,0L,11L,8L,8L,0L,18L,5L,22L,0L,11L,12L,31L,0L,34L,17L,10L,0L,45L,20L,32L,0L,24L,17L,54L,0L,63L,24L,21L,0L,30L,20L,70L,0L,27L,22L,79L,0L,84L,27L,24L,0L,93L,20L,72L,0L,36L,33L,102L,0L,55L,38L,37L,0L,114L,27L,118L,0L,52L,48L,69L,0L,130L,47L,42L,0L,143L,40L,151L,0L,32L,55L,90L,0L,155L,52L,72L,0L,162L,33L,96L,0L,57L,56L,181L,0L,114L,63L,58L,0L,107L,40L,193L,0L,72L,48L,198L,0L,203L,78L,39L,0L,210L,60L,216L,0L,79L,60L,225L,0L,126L,85L,100L,0L,159L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232930Inst : IEnumerable<long>
{
public static readonly long[] Value=A232930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232930.Bytes);
public long this[int i]=>Value[i];

public static A232930Inst Instance=new A232930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232931
{
public static readonly long[] Value={ 2L,3L,5L,2L,3L,2L,7L,5L,2L,5L,2L,7L,3L,3L,2L,3L,5L,13L,2L,3L,2L,5L,7L,2L,2L,5L,3L,3L,2L,5L,2L,3L,11L,2L,3L,11L,7L,7L,2L,7L,3L,3L,2L,7L,2L,3L,11L,2L,3L,2L,5L,5L,2L,5L,2L,11L,3L,3L,5L,2L,7L,11L,2L,3L,2L,5L,7L,2L,2L,5L,3L,3L,2L,7L,3L,11L,2L,3L,7L,7L,5L,2L,5L,2L,13L,3L,3L,2L,2L,3L,2L,3L,2L,5L,5L,11L,2L,7L,5L,3L,3L,5L,2L,3L,13L,5L,2L,3L,2L,17L,2L,2L,7L,3L,3L,2L,13L,2L,5L,2L,3L,5L,7L,5L,2L,5L,2L,11L,3L,2L,5L,2L,3L,7L,2L,3L,2L,17L,5L,7L,2L,7L,2L,5L,3L,3L,7L,2L,3L,7L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232931Inst : IEnumerable<long>
{
public static readonly long[] Value=A232931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232931.Bytes);
public long this[int i]=>Value[i];

public static A232931Inst Instance=new A232931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232932
{
public static readonly long[] Value={ 2L,3L,3L,5L,2L,7L,2L,11L,5L,13L,3L,2L,7L,3L,2L,5L,2L,3L,3L,11L,2L,2L,5L,7L,3L,2L,13L,5L,3L,2L,7L,3L,11L,2L,11L,2L,7L,11L,7L,2L,3L,2L,5L,3L,2L,5L,3L,3L,5L,2L,11L,2L,13L,5L,5L,2L,5L,3L,2L,7L,2L,3L,2L,2L,5L,13L,2L,3L,2L,5L,17L,3L,2L,7L,3L,3L,5L,2L,13L,2L,7L,5L,19L,2L,3L,11L,3L,2L,5L,2L,3L,3L,7L,2L,5L,2L,5L,11L,5L,3L,2L,5L,3L,2L,11L,2L,3L,7L,2L,2L,11L,7L,3L,2L,5L,3L,2L,5L,3L,3L,2L,11L,2L,19L,5L,5L,2L,3L,2L,17L,3L,2L,7L,2L,3L,3L,13L,2L,5L,2L,5L,11L,7L,3L,2L,7L,3L,13L,2L,3L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232932Inst : IEnumerable<long>
{
public static readonly long[] Value=A232932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232932.Bytes);
public long this[int i]=>Value[i];

public static A232932Inst Instance=new A232932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232933
{
public static readonly long[] Value={ 1L,1L,0L,2L,3L,3L,12L,4L,8L,35L,45L,40L,144L,348L,132L,96L,910L,1862L,1316L,952L,5976L,11600L,14808L,5760L,2176L,39942L,100260L,123606L,63360L,35712L,306570L,919270L,1069910L,910650L,343040L,79360L,2698223L,8427243L,11694397L,10673641L,4477440L,1945856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232933Inst : IEnumerable<long>
{
public static readonly long[] Value=A232933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232933.Bytes);
public long this[int i]=>Value[i];

public static A232933Inst Instance=new A232933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232934
{
public static readonly BigInteger[] Value={ 3L,12L,84L,1048L,26644L,1294504L,123516664L,22870954236L,8259047739212L,5804528923256596L,7946219601520287416L,BigInteger.Parse("21181791025549725373140"),BigInteger.Parse("109959477313325884615593152"),BigInteger.Parse("1111595819289260873354274996460") };
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
public class A232934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232934Inst Instance=new A232934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232935
{
public static readonly long[] Value={ 6L,12L,26L,56L,120L,258L,554L,1190L,2556L,5490L,11792L,25328L,54402L,116850L,250982L,539084L,1157898L,2487048L,5341928L,11473922L,24644826L,52934598L,113698172L,244212194L,524543136L,1126665696L,2419964162L,5197838690L,11164432710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232935Inst : IEnumerable<long>
{
public static readonly long[] Value=A232935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232935.Bytes);
public long this[int i]=>Value[i];

public static A232935Inst Instance=new A232935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232936
{
public static readonly long[] Value={ 12L,26L,84L,252L,774L,2360L,7212L,22024L,67272L,205466L,627562L,1916768L,5854418L,17881234L,54614930L,166811210L,509494028L,1556155380L,4752989126L,14517127208L,44339883148L,135427981664L,413639750856L,1263386202642L,3858779756370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232936Inst : IEnumerable<long>
{
public static readonly long[] Value=A232936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232936.Bytes);
public long this[int i]=>Value[i];

public static A232936Inst Instance=new A232936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232937
{
public static readonly long[] Value={ 24L,56L,252L,1048L,4458L,18850L,79810L,337850L,1430144L,6054098L,25627862L,108487018L,459242866L,1944049234L,8229473620L,34836688334L,147469316688L,624261386538L,2642599067830L,11186547787492L,47354459831826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232937Inst : IEnumerable<long>
{
public static readonly long[] Value=A232937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232937.Bytes);
public long this[int i]=>Value[i];

public static A232937Inst Instance=new A232937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232938
{
public static readonly long[] Value={ 48L,120L,774L,4458L,26644L,157322L,932576L,5521380L,32701386L,193661452L,1146912480L,6792272698L,40225408560L,238224086698L,1410817796536L,8355186864526L,49481335558724L,293039831819072L,1735449179468938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232938Inst : IEnumerable<long>
{
public static readonly long[] Value=A232938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232938.Bytes);
public long this[int i]=>Value[i];

public static A232938Inst Instance=new A232938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232939
{
public static readonly long[] Value={ 96L,258L,2360L,18850L,157322L,1294504L,10700160L,88318190L,729295244L,6021446660L,49717871728L,410507714440L,3389459358490L,27985921958788L,231072754052826L,1907910019604876L,15753136243946376L,130069709821883698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232939Inst : IEnumerable<long>
{
public static readonly long[] Value=A232939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232939.Bytes);
public long this[int i]=>Value[i];

public static A232939Inst Instance=new A232939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232940
{
public static readonly long[] Value={ 192L,554L,7212L,79810L,932576L,10700160L,123516664L,1422959686L,16403819514L,189062126148L,2179181824046L,25117338039572L,289505052484974L,3336861029886146L,38460966820329646L,443304625973863734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232940Inst : IEnumerable<long>
{
public static readonly long[] Value=A232940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232940.Bytes);
public long this[int i]=>Value[i];

public static A232940Inst Instance=new A232940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232941
{
public static readonly long[] Value={ 3L,6L,6L,12L,12L,12L,24L,26L,26L,24L,48L,56L,84L,56L,48L,96L,120L,252L,252L,120L,96L,192L,258L,774L,1048L,774L,258L,192L,384L,554L,2360L,4458L,4458L,2360L,554L,384L,768L,1190L,7212L,18850L,26644L,18850L,7212L,1190L,768L,1536L,2556L,22024L,79810L,157322L,157322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232941Inst : IEnumerable<long>
{
public static readonly long[] Value=A232941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232941.Bytes);
public long this[int i]=>Value[i];

public static A232941Inst Instance=new A232941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232942
{
public static readonly BigInteger[] Value={ 1L,17L,1163L,328989L,389997789L,1950478851269L,41313911641960579L,BigInteger.Parse("3714942841397823613817"),BigInteger.Parse("1420295754221243029275852053"),BigInteger.Parse("2311198726771295243900465723816785") };
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
public class A232942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A232942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A232942Inst Instance=new A232942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A232943
{
public static readonly long[] Value={ 9L,99L,1163L,13707L,161621L,1905737L,22471303L,264968059L,3124343613L,36840376337L,434399508111L,5122177116787L,60397624596373L,712172377821369L,8397507337767063L,99018343990785067L,1167564617964899501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A232943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A232943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A232943Inst : IEnumerable<long>
{
public static readonly long[] Value=A232943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A232943.Bytes);
public long this[int i]=>Value[i];

public static A232943Inst Instance=new A232943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233024
{
public static readonly BigInteger[] Value={ 243L,12555L,959385L,75489671L,6050598339L,487651369463L,39386531523609L,3183658674622011L,257414773440925415L,BigInteger.Parse("20815582600558673815"),BigInteger.Parse("1683301058522200223439"),BigInteger.Parse("136126239210040751513149") };
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
public class A233024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233024Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233024.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233024Inst Instance=new A233024Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233025
{
public static readonly BigInteger[] Value={ 729L,67449L,9997413L,1546718177L,245698677999L,39386531523609L,6338787392715565L,1021854400935817069L,BigInteger.Parse("164848602838755709211"),BigInteger.Parse("26602184763154679609107"),BigInteger.Parse("4293469218556492461639273") };
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
public class A233025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233025Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A233025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233025.Bytes);
public BigInteger this[int i]=>Value[i];

public static A233025Inst Instance=new A233025Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233026
{
public static readonly long[] Value={ 1L,3L,3L,9L,15L,9L,27L,81L,81L,27L,81L,435L,849L,435L,81L,243L,2337L,8835L,8835L,2337L,243L,729L,12555L,92067L,179999L,92067L,12555L,729L,2187L,67449L,959385L,3685017L,3685017L,959385L,67449L,2187L,6561L,362355L,9997413L,75489671L,149128385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233026Inst : IEnumerable<long>
{
public static readonly long[] Value=A233026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233026.Bytes);
public long this[int i]=>Value[i];

public static A233026Inst Instance=new A233026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233027
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,4L,2L,6L,4L,6L,3L,8L,2L,7L,3L,4L,4L,7L,2L,7L,8L,3L,9L,15L,7L,14L,9L,10L,9L,15L,6L,15L,8L,16L,11L,17L,8L,23L,11L,15L,16L,23L,8L,23L,18L,18L,19L,31L,13L,27L,20L,19L,14L,31L,10L,36L,17L,24L,19L,39L,16L,39L,24L,22L,25L,33L,18L,47L,28L,31L,18L,47L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233027Inst : IEnumerable<long>
{
public static readonly long[] Value=A233027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233027.Bytes);
public long this[int i]=>Value[i];

public static A233027Inst Instance=new A233027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233028
{
public static readonly long[] Value={ 34L,96L,333L,912L,2874L,8070L,25028L,71492L,221072L,637090L,1967353L,5696300L,17569092L,51022742L,157190828L,457507314L,1408016908L,4105250676L,12622211969L,36855295684L,113218810762L,330996127114L,1016009702826L,2973522638274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233028Inst : IEnumerable<long>
{
public static readonly long[] Value=A233028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233028.Bytes);
public long this[int i]=>Value[i];

public static A233028Inst Instance=new A233028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233029
{
public static readonly long[] Value={ 96L,642L,3132L,16296L,77353L,337570L,1459711L,6131600L,25014797L,100647020L,399073108L,1561490768L,6050110218L,23239177456L,88590795541L,335553550058L,1263942149575L,4737487677280L,17680474805387L,65735112648424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233029Inst : IEnumerable<long>
{
public static readonly long[] Value=A233029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233029.Bytes);
public long this[int i]=>Value[i];

public static A233029Inst Instance=new A233029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233030
{
public static readonly long[] Value={ 333L,3132L,55642L,566933L,7169782L,74939353L,839537894L,8735284526L,93454206487L,969444236906L,10189585915899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233030Inst : IEnumerable<long>
{
public static readonly long[] Value=A233030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233030.Bytes);
public long this[int i]=>Value[i];

public static A233030Inst Instance=new A233030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233031
{
public static readonly long[] Value={ 34L,96L,96L,333L,642L,333L,912L,3132L,3132L,912L,2874L,16296L,55642L,16296L,2874L,8070L,77353L,566933L,566933L,77353L,8070L,25028L,337570L,7169782L,12724788L,7169782L,337570L,25028L,71492L,1459711L,74939353L,308492287L,308492287L,74939353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233031Inst : IEnumerable<long>
{
public static readonly long[] Value=A233031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233031.Bytes);
public long this[int i]=>Value[i];

public static A233031Inst Instance=new A233031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233032
{
public static readonly long[] Value={ 12L,23L,34L,45L,58L,69L,80L,91L,102L,112L,113L,123L,134L,145L,158L,169L,180L,191L,202L,213L,223L,224L,234L,245L,258L,269L,280L,291L,302L,313L,324L,334L,335L,345L,358L,369L,380L,391L,402L,413L,424L,435L,445L,458L,469L,480L,491L,502L,513L,524L,535L,546L,559L,569L,580L,591L,602L,613L,624L,635L,646L,659L,669L,670L,680L,691L,702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233032Inst : IEnumerable<long>
{
public static readonly long[] Value=A233032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233032.Bytes);
public long this[int i]=>Value[i];

public static A233032Inst Instance=new A233032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233033
{
public static readonly long[] Value={ 8L,5L,9L,2L,4L,7L,1L,5L,7L,9L,2L,8L,5L,9L,0L,6L,1L,5L,5L,3L,9L,9L,0L,9L,9L,3L,9L,4L,7L,5L,7L,5L,9L,9L,8L,0L,7L,1L,2L,8L,8L,4L,3L,5L,0L,8L,6L,0L,4L,1L,4L,9L,2L,6L,7L,6L,0L,5L,2L,0L,6L,8L,9L,7L,6L,6L,3L,8L,3L,4L,8L,1L,5L,3L,3L,4L,8L,9L,2L,3L,3L,0L,7L,1L,1L,3L,8L,8L,3L,8L,1L,5L,1L,8L,8L,4L,3L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233033Inst : IEnumerable<long>
{
public static readonly long[] Value=A233033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233033.Bytes);
public long this[int i]=>Value[i];

public static A233033Inst Instance=new A233033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233034
{
public static readonly long[] Value={ 1L,0L,-2L,4L,-1L,-8L,14L,-4L,-23L,40L,-10L,-60L,98L,-24L,-140L,224L,-54L,-304L,478L,-112L,-627L,968L,-224L,-1236L,1884L,-432L,-2346L,3540L,-801L,-4320L,6454L,-1448L,-7742L,11472L,-2556L,-13548L,19936L,-4408L,-23226L,33952L,-7462L,-39080L,56800L,-12416L,-64660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233034Inst : IEnumerable<long>
{
public static readonly long[] Value=A233034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233034.Bytes);
public long this[int i]=>Value[i];

public static A233034Inst Instance=new A233034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233035
{
public static readonly long[] Value={ 0L,0L,0L,4L,5L,6L,7L,16L,18L,20L,22L,36L,39L,42L,45L,64L,68L,72L,76L,100L,105L,110L,115L,144L,150L,156L,162L,196L,203L,210L,217L,256L,264L,272L,280L,324L,333L,342L,351L,400L,410L,420L,430L,484L,495L,506L,517L,576L,588L,600L,612L,676L,689L,702L,715L,784L,798L,812L,826L,900L,915L,930L,945L,1024L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233035Inst : IEnumerable<long>
{
public static readonly long[] Value=A233035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233035.Bytes);
public long this[int i]=>Value[i];

public static A233035Inst Instance=new A233035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233036
{
public static readonly long[] Value={ 0L,0L,0L,4L,6L,8L,12L,16L,20L,24L,30L,36L,42L,48L,56L,64L,72L,80L,90L,100L,110L,120L,132L,144L,156L,168L,182L,196L,210L,224L,240L,256L,272L,288L,306L,324L,342L,360L,380L,400L,420L,440L,462L,484L,506L,528L,552L,576L,600L,624L,650L,676L,702L,728L,756L,784L,812L,840L,870L,900L,930L,960L,992L,1024L,1056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233036Inst : IEnumerable<long>
{
public static readonly long[] Value=A233036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233036.Bytes);
public long this[int i]=>Value[i];

public static A233036Inst Instance=new A233036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233037
{
public static readonly long[] Value={ 1L,1L,-3L,1L,5L,-10L,4L,17L,-31L,9L,46L,-79L,21L,112L,-183L,46L,249L,-396L,98L,521L,-815L,193L,1041L,-1599L,373L,1998L,-3031L,696L,3708L,-5567L,1262L,6694L,-9955L,2233L,11788L,-17393L,3872L,20313L,-29771L,6572L,34342L,-50016L,10973L,57065L,-82654L,18030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233037Inst : IEnumerable<long>
{
public static readonly long[] Value=A233037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233037.Bytes);
public long this[int i]=>Value[i];

public static A233037Inst Instance=new A233037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233038
{
public static readonly long[] Value={ 88799L,284729L,626609L,6560999L,17843459L,42981929L,69156539L,124066079L,208729049L,615095849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233038Inst : IEnumerable<long>
{
public static readonly long[] Value=A233038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233038.Bytes);
public long this[int i]=>Value[i];

public static A233038Inst Instance=new A233038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233039
{
public static readonly long[] Value={ 28L,200L,224L,234L,270L,496L,496L,819L,936L,1488L,1638L,3724L,6200L,6200L,6860L,6975L,8128L,8128L,8128L,10976L,13104L,18600L,21600L,24384L,24384L,24800L,27000L,27000L,29792L,40131L,40640L,43008L,50274L,54000L,54400L,58032L,87750L,93100L,154791L,160524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233039Inst : IEnumerable<long>
{
public static readonly long[] Value=A233039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233039.Bytes);
public long this[int i]=>Value[i];

public static A233039Inst Instance=new A233039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A233168
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,3L,11L,8L,8L,11L,48L,64L,96L,64L,48L,236L,512L,1280L,1280L,512L,236L,1248L,4096L,18432L,28672L,18432L,4096L,1248L,6896L,32768L,278528L,720896L,720896L,278528L,32768L,6896L,39168L,262144L,4325376L,19922944L,31457280L,19922944L,4325376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A233168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A233168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A233168Inst : IEnumerable<long>
{
public static readonly long[] Value=A233168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A233168.Bytes);
public long this[int i]=>Value[i];

public static A233168Inst Instance=new A233168Inst();

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