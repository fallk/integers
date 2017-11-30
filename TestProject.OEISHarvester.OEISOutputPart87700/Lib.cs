using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A107341
{
public static readonly long[] Value={ 3L,1L,2L,3L,5L,11L,15L,22L,27L,40L,56L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107341Inst : IEnumerable<long>
{
public static readonly long[] Value=A107341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107341.Bytes);
public long this[int i]=>Value[i];

public static A107341Inst Instance=new A107341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107342
{
public static readonly long[] Value={ 4L,6L,9L,46L,49L,69L,94L,446L,466L,469L,649L,669L,694L,699L,949L,4449L,4469L,4499L,4666L,4694L,4699L,4946L,6499L,6646L,6649L,6694L,6999L,9446L,9449L,9466L,9469L,9946L,9969L,44494L,44669L,44949L,44966L,44969L,44999L,46469L,46666L,46946L,46969L,46994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107342Inst : IEnumerable<long>
{
public static readonly long[] Value=A107342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107342.Bytes);
public long this[int i]=>Value[i];

public static A107342Inst Instance=new A107342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107343
{
public static readonly long[] Value={ 92L,550L,30L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107343Inst : IEnumerable<long>
{
public static readonly long[] Value=A107343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107343.Bytes);
public long this[int i]=>Value[i];

public static A107343Inst Instance=new A107343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107344
{
public static readonly long[] Value={ 5172L,984L,222L,96L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107344Inst : IEnumerable<long>
{
public static readonly long[] Value=A107344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107344.Bytes);
public long this[int i]=>Value[i];

public static A107344Inst Instance=new A107344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107345
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,4L,3L,3L,2L,3L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,5L,4L,6L,3L,6L,3L,3L,2L,6L,3L,1L,1L,3L,1L,1L,1L,4L,3L,3L,2L,3L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,6L,5L,10L,4L,10L,6L,6L,3L,10L,6L,4L,3L,6L,3L,3L,2L,10L,6L,4L,3L,4L,1L,1L,1L,6L,3L,1L,1L,3L,1L,1L,1L,5L,4L,6L,3L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107345Inst : IEnumerable<long>
{
public static readonly long[] Value=A107345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107345.Bytes);
public long this[int i]=>Value[i];

public static A107345Inst Instance=new A107345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107346
{
public static readonly long[] Value={ 9L,81L,18L,81L,9L,702L,9L,171L,27L,72L,18L,693L,18L,72L,27L,171L,9L,702L,9L,81L,18L,81L,9L,5913L,9L,81L,18L,81L,9L,1602L,9L,261L,36L,63L,27L,594L,18L,162L,36L,162L,18L,603L,9L,171L,27L,72L,18L,5814L,9L,171L,27L,72L,18L,603L,9L,261L,36L,63L,27L,1584L,27L,63L,36L,261L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107346Inst : IEnumerable<long>
{
public static readonly long[] Value=A107346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107346.Bytes);
public long this[int i]=>Value[i];

public static A107346Inst Instance=new A107346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107347
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,9L,9L,9L,9L,10L,11L,11L,12L,13L,12L,13L,13L,14L,13L,14L,15L,15L,15L,16L,16L,17L,18L,19L,19L,20L,19L,18L,18L,19L,20L,21L,22L,23L,23L,23L,24L,25L,25L,25L,26L,27L,26L,27L,28L,28L,28L,28L,28L,29L,30L,30L,30L,31L,32L,32L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107347Inst : IEnumerable<long>
{
public static readonly long[] Value=A107347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107347.Bytes);
public long this[int i]=>Value[i];

public static A107347Inst Instance=new A107347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107348
{
public static readonly long[] Value={ 0L,1L,6L,1L,11L,20L,1L,18L,35L,46L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107348Inst : IEnumerable<long>
{
public static readonly long[] Value=A107348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107348.Bytes);
public long this[int i]=>Value[i];

public static A107348Inst Instance=new A107348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107349
{
public static readonly long[] Value={ 3556550L,4112560L,4112568L,4116958L,4117950L,4118050L,4554051L,4614334L,4614393L,4614437L,4614444L,4652931L,4662825L,4663397L,4668326L,4668331L,4668793L,4668843L,4669228L,4669275L,4669281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107349Inst : IEnumerable<long>
{
public static readonly long[] Value=A107349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107349.Bytes);
public long this[int i]=>Value[i];

public static A107349Inst Instance=new A107349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107350
{
public static readonly BigInteger[] Value={ 1L,4L,34L,346L,3965L,48396L,615966L,8082457L,108545916L,1484716135L,20612084010L,289688970195L,4113620233260L,58930127470164L,850641610106596L,12360278974175769L,180648953113093368L,2653875476976308643L,BigInteger.Parse("39167191622334514398"),BigInteger.Parse("580439539153823110678"),BigInteger.Parse("8633956582855204662785") };
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
public class A107350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107350Inst Instance=new A107350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107351
{
public static readonly long[] Value={ 1L,3L,9L,21L,45L,87L,159L,273L,450L,712L,1092L,1626L,2364L,3360L,4686L,6420L,8661L,11517L,15121L,19617L,25179L,31995L,40287L,50295L,62298L,76596L,93534L,113482L,136860L,164118L,195762L,232332L,274431L,322701L,377853L,440643L,511903L,592515L,683445L,785715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107351Inst : IEnumerable<long>
{
public static readonly long[] Value=A107351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107351.Bytes);
public long this[int i]=>Value[i];

public static A107351Inst Instance=new A107351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107352
{
public static readonly long[] Value={ 1L,10L,55L,192L,522L,1197L,2432L,4520L,7838L,12867L,20193L,30524L,44696L,63694L,88658L,120895L,161885L,213294L,276997L,355082L,449849L,563834L,699826L,860861L,1050260L,1271598L,1528765L,1825937L,2167611L,2558606L,3004075L,3509523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107352Inst : IEnumerable<long>
{
public static readonly long[] Value=A107352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107352.Bytes);
public long this[int i]=>Value[i];

public static A107352Inst Instance=new A107352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107353
{
public static readonly long[] Value={ 0L,10L,1L,11L,12L,2L,20L,21L,13L,3L,23L,22L,24L,4L,14L,15L,5L,25L,26L,6L,16L,17L,7L,27L,28L,8L,18L,19L,9L,29L,32L,30L,31L,33L,34L,35L,36L,37L,38L,39L,43L,40L,41L,42L,44L,45L,46L,47L,48L,49L,54L,50L,51L,52L,53L,55L,56L,57L,58L,59L,65L,60L,61L,62L,63L,64L,66L,67L,68L,69L,76L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107353Inst : IEnumerable<long>
{
public static readonly long[] Value=A107353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107353.Bytes);
public long this[int i]=>Value[i];

public static A107353Inst Instance=new A107353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107354
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,44L,516L,11622L,512022L,44588536L,7718806044L,2664170119608L,1836214076324153L,2529135272371085496L,BigInteger.Parse("6964321029630556852944"),BigInteger.Parse("38346813253279804426846032"),BigInteger.Parse("422247020982575523983378003936") };
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
public class A107354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107354Inst Instance=new A107354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107355
{
public static readonly long[] Value={ 1L,34L,49L,51L,52L,63L,70L,77L,86L,88L,91L,94L,95L,105L,116L,118L,121L,123L,124L,125L,133L,135L,143L,153L,154L,160L,161L,162L,165L,172L,175L,177L,185L,188L,195L,201L,203L,206L,207L,208L,217L,219L,222L,225L,236L,238L,244L,248L,250L,253L,255L,260L,261L,262L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107355Inst : IEnumerable<long>
{
public static readonly long[] Value=A107355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107355.Bytes);
public long this[int i]=>Value[i];

public static A107355Inst Instance=new A107355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107356
{
public static readonly long[] Value={ 2L,2L,1L,4L,4L,2L,2L,1L,4L,2L,3L,6L,2L,6L,4L,2L,1L,2L,8L,4L,4L,2L,3L,6L,6L,5L,4L,10L,8L,4L,2L,1L,4L,6L,6L,6L,3L,4L,3L,6L,10L,4L,6L,8L,9L,6L,2L,4L,4L,2L,2L,1L,6L,2L,7L,8L,2L,12L,4L,9L,3L,6L,12L,6L,18L,6L,7L,4L,6L,7L,6L,6L,14L,4L,2L,2L,12L,10L,6L,6L,4L,10L,7L,4L,18L,4L,4L,2L,3L,6L,5L,20L,14L,8L,5L,12L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107356Inst : IEnumerable<long>
{
public static readonly long[] Value=A107356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107356.Bytes);
public long this[int i]=>Value[i];

public static A107356Inst Instance=new A107356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107357
{
public static readonly BigInteger[] Value={ 2L,3L,2L,1L,3L,4L,1L,8L,9L,5L,64L,2L,317L,79L,17L,2049L,7653L,26628L,9L,24001L,232920L,1145407L,BigInteger.Parse("3498690007594650042369"),2058538L,59L,27L,28L,60L,9272781L,4L,69273669L,4870848L,BigInteger.Parse("2387010102192469724605148123694256129"),2L,2L,-52L,44L,1L,-4695L,174L,44584L,BigInteger.Parse("111111111111111111111111111111111111111112"),30402458L,668803782L,1134903171L,382443020333L };
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
public class A107357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107357Inst Instance=new A107357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107358
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,144L,233L,376L,608L,982L,1587L,2564L,4143L,6694L,10816L,17476L,28237L,45624L,73717L,119108L,192449L,310949L,502416L,811778L,1311630L,2119265L,3424201L,5532650L,8939375L,14443788L,23337539L,37707610L,60926041L,98441202L,159056294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107358Inst : IEnumerable<long>
{
public static readonly long[] Value=A107358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107358.Bytes);
public long this[int i]=>Value[i];

public static A107358Inst Instance=new A107358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107359
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,6L,1L,1L,3L,1L,2L,1L,1L,11L,1L,2L,1L,1L,6L,1L,1L,3L,1L,2L,1L,1L,22L,1L,1L,3L,1L,2L,1L,1L,11L,1L,2L,1L,1L,6L,1L,1L,3L,1L,2L,1L,1L,43L,1L,2L,1L,1L,6L,1L,1L,3L,1L,2L,1L,1L,22L,1L,1L,3L,1L,2L,1L,1L,11L,1L,2L,1L,1L,6L,1L,1L,3L,1L,2L,1L,1L,86L,1L,1L,3L,1L,2L,1L,1L,11L,1L,2L,1L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107359Inst : IEnumerable<long>
{
public static readonly long[] Value=A107359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107359.Bytes);
public long this[int i]=>Value[i];

public static A107359Inst Instance=new A107359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107360
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,19L,31L,61L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107360Inst : IEnumerable<long>
{
public static readonly long[] Value=A107360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107360.Bytes);
public long this[int i]=>Value[i];

public static A107360Inst Instance=new A107360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107361
{
public static readonly long[] Value={ 1L,2L,8L,21L,68L,196L,601L,1782L,5380L,16085L,48344L,144888L,434897L,1304314L,3913552L,11739669L,35220604L,105659228L,316981865L,950938830L,2852827436L,8558464597L,25675422448L,77026220976L,231078737953L,693236092466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107361Inst : IEnumerable<long>
{
public static readonly long[] Value=A107361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107361.Bytes);
public long this[int i]=>Value[i];

public static A107361Inst Instance=new A107361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107362
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107362Inst : IEnumerable<long>
{
public static readonly long[] Value=A107362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107362.Bytes);
public long this[int i]=>Value[i];

public static A107362Inst Instance=new A107362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107363
{
public static readonly long[] Value={ 1L,1L,-1L,1L,2L,0L,5L,3L,-7L,3L,8L,0L,21L,13L,-29L,13L,34L,0L,89L,55L,-123L,55L,144L,0L,377L,233L,-521L,233L,610L,0L,1597L,987L,-2207L,987L,2584L,0L,6765L,4181L,-9349L,4181L,10946L,0L,28657L,17711L,-39603L,17711L,46368L,0L,121393L,75025L,-167761L,75025L,196418L,0L,514229L,317811L,-710647L,317811L,832040L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107363Inst : IEnumerable<long>
{
public static readonly long[] Value=A107363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107363.Bytes);
public long this[int i]=>Value[i];

public static A107363Inst Instance=new A107363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107364
{
public static readonly long[] Value={ 1L,3L,9L,13L,27L,39L,81L,117L,169L,243L,351L,507L,729L,1053L,1521L,2187L,2197L,3159L,4563L,6561L,6591L,9477L,13689L,19683L,19773L,28431L,28561L,41067L,59049L,59319L,85293L,85683L,123201L,177147L,177957L,255879L,257049L,369603L,371293L,531441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107364Inst : IEnumerable<long>
{
public static readonly long[] Value=A107364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107364.Bytes);
public long this[int i]=>Value[i];

public static A107364Inst Instance=new A107364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107365
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,13L,16L,18L,21L,24L,26L,48L,79L,99L,110L,129L,140L,187L,304L,566L,670L,798L,905L,1020L,1119L,1346L,2266L,3354L,5140L,7043L,7854L,10548L,17986L,26886L,33861L,42373L,49100L,57393L,63954L,72099L,148934L,290510L,348529L,483751L,539780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107365Inst : IEnumerable<long>
{
public static readonly long[] Value=A107365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107365.Bytes);
public long this[int i]=>Value[i];

public static A107365Inst Instance=new A107365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107366
{
public static readonly long[] Value={ 0L,6L,8L,26L,36L,44L,48L,50L,54L,60L,68L,74L,104L,110L,114L,126L,140L,156L,158L,194L,198L,204L,210L,224L,228L,230L,258L,278L,288L,300L,314L,320L,326L,336L,344L,348L,378L,386L,396L,410L,428L,440L,450L,474L,476L,488L,510L,530L,534L,546L,560L,566L,578L,590L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107366Inst : IEnumerable<long>
{
public static readonly long[] Value=A107366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107366.Bytes);
public long this[int i]=>Value[i];

public static A107366Inst Instance=new A107366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107367
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,23L,59L,67L,101L,223L,449L,557L,601L,823L,4999L,5557L,6011L,8233L,9949L,57557L,60101L,82223L,94949L,555557L,600011L,822223L,994949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107367Inst : IEnumerable<long>
{
public static readonly long[] Value=A107367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107367.Bytes);
public long this[int i]=>Value[i];

public static A107367Inst Instance=new A107367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107368
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,1L,2L,3L,4L,6L,8L,12L,17L,25L,36L,52L,75L,108L,156L,225L,325L,469L,677L,977L,1410L,2035L,2937L,4239L,6118L,8830L,12744L,18393L,26546L,38313L,55296L,79807L,115183L,166240L,239929L,346282L,499778L,721314L,1041050L,1502515L,2168533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107368Inst : IEnumerable<long>
{
public static readonly long[] Value=A107368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107368.Bytes);
public long this[int i]=>Value[i];

public static A107368Inst Instance=new A107368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107369
{
public static readonly long[] Value={ 0L,2L,6L,14L,20L,30L,56L,66L,72L,74L,84L,90L,102L,116L,132L,134L,146L,150L,162L,164L,176L,186L,206L,212L,216L,224L,234L,240L,246L,254L,260L,282L,312L,314L,326L,332L,342L,344L,350L,354L,360L,366L,380L,402L,410L,414L,444L,450L,482L,486L,492L,510L,512L,534L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107369Inst : IEnumerable<long>
{
public static readonly long[] Value=A107369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107369.Bytes);
public long this[int i]=>Value[i];

public static A107369Inst Instance=new A107369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107370
{
public static readonly long[] Value={ 3L,0L,8L,7L,0L,6L,0L,6L,0L,9L,0L,5L,0L,3L,5L,8L,7L,3L,8L,4L,3L,9L,6L,8L,7L,1L,2L,0L,6L,3L,6L,7L,3L,7L,6L,9L,9L,0L,3L,9L,3L,9L,4L,4L,8L,1L,4L,4L,2L,7L,6L,8L,1L,1L,0L,0L,2L,5L,2L,6L,0L,7L,4L,3L,3L,3L,4L,7L,3L,0L,8L,9L,6L,9L,6L,2L,9L,4L,9L,6L,8L,0L,6L,3L,9L,4L,3L,0L,5L,4L,8L,7L,2L,1L,2L,5L,5L,8L,4L,8L,8L,5L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107370Inst : IEnumerable<long>
{
public static readonly long[] Value=A107370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107370.Bytes);
public long this[int i]=>Value[i];

public static A107370Inst Instance=new A107370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107371
{
public static readonly long[] Value={ 6L,10L,12L,30L,34L,36L,42L,54L,64L,66L,70L,76L,82L,94L,114L,124L,132L,136L,154L,160L,174L,180L,184L,190L,192L,210L,216L,234L,240L,250L,252L,264L,276L,292L,300L,306L,324L,342L,346L,352L,402L,406L,426L,436L,444L,454L,456L,462L,472L,484L,496L,502L,510L,532L,534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107371Inst : IEnumerable<long>
{
public static readonly long[] Value=A107371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107371.Bytes);
public long this[int i]=>Value[i];

public static A107371Inst Instance=new A107371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107372
{
public static readonly long[] Value={ 1L,4L,10L,18L,24L,36L,40L,46L,60L,64L,70L,76L,78L,88L,96L,124L,136L,144L,150L,154L,168L,178L,180L,190L,208L,210L,216L,234L,238L,244L,246L,256L,264L,294L,298L,318L,330L,334L,340L,346L,360L,378L,384L,388L,418L,420L,426L,430L,438L,444L,456L,460L,480L,486L,498L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107372Inst : IEnumerable<long>
{
public static readonly long[] Value=A107372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107372.Bytes);
public long this[int i]=>Value[i];

public static A107372Inst Instance=new A107372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107373
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,14L,38L,76L,187L,374L,874L,1748L,3958L,7916L,17548L,35096L,76627L,153254L,330818L,661636L,1415650L,2831300L,6015316L,12030632L,25413342L,50826684L,106853668L,213707336L,447472972L,894945944L,1867450648L,3734901296L,7770342787L,15540685574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107373Inst : IEnumerable<long>
{
public static readonly long[] Value=A107373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107373.Bytes);
public long this[int i]=>Value[i];

public static A107373Inst Instance=new A107373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107374
{
public static readonly BigInteger[] Value={ 2L,23L,37L,211L,311L,313L,317L,23691827L,236132639L,2711142277L,236918275481L,23671421424998147L,BigInteger.Parse("23611223366121242363"),BigInteger.Parse("27111422497798154539"),BigInteger.Parse("23611192233385766114209418627"),BigInteger.Parse("23611222333466669138253506759"),BigInteger.Parse("236918274154821232463697381107"),BigInteger.Parse("2361122333766741112224078141221") };
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
public class A107374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107374Inst Instance=new A107374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107375
{
public static readonly long[] Value={ 0L,1L,1L,2L,6L,29L,161L,928L,5388L,31333L,182269L,1060358L,6168762L,35887625L,208781333L,1214615068L,7066195896L,41108599753L,239155126777L,1391318970218L,8094196026894L,47089136800949L,273947751857609L,1593730016014072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107375Inst : IEnumerable<long>
{
public static readonly long[] Value=A107375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107375.Bytes);
public long this[int i]=>Value[i];

public static A107375Inst Instance=new A107375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107376
{
public static readonly long[] Value={ 0L,1L,1L,2L,7L,41L,272L,1853L,12677L,86794L,594315L,4069613L,27867056L,190822393L,1306675145L,8947587010L,61269485263L,419548848433L,2872902154816L,19672481099861L,134709256274733L,922434929990986L,6316464240083059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107376Inst : IEnumerable<long>
{
public static readonly long[] Value=A107376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107376.Bytes);
public long this[int i]=>Value[i];

public static A107376Inst Instance=new A107376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107377
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,19L,84L,393L,1865L,8886L,42381L,202187L,964640L,4602409L,21958729L,104768258L,499864605L,2384926971L,11378834836L,54290082897L,259025915025L,1235850473974L,5896423120549L,28132695944723L,134225201438720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107377Inst : IEnumerable<long>
{
public static readonly long[] Value=A107377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107377.Bytes);
public long this[int i]=>Value[i];

public static A107377Inst Instance=new A107377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107378
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,11L,35L,122L,440L,1609L,5913L,21770L,80204L,295555L,1089227L,4014322L,14794864L,54526993L,200961457L,740652050L,2729705364L,10060448635L,37078224883L,136653426026L,503642204200L,1856195468633L,6841089945545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107378Inst : IEnumerable<long>
{
public static readonly long[] Value=A107378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107378.Bytes);
public long this[int i]=>Value[i];

public static A107378Inst Instance=new A107378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107379
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,30L,110L,436L,1801L,7657L,33401L,148847L,674585L,3100410L,14422567L,67792847L,321546251L,1537241148L,7400926549L,35854579015L,174677578889L,855312650751L,4207291811538L,20782253017825L,103048079556241L,512753419159803L,2559639388956793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107379Inst : IEnumerable<long>
{
public static readonly long[] Value=A107379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107379.Bytes);
public long this[int i]=>Value[i];

public static A107379Inst Instance=new A107379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107380
{
public static readonly long[] Value={ 127L,193L,431L,705L,795L,798L,1282L,1601L,1635L,1659L,1784L,1862L,2245L,2257L,2301L,2424L,2532L,2635L,2776L,2830L,3007L,3022L,3076L,3089L,3125L,3193L,3296L,3307L,3325L,3349L,3546L,3609L,3649L,3741L,3895L,3932L,3940L,3958L,4065L,4093L,4153L,4318L,4489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107380Inst : IEnumerable<long>
{
public static readonly long[] Value=A107380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107380.Bytes);
public long this[int i]=>Value[i];

public static A107380Inst Instance=new A107380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107381
{
public static readonly long[] Value={ 4L,3L,9L,17L,40L,92L,215L,506L,1200L,2861L,6848L,16436L,39523L,95162L,229328L,552977L,1333920L,3218612L,7767575L,18747986L,45254200L,109241261L,263712248L,636626156L,1536900483L,3710323442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107381Inst : IEnumerable<long>
{
public static readonly long[] Value=A107381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107381.Bytes);
public long this[int i]=>Value[i];

public static A107381Inst Instance=new A107381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107382
{
public static readonly long[] Value={ 4L,4L,16L,52L,188L,684L,2512L,9244L,34052L,125476L,462416L,1704212L,6280892L,23148428L,85314448L,314430012L,1158845444L,4270975556L,15740867728L,58013659124L,213811888828L,788013108844L,2904256931152L,10703766510172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107382Inst : IEnumerable<long>
{
public static readonly long[] Value=A107382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107382.Bytes);
public long this[int i]=>Value[i];

public static A107382Inst Instance=new A107382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107383
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,6L,12L,20L,36L,64L,112L,200L,352L,624L,1104L,1952L,3456L,6112L,10816L,19136L,33856L,59904L,105984L,187520L,331776L,587008L,1038592L,1837568L,3251200L,5752320L,10177536L,18007040L,31859712L,56369152L,99733504L,176457728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107383Inst : IEnumerable<long>
{
public static readonly long[] Value=A107383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107383.Bytes);
public long this[int i]=>Value[i];

public static A107383Inst Instance=new A107383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107384
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,8L,20L,38L,83L,173L,362L,767L,1604L,3386L,7112L,14969L,31493L,66242L,139385L,293204L,616880L,1297766L,2730251L,5743937L,12084050L,25422563L,53483960L,112519838L,236719568L,498011393L,1047718217L,2204192882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107384Inst : IEnumerable<long>
{
public static readonly long[] Value=A107384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107384.Bytes);
public long this[int i]=>Value[i];

public static A107384Inst Instance=new A107384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107385
{
public static readonly long[] Value={ 0L,1L,1L,2L,6L,10L,30L,62L,158L,366L,878L,2094L,4974L,11886L,28270L,67438L,160622L,382830L,912238L,2173806L,5180270L,12344174L,29416302L,70097774L,167041902L,398056302L,948558702L,2260392814L,5386460014L,12835806062L,30587411310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107385Inst : IEnumerable<long>
{
public static readonly long[] Value=A107385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107385.Bytes);
public long this[int i]=>Value[i];

public static A107385Inst Instance=new A107385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107386
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,7L,9L,16L,20L,29L,35L,46L,54L,67L,77L,92L,104L,121L,135L,154L,170L,191L,209L,232L,252L,277L,299L,326L,350L,379L,405L,436L,464L,497L,527L,562L,594L,631L,665L,704L,740L,781L,819L,862L,902L,947L,989L,1036L,1080L,1129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107386Inst : IEnumerable<long>
{
public static readonly long[] Value=A107386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107386.Bytes);
public long this[int i]=>Value[i];

public static A107386Inst Instance=new A107386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107387
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,7L,16L,41L,105L,274L,715L,1871L,4896L,12817L,33553L,87842L,229971L,602071L,1576240L,4126649L,10803705L,28284466L,74049691L,193864607L,507544128L,1328767777L,3478759201L,9107509826L,23843770275L,62423800999L,163427632720L,427859097161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107387Inst : IEnumerable<long>
{
public static readonly long[] Value=A107387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107387.Bytes);
public long this[int i]=>Value[i];

public static A107387Inst Instance=new A107387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107388
{
public static readonly long[] Value={ 0L,1L,-1L,2L,4L,21L,75L,286L,1064L,3977L,14839L,55386L,206700L,771421L,2878979L,10744502L,40099024L,149651601L,558507375L,2084377906L,7779004244L,29031639077L,108347552059L,404358569166L,1509086724600L,5631988329241L,21018866592359L,78443478040202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107388Inst : IEnumerable<long>
{
public static readonly long[] Value=A107388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107388.Bytes);
public long this[int i]=>Value[i];

public static A107388Inst Instance=new A107388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107389
{
public static readonly long[] Value={ 0L,1L,-1L,2L,5L,31L,144L,697L,3335L,15986L,76589L,366967L,1758240L,8424241L,40362959L,193390562L,926589845L,4439558671L,21271203504L,101916458857L,488311090775L,2339638995026L,11209883884349L,53709780426727L,257339018249280L,1232985310819681L,5907587535849119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107389Inst : IEnumerable<long>
{
public static readonly long[] Value=A107389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107389.Bytes);
public long this[int i]=>Value[i];

public static A107389Inst Instance=new A107389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107390
{
public static readonly long[] Value={ 4L,6L,18L,36L,76L,147L,285L,532L,984L,1795L,3237L,5793L,10293L,18168L,31887L,55709L,96926L,167972L,290136L,499615L,857947L,1469576L,2511369L,4282663L,7289002L,12383250L,21002336L,35564859L,60136917L,101547211L,171253466L,288461204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107390Inst : IEnumerable<long>
{
public static readonly long[] Value=A107390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107390.Bytes);
public long this[int i]=>Value[i];

public static A107390Inst Instance=new A107390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107391
{
public static readonly BigInteger[] Value={ 24L,-896L,67584L,-4161536L,268959744L,-17171480576L,1099645845504L,-70366596694016L,4503633987108864L,-288229826395897856L,BigInteger.Parse("18446752869802573824"),BigInteger.Parse("-1180591479979922948096"),BigInteger.Parse("75557865977714137104384") };
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
public class A107391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107391Inst Instance=new A107391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107392
{
public static readonly long[] Value={ 7L,31L,103L,303L,831L,2175L,5503L,13567L,32767L,77823L,182271L,421887L,966655L,2195455L,4947967L,11075583L,24641535L,54525951L,120061951L,263192575L,574619647L,1249902591L,2709520383L,5855248383L,12616466431L,27111981055L,58116276223L,124285616127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107392Inst : IEnumerable<long>
{
public static readonly long[] Value=A107392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107392.Bytes);
public long this[int i]=>Value[i];

public static A107392Inst Instance=new A107392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107393
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,2L,-1L,2L,-1L,2L,0L,2L,-1L,2L,-1L,2L,1L,2L,-1L,2L,-1L,2L,1L,2L,-1L,2L,1L,2L,1L,2L,-1L,2L,-1L,2L,1L,2L,1L,2L,-1L,2L,1L,2L,-1L,2L,-1L,2L,1L,2L,-1L,2L,1L,2L,1L,2L,-1L,2L,1L,2L,1L,2L,-1L,2L,-1L,2L,1L,2L,1L,2L,-1L,2L,1L,2L,-1L,2L,-1L,2L,1L,2L,1L,2L,-1L,2L,1L,2L,-1L,2L,1L,2L,1L,2L,-1L,2L,1L,2L,1L,2L,1L,2L,-1L,2L,1L,2L,-1L,2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107393Inst : IEnumerable<long>
{
public static readonly long[] Value=A107393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107393.Bytes);
public long this[int i]=>Value[i];

public static A107393Inst Instance=new A107393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107394
{
public static readonly long[] Value={ 6L,30L,90L,210L,420L,756L,1260L,1980L,2970L,4290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107394Inst : IEnumerable<long>
{
public static readonly long[] Value=A107394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107394.Bytes);
public long this[int i]=>Value[i];

public static A107394Inst Instance=new A107394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107395
{
public static readonly long[] Value={ 15L,175L,1050L,4410L,14700L,41580L,103950L,235950L,495495L,975975L,1821820L,3248700L,5569200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107395Inst : IEnumerable<long>
{
public static readonly long[] Value=A107395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107395.Bytes);
public long this[int i]=>Value[i];

public static A107395Inst Instance=new A107395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107396
{
public static readonly long[] Value={ 21L,336L,2646L,14112L,58212L,199584L,594594L,1185584L,3864861L,8744736L,18582564L,37425024L,71954064L,132838272L,236618172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107396Inst : IEnumerable<long>
{
public static readonly long[] Value=A107396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107396.Bytes);
public long this[int i]=>Value[i];

public static A107396Inst Instance=new A107396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107397
{
public static readonly long[] Value={ 28L,588L,5880L,38804L,194040L,792792L,2774772L,8588580L,24048024L,61941880L,148660512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107397Inst : IEnumerable<long>
{
public static readonly long[] Value=A107397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107397.Bytes);
public long this[int i]=>Value[i];

public static A107397Inst Instance=new A107397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107398
{
public static readonly long[] Value={ 36L,960L,11880L,950740L,566280L,2718144L,11042460L,39262080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107398Inst : IEnumerable<long>
{
public static readonly long[] Value=A107398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107398.Bytes);
public long this[int i]=>Value[i];

public static A107398Inst Instance=new A107398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107399
{
public static readonly long[] Value={ 45L,1485L,22275L,212355L,1486485L,8281845L,38648610L,156434850L,563165460L,1837398420L,5512195260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107399Inst : IEnumerable<long>
{
public static readonly long[] Value=A107399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107399.Bytes);
public long this[int i]=>Value[i];

public static A107399Inst Instance=new A107399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107400
{
public static readonly long[] Value={ 0L,6L,14L,24L,30L,32L,42L,44L,56L,60L,80L,86L,90L,122L,126L,134L,146L,162L,164L,182L,186L,204L,224L,234L,242L,246L,252L,266L,276L,284L,290L,294L,302L,312L,330L,336L,354L,356L,360L,374L,386L,416L,422L,426L,440L,450L,452L,464L,482L,494L,500L,504L,506L,510L,554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107400Inst : IEnumerable<long>
{
public static readonly long[] Value=A107400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107400.Bytes);
public long this[int i]=>Value[i];

public static A107400Inst Instance=new A107400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107401
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,8L,10L,31L,36L,117L,133L,438L,495L,1636L,1846L,6107L,6888L,22793L,25705L,85066L,95931L,317472L,358018L,1184823L,1336140L,4421821L,4986541L,16502462L,18610023L,61588028L,69453550L,229849651L,259204176L,857810577L,967363153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107401Inst : IEnumerable<long>
{
public static readonly long[] Value=A107401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107401.Bytes);
public long this[int i]=>Value[i];

public static A107401Inst Instance=new A107401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107402
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,11L,12L,55L,55L,266L,261L,1277L,1248L,6121L,5977L,29330L,28635L,140531L,137196L,673327L,657343L,3226106L,3149517L,15457205L,15090240L,74059921L,72301681L,354842402L,346418163L,1700152091L,1659789132L,8145918055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107402Inst : IEnumerable<long>
{
public static readonly long[] Value=A107402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107402.Bytes);
public long this[int i]=>Value[i];

public static A107402Inst Instance=new A107402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107403
{
public static readonly BigInteger[] Value={ 1L,3L,18L,165L,2016L,30783L,564048L,12057825L,294587136L,8096756763L,247266851328L,8306410495485L,304403359942656L,12085026305182743L,516690458532292608L,BigInteger.Parse("23668814542820609145"),BigInteger.Parse("1156515067746149400576") };
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
public class A107403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107403Inst Instance=new A107403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107404
{
public static readonly ulong[] Value={ 1L,2L,6L,26L,144L,962L,7536L,67706L,685824L,7730882L,95970816L,1300815386L,19113775104L,302616787202L,5135568746496L,92996021795066L,1789758460329984L,36479831022049922L,785020114093080576L,17785273588395966746UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107404Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A107404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107404.Bytes);
public ulong this[int i]=>Value[i];

public static A107404Inst Instance=new A107404Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107405
{
public static readonly long[] Value={ 0L,6L,18L,20L,44L,50L,56L,78L,98L,104L,110L,120L,126L,134L,138L,144L,170L,174L,180L,188L,204L,218L,240L,246L,254L,258L,260L,266L,270L,284L,296L,306L,308L,324L,348L,354L,386L,396L,408L,410L,414L,420L,450L,456L,464L,476L,488L,510L,518L,524L,534L,540L,546L,554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107405Inst : IEnumerable<long>
{
public static readonly long[] Value=A107405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107405.Bytes);
public long this[int i]=>Value[i];

public static A107405Inst Instance=new A107405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107406
{
public static readonly long[] Value={ 24L,28L,34L,46L,54L,60L,78L,90L,94L,96L,108L,118L,124L,138L,144L,148L,154L,160L,186L,208L,216L,220L,238L,244L,250L,256L,274L,276L,280L,286L,288L,300L,306L,316L,330L,346L,358L,364L,376L,390L,414L,418L,424L,438L,484L,486L,490L,496L,504L,516L,538L,544L,546L,550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107406Inst : IEnumerable<long>
{
public static readonly long[] Value=A107406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107406.Bytes);
public long this[int i]=>Value[i];

public static A107406Inst Instance=new A107406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107407
{
public static readonly long[] Value={ 1L,6L,10L,12L,16L,30L,40L,54L,64L,70L,72L,82L,84L,94L,96L,106L,112L,120L,126L,132L,136L,160L,162L,166L,174L,184L,202L,204L,210L,220L,222L,226L,240L,244L,250L,252L,264L,274L,282L,292L,304L,306L,316L,330L,334L,342L,346L,352L,360L,364L,390L,394L,402L,420L,426L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107407Inst : IEnumerable<long>
{
public static readonly long[] Value=A107407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107407.Bytes);
public long this[int i]=>Value[i];

public static A107407Inst Instance=new A107407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107408
{
public static readonly long[] Value={ 0L,10L,1L,11L,2L,12L,3L,13L,4L,14L,5L,15L,6L,16L,7L,17L,8L,18L,9L,19L,100L,21L,23L,25L,27L,29L,101L,20L,22L,24L,26L,28L,102L,30L,31L,34L,37L,103L,40L,41L,35L,38L,110L,32L,45L,39L,112L,42L,36L,49L,113L,50L,51L,46L,104L,52L,47L,111L,33L,56L,114L,60L,61L,57L,120L,43L,67L,123L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107408Inst : IEnumerable<long>
{
public static readonly long[] Value=A107408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107408.Bytes);
public long this[int i]=>Value[i];

public static A107408Inst Instance=new A107408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107409
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,1L,0L,7L,8L,5L,0L,3L,8L,1L,2L,1L,4L,7L,2L,3L,2L,7L,2L,1L,0L,3L,4L,7L,4L,5L,6L,5L,6L,7L,8L,1L,6L,5L,2L,3L,0L,5L,8L,3L,6L,7L,6L,9L,2L,7L,8L,7L,2L,7L,6L,5L,8L,9L,2L,9L,0L,1L,0L,1L,2L,3L,6L,1L,0L,7L,8L,5L,0L,3L,8L,1L,2L,1L,4L,7L,2L,3L,2L,7L,2L,1L,0L,3L,4L,7L,4L,5L,6L,5L,6L,7L,8L,1L,6L,5L,2L,3L,0L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107409Inst : IEnumerable<long>
{
public static readonly long[] Value=A107409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107409.Bytes);
public long this[int i]=>Value[i];

public static A107409Inst Instance=new A107409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107410
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,2L,2L,1L,5L,8L,5L,0L,4L,0L,4L,8L,3L,6L,8L,8L,4L,2L,5L,2L,0L,7L,0L,7L,5L,3L,6L,5L,5L,7L,8L,2L,8L,0L,1L,0L,1L,2L,3L,6L,2L,2L,1L,5L,8L,5L,0L,4L,0L,4L,8L,3L,6L,8L,8L,4L,2L,5L,2L,0L,7L,0L,7L,5L,3L,6L,5L,5L,7L,8L,2L,8L,0L,1L,0L,1L,2L,3L,6L,2L,2L,1L,5L,8L,5L,0L,4L,0L,4L,8L,3L,6L,8L,8L,4L,2L,5L,2L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107410Inst : IEnumerable<long>
{
public static readonly long[] Value=A107410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107410.Bytes);
public long this[int i]=>Value[i];

public static A107410Inst Instance=new A107410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107411
{
public static readonly long[] Value={ 0L,10L,100L,101L,102L,120L,201L,210L,1002L,1012L,1020L,1021L,1022L,1023L,1032L,1203L,1230L,1302L,1320L,2013L,2031L,2103L,2130L,2301L,2310L,3012L,3021L,3102L,3120L,3201L,3210L,10023L,10032L,10123L,10132L,10230L,10231L,10232L,10233L,10234L,10243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107411Inst : IEnumerable<long>
{
public static readonly long[] Value=A107411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107411.Bytes);
public long this[int i]=>Value[i];

public static A107411Inst Instance=new A107411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107412
{
public static readonly long[] Value={ 94L,220L,241L,367L,379L,400L,421L,454L,538L,589L,640L,712L,736L,853L,880L,976L,1000L,1084L,1111L,1273L,1291L,1333L,1369L,1459L,1489L,1564L,1597L,1729L,1798L,1831L,1912L,1984L,2035L,2113L,2140L,2203L,2293L,2353L,2377L,2530L,2587L,2716L,2728L,2833L,2941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107412Inst : IEnumerable<long>
{
public static readonly long[] Value=A107412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107412.Bytes);
public long this[int i]=>Value[i];

public static A107412Inst Instance=new A107412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107413
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,15L,94L,641L,4399L,30232L,207793L,1428251L,9817006L,67476683L,463797507L,3187888306L,21911786295L,150609536029L,1035206899050L,7115441373087L,48907620283741L,336164012378182L,2310606047944781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107413Inst : IEnumerable<long>
{
public static readonly long[] Value=A107413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107413.Bytes);
public long this[int i]=>Value[i];

public static A107413Inst Instance=new A107413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107414
{
public static readonly long[] Value={ 2L,12L,6L,60L,78L,336L,18L,216L,96L,144L,120L,18L,510L,516L,336L,66L,60L,420L,144L,570L,570L,270L,120L,156L,54L,102L,102L,540L,504L,48L,582L,264L,210L,156L,156L,78L,30L,282L,354L,240L,156L,372L,24L,102L,150L,180L,306L,690L,120L,210L,204L,252L,144L,156L,240L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107414Inst : IEnumerable<long>
{
public static readonly long[] Value=A107414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107414.Bytes);
public long this[int i]=>Value[i];

public static A107414Inst Instance=new A107414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107415
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-3L,1L,12L,-20L,9L,-1L,288L,-492L,236L,-33L,1L,34560L,-59328L,28812L,-4196L,153L,-1L,24883200L,-42750720L,20803968L,-3049932L,114356L,-873L,1L,125411328000L,-215488512000L,104894749440L,-15392461248L,579404172L,-4514276L,5913L,-1L,5056584744960000L,-8688622215168000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107415Inst : IEnumerable<long>
{
public static readonly long[] Value=A107415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107415.Bytes);
public long this[int i]=>Value[i];

public static A107415Inst Instance=new A107415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107416
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-3L,1L,6L,-11L,6L,-1L,30L,-61L,41L,-11L,1L,240L,-518L,389L,-129L,19L,-1L,3120L,-6974L,5575L,-2066L,376L,-32L,1L,65520L,-149574L,124049L,-48961L,9962L,-1048L,53L,-1L,2227680L,-5151036L,4367240L,-1788723L,387669L,-45594L,2850L,-87L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107416Inst : IEnumerable<long>
{
public static readonly long[] Value=A107416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107416.Bytes);
public long this[int i]=>Value[i];

public static A107416Inst Instance=new A107416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107417
{
public static readonly long[] Value={ 1L,18L,126L,560L,1890L,5292L,12936L,28512L,57915L,110110L,198198L,340704L,563108L,899640L,1395360L,2108544L,3113397L,4503114L,6393310L,8925840L,12273030L,16642340L,22281480L,29484000L,38595375L,50019606L,64226358L,81758656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107417Inst : IEnumerable<long>
{
public static readonly long[] Value=A107417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107417.Bytes);
public long this[int i]=>Value[i];

public static A107417Inst Instance=new A107417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107418
{
public static readonly long[] Value={ 1L,28L,280L,1680L,7350L,25872L,77616L,205920L,495495L,1101100L,2290288L,4504864L,8446620L,15193920L,26356800L,44279424L,72299997L,115079580L,179012680L,272734000L,407737330L,599124240L,866502000L,1235052000L,1736791875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107418Inst : IEnumerable<long>
{
public static readonly long[] Value=A107418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107418.Bytes);
public long this[int i]=>Value[i];

public static A107418Inst Instance=new A107418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107419
{
public static readonly long[] Value={ 1L,40L,540L,4200L,23100L,99792L,360360L,1132560L,3185325L,8179600L,19467448L,43439760L,91706160L,184497600L,355816800L,661028544L,1187785665L,2071432440L,3516320500L,5824819000L,9436206780L,14978106000L,23333661000L,35728290000L,53840548125L,79942445856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107419Inst : IEnumerable<long>
{
public static readonly long[] Value=A107419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107419.Bytes);
public long this[int i]=>Value[i];

public static A107419Inst Instance=new A107419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107420
{
public static readonly long[] Value={ 1L,54L,945L,9240L,62370L,324324L,1387386L,5096520L,16563690L,48668620L,131405274L,330142176L,779502360L,1743502320L,3718285560L,7601828256L,14966099379L,28482196050L,52568991475L,94362067800L,165133618650L,282337298100L,472506635250L,775303893000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107420Inst : IEnumerable<long>
{
public static readonly long[] Value=A107420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107420.Bytes);
public long this[int i]=>Value[i];

public static A107420Inst Instance=new A107420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107421
{
public static readonly long[] Value={ 1L,70L,1540L,18480L,150150L,924924L,4624620L,19631040L,73002930L,243343100L,739763024L,2078672960L,5456516520L,13495999440L,31674284400L,70950397056L,152432493675L,315413948850L,630827897700L,1223211990000L,2305754601150L,4235059471500L,7595106655500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107421Inst : IEnumerable<long>
{
public static readonly long[] Value=A107421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107421.Bytes);
public long this[int i]=>Value[i];

public static A107421Inst Instance=new A107421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107422
{
public static readonly long[] Value={ 1L,88L,2376L,34320L,330330L,2378376L,13741728L,66745536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107422Inst : IEnumerable<long>
{
public static readonly long[] Value=A107422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107422.Bytes);
public long this[int i]=>Value[i];

public static A107422Inst Instance=new A107422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107423
{
public static readonly long[] Value={ 15L,35L,143L,899L,1763L,5183L,19043L,79523L,213443L,359999L,412163L,685583L,777923L,1192463L,1695203L,2585663L,4536899L,5143823L,5673923L,7225343L,12446783L,12659363L,12830723L,17040383L,17892899L,18818243L,20684303L,25100099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107423Inst : IEnumerable<long>
{
public static readonly long[] Value=A107423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107423.Bytes);
public long this[int i]=>Value[i];

public static A107423Inst Instance=new A107423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107424
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,3L,5L,2L,1L,0L,5L,17L,13L,3L,1L,0L,9L,43L,50L,20L,3L,1L,0L,16L,124L,220L,136L,36L,4L,1L,0L,28L,338L,866L,773L,296L,52L,4L,1L,0L,51L,941L,3435L,4280L,2303L,596L,78L,5L,1L,0L,93L,2591L,13250L,22430L,16317L,5817L,1080L,105L,5L,1L,0L,170L,7234L,51061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107424Inst : IEnumerable<long>
{
public static readonly long[] Value=A107424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107424.Bytes);
public long this[int i]=>Value[i];

public static A107424Inst Instance=new A107424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107425
{
public static readonly long[] Value={ 11L,58L,170L,184L,185L,208L,347L,354L,506L,523L,541L,561L,652L,655L,702L,703L,709L,710L,711L,730L,813L,814L,876L,925L,940L,947L,1012L,1062L,1157L,1164L,1173L,1174L,1213L,1269L,1326L,1375L,1412L,1429L,1430L,1486L,1534L,1537L,1544L,1545L,1590L,1657L,1682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107425Inst : IEnumerable<long>
{
public static readonly long[] Value=A107425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107425.Bytes);
public long this[int i]=>Value[i];

public static A107425Inst Instance=new A107425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107426
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,23L,31L,37L,41L,47L,71L,73L,89L,101L,109L,131L,197L,211L,271L,283L,367L,379L,443L,457L,461L,599L,661L,743L,773L,821L,823L,827L,911L,929L,941L,971L,977L,983L,991L,1013L,1033L,1051L,1093L,1163L,1181L,1237L,1259L,1289L,1291L,1307L,1321L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107426Inst : IEnumerable<long>
{
public static readonly long[] Value=A107426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107426.Bytes);
public long this[int i]=>Value[i];

public static A107426Inst Instance=new A107426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107427
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,7L,10L,14L,18L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107427Inst : IEnumerable<long>
{
public static readonly long[] Value=A107427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107427.Bytes);
public long this[int i]=>Value[i];

public static A107427Inst Instance=new A107427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107428
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,21L,39L,71L,141L,276L,542L,1070L,2110L,4189L,8351L,16618L,33134L,66129L,131937L,263483L,526453L,1051984L,2102582L,4203177L,8403116L,16800894L,33593742L,67174863L,134328816L,268624026L,537192064L,1074288649L,2148414285L,4296543181L,8592585289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107428Inst : IEnumerable<long>
{
public static readonly long[] Value=A107428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107428.Bytes);
public long this[int i]=>Value[i];

public static A107428Inst Instance=new A107428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107429
{
public static readonly long[] Value={ 1L,1L,3L,4L,8L,18L,33L,65L,127L,264L,515L,1037L,2052L,4103L,8217L,16408L,32811L,65590L,131127L,262112L,524409L,1048474L,2097319L,4194250L,8389414L,16778024L,33557921L,67116113L,134235473L,268471790L,536948820L,1073893571L,2147779943L,4295515305L,8590928746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107429Inst : IEnumerable<long>
{
public static readonly long[] Value=A107429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107429.Bytes);
public long this[int i]=>Value[i];

public static A107429Inst Instance=new A107429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107430
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,4L,6L,1L,1L,5L,5L,10L,10L,1L,1L,6L,6L,15L,15L,20L,1L,1L,7L,7L,21L,21L,35L,35L,1L,1L,8L,8L,28L,28L,56L,56L,70L,1L,1L,9L,9L,36L,36L,84L,84L,126L,126L,1L,1L,10L,10L,45L,45L,120L,120L,210L,210L,252L,1L,1L,11L,11L,55L,55L,165L,165L,330L,330L,462L,462L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107430Inst : IEnumerable<long>
{
public static readonly long[] Value=A107430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107430.Bytes);
public long this[int i]=>Value[i];

public static A107430Inst Instance=new A107430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107431
{
public static readonly long[] Value={ 3L,5L,4L,7L,4L,5L,9L,7L,5L,6L,11L,8L,7L,6L,3L,13L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107431Inst : IEnumerable<long>
{
public static readonly long[] Value=A107431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107431.Bytes);
public long this[int i]=>Value[i];

public static A107431Inst Instance=new A107431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107432
{
public static readonly long[] Value={ 1L,4L,4L,7L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107432Inst : IEnumerable<long>
{
public static readonly long[] Value=A107432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107432.Bytes);
public long this[int i]=>Value[i];

public static A107432Inst Instance=new A107432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107433
{
public static readonly long[] Value={ 0L,9L,10L,18L,19L,20L,27L,28L,31L,36L,37L,42L,45L,46L,50L,54L,55L,64L,65L,73L,76L,82L,87L,91L,98L,100L,108L,109L,110L,118L,119L,120L,127L,128L,129L,130L,136L,137L,138L,139L,140L,145L,146L,148L,149L,150L,154L,155L,158L,159L,160L,163L,164L,165L,168L,169L,170L,172L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107433Inst : IEnumerable<long>
{
public static readonly long[] Value=A107433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107433.Bytes);
public long this[int i]=>Value[i];

public static A107433Inst Instance=new A107433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107434
{
public static readonly long[] Value={ 0L,9L,10L,8L,1L,18L,11L,28L,7L,2L,17L,12L,27L,20L,19L,30L,6L,3L,16L,13L,26L,23L,36L,31L,38L,14L,5L,4L,15L,24L,25L,34L,35L,40L,29L,37L,21L,47L,22L,57L,32L,46L,33L,56L,39L,50L,41L,45L,42L,51L,43L,52L,44L,53L,48L,54L,49L,55L,64L,58L,61L,63L,60L,59L,70L,62L,67L,72L,71L,68L,73L,65L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107434Inst : IEnumerable<long>
{
public static readonly long[] Value=A107434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107434.Bytes);
public long this[int i]=>Value[i];

public static A107434Inst Instance=new A107434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107435
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,3L,2L,1L,1L,1L,3L,1L,4L,2L,2L,1L,1L,2L,1L,2L,3L,2L,3L,2L,1L,1L,1L,2L,2L,1L,3L,3L,2L,2L,1L,1L,2L,3L,3L,2L,3L,4L,4L,3L,2L,1L,1L,1L,1L,1L,3L,1L,4L,2L,2L,2L,2L,1L,1L,2L,2L,2L,4L,2L,3L,5L,3L,3L,3L,2L,1L,1L,1L,3L,2L,3L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107435Inst : IEnumerable<long>
{
public static readonly long[] Value=A107435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107435.Bytes);
public long this[int i]=>Value[i];

public static A107435Inst Instance=new A107435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107436
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107436Inst : IEnumerable<long>
{
public static readonly long[] Value=A107436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107436.Bytes);
public long this[int i]=>Value[i];

public static A107436Inst Instance=new A107436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107437
{
public static readonly long[] Value={ 5L,7L,5L,5L,5L,5L,6L,5L,5L,5L,6L,5L,6L,5L,5L,5L,5L,6L,7L,5L,5L,6L,5L,7L,5L,5L,5L,6L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,5L,6L,5L,5L,5L,7L,5L,5L,5L,5L,6L,5L,8L,5L,6L,5L,6L,5L,7L,5L,5L,6L,6L,5L,7L,5L,5L,6L,5L,5L,6L,5L,5L,5L,5L,5L,5L,6L,5L,7L,5L,6L,5L,6L,5L,5L,7L,9L,5L,5L,5L,7L,5L,7L,5L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107437Inst : IEnumerable<long>
{
public static readonly long[] Value=A107437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107437.Bytes);
public long this[int i]=>Value[i];

public static A107437Inst Instance=new A107437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107438
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,41L,47L,53L,71L,83L,101L,107L,113L,131L,137L,167L,173L,191L,197L,227L,251L,257L,281L,293L,311L,317L,347L,353L,383L,401L,431L,461L,467L,503L,521L,563L,587L,593L,641L,647L,677L,683L,701L,743L,773L,797L,821L,827L,857L,863L,887L,911L,941L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107438Inst : IEnumerable<long>
{
public static readonly long[] Value=A107438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107438.Bytes);
public long this[int i]=>Value[i];

public static A107438Inst Instance=new A107438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107439
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,23L,89L,113L,137L,149L,163L,181L,191L,233L,257L,263L,277L,283L,397L,419L,421L,443L,449L,461L,463L,509L,557L,569L,593L,599L,613L,619L,701L,719L,821L,823L,829L,857L,863L,877L,919L,1097L,1103L,1117L,1171L,1181L,1193L,1213L,1237L,1259L,1361L,1367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107439Inst : IEnumerable<long>
{
public static readonly long[] Value=A107439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107439.Bytes);
public long this[int i]=>Value[i];

public static A107439Inst Instance=new A107439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107440
{
public static readonly long[] Value={ 601L,1825891L,5091761L,8183891L,12909551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107440Inst : IEnumerable<long>
{
public static readonly long[] Value=A107440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107440.Bytes);
public long this[int i]=>Value[i];

public static A107440Inst Instance=new A107440Inst();

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