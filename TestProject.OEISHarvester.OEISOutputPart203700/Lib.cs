using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286356
{
public static readonly long[] Value={ 0L,2L,5L,7L,9L,23L,14L,29L,12L,31L,20L,80L,27L,40L,31L,121L,35L,80L,44L,94L,40L,50L,54L,302L,18L,61L,38L,109L,65L,499L,77L,497L,50L,73L,40L,668L,90L,86L,61L,328L,104L,532L,119L,125L,94L,100L,135L,1178L,25L,94L,73L,142L,152L,302L,50L,355L,86L,115L,170L,1894L,189L,131L,109L,2017L,61L,566L,209L,160L,100L,532L,230L,2630L,252L,148L,94L,179L,50L,601L,275L,1228L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286356Inst : IEnumerable<long>
{
public static readonly long[] Value=A286356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286356.Bytes);
public long this[int i]=>Value[i];

public static A286356Inst Instance=new A286356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286357
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,3L,4L,1L,1L,2L,3L,3L,2L,4L,4L,1L,2L,1L,3L,2L,6L,3L,4L,3L,1L,2L,4L,4L,2L,4L,6L,1L,5L,2L,5L,1L,2L,3L,4L,2L,2L,6L,3L,3L,2L,4L,5L,3L,1L,1L,4L,2L,2L,4L,4L,4L,5L,2L,3L,4L,2L,6L,4L,1L,3L,5L,3L,2L,6L,5L,4L,1L,2L,2L,3L,3L,6L,4L,5L,2L,1L,2L,3L,6L,3L,3L,4L,3L,2L,2L,5L,4L,8L,5L,4L,3L,2L,1L,3L,1L,2L,4L,4L,2L,7L,2L,3L,4L,2L,4L,4L,4L,2L,5L,5L,2L,2L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286357Inst : IEnumerable<long>
{
public static readonly long[] Value=A286357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286357.Bytes);
public long this[int i]=>Value[i];

public static A286357Inst Instance=new A286357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286358
{
public static readonly long[] Value={ 1L,4L,6L,22L,8L,13L,10L,106L,79L,47L,13L,39L,30L,19L,19L,466L,47L,742L,24L,233L,21L,58L,19L,139L,466L,233L,32L,49L,122L,70L,21L,1954L,26L,380L,26L,4096L,192L,139L,49L,1037L,233L,34L,81L,256L,782L,70L,26L,531L,1597L,4279L,70L,1227L,380L,157L,70L,157L,41L,1037L,139L,280L,498L,34L,124L,8002L,256L,83L,174L,2018L,34L,83L,70L,18916L,705L,1655L,531L,669L,34L,280L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286358Inst : IEnumerable<long>
{
public static readonly long[] Value=A286358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286358.Bytes);
public long this[int i]=>Value[i];

public static A286358Inst Instance=new A286358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286391
{
public static readonly BigInteger[] Value={ 1L,1L,15L,344L,6835L,119392L,2136080L,38329669L,688355077L,12374676591L,222673114420L,4005005917279L,72004800735036L,1294444641691072L,23273376392535695L,418470613768822683L,7524342117053834729L,BigInteger.Parse("135288703461639048592"),BigInteger.Parse("2432489164334993344213") };
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
public class A286391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286391Inst Instance=new A286391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286392
{
public static readonly BigInteger[] Value={ 1L,6L,231L,1284066L,352654485156L,3553786240466361696L,BigInteger.Parse("1289303099816839265917858176"),BigInteger.Parse("16839193280515921004090301582258640896"),BigInteger.Parse("7917535832871659713272867459049024690729209839616") };
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
public class A286392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286392Inst Instance=new A286392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286393
{
public static readonly BigInteger[] Value={ 1L,7L,406L,5105212L,4154189102413L,BigInteger.Parse("167633579843887699759"),BigInteger.Parse("331466355732596931093508048522"),BigInteger.Parse("32115447190132359991237336502881651018804"),BigInteger.Parse("152470060954479462517322396167243320349298407119379801") };
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
public class A286393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286393Inst Instance=new A286393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286394
{
public static readonly BigInteger[] Value={ 1L,8L,666L,16912512L,35184646816768L,BigInteger.Parse("4722366500530551259136"),BigInteger.Parse("40564819207305653446303190876160"),BigInteger.Parse("22300745198530623151211847196048401987796992") };
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
public class A286394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286394Inst Instance=new A286394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286395
{
public static readonly long[] Value={ 1L,3L,7L,8L,9L,11L,15L,19L,29L,55L,76L,159L,266L,311L,394L,908L,1732L,1875L,4335L,6334L,7641L,16421L,33721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286395Inst : IEnumerable<long>
{
public static readonly long[] Value=A286395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286395.Bytes);
public long this[int i]=>Value[i];

public static A286395Inst Instance=new A286395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286396
{
public static readonly BigInteger[] Value={ 1L,9L,1035L,48700845L,231628411446741L,BigInteger.Parse("89737248564744874067889"),BigInteger.Parse("2816049943117424212512789695666175"),BigInteger.Parse("7158021121277935153545945911617993395398302485") };
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
public class A286396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286396Inst Instance=new A286396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286397
{
public static readonly BigInteger[] Value={ 1L,10L,1540L,125512750L,1250002537502500L,BigInteger.Parse("1250000000501250002500000"),BigInteger.Parse("125000000000000250375000000250000000"),BigInteger.Parse("1250000000000000000005001250000000002500000000000") };
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
public class A286397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286397Inst Instance=new A286397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286398
{
public static readonly BigInteger[] Value={ 1L,7L,143L,7429L,94395L,70514711L,68421139647L,3628781953225L,180465781280744001L,1051696554978819009L,2043771643161196817L,BigInteger.Parse("455757414124192757820663"),BigInteger.Parse("145129235359794615466069"),BigInteger.Parse("1358004768744860147421669766123"),BigInteger.Parse("9043798410819212324167588503127725") };
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
public class A286398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286398Inst Instance=new A286398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286399
{
public static readonly long[] Value={ 0L,0L,1L,8L,32L,96L,244L,528L,1024L,1856L,3126L,5016L,7808L,11616L,16808L,23856L,32768L,44352L,59293L,77352L,100032L,128128L,161052L,201264L,249856L,305280L,371294L,450128L,537856L,640992L,762744L,894528L,1048576L,1228224L,1419858L,1642080L,1897376L,2167008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286399Inst : IEnumerable<long>
{
public static readonly long[] Value=A286399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286399.Bytes);
public long this[int i]=>Value[i];

public static A286399Inst Instance=new A286399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286400
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286400Inst : IEnumerable<long>
{
public static readonly long[] Value=A286400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286400.Bytes);
public long this[int i]=>Value[i];

public static A286400Inst Instance=new A286400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286401
{
public static readonly long[] Value={ 1L,4L,7L,8L,10L,13L,15L,18L,19L,22L,25L,26L,28L,31L,32L,35L,37L,40L,43L,44L,46L,49L,51L,54L,55L,58L,60L,63L,66L,67L,69L,72L,73L,76L,79L,80L,82L,85L,87L,90L,91L,94L,97L,98L,100L,103L,104L,107L,109L,112L,115L,116L,118L,121L,122L,125L,128L,129L,131L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286401Inst : IEnumerable<long>
{
public static readonly long[] Value=A286401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286401.Bytes);
public long this[int i]=>Value[i];

public static A286401Inst Instance=new A286401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286402
{
public static readonly long[] Value={ 2L,3L,5L,6L,9L,11L,12L,14L,16L,17L,20L,21L,23L,24L,27L,29L,30L,33L,34L,36L,38L,39L,41L,42L,45L,47L,48L,50L,52L,53L,56L,57L,59L,61L,62L,64L,65L,68L,70L,71L,74L,75L,77L,78L,81L,83L,84L,86L,88L,89L,92L,93L,95L,96L,99L,101L,102L,105L,106L,108L,110L,111L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286402Inst : IEnumerable<long>
{
public static readonly long[] Value=A286402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286402.Bytes);
public long this[int i]=>Value[i];

public static A286402Inst Instance=new A286402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286403
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1110L,11L,111100L,11L,11111100L,110L,1111111111L,100L,111111111111L,0L,11111111111111L,0L,1111111111110011L,11110L,111111111111110011L,11100L,11111111111111101111UL,11000L,BigInteger.Parse("1111111111111111101111"),110000L,BigInteger.Parse("111111111111111111101111"),110000L };
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
public class A286403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286403Inst Instance=new A286403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286404
{
public static readonly BigInteger[] Value={ 1L,1L,0L,111L,11000L,1111L,1100000L,111111L,11000000L,1111111111L,100000000L,111111111111L,0L,11111111111111L,0L,1100111111111111L,1111000000000000L,110011111111111111L,11100000000000000L,11110111111111111111UL,110000000000000000L,BigInteger.Parse("1111011111111111111111") };
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
public class A286404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286404Inst Instance=new A286404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286405
{
public static readonly long[] Value={ 1L,2L,0L,14L,3L,60L,3L,252L,6L,1023L,4L,4095L,0L,16383L,0L,65523L,30L,262131L,28L,1048559L,24L,4194287L,48L,16777199L,48L,67108847L,48L,268435439L,0L,1073741767L,124L,4294967239L,188L,17179868939L,12L,68719476675L,502L,274877906591L,352L,1099511627295L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286405Inst : IEnumerable<long>
{
public static readonly long[] Value=A286405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286405.Bytes);
public long this[int i]=>Value[i];

public static A286405Inst Instance=new A286405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286406
{
public static readonly long[] Value={ 1L,1L,0L,7L,24L,15L,96L,63L,192L,1023L,256L,4095L,0L,16383L,0L,53247L,61440L,212991L,114688L,1015807L,196608L,4063231L,393216L,16252927L,1572864L,65011711L,6291456L,260046847L,0L,956301311L,520093696L,3825205247L,2046820352L,14025752575L,6442450944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286406Inst : IEnumerable<long>
{
public static readonly long[] Value=A286406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286406.Bytes);
public long this[int i]=>Value[i];

public static A286406Inst Instance=new A286406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286455
{
public static readonly long[] Value={ 0L,2L,8L,2L,18L,11L,40L,2L,8L,22L,71L,11L,97L,46L,30L,2L,143L,11L,179L,22L,93L,92L,262L,11L,18L,121L,8L,46L,335L,154L,417L,2L,212L,211L,69L,11L,540L,254L,302L,22L,679L,326L,794L,92L,30L,379L,918L,11L,40L,22L,467L,121L,1051L,11L,234L,46L,530L,529L,1242L,154L,1344L,631L,93L,2L,744L,704L,1615L,211L,822L,326L,1790L,11L,1912L,904L,30L,254L,140L,947L,2167L,22L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286455Inst : IEnumerable<long>
{
public static readonly long[] Value=A286455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286455.Bytes);
public long this[int i]=>Value[i];

public static A286455Inst Instance=new A286455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286456
{
public static readonly long[] Value={ 0L,1L,5L,5L,13L,18L,25L,13L,19L,40L,41L,40L,61L,71L,41L,25L,85L,41L,113L,83L,72L,111L,145L,71L,42L,160L,42L,142L,181L,84L,221L,41L,112L,218L,73L,72L,265L,285L,161L,142L,313L,143L,365L,217L,85L,361L,421L,111L,74L,85L,219L,308L,481L,73L,113L,238L,286L,446L,545L,143L,613L,540L,144L,61L,162L,218L,685L,415L,362L,144L,761L,112L,841L,643L,86L,538L,114L,309L,925L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286456Inst : IEnumerable<long>
{
public static readonly long[] Value=A286456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286456.Bytes);
public long this[int i]=>Value[i];

public static A286456Inst Instance=new A286456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286457
{
public static readonly long[] Value={ 0L,1L,1L,5L,1L,13L,1L,25L,5L,41L,1L,61L,1L,85L,13L,113L,1L,145L,1L,181L,32L,221L,1L,265L,5L,313L,33L,365L,1L,421L,1L,481L,72L,545L,13L,613L,1L,685L,143L,761L,1L,841L,1L,925L,86L,1013L,1L,1105L,5L,1201L,219L,1301L,1L,1405L,32L,1513L,335L,1625L,1L,1741L,1L,1861L,201L,1985L,60L,2113L,1L,2245L,447L,2381L,1L,2521L,1L,2665L,223L,2813L,13L,2965L,1L,3121L,224L,3281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286457Inst : IEnumerable<long>
{
public static readonly long[] Value=A286457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286457.Bytes);
public long this[int i]=>Value[i];

public static A286457Inst Instance=new A286457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286458
{
public static readonly long[] Value={ 1L,1L,2L,3L,13L,25L,24L,15L,61L,5L,85L,113L,112L,64L,87L,55L,201L,243L,242L,313L,204L,393L,451L,513L,137L,22L,613L,250L,723L,651L,842L,276L,67L,844L,196L,1015L,1107L,657L,196L,1253L,1355L,1020L,1407L,559L,812L,795L,1744L,1864L,833L,2051L,1062L,101L,2181L,1363L,2384L,2524L,597L,2741L,2891L,3045L,3203L,1935L,1756L,1081L,1249L,1938L,3703L,1534L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286458Inst : IEnumerable<long>
{
public static readonly long[] Value=A286458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286458.Bytes);
public long this[int i]=>Value[i];

public static A286458Inst Instance=new A286458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286459
{
public static readonly long[] Value={ 1L,1L,2L,13L,3L,24L,85L,25L,112L,201L,5L,242L,61L,15L,451L,723L,64L,87L,842L,393L,1107L,1355L,113L,1407L,137L,22L,1744L,204L,844L,2181L,2891L,313L,67L,3203L,657L,3703L,4056L,243L,196L,4424L,55L,4908L,196L,795L,5521L,2384L,2741L,1062L,6507L,250L,7574L,8460L,651L,8590L,9122L,1935L,9393L,597L,559L,1249L,833L,1507L,613L,9391L,4155L,12492L,5949L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286459Inst : IEnumerable<long>
{
public static readonly long[] Value=A286459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286459.Bytes);
public long this[int i]=>Value[i];

public static A286459Inst Instance=new A286459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286460
{
public static readonly long[] Value={ 1L,8L,7L,39L,16L,80L,29L,157L,79L,173L,67L,438L,92L,302L,277L,600L,154L,782L,191L,949L,497L,668L,277L,1957L,466L,905L,781L,1656L,436L,2630L,497L,2284L,1129L,1487L,1129L,4281L,704L,1832L,1541L,4282L,862L,4658L,947L,3658L,3004L,2630L,1129L,8133L,1597L,4373L,2557L,4953L,1432L,7262L,2557L,7507L,3161L,4097L,1771L,14368L,1892L,4658L,5357L,8785L,3487L,10442L,2279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286460Inst : IEnumerable<long>
{
public static readonly long[] Value=A286460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286460.Bytes);
public long this[int i]=>Value[i];

public static A286460Inst Instance=new A286460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286461
{
public static readonly long[] Value={ 1L,5L,4L,9L,22L,5L,4L,32L,4L,5L,121L,9L,46L,437L,4L,20L,121L,17L,4L,24L,4L,5L,67L,14L,22L,17L,4L,24L,121L,5L,4L,2562L,211L,5L,121L,9L,4L,107L,121L,14L,7261L,5L,211L,24L,4L,17L,121L,41L,4L,2280L,4L,9L,254L,5L,4L,32L,4L,17L,67L,24L,22L,17L,631L,35L,121L,5L,121L,783L,4L,5L,121L,32L,211L,2280L,4L,9L,67L,17L,4L,41L,121L,5L,254L,9L,46L,2280L,4L,140L,121L,5L,4L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286461Inst : IEnumerable<long>
{
public static readonly long[] Value=A286461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286461.Bytes);
public long this[int i]=>Value[i];

public static A286461Inst Instance=new A286461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286462
{
public static readonly long[] Value={ 1L,1L,5L,1L,1L,5L,4L,1L,6L,1L,2L,5L,1L,4L,12L,1L,1L,6L,2L,1L,3L,2L,4L,5L,1L,1L,14L,4L,1L,12L,11L,1L,3L,1L,2L,6L,1L,2L,8L,1L,1L,3L,2L,2L,6L,4L,7L,5L,1L,1L,5L,1L,1L,14L,4L,4L,3L,1L,2L,12L,1L,11L,31L,1L,1L,3L,2L,1L,3L,2L,4L,6L,1L,1L,5L,2L,1L,8L,7L,1L,15L,1L,2L,3L,1L,2L,8L,2L,1L,6L,2L,4L,3L,7L,11L,5L,1L,1L,9L,1L,1L,5L,4L,1L,3L,1L,2L,14L,1L,4L,12L,4L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286462Inst : IEnumerable<long>
{
public static readonly long[] Value=A286462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286462.Bytes);
public long this[int i]=>Value[i];

public static A286462Inst Instance=new A286462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286463
{
public static readonly long[] Value={ 1L,2L,5L,7L,2L,23L,2L,29L,18L,16L,2L,80L,2L,16L,23L,121L,2L,94L,2L,67L,23L,16L,2L,302L,7L,16L,59L,67L,2L,467L,2L,497L,23L,16L,16L,706L,2L,16L,23L,277L,2L,467L,2L,67L,94L,16L,2L,1178L,7L,67L,23L,67L,2L,355L,16L,277L,23L,16L,2L,1832L,2L,16L,94L,2017L,16L,467L,2L,67L,23L,436L,2L,2704L,2L,16L,80L,67L,16L,467L,2L,1129L,195L,16L,2L,1832L,16L,16L,23L,277L,2L,1894L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286463Inst : IEnumerable<long>
{
public static readonly long[] Value=A286463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286463.Bytes);
public long this[int i]=>Value[i];

public static A286463Inst Instance=new A286463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286464
{
public static readonly long[] Value={ 2L,2L,12L,2L,16L,12L,29L,2L,31L,16L,67L,12L,67L,29L,138L,2L,16L,31L,67L,16L,467L,67L,277L,12L,67L,67L,745L,29L,277L,138L,497L,2L,23L,16L,67L,31L,436L,67L,302L,16L,436L,467L,1771L,67L,1894L,277L,1129L,12L,67L,67L,668L,67L,1771L,745L,2557L,29L,302L,277L,2557L,138L,1129L,497L,2148L,2L,16L,23L,67L,16L,467L,67L,277L,31L,436L,436L,1832L,67L,1771L,302L,1129L,16L,566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286464Inst : IEnumerable<long>
{
public static readonly long[] Value=A286464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286464.Bytes);
public long this[int i]=>Value[i];

public static A286464Inst Instance=new A286464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286465
{
public static readonly long[] Value={ 1L,2L,2L,5L,12L,2L,2L,23L,5L,2L,16L,9L,18L,29L,2L,5L,23L,16L,2L,23L,5L,2L,67L,9L,25L,16L,2L,23L,23L,2L,2L,80L,23L,2L,16L,14L,9L,67L,16L,5L,138L,2L,16L,23L,5L,16L,16L,31L,9L,67L,2L,5L,467L,2L,2L,23L,5L,16L,67L,40L,33L,16L,29L,5L,23L,2L,16L,302L,5L,2L,16L,31L,31L,67L,2L,5L,80L,16L,2L,23L,23L,2L,436L,9L,42L,67L,2L,80L,23L,2L,2L,23L,23L,16L,277L,14L,9L,436L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286465Inst : IEnumerable<long>
{
public static readonly long[] Value=A286465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286465.Bytes);
public long this[int i]=>Value[i];

public static A286465Inst Instance=new A286465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286466
{
public static readonly long[] Value={ 1L,2L,5L,12L,2L,16L,5L,38L,7L,16L,9L,94L,2L,16L,23L,138L,2L,67L,5L,80L,16L,16L,9L,355L,7L,16L,38L,80L,2L,436L,5L,530L,16L,16L,40L,706L,2L,16L,23L,302L,2L,436L,5L,80L,67L,16L,9L,1228L,7L,67L,23L,80L,2L,277L,23L,302L,16L,16L,14L,2021L,2L,16L,80L,2082L,16L,436L,5L,80L,16L,436L,9L,2704L,2L,16L,80L,80L,16L,436L,5L,1178L,121L,16L,9L,2086L,16L,16L,23L,302L,2L,1771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286466Inst : IEnumerable<long>
{
public static readonly long[] Value=A286466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286466.Bytes);
public long this[int i]=>Value[i];

public static A286466Inst Instance=new A286466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286467
{
public static readonly long[] Value={ 1L,3L,5L,9L,5L,19L,5L,33L,18L,25L,5L,51L,5L,25L,40L,73L,5L,72L,12L,84L,40L,25L,5L,128L,69L,25L,71L,84L,5L,180L,12L,146L,40L,25L,40L,242L,23L,40L,40L,198L,12L,180L,5L,177L,177L,40L,5L,337L,31L,216L,40L,84L,12L,284L,59L,308L,140L,40L,12L,478L,12L,40L,177L,339L,40L,180L,23L,177L,140L,387L,12L,610L,12L,59L,216L,177L,59L,309L,12L,540L,332L,40L,5L,608L,59L,40L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286467Inst : IEnumerable<long>
{
public static readonly long[] Value=A286467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286467.Bytes);
public long this[int i]=>Value[i];

public static A286467Inst Instance=new A286467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286468
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,4L,4L,3L,1L,2L,6L,5L,9L,8L,8L,9L,5L,6L,2L,1L,3L,4L,12L,15L,7L,10L,18L,25L,27L,16L,16L,27L,25L,18L,10L,7L,15L,12L,4L,3L,1L,2L,6L,5L,9L,8L,24L,45L,35L,30L,14L,11L,21L,20L,36L,75L,49L,50L,54L,125L,81L,32L,32L,81L,125L,54L,50L,49L,75L,36L,20L,21L,11L,14L,30L,35L,45L,24L,8L,9L,5L,6L,2L,1L,3L,4L,12L,15L,7L,10L,18L,25L,27L,16L,48L,135L,175L,90L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286468Inst : IEnumerable<long>
{
public static readonly long[] Value=A286468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286468.Bytes);
public long this[int i]=>Value[i];

public static A286468Inst Instance=new A286468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286469
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,1L,4L,1L,2L,2L,5L,1L,6L,3L,2L,1L,7L,1L,8L,2L,2L,4L,9L,1L,3L,5L,2L,3L,10L,1L,11L,1L,3L,6L,3L,1L,12L,7L,4L,2L,13L,2L,14L,4L,2L,8L,15L,1L,4L,2L,5L,5L,16L,1L,3L,3L,6L,9L,17L,1L,18L,10L,2L,1L,3L,3L,19L,6L,7L,2L,20L,1L,21L,11L,2L,7L,4L,4L,22L,2L,2L,12L,23L,2L,4L,13L,8L,4L,24L,1L,4L,8L,9L,14L,5L,1L,25L,3L,3L,2L,26L,5L,27L,5L,2L,15L,28L,1L,29L,2L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286469Inst : IEnumerable<long>
{
public static readonly long[] Value=A286469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286469.Bytes);
public long this[int i]=>Value[i];

public static A286469Inst Instance=new A286469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286470
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,0L,3L,1L,0L,0L,1L,0L,2L,2L,4L,0L,1L,0L,5L,0L,3L,0L,1L,0L,0L,3L,6L,1L,1L,0L,7L,4L,2L,0L,2L,0L,4L,1L,8L,0L,1L,0L,2L,5L,5L,0L,1L,2L,3L,6L,9L,0L,1L,0L,10L,2L,0L,3L,3L,0L,6L,7L,2L,0L,1L,0L,11L,1L,7L,1L,4L,0L,2L,0L,12L,0L,2L,4L,13L,8L,4L,0L,1L,2L,8L,9L,14L,5L,1L,0L,3L,3L,2L,0L,5L,0L,5L,1L,15L,0L,1L,0L,2L,10L,3L,0L,6L,6L,9L,4L,16L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286470Inst : IEnumerable<long>
{
public static readonly long[] Value=A286470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286470.Bytes);
public long this[int i]=>Value[i];

public static A286470Inst Instance=new A286470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286519
{
public static readonly ulong[] Value={ 1L,11L,101L,1111L,11111L,111111L,1111111L,11111111L,111111111L,1111111111L,11111111111L,111111111111L,1111111111111L,11111111111111L,111111111111111L,1111111111111111L,11111111111111111L,111111111111111111L,1111111111111111111L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286519Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286519.Bytes);
public ulong this[int i]=>Value[i];

public static A286519Inst Instance=new A286519Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286520
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,5L,1L,1L,1L,1L,1L,5L,1L,1L,1L,3L,1L,5L,1L,2L,2L,1L,1L,4L,1L,2L,1L,2L,1L,3L,1L,3L,1L,1L,1L,17L,1L,1L,2L,1L,1L,5L,1L,2L,1L,5L,1L,9L,1L,1L,2L,2L,1L,5L,1L,4L,1L,1L,1L,17L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286520Inst : IEnumerable<long>
{
public static readonly long[] Value=A286520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286520.Bytes);
public long this[int i]=>Value[i];

public static A286520Inst Instance=new A286520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286521
{
public static readonly long[] Value={ 1L,3L,5L,15L,31L,63L,127L,255L,511L,1023L,2047L,4095L,8191L,16383L,32767L,65535L,131071L,262143L,524287L,1048575L,2097151L,4194303L,8388607L,16777215L,33554431L,67108863L,134217727L,268435455L,536870911L,1073741823L,2147483647L,4294967295L,8589934591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286521Inst : IEnumerable<long>
{
public static readonly long[] Value=A286521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286521.Bytes);
public long this[int i]=>Value[i];

public static A286521Inst Instance=new A286521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286522
{
public static readonly long[] Value={ 2L,4L,8L,14L,23L,36L,52L,72L,93L,116L,138L,158L,174L,185L,191L,191L,186L,176L,162L,146L,128L,110L,93L,77L,62L,49L,38L,29L,22L,16L,12L,8L,6L,4L,2L,2L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286522Inst : IEnumerable<long>
{
public static readonly long[] Value=A286522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286522.Bytes);
public long this[int i]=>Value[i];

public static A286522Inst Instance=new A286522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286523
{
public static readonly BigInteger[] Value={ 2L,4L,8L,128L,640L,8192L,1605632L,536870912L,100663296L,137438953472L,32195899484536832L,1152921504606846976L,BigInteger.Parse("214035842104995017129984"),BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("2417851639229258349412352"),BigInteger.Parse("2658455991569831745807614120560689152"),BigInteger.Parse("16645314084009764791991725029402697793536"),BigInteger.Parse("680564733841876926926749214863536422912"),BigInteger.Parse("2958953999535335146041291694037024012985750731620352") };
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
public class A286523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286523Inst Instance=new A286523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286524
{
public static readonly BigInteger[] Value={ 1L,1L,1L,9L,27L,225L,30375L,7441875L,1071875L,1181472075L,232602314765625L,7296820763203125L,BigInteger.Parse("1228777319702643046875"),BigInteger.Parse("407740293448065703125"),BigInteger.Parse("12646770836979187723815"),BigInteger.Parse("13904872587870848957579157123046875"),BigInteger.Parse("89477855102948913042021876086806640625"),BigInteger.Parse("3865644245069923858264226752294921875"),BigInteger.Parse("18203690021177687874093952515006818038631103515625") };
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
public class A286524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286524Inst Instance=new A286524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286525
{
public static readonly BigInteger[] Value={ 1L,1L,3L,978L,7885536L,1030690752000L,2681594035175055000L,BigInteger.Parse("111102459342780333711432912"),BigInteger.Parse("82765346051371433995689422809152600"),BigInteger.Parse("984929152509556378339959477248973638627262816"),BigInteger.Parse("201525938526971993585665495909682003042353826154218776128") };
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
public class A286525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286525Inst Instance=new A286525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286526
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2874L,84086160L,77920099694640L,BigInteger.Parse("1787320731699689472000"),BigInteger.Parse("1208369393947533515948886636000"),BigInteger.Parse("22022604563875220592723146462014970246400"),BigInteger.Parse("10631042739086498005729294276105510004209560426195000"),BigInteger.Parse("136864426940639977623403211038729959780835360788855628470904385280") };
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
public class A286526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286526Inst Instance=new A286526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286527
{
public static readonly long[] Value={ 1L,6L,70L,210L,2622L,9282L,277134L,1159710L,8064030L,56185590L,186605430L,2748628830L,5053814978L,72641163166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286527Inst : IEnumerable<long>
{
public static readonly long[] Value=A286527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286527.Bytes);
public long this[int i]=>Value[i];

public static A286527Inst Instance=new A286527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286528
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,1L,3L,2L,2L,3L,3L,3L,3L,4L,2L,4L,3L,3L,4L,4L,3L,5L,4L,2L,5L,3L,3L,4L,4L,4L,5L,5L,3L,6L,4L,4L,5L,5L,5L,6L,6L,5L,7L,6L,4L,7L,5L,5L,6L,6L,3L,7L,4L,4L,5L,5L,5L,6L,6L,5L,5L,6L,6L,6L,7L,7L,7L,8L,4L,7L,5L,5L,6L,6L,6L,7L,7L,3L,8L,4L,4L,5L,5L,5L,6L,6L,5L,7L,6L,6L,7L,7L,5L,7L,6L,6L,7L,7L,7L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286528Inst : IEnumerable<long>
{
public static readonly long[] Value=A286528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286528.Bytes);
public long this[int i]=>Value[i];

public static A286528Inst Instance=new A286528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286529
{
public static readonly long[] Value={ 2L,3L,2L,2L,2L,4L,3L,6L,6L,4L,2L,6L,4L,6L,2L,4L,2L,8L,4L,4L,3L,4L,3L,6L,6L,8L,2L,4L,2L,4L,4L,4L,2L,4L,4L,6L,4L,8L,2L,10L,2L,6L,6L,6L,4L,6L,3L,4L,6L,8L,4L,4L,4L,4L,2L,7L,2L,4L,2L,12L,6L,8L,4L,2L,4L,4L,4L,4L,2L,8L,2L,12L,6L,8L,5L,4L,5L,4L,5L,12L,4L,4L,4L,12L,2L,12L,4L,12L,4L,8L,4L,6L,2L,6L,6L,12L,6L,8L,8L,2L,2L,8L,8L,10L,2L,8L,2L,16L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286529Inst : IEnumerable<long>
{
public static readonly long[] Value=A286529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286529.Bytes);
public long this[int i]=>Value[i];

public static A286529Inst Instance=new A286529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286530
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,0L,1L,2L,3L,0L,0L,0L,2L,2L,-2L,-1L,0L,2L,2L,-2L,-1L,0L,1L,-2L,3L,4L,-2L,-2L,0L,-4L,2L,-2L,-2L,0L,0L,-3L,2L,4L,-2L,2L,0L,-2L,4L,0L,-2L,2L,1L,-6L,3L,2L,0L,-2L,2L,-4L,-2L,-1L,-2L,0L,0L,0L,4L,4L,-2L,-5L,0L,-4L,2L,-2L,-2L,0L,0L,0L,4L,4L,-1L,-2L,1L,-4L,3L,2L,-1L,0L,2L,0L,-2L,8L,0L,4L,2L,-4L,0L,0L,-2L,2L,2L,0L,4L,2L,2L,-7L,0L,0L,6L,2L,-6L,4L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286530Inst : IEnumerable<long>
{
public static readonly long[] Value=A286530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286530.Bytes);
public long this[int i]=>Value[i];

public static A286530Inst Instance=new A286530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286531
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,5L,2L,6L,4L,7L,3L,7L,5L,5L,2L,8L,6L,9L,4L,10L,7L,7L,3L,9L,7L,11L,5L,7L,5L,5L,2L,12L,8L,13L,6L,14L,9L,9L,4L,14L,10L,15L,7L,10L,7L,7L,3L,13L,9L,15L,7L,15L,11L,11L,5L,9L,7L,11L,5L,7L,5L,5L,2L,16L,12L,17L,8L,18L,13L,13L,6L,19L,14L,20L,9L,14L,9L,9L,4L,18L,14L,21L,10L,21L,15L,15L,7L,14L,10L,15L,7L,10L,7L,7L,3L,17L,13L,20L,9L,21L,15L,15L,7L,20L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286531Inst : IEnumerable<long>
{
public static readonly long[] Value=A286531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286531.Bytes);
public long this[int i]=>Value[i];

public static A286531Inst Instance=new A286531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286532
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,4L,4L,6L,3L,6L,4L,7L,2L,4L,5L,6L,4L,8L,4L,9L,3L,6L,4L,10L,4L,8L,6L,11L,2L,4L,4L,6L,4L,9L,4L,9L,4L,8L,4L,12L,4L,8L,4L,13L,3L,6L,6L,10L,5L,8L,8L,14L,4L,8L,4L,12L,4L,12L,4L,15L,2L,4L,6L,6L,4L,8L,7L,9L,4L,8L,4L,14L,4L,8L,6L,13L,4L,8L,6L,12L,4L,8L,4L,16L,4L,8L,8L,12L,6L,8L,4L,17L,3L,6L,4L,10L,4L,12L,9L,14L,4L,9L,4L,12L,4L,18L,4L,19L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286532Inst : IEnumerable<long>
{
public static readonly long[] Value=A286532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286532.Bytes);
public long this[int i]=>Value[i];

public static A286532Inst Instance=new A286532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286533
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,5L,3L,2L,6L,7L,7L,5L,4L,5L,3L,2L,8L,9L,10L,7L,9L,11L,7L,5L,6L,7L,7L,5L,4L,5L,3L,2L,12L,13L,14L,9L,14L,15L,10L,7L,13L,15L,15L,11L,9L,11L,7L,5L,8L,9L,10L,7L,9L,11L,7L,5L,6L,7L,7L,5L,4L,5L,3L,2L,16L,17L,18L,13L,19L,20L,14L,9L,18L,21L,21L,15L,14L,15L,10L,7L,17L,20L,21L,15L,20L,22L,15L,11L,13L,15L,15L,11L,9L,11L,7L,5L,12L,13L,14L,9L,14L,15L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286533Inst : IEnumerable<long>
{
public static readonly long[] Value=A286533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286533.Bytes);
public long this[int i]=>Value[i];

public static A286533Inst Instance=new A286533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286534
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,2L,3L,6L,7L,5L,5L,6L,5L,2L,3L,6L,8L,5L,6L,9L,10L,5L,5L,10L,11L,5L,4L,6L,5L,2L,3L,6L,8L,6L,10L,12L,10L,4L,5L,13L,14L,5L,5L,13L,10L,5L,5L,10L,13L,5L,5L,15L,10L,5L,5L,11L,11L,5L,5L,6L,5L,2L,3L,6L,8L,5L,11L,12L,13L,5L,5L,16L,17L,5L,5L,13L,11L,5L,5L,10L,18L,5L,11L,19L,10L,5L,5L,10L,20L,5L,5L,13L,10L,5L,5L,10L,13L,6L,5L,20L,10L,5L,6L,10L,21L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286534Inst : IEnumerable<long>
{
public static readonly long[] Value=A286534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286534.Bytes);
public long this[int i]=>Value[i];

public static A286534Inst Instance=new A286534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286567
{
public static readonly long[] Value={ 1L,1L,3L,5L,11L,3L,43L,5L,3L,11L,683L,3L,2731L,43L,3L,5L,43691L,3L,174763L,5L,3L,23L,2796203L,3L,11L,2731L,3L,5L,59L,3L,715827883L,5L,3L,43691L,11L,3L,1777L,174763L,3L,5L,83L,3L,2932031007403L,5L,3L,47L,283L,3L,43L,11L,3L,5L,107L,3L,11L,5L,3L,59L,2833L,3L,768614336404564651L,715827883L,3L,5L,11L,3L,7327657L,5L,3L,11L,56409643L,3L,1753L,223L,3L,5L,43L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286567Inst : IEnumerable<long>
{
public static readonly long[] Value=A286567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286567.Bytes);
public long this[int i]=>Value[i];

public static A286567Inst Instance=new A286567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286568
{
public static readonly long[] Value={ 1L,1L,8L,3L,14L,8L,42L,10L,21L,14L,76L,19L,90L,42L,63L,36L,152L,21L,208L,44L,148L,76L,322L,53L,210L,90L,228L,117L,434L,63L,625L,136L,296L,152L,402L,78L,702L,208L,375L,152L,860L,148L,988L,251L,324L,322L,1271L,169L,903L,210L,627L,324L,1430L,228L,943L,375L,816L,434L,1828L,187L,1890L,625L,777L,528L,1273L,296L,2344L,560L,1220L,402L,2698L,300L,2700L,702L,901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286568Inst : IEnumerable<long>
{
public static readonly long[] Value=A286568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286568.Bytes);
public long this[int i]=>Value[i];

public static A286568Inst Instance=new A286568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286569
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,3L,2L,1L,1L,4L,2L,2L,2L,1L,1L,1L,3L,5L,4L,3L,3L,2L,1L,1L,1L,6L,2L,1L,4L,4L,3L,3L,2L,3L,3L,3L,3L,3L,5L,5L,7L,7L,8L,9L,9L,2L,5L,9L,1L,3L,7L,2L,3L,1L,1L,1L,1L,10L,2L,5L,6L,1L,7L,4L,4L,3L,3L,1L,5L,5L,7L,3L,9L,9L,5L,5L,9L,9L,5L,9L,7L,5L,7L,11L,7L,9L,11L,11L,12L,12L,13L,14L,9L,5L,3L,15L,7L,9L,16L,4L,12L,11L,5L,1L,16L,3L,3L,17L,1L,6L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286569Inst : IEnumerable<long>
{
public static readonly long[] Value=A286569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286569.Bytes);
public long this[int i]=>Value[i];

public static A286569Inst Instance=new A286569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286570
{
public static readonly long[] Value={ 1L,3L,3L,10L,3L,61L,3L,36L,10L,27L,3L,117L,3L,27L,34L,136L,3L,103L,3L,90L,21L,27L,3L,619L,10L,27L,36L,753L,3L,625L,3L,528L,34L,27L,21L,666L,3L,27L,21L,552L,3L,625L,3L,117L,103L,27L,3L,1323L,10L,78L,34L,90L,3L,430L,21L,489L,21L,27L,3L,2545L,3L,27L,78L,2080L,21L,625L,3L,90L,34L,495L,3L,2773L,3L,27L,78L,117L,21L,625L,3L,1224L,136L,27L,3L,3801L,21L,27L,34L,375L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286570Inst : IEnumerable<long>
{
public static readonly long[] Value=A286570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286570.Bytes);
public long this[int i]=>Value[i];

public static A286570Inst Instance=new A286570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286571
{
public static readonly long[] Value={ 1L,5L,8L,25L,17L,21L,30L,113L,70L,51L,68L,103L,93L,72L,51L,481L,155L,148L,192L,222L,331L,126L,278L,324L,382L,159L,569L,78L,437L,591L,498L,1985L,126L,237L,786L,2521L,705L,282L,952L,375L,863L,660L,948L,243L,337L,384L,1130L,1759L,1330L,1842L,237L,678L,1433L,520L,1776L,459L,1897L,567L,1772L,2076L,1893L,636L,2713L,8065L,2421L,810L,2280L,1002L,384L,2046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286571Inst : IEnumerable<long>
{
public static readonly long[] Value=A286571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286571.Bytes);
public long this[int i]=>Value[i];

public static A286571Inst Instance=new A286571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286572
{
public static readonly long[] Value={ 0L,1L,7L,22L,23L,67L,29L,122L,79L,173L,67L,408L,107L,277L,328L,531L,214L,742L,191L,949L,530L,631L,277L,1894L,498L,905L,781L,1598L,467L,2704L,497L,2149L,1178L,1600L,1228L,4188L,743L,1771L,1656L,4282L,949L,4658L,947L,3572L,3163L,2557L,1129L,8005L,1597L,4373L,2855L,4953L,1487L,7141L,2704L,7384L,3242L,4097L,1771L,14539L,1955L,4561L,5462L,8520L,3745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286572Inst : IEnumerable<long>
{
public static readonly long[] Value=A286572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286572.Bytes);
public long this[int i]=>Value[i];

public static A286572Inst Instance=new A286572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286573
{
public static readonly long[] Value={ 1L,2L,5L,7L,14L,23L,9L,29L,42L,40L,65L,80L,90L,31L,40L,121L,44L,142L,189L,109L,61L,115L,77L,302L,273L,148L,318L,94L,434L,532L,20L,497L,115L,86L,148L,826L,702L,271L,148L,355L,230L,601L,119L,220L,265L,131L,299L,1178L,297L,485L,86L,265L,1430L,838L,320L,328L,271L,556L,1769L,1957L,1890L,50L,142L,2017L,148L,751L,2277L,179L,373L,832L,665L,2932L,54L,856L,485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286573Inst : IEnumerable<long>
{
public static readonly long[] Value=A286573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286573.Bytes);
public long this[int i]=>Value[i];

public static A286573Inst Instance=new A286573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286574
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,3L,2L,3L,1L,2L,2L,2L,2L,3L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,3L,3L,3L,3L,4L,3L,4L,2L,3L,3L,3L,3L,4L,2L,3L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,3L,3L,3L,3L,4L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286574Inst : IEnumerable<long>
{
public static readonly long[] Value=A286574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286574.Bytes);
public long this[int i]=>Value[i];

public static A286574Inst Instance=new A286574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286575
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,4L,2L,4L,4L,4L,2L,4L,4L,2L,2L,4L,4L,4L,4L,8L,4L,8L,2L,4L,4L,4L,4L,8L,2L,4L,2L,4L,4L,4L,4L,8L,4L,8L,4L,8L,8L,8L,4L,8L,8L,4L,2L,4L,4L,4L,4L,8L,4L,8L,4L,8L,8L,8L,2L,4L,4L,4L,2L,4L,4L,4L,4L,8L,4L,8L,4L,8L,8L,8L,4L,8L,8L,4L,4L,8L,8L,8L,8L,16L,8L,16L,4L,8L,8L,8L,8L,16L,4L,8L,2L,4L,4L,4L,4L,8L,4L,8L,4L,8L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286575Inst : IEnumerable<long>
{
public static readonly long[] Value=A286575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286575.Bytes);
public long this[int i]=>Value[i];

public static A286575Inst Instance=new A286575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286576
{
public static readonly long[] Value={ 1L,2L,2L,0L,2L,1L,0L,0L,2L,1L,1L,0L,0L,0L,0L,0L,2L,1L,1L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,1L,0L,1L,2L,0L,0L,1L,2L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,1L,0L,1L,2L,0L,0L,1L,2L,2L,0L,0L,0L,0L,0L,1L,2L,2L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286576Inst : IEnumerable<long>
{
public static readonly long[] Value=A286576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286576.Bytes);
public long this[int i]=>Value[i];

public static A286576Inst Instance=new A286576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286577
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,1L,6L,7L,3L,9L,10L,4L,12L,13L,1L,15L,16L,6L,18L,19L,7L,21L,22L,3L,24L,25L,9L,27L,28L,10L,30L,31L,4L,33L,34L,12L,36L,37L,13L,39L,40L,1L,42L,43L,15L,45L,46L,16L,48L,49L,6L,51L,52L,18L,54L,55L,19L,57L,58L,7L,60L,61L,21L,63L,64L,22L,66L,67L,3L,69L,70L,24L,72L,73L,25L,75L,76L,9L,78L,79L,27L,81L,82L,28L,84L,85L,10L,87L,88L,30L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286577Inst : IEnumerable<long>
{
public static readonly long[] Value=A286577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286577.Bytes);
public long this[int i]=>Value[i];

public static A286577Inst Instance=new A286577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286578
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,4L,6L,2L,7L,9L,3L,10L,5L,0L,12L,15L,4L,8L,16L,6L,19L,21L,2L,22L,13L,7L,24L,11L,9L,27L,30L,3L,17L,31L,10L,34L,36L,5L,18L,37L,0L,40L,20L,12L,42L,28L,15L,26L,45L,4L,49L,51L,8L,52L,54L,16L,55L,29L,6L,33L,25L,19L,14L,57L,21L,64L,43L,2L,66L,69L,22L,39L,35L,13L,70L,75L,7L,44L,76L,24L,48L,79L,11L,82L,61L,9L,84L,23L,27L,87L,90L,30L,47L,46L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286578Inst : IEnumerable<long>
{
public static readonly long[] Value=A286578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286578.Bytes);
public long this[int i]=>Value[i];

public static A286578Inst Instance=new A286578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286579
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,4L,3L,4L,5L,6L,1L,2L,7L,8L,5L,6L,9L,10L,7L,8L,11L,12L,3L,1L,13L,14L,9L,10L,15L,16L,11L,12L,17L,18L,2L,4L,19L,20L,13L,14L,21L,22L,15L,16L,23L,24L,5L,6L,25L,26L,17L,18L,27L,28L,19L,20L,29L,30L,3L,1L,31L,32L,21L,22L,33L,34L,23L,24L,35L,36L,7L,8L,37L,38L,25L,26L,39L,40L,27L,28L,41L,42L,9L,1L,43L,44L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286579Inst : IEnumerable<long>
{
public static readonly long[] Value=A286579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286579.Bytes);
public long this[int i]=>Value[i];

public static A286579Inst Instance=new A286579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286580
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,6L,2L,4L,12L,8L,6L,16L,12L,6L,2L,4L,12L,12L,8L,36L,24L,6L,16L,30L,12L,6L,32L,24L,12L,6L,2L,4L,12L,12L,12L,36L,60L,8L,36L,24L,24L,6L,72L,72L,30L,16L,30L,48L,12L,6L,60L,60L,32L,24L,30L,12L,6L,64L,48L,24L,12L,6L,2L,4L,12L,12L,12L,36L,60L,12L,36L,60L,60L,8L,72L,180L,24L,36L,24L,180L,24L,6L,72L,120L,72L,72L,30L,30L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286580Inst : IEnumerable<long>
{
public static readonly long[] Value=A286580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286580.Bytes);
public long this[int i]=>Value[i];

public static A286580Inst Instance=new A286580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286581
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,2L,3L,6L,4L,5L,7L,6L,5L,2L,3L,6L,6L,4L,8L,9L,5L,7L,10L,6L,5L,11L,9L,6L,5L,2L,3L,6L,6L,6L,8L,12L,4L,8L,9L,9L,5L,13L,13L,10L,7L,10L,14L,6L,5L,12L,12L,11L,9L,10L,6L,5L,15L,14L,9L,6L,5L,2L,3L,6L,6L,6L,8L,12L,6L,8L,12L,12L,4L,13L,16L,9L,8L,9L,16L,9L,5L,13L,17L,13L,13L,10L,10L,7L,18L,19L,12L,14L,10L,14L,20L,6L,5L,18L,12L,12L,12L,10L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286581Inst : IEnumerable<long>
{
public static readonly long[] Value=A286581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286581.Bytes);
public long this[int i]=>Value[i];

public static A286581Inst Instance=new A286581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286582
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,2L,2L,1L,1L,1L,1L,2L,1L,3L,1L,2L,2L,3L,5L,3L,3L,2L,3L,2L,2L,3L,3L,4L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,4L,1L,4L,3L,3L,2L,1L,2L,5L,2L,3L,3L,2L,1L,2L,1L,1L,2L,2L,4L,3L,2L,4L,3L,4L,2L,1L,3L,1L,3L,4L,2L,2L,4L,5L,7L,3L,3L,1L,2L,3L,4L,1L,1L,3L,5L,2L,1L,2L,1L,2L,5L,4L,6L,2L,3L,1L,2L,3L,2L,4L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286582Inst : IEnumerable<long>
{
public static readonly long[] Value=A286582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286582.Bytes);
public long this[int i]=>Value[i];

public static A286582Inst Instance=new A286582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286823
{
public static readonly ulong[] Value={ 1L,10L,111L,1110L,11101L,111110L,1111101L,11111110L,111111101L,1111111110L,11111111101L,111111111110L,1111111111101L,11111111111110L,111111111111101L,1111111111111110L,11111111111111101L,111111111111111110L,1111111111111111101L,11111111111111111110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286823Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286823.Bytes);
public ulong this[int i]=>Value[i];

public static A286823Inst Instance=new A286823Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286824
{
public static readonly long[] Value={ 1L,1L,111L,111L,10111L,11111L,1011111L,1111111L,101111111L,111111111L,10111111111L,11111111111L,1011111111111L,1111111111111L,101111111111111L,111111111111111L,10111111111111111L,11111111111111111L,1011111111111111111L,1111111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286824Inst : IEnumerable<long>
{
public static readonly long[] Value=A286824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286824.Bytes);
public long this[int i]=>Value[i];

public static A286824Inst Instance=new A286824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286825
{
public static readonly long[] Value={ 1L,2L,7L,14L,29L,62L,125L,254L,509L,1022L,2045L,4094L,8189L,16382L,32765L,65534L,131069L,262142L,524285L,1048574L,2097149L,4194302L,8388461L,16777214L,33554189L,67108862L,134217485L,268435454L,536870669L,1073741822L,2147483341L,4294967294L,8589933773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286825Inst : IEnumerable<long>
{
public static readonly long[] Value=A286825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286825.Bytes);
public long this[int i]=>Value[i];

public static A286825Inst Instance=new A286825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286826
{
public static readonly long[] Value={ 1L,1L,7L,7L,23L,31L,95L,127L,383L,511L,1535L,2047L,6143L,8191L,24575L,32767L,98303L,131071L,393215L,524287L,1572863L,2097151L,5996543L,8388607L,23199743L,33554431L,92798975L,134217727L,371195903L,536870911L,1505755135L,2147483647L,6014631935L,8539602943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286826Inst : IEnumerable<long>
{
public static readonly long[] Value=A286826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286826.Bytes);
public long this[int i]=>Value[i];

public static A286826Inst Instance=new A286826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286827
{
public static readonly ulong[] Value={ 1L,10L,111L,1110L,11111L,111111L,1111111L,11111100L,111111111L,1111110110L,11111111111L,111111111111L,1111111111111L,11111111101100L,111111111111111L,1111111111111000L,11111111111111111L,111111111111001100L,1111111111111111111L,11111111111101111000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286827Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286827.Bytes);
public ulong this[int i]=>Value[i];

public static A286827Inst Instance=new A286827Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286828
{
public static readonly BigInteger[] Value={ 1L,1L,111L,111L,11111L,111111L,1111111L,111111L,111111111L,110111111L,11111111111L,111111111111L,1111111111111L,110111111111L,111111111111111L,1111111111111L,11111111111111111L,1100111111111111L,1111111111111111111L,11110111111111111L,BigInteger.Parse("111111111111111111111") };
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
public class A286828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286828Inst Instance=new A286828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286829
{
public static readonly long[] Value={ 1L,2L,7L,14L,31L,63L,127L,252L,511L,1014L,2047L,4095L,8191L,16364L,32767L,65528L,131071L,262092L,524287L,1048440L,2097151L,4193916L,8388607L,16776988L,33554431L,67106872L,134217727L,268434556L,536870911L,1073733688L,2147483647L,4294963324L,8589934591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286829Inst : IEnumerable<long>
{
public static readonly long[] Value=A286829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286829.Bytes);
public long this[int i]=>Value[i];

public static A286829Inst Instance=new A286829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286830
{
public static readonly long[] Value={ 1L,1L,7L,7L,31L,63L,127L,63L,511L,447L,2047L,4095L,8191L,3583L,32767L,8191L,131071L,53247L,524287L,126975L,2097151L,1023999L,8388607L,3735551L,33554431L,7372799L,134217727L,65273855L,536870911L,117571583L,2147483647L,1041235967L,8589934591L,1880883199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286830Inst : IEnumerable<long>
{
public static readonly long[] Value=A286830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286830.Bytes);
public long this[int i]=>Value[i];

public static A286830Inst Instance=new A286830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286831
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1001L,1001L,1001L,1001L,1001L,1001L,1101L,1101L,10001101L,10001101L,10001101L,10001101L,10001101L,10001101L,10001101L,10001101L,10101111L,10101111L,1010101111L,1110101111L,1111101111L,1111101111L,11111101111L,11111101111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286831Inst : IEnumerable<long>
{
public static readonly long[] Value=A286831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286831.Bytes);
public long this[int i]=>Value[i];

public static A286831Inst Instance=new A286831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286832
{
public static readonly ulong[] Value={ 1L,10L,100L,1000L,10000L,100000L,1000000L,10000000L,100100000L,1001000000L,10010000000L,100100000000L,1001000000000L,10010000000000L,101100000000000L,1011000000000000L,10110001000000000L,101100010000000000L,1011000100000000000L,10110001000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286832Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286832.Bytes);
public ulong this[int i]=>Value[i];

public static A286832Inst Instance=new A286832Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286833
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,9L,9L,9L,9L,9L,9L,13L,13L,141L,141L,141L,141L,141L,141L,141L,141L,175L,175L,687L,943L,1007L,1007L,2031L,2031L,34799L,38911L,38911L,47103L,47103L,47103L,47103L,47103L,178175L,180223L,180223L,262143L,524287L,524287L,524287L,1048575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286833Inst : IEnumerable<long>
{
public static readonly long[] Value=A286833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286833.Bytes);
public long this[int i]=>Value[i];

public static A286833Inst Instance=new A286833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286834
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,288L,576L,1152L,2304L,4608L,9216L,22528L,45056L,90624L,181248L,362496L,724992L,1449984L,2899968L,5799936L,11599872L,32112640L,64225280L,128581632L,257687552L,519569408L,1039138816L,2079326208L,4158652416L,8317435904L,17173839872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286834Inst : IEnumerable<long>
{
public static readonly long[] Value=A286834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286834.Bytes);
public long this[int i]=>Value[i];

public static A286834Inst Instance=new A286834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286835
{
public static readonly long[] Value={ 5L,8L,15L,6L,29L,27L,5L,54L,60L,6L,63L,7L,6L,54L,75L,6L,12L,52L,7L,76L,69L,5L,74L,27L,6L,78L,12L,6L,97L,33L,6L,15L,85L,5L,99L,46L,5L,15L,95L,6L,56L,13L,6L,82L,20L,5L,7L,81L,6L,126L,141L,5L,130L,67L,6L,52L,13L,5L,17L,38L,5L,8L,55L,6L,85L,15L,5L,106L,143L,5L,22L,12L,6L,95L,94L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286835Inst : IEnumerable<long>
{
public static readonly long[] Value=A286835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286835.Bytes);
public long this[int i]=>Value[i];

public static A286835Inst Instance=new A286835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286836
{
public static readonly long[] Value={ 54L,152L,250L,370L,468L,686L,1358L,1456L,1674L,2224L,2322L,2540L,2662L,3528L,4394L,4940L,5038L,5256L,6244L,6886L,6984L,7110L,7202L,8190L,9056L,9826L,11772L,12194L,12292L,12510L,13498L,13718L,14364L,17080L,19026L,24334L,24416L,24514L,24732L,25720L,26586L,29302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286836Inst : IEnumerable<long>
{
public static readonly long[] Value=A286836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286836.Bytes);
public long this[int i]=>Value[i];

public static A286836Inst Instance=new A286836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286837
{
public static readonly long[] Value={ 1386L,6790L,8130L,18618L,21378L,27654L,38874L,60030L,64020L,71058L,89178L,92130L,97014L,117114L,118902L,180438L,182226L,224058L,247044L,396078L,495114L,510906L,528510L,723486L,855966L,979098L,1007562L,1012380L,1032360L,1141194L,1302906L,1410294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286837Inst : IEnumerable<long>
{
public static readonly long[] Value=A286837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286837.Bytes);
public long this[int i]=>Value[i];

public static A286837Inst Instance=new A286837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286838
{
public static readonly long[] Value={ 5L,5L,1L,0L,5L,5L,1L,0L,1L,8L,8L,6L,12L,6L,3L,0L,4L,7L,4L,5L,0L,5L,1L,4L,11L,7L,6L,10L,5L,5L,5L,9L,6L,10L,6L,2L,5L,0L,0L,2L,11L,7L,7L,0L,7L,5L,12L,3L,4L,2L,9L,6L,7L,2L,12L,7L,6L,1L,5L,0L,5L,3L,11L,0L,10L,12L,3L,8L,5L,6L,10L,5L,9L,6L,9L,2L,8L,5L,0L,12L,11L,0L,2L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286838Inst : IEnumerable<long>
{
public static readonly long[] Value=A286838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286838.Bytes);
public long this[int i]=>Value[i];

public static A286838Inst Instance=new A286838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286920
{
public static readonly BigInteger[] Value={ 1L,1L,9L,1L,45L,1701L,1L,405L,134865L,97135605L,1L,3321L,10766601L,70618411521L,463255079498001L,1L,29889L,871858485L,51473762336565L,3039416437115008521L,BigInteger.Parse("179474497026544179696969"),1L,266085L,70607782701L,37523729625344145L,BigInteger.Parse("19941610769429949618201"),BigInteger.Parse("10597789568841677482963905405"),BigInteger.Parse("5632099886234793715531013441442501") };
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
public class A286920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286920Inst Instance=new A286920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286921
{
public static readonly BigInteger[] Value={ 1L,1L,10L,1L,55L,2575L,1L,550L,253000L,250525000L,1L,5050L,25007500L,250025500000L,2500000075000000L,1L,50500L,2500300000L,250002775000000L,BigInteger.Parse("25000000255000000000"),BigInteger.Parse("2500000000502500000000000"),1L,500500L,250000750000L,250000250500000000L,BigInteger.Parse("250000000000750000000000"),BigInteger.Parse("250000000000250500000000000000"),BigInteger.Parse("250000000000000000750000000000000000") };
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
public class A286921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286921Inst Instance=new A286921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286922
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286922Inst : IEnumerable<long>
{
public static readonly long[] Value=A286922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286922.Bytes);
public long this[int i]=>Value[i];

public static A286922Inst Instance=new A286922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286923
{
public static readonly long[] Value={ 3L,7L,12L,16L,21L,25L,29L,34L,38L,43L,47L,51L,56L,60L,65L,69L,74L,78L,82L,87L,91L,96L,100L,104L,109L,113L,118L,122L,127L,131L,135L,140L,144L,149L,153L,157L,162L,166L,171L,175L,179L,184L,188L,193L,197L,202L,206L,210L,215L,219L,224L,228L,232L,237L,241L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286923Inst : IEnumerable<long>
{
public static readonly long[] Value=A286923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286923.Bytes);
public long this[int i]=>Value[i];

public static A286923Inst Instance=new A286923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286924
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,26L,27L,28L,30L,31L,32L,33L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,61L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286924Inst : IEnumerable<long>
{
public static readonly long[] Value=A286924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286924.Bytes);
public long this[int i]=>Value[i];

public static A286924Inst Instance=new A286924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286925
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286925Inst : IEnumerable<long>
{
public static readonly long[] Value=A286925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286925.Bytes);
public long this[int i]=>Value[i];

public static A286925Inst Instance=new A286925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286926
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,75L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286926Inst : IEnumerable<long>
{
public static readonly long[] Value=A286926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286926.Bytes);
public long this[int i]=>Value[i];

public static A286926Inst Instance=new A286926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286927
{
public static readonly long[] Value={ 6L,12L,20L,26L,34L,40L,46L,54L,60L,68L,74L,80L,88L,94L,102L,108L,116L,122L,128L,136L,142L,150L,156L,162L,170L,176L,184L,190L,198L,204L,210L,218L,224L,232L,238L,244L,252L,258L,266L,272L,278L,286L,292L,300L,306L,314L,320L,326L,334L,340L,348L,354L,360L,368L,374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286927Inst : IEnumerable<long>
{
public static readonly long[] Value=A286927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286927.Bytes);
public long this[int i]=>Value[i];

public static A286927Inst Instance=new A286927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286928
{
public static readonly BigInteger[] Value={ 1L,5L,37L,489L,8801L,204763L,5832765L,197018321L,7702189345L,342237634221L,17039997700639L,939906923598525L,56899727331724863L,3751071253402671045L,BigInteger.Parse("267515957818316650221"),BigInteger.Parse("20522595752454270972321"),BigInteger.Parse("1685273102403664075044305"),BigInteger.Parse("147501996974331775160471677") };
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
public class A286928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286928Inst Instance=new A286928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286929
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,13L,17L,25L,33L,46L,61L,84L,108L,147L,187L,248L,316L,414L,519L,675L,843L,1077L,1339L,1699L,2090L,2633L,3227L,4020L,4909L,6076L,7369L,9075L,10965L,13394L,16129L,19613L,23493L,28434L,33954L,40858L,48643L,58301L,69124L,82547L,97593L,116017L,136804L,162101L,190504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286929Inst : IEnumerable<long>
{
public static readonly long[] Value=A286929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286929.Bytes);
public long this[int i]=>Value[i];

public static A286929Inst Instance=new A286929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286930
{
public static readonly long[] Value={ 0L,72L,4608L,52488L,294912L,1125000L,3359232L,8470728L,18874368L,38263752L,72000000L,127552392L,214990848L,347530248L,542126592L,820125000L,1207959552L,1737904968L,2448880128L,3387303432L,4608000000L,6175160712L,8163353088L,10658584008L,13759414272L,17578125000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286930Inst : IEnumerable<long>
{
public static readonly long[] Value=A286930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286930.Bytes);
public long this[int i]=>Value[i];

public static A286930Inst Instance=new A286930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286931
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,7L,3L,9L,6L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286931Inst : IEnumerable<long>
{
public static readonly long[] Value=A286931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286931.Bytes);
public long this[int i]=>Value[i];

public static A286931Inst Instance=new A286931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286932
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,1L,0L,1L,-3L,4L,0L,0L,1L,-4L,9L,-4L,-1L,0L,1L,-5L,16L,-18L,0L,1L,0L,1L,-6L,25L,-48L,27L,8L,-1L,0L,1L,-7L,36L,-100L,128L,-27L,-24L,1L,0L,1L,-8L,49L,-180L,375L,-320L,-27L,48L,0L,0L,1L,-9L,64L,-294L,864L,-1375L,704L,243L,-64L,-1L,0L,1L,-10L,81L,-448L,1715L,-4104L,4875L,-1280L,-810L,48L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286932Inst : IEnumerable<long>
{
public static readonly long[] Value=A286932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286932.Bytes);
public long this[int i]=>Value[i];

public static A286932Inst Instance=new A286932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286933
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,4L,2L,0L,1L,4L,9L,12L,3L,0L,1L,5L,16L,36L,32L,5L,0L,1L,6L,25L,80L,135L,88L,9L,0L,1L,7L,36L,150L,384L,513L,248L,15L,0L,1L,8L,49L,252L,875L,1856L,1971L,688L,26L,0L,1L,9L,64L,392L,1728L,5125L,9024L,7533L,1920L,45L,0L,1L,10L,81L,576L,3087L,11880L,30125L,43776L,28836L,5360L,78L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286933Inst : IEnumerable<long>
{
public static readonly long[] Value=A286933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286933.Bytes);
public long this[int i]=>Value[i];

public static A286933Inst Instance=new A286933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286934
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,2L,0L,1L,1L,1L,2L,0L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,3L,1L,1L,2L,2L,3L,2L,1L,2L,2L,3L,2L,1L,3L,2L,3L,2L,2L,3L,3L,3L,3L,2L,3L,3L,3L,4L,2L,3L,3L,4L,4L,3L,3L,4L,4L,4L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286934Inst : IEnumerable<long>
{
public static readonly long[] Value=A286934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286934.Bytes);
public long this[int i]=>Value[i];

public static A286934Inst Instance=new A286934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286935
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,2L,1L,1L,1L,0L,2L,0L,2L,1L,1L,1L,0L,2L,0L,2L,1L,1L,1L,1L,3L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,2L,3L,2L,3L,1L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286935Inst : IEnumerable<long>
{
public static readonly long[] Value=A286935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286935.Bytes);
public long this[int i]=>Value[i];

public static A286935Inst Instance=new A286935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286936
{
public static readonly long[] Value={ 1L,2L,4L,8L,26L,28L,43L,70L,92L,128L,331L,364L,478L,532L,689L,778L,895L,1210L,5081L,7855L,17852L,20864L,42598L,56858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286936Inst : IEnumerable<long>
{
public static readonly long[] Value=A286936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286936.Bytes);
public long this[int i]=>Value[i];

public static A286936Inst Instance=new A286936Inst();

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