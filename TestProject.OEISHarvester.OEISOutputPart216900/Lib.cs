using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A255282
{
public static readonly long[] Value={ 1L,7L,31L,127L,511L,2031L,8043L,31735L,125063L,492367L,1937763L,7624303L,29995559L,118000431L,464192219L,1826013415L,7183010967L,28255752751L,111149170563L,437224979743L,1719900889847L,6765528227247L,26613372893339L,104688284286487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255282Inst : IEnumerable<long>
{
public static readonly long[] Value=A255282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255282.Bytes);
public long this[int i]=>Value[i];

public static A255282Inst Instance=new A255282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255283
{
public static readonly long[] Value={ 1L,7L,7L,31L,7L,49L,31L,145L,7L,49L,49L,217L,31L,217L,145L,601L,7L,49L,49L,217L,49L,343L,217L,1015L,31L,217L,217L,961L,145L,1015L,601L,2551L,7L,49L,49L,217L,49L,343L,217L,1015L,49L,343L,343L,1519L,217L,1519L,1015L,4207L,31L,217L,217L,961L,217L,1519L,961L,4495L,145L,1015L,1015L,4495L,601L,4207L,2551L,10351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255283Inst : IEnumerable<long>
{
public static readonly long[] Value=A255283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255283.Bytes);
public long this[int i]=>Value[i];

public static A255283Inst Instance=new A255283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255284
{
public static readonly long[] Value={ 1L,7L,31L,145L,601L,2551L,10351L,42433L,170761L,690247L,2768191L,11123185L,44543161L,178525591L,714455311L,2860291873L,11443638121L,45791846887L,183184681951L,732859788625L,2931560215321L,11727088287031L,46909200573871L,187642734275713L,750576869083081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255284Inst : IEnumerable<long>
{
public static readonly long[] Value=A255284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255284.Bytes);
public long this[int i]=>Value[i];

public static A255284Inst Instance=new A255284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255285
{
public static readonly BigInteger[] Value={ 1L,21L,111L,2001L,12021L,222111L,1001001L,21021021L,111111111L,2000000001L,12000000021L,222000000111L,1002000002001L,21012000012021L,111222000222111L,2002002001001001L,12012012021021021L,222222222111111111L,1000000001000000001L,BigInteger.Parse("21000000021000000021"),BigInteger.Parse("111000000111000000111") };
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
public class A255285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255285Inst Instance=new A255285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255286
{
public static readonly long[] Value={ 1L,7L,13L,55L,142L,715L,757L,5299L,9841L,39367L,98422L,511771L,570862L,3818644L,7421206L,29800819L,74505454L,387410647L,387440173L,2712081211L,5036722249L,21309209515L,55016504566L,277019723695L,293292210961L,2053045476727L,3812798742493L,15251194969975L,38127987424942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255286Inst : IEnumerable<long>
{
public static readonly long[] Value=A255286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255286.Bytes);
public long this[int i]=>Value[i];

public static A255286Inst Instance=new A255286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255287
{
public static readonly long[] Value={ 1L,8L,8L,8L,64L,52L,8L,64L,101L,8L,64L,64L,64L,512L,404L,52L,416L,448L,8L,64L,233L,64L,512L,700L,101L,808L,992L,8L,64L,64L,64L,512L,416L,64L,512L,808L,64L,512L,512L,512L,4096L,3220L,404L,3232L,3224L,52L,416L,832L,416L,3328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255287Inst : IEnumerable<long>
{
public static readonly long[] Value=A255287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255287.Bytes);
public long this[int i]=>Value[i];

public static A255287Inst Instance=new A255287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255288
{
public static readonly long[] Value={ 0L,0L,13L,0L,0L,32L,13L,104L,112L,0L,0L,104L,0L,0L,184L,32L,256L,296L,13L,104L,208L,104L,832L,836L,112L,896L,1081L,0L,0L,104L,0L,0L,256L,104L,832L,896L,0L,0L,832L,0L,0L,1400L,184L,1472L,1768L,32L,256L,932L,256L,2048L,2692L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255288Inst : IEnumerable<long>
{
public static readonly long[] Value=A255288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255288.Bytes);
public long this[int i]=>Value[i];

public static A255288Inst Instance=new A255288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255289
{
public static readonly long[] Value={ 1L,4L,12L,4L,32L,48L,12L,84L,117L,4L,32L,84L,32L,256L,300L,48L,336L,324L,12L,84L,225L,84L,672L,792L,117L,852L,876L,4L,32L,84L,32L,256L,336L,84L,672L,852L,32L,256L,672L,256L,2048L,2316L,300L,2352L,2448L,48L,336L,900L,336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255289Inst : IEnumerable<long>
{
public static readonly long[] Value=A255289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255289.Bytes);
public long this[int i]=>Value[i];

public static A255289Inst Instance=new A255289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255290
{
public static readonly long[] Value={ 0L,4L,9L,4L,32L,36L,9L,84L,96L,4L,32L,84L,32L,256L,288L,36L,336L,420L,9L,84L,216L,84L,672L,744L,96L,852L,1197L,4L,32L,84L,32L,256L,336L,84L,672L,852L,32L,256L,672L,256L,2048L,2304L,288L,2352L,2544L,36L,336L,864L,336L,2688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255290Inst : IEnumerable<long>
{
public static readonly long[] Value=A255290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255290.Bytes);
public long this[int i]=>Value[i];

public static A255290Inst Instance=new A255290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255291
{
public static readonly long[] Value={ 1L,5L,4L,5L,25L,12L,4L,20L,69L,5L,25L,20L,25L,125L,52L,12L,60L,281L,4L,20L,97L,20L,100L,353L,69L,345L,448L,5L,25L,20L,25L,125L,60L,20L,100L,345L,25L,125L,100L,125L,625L,252L,52L,260L,1341L,12L,60L,381L,60L,300L,1413L,281L,1405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255291Inst : IEnumerable<long>
{
public static readonly long[] Value=A255291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255291.Bytes);
public long this[int i]=>Value[i];

public static A255291Inst Instance=new A255291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255292
{
public static readonly long[] Value={ 0L,0L,9L,0L,0L,37L,9L,45L,44L,0L,0L,45L,0L,0L,177L,37L,185L,156L,9L,45L,72L,45L,225L,228L,44L,220L,573L,0L,0L,45L,0L,0L,185L,45L,225L,220L,0L,0L,225L,0L,0L,877L,177L,885L,716L,37L,185L,256L,185L,925L,788L,156L,780L,2281L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255292Inst : IEnumerable<long>
{
public static readonly long[] Value=A255292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255292.Bytes);
public long this[int i]=>Value[i];

public static A255292Inst Instance=new A255292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255293
{
public static readonly long[] Value={ 1L,4L,8L,4L,17L,29L,8L,37L,49L,4L,17L,37L,17L,76L,128L,29L,136L,196L,8L,37L,89L,37L,176L,292L,49L,260L,584L,4L,17L,37L,17L,76L,136L,37L,176L,260L,17L,76L,176L,76L,353L,605L,128L,613L,961L,29L,136L,332L,136L,653L,1105L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255293Inst : IEnumerable<long>
{
public static readonly long[] Value=A255293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255293.Bytes);
public long this[int i]=>Value[i];

public static A255293Inst Instance=new A255293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255294
{
public static readonly long[] Value={ 0L,1L,5L,1L,8L,20L,5L,28L,64L,1L,8L,28L,8L,49L,101L,20L,109L,241L,5L,28L,80L,28L,149L,289L,64L,305L,437L,1L,8L,28L,8L,49L,109L,28L,149L,305L,8L,49L,149L,49L,272L,524L,101L,532L,1096L,20L,109L,305L,109L,572L,1096L,241L,1160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255294Inst : IEnumerable<long>
{
public static readonly long[] Value=A255294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255294.Bytes);
public long this[int i]=>Value[i];

public static A255294Inst Instance=new A255294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255295
{
public static readonly long[] Value={ 1L,6L,6L,24L,6L,36L,24L,92L,6L,36L,36L,144L,24L,144L,92L,340L,6L,36L,36L,144L,36L,216L,144L,552L,24L,144L,144L,576L,92L,552L,340L,1236L,6L,36L,36L,144L,36L,216L,144L,552L,36L,216L,216L,864L,144L,864L,552L,2040L,24L,144L,144L,576L,144L,864L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255295Inst : IEnumerable<long>
{
public static readonly long[] Value=A255295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255295.Bytes);
public long this[int i]=>Value[i];

public static A255295Inst Instance=new A255295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255296
{
public static readonly long[] Value={ 1L,6L,24L,92L,340L,1236L,4452L,15956L,57028L,203508L,725604L,2585876L,9212932L,32818740L,116898468L,416365652L,1482959428L,5281740660L,18811402980L,66998214548L,238618498180L,849854020788L,3026803253028L,10780126189268L,38394001851076L,136742291486196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255296Inst : IEnumerable<long>
{
public static readonly long[] Value=A255296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255296.Bytes);
public long this[int i]=>Value[i];

public static A255296Inst Instance=new A255296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255297
{
public static readonly long[] Value={ 1L,4L,4L,14L,4L,16L,14L,46L,4L,16L,16L,56L,14L,56L,46L,146L,4L,16L,16L,56L,16L,64L,56L,184L,14L,56L,56L,196L,46L,184L,146L,454L,4L,16L,16L,56L,16L,64L,56L,184L,16L,64L,64L,224L,56L,224L,184L,584L,14L,56L,56L,196L,56L,224L,196L,644L,46L,184L,184L,644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255297Inst : IEnumerable<long>
{
public static readonly long[] Value=A255297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255297.Bytes);
public long this[int i]=>Value[i];

public static A255297Inst Instance=new A255297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255298
{
public static readonly long[] Value={ 1L,4L,4L,16L,4L,16L,16L,58L,4L,16L,16L,64L,16L,64L,58L,204L,4L,16L,16L,64L,16L,64L,64L,232L,16L,64L,64L,256L,58L,232L,204L,714L,4L,16L,16L,64L,16L,64L,64L,232L,16L,64L,64L,256L,64L,256L,232L,816L,16L,64L,64L,256L,64L,256L,256L,928L,58L,232L,232L,928L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255298Inst : IEnumerable<long>
{
public static readonly long[] Value=A255298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255298.Bytes);
public long this[int i]=>Value[i];

public static A255298Inst Instance=new A255298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255299
{
public static readonly long[] Value={ 1L,4L,16L,58L,204L,714L,2492L,8682L,30228L,105226L,366276L,1274922L,4437692L,15446554L,53765916L,187147146L,651418116L,2267444842L,7892485300L,27472040138L,95624259340L,332847482970L,1158570537292L,4032735032490L,14037083980308L,48860072772074L,170071413502180L,591982043090090L,2060562279111580L,7172374493538586L,24965494321148156L,86899520830961866L,302478557946941732L,1052862859805769450L,3664789362535367700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255299Inst : IEnumerable<long>
{
public static readonly long[] Value=A255299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255299.Bytes);
public long this[int i]=>Value[i];

public static A255299Inst Instance=new A255299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255300
{
public static readonly long[] Value={ 1L,4L,4L,16L,4L,16L,16L,56L,4L,16L,16L,64L,16L,64L,56L,196L,4L,16L,16L,64L,16L,64L,64L,224L,16L,64L,64L,256L,56L,224L,196L,680L,4L,16L,16L,64L,16L,64L,64L,224L,16L,64L,64L,256L,64L,256L,224L,784L,16L,64L,64L,256L,64L,256L,256L,896L,56L,224L,224L,896L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255300Inst : IEnumerable<long>
{
public static readonly long[] Value=A255300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255300.Bytes);
public long this[int i]=>Value[i];

public static A255300Inst Instance=new A255300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255301
{
public static readonly long[] Value={ 1L,4L,16L,56L,196L,680L,2348L,8096L,27892L,96056L,330748L,1138768L,3920644L,13498088L,46471180L,159990272L,550811156L,1896319640L,6528602140L,22476505520L,77381536036L,266407155784L,917179667500L,3157642420064L,10871049557044L,37426567849976L,128851218332732L,443605636686608L,1527233994485572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255301Inst : IEnumerable<long>
{
public static readonly long[] Value=A255301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255301.Bytes);
public long this[int i]=>Value[i];

public static A255301Inst Instance=new A255301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255302
{
public static readonly long[] Value={ 1L,4L,4L,16L,4L,16L,16L,60L,4L,16L,16L,64L,16L,64L,60L,216L,4L,16L,16L,64L,16L,64L,64L,240L,16L,64L,64L,256L,60L,240L,216L,768L,4L,16L,16L,64L,16L,64L,64L,240L,16L,64L,64L,256L,64L,256L,240L,864L,16L,64L,64L,256L,64L,256L,256L,960L,60L,240L,240L,960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255302Inst : IEnumerable<long>
{
public static readonly long[] Value=A255302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255302.Bytes);
public long this[int i]=>Value[i];

public static A255302Inst Instance=new A255302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255303
{
public static readonly long[] Value={ 1L,4L,16L,60L,216L,768L,2728L,9704L,34552L,123064L,438328L,1561176L,5560248L,19803096L,70529656L,251194904L,894643768L,3186321112L,11348251384L,40417397400L,143948695992L,512680882776L,1825940038264L,6503181876248L,23161425701176L,82490640856024L,293794773978616L,1046365603664280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255303Inst : IEnumerable<long>
{
public static readonly long[] Value=A255303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255303.Bytes);
public long this[int i]=>Value[i];

public static A255303Inst Instance=new A255303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255304
{
public static readonly long[] Value={ 1L,5L,5L,15L,5L,25L,15L,51L,5L,25L,25L,75L,15L,75L,51L,153L,5L,25L,25L,75L,25L,125L,75L,255L,15L,75L,75L,225L,51L,255L,153L,477L,5L,25L,25L,75L,25L,125L,75L,255L,25L,125L,125L,375L,75L,375L,255L,765L,15L,75L,75L,225L,75L,375L,225L,765L,51L,255L,255L,765L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255304Inst : IEnumerable<long>
{
public static readonly long[] Value=A255304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255304.Bytes);
public long this[int i]=>Value[i];

public static A255304Inst Instance=new A255304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255305
{
public static readonly long[] Value={ 6L,23L,299L,3439L,51637L,894211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255305Inst : IEnumerable<long>
{
public static readonly long[] Value=A255305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255305.Bytes);
public long this[int i]=>Value[i];

public static A255305Inst Instance=new A255305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255306
{
public static readonly long[] Value={ 2L,0L,1L,9L,4L,1L,8L,3L,5L,7L,5L,5L,3L,7L,9L,6L,3L,4L,5L,3L,2L,0L,2L,9L,0L,5L,2L,1L,1L,6L,7L,0L,9L,9L,5L,8L,9L,9L,4L,8L,2L,8L,0L,9L,5L,2L,1L,3L,4L,4L,4L,9L,6L,0L,5L,1L,3L,1L,9L,6L,4L,8L,7L,2L,6L,7L,9L,3L,1L,4L,9L,5L,9L,2L,1L,0L,4L,8L,2L,4L,0L,5L,8L,2L,2L,2L,5L,9L,3L,1L,6L,5L,2L,6L,3L,4L,0L,0L,3L,0L,6L,4L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255306Inst : IEnumerable<long>
{
public static readonly long[] Value=A255306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255306.Bytes);
public long this[int i]=>Value[i];

public static A255306Inst Instance=new A255306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255307
{
public static readonly BigInteger[] Value={ 1L,12L,122L,1224L,12242L,122424L,1224242L,12242424L,122424246L,1224242462L,12242424626L,122424246264L,1224242462642L,12242424626424L,122424246264246L,1224242462642466L,12242424626424662L,122424246264246626L,1224242462642466264L,12242424626424662642UL,BigInteger.Parse("122424246264246626426") };
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
public class A255307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255307Inst Instance=new A255307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255308
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255308Inst : IEnumerable<long>
{
public static readonly long[] Value=A255308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255308.Bytes);
public long this[int i]=>Value[i];

public static A255308Inst Instance=new A255308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255309
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255309Inst : IEnumerable<long>
{
public static readonly long[] Value=A255309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255309.Bytes);
public long this[int i]=>Value[i];

public static A255309Inst Instance=new A255309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255310
{
public static readonly long[] Value={ 2L,5L,6L,11L,20L,21L,22L,39L,72L,137L,266L,267L,524L,1037L,2062L,4111L,8208L,16401L,32786L,65555L,65556L,65557L,65558L,131095L,262168L,524313L,1048602L,2097179L,4194332L,8388637L,16777246L,33554463L,67108896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255310Inst : IEnumerable<long>
{
public static readonly long[] Value=A255310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255310.Bytes);
public long this[int i]=>Value[i];

public static A255310Inst Instance=new A255310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255311
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,2L,4L,6L,2L,6L,4L,2L,4L,6L,6L,2L,6L,4L,2L,6L,4L,6L,8L,4L,2L,4L,2L,4L,1L,4L,4L,6L,2L,1L,0L,2L,6L,6L,4L,6L,6L,2L,1L,0L,2L,4L,2L,1L,2L,1L,2L,4L,2L,4L,6L,2L,1L,0L,6L,6L,6L,2L,6L,4L,2L,1L,0L,1L,4L,4L,2L,4L,1L,4L,6L,1L,0L,2L,4L,6L,8L,6L,6L,4L,6L,8L,4L,8L,1L,0L,2L,1L,0L,2L,6L,4L,6L,8L,4L,2L,4L,1L,2L,8L,4L,8L,4L,6L,1L,2L,2L,1L,8L,6L,1L,0L,6L,6L,2L,6L,1L,0L,6L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255311Inst : IEnumerable<long>
{
public static readonly long[] Value=A255311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255311.Bytes);
public long this[int i]=>Value[i];

public static A255311Inst Instance=new A255311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255312
{
public static readonly long[] Value={ 1L,2L,3L,4L,26L,27L,35L,36L,37L,47L,153L,206L,254L,255L,267L,326L,334L,543L,544L,550L,573L,590L,604L,719L,720L,965L,1327L,1340L,1353L,1354L,1414L,1423L,1453L,1474L,1579L,1589L,1598L,1762L,1856L,2105L,2840L,2921L,2922L,2928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255312Inst : IEnumerable<long>
{
public static readonly long[] Value=A255312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255312.Bytes);
public long this[int i]=>Value[i];

public static A255312Inst Instance=new A255312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255313
{
public static readonly long[] Value={ 3L,5L,3L,7L,5L,3L,7L,5L,7L,5L,11L,7L,5L,7L,5L,13L,11L,7L,5L,7L,5L,13L,11L,13L,11L,7L,5L,3L,17L,13L,11L,13L,11L,7L,5L,3L,19L,17L,13L,11L,13L,11L,7L,5L,3L,19L,17L,19L,17L,13L,11L,7L,5L,7L,5L,23L,19L,17L,19L,17L,13L,11L,7L,5L,7L,5L,23L,19L,17L,19L,23L,19L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255313Inst : IEnumerable<long>
{
public static readonly long[] Value=A255313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255313.Bytes);
public long this[int i]=>Value[i];

public static A255313Inst Instance=new A255313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255314
{
public static readonly long[] Value={ 7L,43L,157L,421L,8191L,12211L,74257L,117307L,660157L,985057L,1588861L,2435161L,3263443L,4676407L,6004951L,8193907L,12535141L,18408391L,20761693L,27630793L,34251757L,36078043L,55987807L,79753831L,94138507L,106141507L,119257321L,197191807L,217931407L,225195043L,281249671L,357455743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255314Inst : IEnumerable<long>
{
public static readonly long[] Value=A255314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255314.Bytes);
public long this[int i]=>Value[i];

public static A255314Inst Instance=new A255314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255315
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,0L,2L,1L,1L,1L,0L,1L,2L,1L,1L,1L,0L,1L,2L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,0L,0L,2L,2L,1L,1L,1L,1L,1L,0L,0L,2L,1L,2L,1L,1L,1L,1L,1L,0L,0L,2L,1L,2L,1L,1L,1L,1L,1L,1L,0L,0L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255315Inst : IEnumerable<long>
{
public static readonly long[] Value=A255315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255315.Bytes);
public long this[int i]=>Value[i];

public static A255315Inst Instance=new A255315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255316
{
public static readonly long[] Value={ 3L,3L,5L,3L,5L,7L,5L,7L,5L,7L,11L,5L,7L,11L,13L,3L,5L,7L,11L,13L,3L,5L,7L,11L,13L,17L,3L,5L,7L,11L,13L,17L,19L,5L,7L,11L,13L,17L,19L,5L,7L,11L,13L,17L,19L,23L,5L,7L,11L,13L,17L,19L,23L,3L,7L,11L,13L,17L,19L,23L,3L,7L,11L,13L,17L,19L,23L,29L,3L,7L,11L,13L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255316Inst : IEnumerable<long>
{
public static readonly long[] Value=A255316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255316.Bytes);
public long this[int i]=>Value[i];

public static A255316Inst Instance=new A255316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255317
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,1L,2L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,2L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,2L,2L,0L,1L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,0L,2L,2L,0L,1L,1L,2L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,2L,2L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255317Inst : IEnumerable<long>
{
public static readonly long[] Value=A255317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255317.Bytes);
public long this[int i]=>Value[i];

public static A255317Inst Instance=new A255317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255318
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,2L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,2L,0L,2L,2L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,2L,1L,0L,2L,1L,1L,0L,0L,1L,1L,1L,2L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,2L,0L,0L,2L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255318Inst : IEnumerable<long>
{
public static readonly long[] Value=A255318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255318.Bytes);
public long this[int i]=>Value[i];

public static A255318Inst Instance=new A255318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255319
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,0L,2L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,2L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,2L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,2L,0L,0L,1L,1L,2L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,2L,1L,2L,1L,0L,2L,0L,1L,1L,0L,0L,2L,0L,0L,0L,1L,1L,0L,0L,0L,1L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255319Inst : IEnumerable<long>
{
public static readonly long[] Value=A255319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255319.Bytes);
public long this[int i]=>Value[i];

public static A255319Inst Instance=new A255319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255320
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,-1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255320Inst : IEnumerable<long>
{
public static readonly long[] Value=A255320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255320.Bytes);
public long this[int i]=>Value[i];

public static A255320Inst Instance=new A255320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255321
{
public static readonly BigInteger[] Value={ 1L,256L,1952152956156672L,BigInteger.Parse("664283228512699358734362008580999708796213453161234432") };
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
public class A255321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255321Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255321.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255321Inst Instance=new A255321Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255322
{
public static readonly BigInteger[] Value={ 1L,1L,24L,8709120L,BigInteger.Parse("182219087869378560000"),BigInteger.Parse("2826438545846116156142906806150103040000000000"),BigInteger.Parse("1051416277636507481568264360276689674557030810000137484550133942059008000000000000000000") };
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
public class A255322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255322Inst Instance=new A255322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255323
{
public static readonly BigInteger[] Value={ 1L,65536L,BigInteger.Parse("29060398333495723291328487792256607374737408") };
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
public class A255323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255323Inst Instance=new A255323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255324
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,4L,2L,0L,6L,4L,2L,4L,6L,8L,8L,10L,10L,12L,16L,12L,14L,18L,18L,18L,18L,20L,22L,30L,22L,26L,24L,34L,26L,28L,24L,30L,42L,38L,42L,42L,36L,40L,38L,40L,36L,34L,38L,48L,50L,48L,60L,56L,56L,66L,62L,66L,64L,72L,76L,68L,70L,72L,76L,80L,76L,78L,72L,72L,78L,74L,70L,72L,84L,84L,86L,84L,92L,88L,84L,88L,86L,94L,96L,98L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255324Inst : IEnumerable<long>
{
public static readonly long[] Value=A255324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255324.Bytes);
public long this[int i]=>Value[i];

public static A255324Inst Instance=new A255324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255325
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,3L,2L,1L,2L,3L,4L,4L,5L,5L,6L,8L,6L,7L,9L,9L,9L,9L,10L,11L,15L,11L,13L,12L,17L,13L,14L,12L,15L,21L,19L,21L,21L,18L,20L,19L,20L,18L,17L,19L,24L,25L,24L,30L,28L,28L,33L,31L,33L,32L,36L,38L,34L,35L,36L,38L,40L,38L,39L,36L,36L,39L,37L,35L,36L,42L,42L,43L,42L,46L,44L,42L,44L,43L,47L,48L,49L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255325Inst : IEnumerable<long>
{
public static readonly long[] Value=A255325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255325.Bytes);
public long this[int i]=>Value[i];

public static A255325Inst Instance=new A255325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255326
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,4L,3L,1L,5L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,4L,1L,3L,2L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,2L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255326Inst : IEnumerable<long>
{
public static readonly long[] Value=A255326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255326.Bytes);
public long this[int i]=>Value[i];

public static A255326Inst Instance=new A255326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255327
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,5L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,0L,1L,3L,1L,0L,1L,2L,1L,4L,1L,0L,1L,2L,1L,0L,1L,5L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,0L,1L,3L,1L,0L,1L,2L,1L,10L,1L,0L,1L,8L,1L,0L,1L,3L,1L,2L,1L,0L,1L,2L,1L,4L,1L,0L,1L,2L,1L,0L,1L,0L,1L,3L,1L,0L,1L,2L,1L,4L,1L,0L,1L,2L,1L,0L,1L,5L,1L,0L,1L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255327Inst : IEnumerable<long>
{
public static readonly long[] Value=A255327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255327.Bytes);
public long this[int i]=>Value[i];

public static A255327Inst Instance=new A255327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255328
{
public static readonly long[] Value={ 1L,1L,0L,4L,0L,0L,7L,0L,3L,0L,0L,1L,1L,6L,0L,6L,0L,3L,0L,0L,1L,1L,12L,0L,1L,5L,0L,0L,1L,6L,0L,6L,0L,3L,0L,0L,1L,1L,12L,0L,1L,0L,0L,12L,1L,0L,1L,5L,0L,0L,1L,12L,0L,1L,5L,0L,0L,1L,6L,0L,6L,0L,3L,0L,0L,1L,1L,12L,0L,1L,0L,0L,12L,1L,0L,1L,0L,0L,10L,1L,0L,0L,0L,11L,1L,0L,1L,5L,0L,0L,1L,12L,0L,1L,0L,0L,12L,1L,0L,1L,5L,0L,0L,1L,12L,0L,1L,5L,0L,0L,1L,6L,0L,6L,0L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255328Inst : IEnumerable<long>
{
public static readonly long[] Value=A255328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255328.Bytes);
public long this[int i]=>Value[i];

public static A255328Inst Instance=new A255328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255329
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,4L,1L,0L,0L,0L,0L,0L,1L,0L,4L,1L,0L,0L,1L,0L,0L,4L,1L,0L,0L,0L,0L,0L,1L,0L,4L,1L,0L,0L,1L,7L,1L,0L,3L,0L,1L,0L,0L,4L,1L,0L,0L,1L,0L,0L,4L,1L,0L,0L,0L,0L,0L,1L,0L,4L,1L,0L,0L,1L,7L,1L,0L,3L,0L,1L,7L,1L,0L,16L,0L,0L,1L,0L,3L,0L,1L,0L,0L,4L,1L,0L,0L,1L,7L,1L,0L,3L,0L,1L,0L,0L,4L,1L,0L,0L,1L,0L,0L,4L,1L,0L,0L,0L,0L,0L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255329Inst : IEnumerable<long>
{
public static readonly long[] Value=A255329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255329.Bytes);
public long this[int i]=>Value[i];

public static A255329Inst Instance=new A255329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255330
{
public static readonly long[] Value={ 1L,2L,0L,4L,1L,0L,7L,0L,3L,1L,0L,5L,2L,6L,0L,6L,0L,3L,1L,0L,5L,2L,12L,0L,2L,5L,0L,4L,2L,6L,0L,6L,0L,3L,1L,0L,5L,2L,12L,0L,2L,7L,1L,12L,4L,0L,2L,5L,0L,4L,2L,12L,0L,2L,5L,0L,4L,2L,6L,0L,6L,0L,3L,1L,0L,5L,2L,12L,0L,2L,7L,1L,12L,4L,0L,2L,7L,1L,10L,17L,0L,0L,1L,11L,4L,0L,2L,5L,0L,4L,2L,12L,0L,2L,7L,1L,12L,4L,0L,2L,5L,0L,4L,2L,12L,0L,2L,5L,0L,4L,2L,6L,0L,6L,0L,3L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255330Inst : IEnumerable<long>
{
public static readonly long[] Value=A255330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255330.Bytes);
public long this[int i]=>Value[i];

public static A255330Inst Instance=new A255330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255331
{
public static readonly long[] Value={ -1L,0L,0L,-4L,1L,0L,-7L,0L,-3L,1L,0L,3L,0L,-6L,0L,-6L,0L,-3L,1L,0L,3L,0L,-12L,0L,0L,-5L,0L,4L,0L,-6L,0L,-6L,0L,-3L,1L,0L,3L,0L,-12L,0L,0L,7L,1L,-12L,2L,0L,0L,-5L,0L,4L,0L,-12L,0L,0L,-5L,0L,4L,0L,-6L,0L,-6L,0L,-3L,1L,0L,3L,0L,-12L,0L,0L,7L,1L,-12L,2L,0L,0L,7L,1L,-10L,15L,0L,0L,1L,-11L,2L,0L,0L,-5L,0L,4L,0L,-12L,0L,0L,7L,1L,-12L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255331Inst : IEnumerable<long>
{
public static readonly long[] Value=A255331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255331.Bytes);
public long this[int i]=>Value[i];

public static A255331Inst Instance=new A255331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255332
{
public static readonly long[] Value={ -1L,-1L,-1L,-5L,-4L,-4L,-11L,-11L,-14L,-13L,-13L,-10L,-10L,-16L,-16L,-22L,-22L,-25L,-24L,-24L,-21L,-21L,-33L,-33L,-33L,-38L,-38L,-34L,-34L,-40L,-40L,-46L,-46L,-49L,-48L,-48L,-45L,-45L,-57L,-57L,-57L,-50L,-49L,-61L,-59L,-59L,-59L,-64L,-64L,-60L,-60L,-72L,-72L,-72L,-77L,-77L,-73L,-73L,-79L,-79L,-85L,-85L,-88L,-87L,-87L,-84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255332Inst : IEnumerable<long>
{
public static readonly long[] Value=A255332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255332.Bytes);
public long this[int i]=>Value[i];

public static A255332Inst Instance=new A255332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255333
{
public static readonly long[] Value={ 1L,3L,3L,7L,8L,8L,15L,15L,18L,19L,19L,24L,26L,32L,32L,38L,38L,41L,42L,42L,47L,49L,61L,61L,63L,68L,68L,72L,74L,80L,80L,86L,86L,89L,90L,90L,95L,97L,109L,109L,111L,118L,119L,131L,135L,135L,137L,142L,142L,146L,148L,160L,160L,162L,167L,167L,171L,173L,179L,179L,185L,185L,188L,189L,189L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255333Inst : IEnumerable<long>
{
public static readonly long[] Value=A255333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255333.Bytes);
public long this[int i]=>Value[i];

public static A255333Inst Instance=new A255333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255334
{
public static readonly long[] Value={ 1512L,7560L,16632L,19656L,25704L,28728L,34776L,37800L,43848L,44928L,46872L,55944L,61992L,65016L,71064L,80136L,83160L,89208L,92232L,98280L,101304L,107352L,110376L,119448L,125496L,128520L,134568L,143640L,146664L,152712L,155736L,161784L,164808L,170856L,173880L,182952L,189000L,192024L,198072L,207144L,210168L,216216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255334Inst : IEnumerable<long>
{
public static readonly long[] Value=A255334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255334.Bytes);
public long this[int i]=>Value[i];

public static A255334Inst Instance=new A255334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255335
{
public static readonly long[] Value={ 2058L,10290L,22638L,26754L,34986L,39102L,47334L,51450L,52728L,59682L,63798L,76146L,84378L,88494L,96726L,109074L,113190L,121422L,125538L,133770L,137886L,146118L,150234L,162582L,170814L,174930L,183162L,195510L,199626L,207858L,211974L,220206L,224322L,232554L,236670L,249018L,257250L,261366L,263640L,269598L,281946L,286062L,294294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255335Inst : IEnumerable<long>
{
public static readonly long[] Value=A255335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255335.Bytes);
public long this[int i]=>Value[i];

public static A255335Inst Instance=new A255335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255336
{
public static readonly long[] Value={ 0L,2L,2L,2L,4L,2L,2L,4L,4L,4L,2L,2L,2L,4L,6L,4L,4L,4L,4L,2L,2L,2L,4L,6L,4L,6L,6L,4L,2L,4L,6L,4L,4L,4L,4L,2L,2L,2L,4L,6L,4L,6L,4L,4L,6L,6L,6L,6L,6L,4L,2L,4L,6L,4L,6L,6L,4L,2L,4L,6L,4L,4L,4L,4L,2L,2L,2L,4L,6L,4L,6L,4L,4L,6L,6L,6L,6L,4L,4L,6L,6L,6L,8L,6L,6L,6L,6L,6L,6L,4L,2L,4L,6L,4L,6L,4L,4L,6L,6L,6L,6L,6L,4L,2L,4L,6L,4L,6L,6L,4L,2L,4L,6L,4L,4L,4L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255336Inst : IEnumerable<long>
{
public static readonly long[] Value=A255336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255336.Bytes);
public long this[int i]=>Value[i];

public static A255336Inst Instance=new A255336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255337
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,1L,2L,3L,2L,2L,2L,2L,1L,1L,1L,2L,3L,2L,3L,3L,2L,1L,2L,3L,2L,2L,2L,2L,1L,1L,1L,2L,3L,2L,3L,2L,2L,3L,3L,3L,3L,3L,2L,1L,2L,3L,2L,3L,3L,2L,1L,2L,3L,2L,2L,2L,2L,1L,1L,1L,2L,3L,2L,3L,2L,2L,3L,3L,3L,3L,2L,2L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,2L,1L,2L,3L,2L,3L,2L,2L,3L,3L,3L,3L,3L,2L,1L,2L,3L,2L,3L,3L,2L,1L,2L,3L,2L,2L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255337Inst : IEnumerable<long>
{
public static readonly long[] Value=A255337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255337.Bytes);
public long this[int i]=>Value[i];

public static A255337Inst Instance=new A255337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255338
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,5L,6L,7L,7L,8L,8L,9L,9L,10L,11L,12L,13L,13L,14L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,20L,21L,22L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,26L,26L,27L,27L,28L,29L,29L,30L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,36L,37L,38L,38L,39L,39L,39L,40L,40L,41L,41L,41L,42L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255338Inst : IEnumerable<long>
{
public static readonly long[] Value=A255338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255338.Bytes);
public long this[int i]=>Value[i];

public static A255338Inst Instance=new A255338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255339
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255339Inst : IEnumerable<long>
{
public static readonly long[] Value=A255339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255339.Bytes);
public long this[int i]=>Value[i];

public static A255339Inst Instance=new A255339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255340
{
public static readonly BigInteger[] Value={ 4L,7L,12L,64L,BigInteger.Parse("13407807929942597099574024998205846127479365820592393377723561443721764030073546976801874298166903427690031858186486050853753882811946569946433649006084096") };
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
public class A255340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255340Inst Instance=new A255340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255341
{
public static readonly long[] Value={ 1L,2L,5L,6L,10L,13L,14L,17L,19L,20L,23L,24L,28L,36L,40L,42L,46L,49L,50L,53L,54L,58L,61L,62L,65L,67L,68L,71L,73L,74L,77L,78L,82L,85L,86L,89L,91L,92L,95L,97L,98L,101L,102L,106L,109L,110L,113L,115L,116L,119L,120L,124L,132L,136L,138L,142L,168L,172L,180L,184L,186L,190L,192L,196L,204L,208L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255341Inst : IEnumerable<long>
{
public static readonly long[] Value=A255341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255341.Bytes);
public long this[int i]=>Value[i];

public static A255341Inst Instance=new A255341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255342
{
public static readonly long[] Value={ 3L,7L,8L,11L,15L,21L,25L,26L,29L,30L,34L,37L,38L,41L,43L,44L,47L,51L,55L,56L,59L,63L,69L,75L,79L,80L,83L,87L,93L,99L,103L,104L,107L,111L,117L,121L,122L,125L,126L,130L,133L,134L,137L,139L,140L,143L,144L,148L,156L,160L,162L,166L,169L,170L,173L,174L,178L,181L,182L,185L,187L,188L,191L,193L,194L,197L,198L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255342Inst : IEnumerable<long>
{
public static readonly long[] Value=A255342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255342.Bytes);
public long this[int i]=>Value[i];

public static A255342Inst Instance=new A255342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255343
{
public static readonly long[] Value={ 9L,27L,31L,32L,35L,39L,45L,57L,81L,105L,123L,127L,128L,131L,135L,141L,145L,146L,149L,150L,154L,157L,158L,161L,163L,164L,167L,171L,175L,176L,179L,183L,189L,195L,199L,200L,203L,207L,213L,219L,223L,224L,227L,231L,237L,249L,267L,271L,272L,275L,279L,285L,297L,321L,345L,369L,387L,391L,392L,395L,399L,405L,417L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255343Inst : IEnumerable<long>
{
public static readonly long[] Value=A255343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255343.Bytes);
public long this[int i]=>Value[i];

public static A255343Inst Instance=new A255343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255344
{
public static readonly long[] Value={ 1L,4294967296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255344Inst : IEnumerable<long>
{
public static readonly long[] Value=A255344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255344.Bytes);
public long this[int i]=>Value[i];

public static A255344Inst Instance=new A255344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255345
{
public static readonly BigInteger[] Value={ 0L,1456L,BigInteger.Parse("6877444662696557082772912"),BigInteger.Parse("76275529557006774610910008878682146858549281112703393437716260657617146482196178356917329340682828388636625682127565089301355422219073820139711425456833968") };
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
public class A255345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255345Inst Instance=new A255345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255346
{
public static readonly long[] Value={ 14L,20L,21L,33L,34L,35L,38L,39L,44L,45L,50L,51L,54L,55L,56L,57L,62L,65L,68L,69L,74L,75L,76L,77L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L,98L,99L,104L,105L,110L,111L,114L,115L,116L,117L,118L,119L,122L,123L,129L,132L,133L,134L,135L,140L,141L,142L,143L,144L,145L,146L,147L,152L,153L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255346Inst : IEnumerable<long>
{
public static readonly long[] Value=A255346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255346.Bytes);
public long this[int i]=>Value[i];

public static A255346Inst Instance=new A255346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255347
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,5L,6L,7L,6L,9L,10L,11L,15L,13L,14L,15L,12L,17L,18L,19L,25L,21L,22L,23L,18L,25L,26L,27L,35L,29L,30L,31L,24L,33L,34L,35L,45L,37L,38L,39L,30L,41L,42L,43L,55L,45L,46L,47L,36L,49L,50L,51L,65L,53L,54L,55L,42L,57L,58L,59L,75L,61L,62L,63L,48L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255347Inst : IEnumerable<long>
{
public static readonly long[] Value=A255347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255347.Bytes);
public long this[int i]=>Value[i];

public static A255347Inst Instance=new A255347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255348
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,9L,12L,8L,10L,5L,15L,25L,20L,16L,14L,7L,21L,27L,18L,24L,30L,32L,22L,11L,33L,66L,36L,42L,28L,49L,35L,70L,40L,50L,60L,45L,75L,81L,39L,13L,26L,52L,64L,34L,17L,51L,102L,48L,54L,72L,78L,96L,84L,56L,98L,112L,126L,63L,105L,125L,55L,110L,44L,88L,121L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255348Inst : IEnumerable<long>
{
public static readonly long[] Value=A255348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255348.Bytes);
public long this[int i]=>Value[i];

public static A255348Inst Instance=new A255348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255349
{
public static readonly long[] Value={ 20L,35L,77L,84L,98L,99L,104L,119L,132L,153L,174L,175L,186L,189L,195L,216L,224L,230L,231L,245L,246L,260L,272L,279L,285L,350L,351L,363L,374L,384L,399L,425L,429L,440L,455L,459L,494L,527L,539L,551L,560L,575L,594L,608L,609L,615L,620L,644L,645L,650L,665L,696L,714L,730L,735L,759L,779L,780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255349Inst : IEnumerable<long>
{
public static readonly long[] Value=A255349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255349.Bytes);
public long this[int i]=>Value[i];

public static A255349Inst Instance=new A255349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255350
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,3L,2L,1L,3L,2L,1L,2L,2L,2L,4L,4L,1L,2L,3L,3L,3L,3L,2L,2L,4L,3L,3L,3L,2L,5L,4L,3L,3L,4L,3L,4L,5L,2L,3L,5L,3L,5L,5L,2L,5L,5L,3L,5L,4L,4L,5L,6L,5L,4L,4L,3L,4L,5L,5L,7L,7L,1L,5L,7L,4L,7L,7L,4L,3L,8L,5L,5L,6L,6L,5L,6L,4L,6L,6L,5L,10L,7L,3L,5L,8L,7L,9L,7L,4L,4L,9L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255350Inst : IEnumerable<long>
{
public static readonly long[] Value=A255350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255350.Bytes);
public long this[int i]=>Value[i];

public static A255350Inst Instance=new A255350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255351
{
public static readonly long[] Value={ 158L,239L,292L,316L,474L,478L,502L,542L,584L,631L,632L,717L,790L,876L,948L,956L,1004L,1084L,1106L,1168L,1195L,1203L,1262L,1264L,1381L,1422L,1434L,1460L,1506L,1580L,1626L,1673L,1738L,1752L,1893L,1896L,1912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255351Inst : IEnumerable<long>
{
public static readonly long[] Value=A255351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255351.Bytes);
public long this[int i]=>Value[i];

public static A255351Inst Instance=new A255351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255352
{
public static readonly long[] Value={ 59L,158L,133L,134L,7L,239L,157L,227L,193L,292L,256L,257L,118L,316L,266L,268L,177L,474L,399L,402L,14L,478L,314L,454L,271L,502L,298L,497L,103L,542L,359L,514L,386L,584L,512L,514L,222L,631L,503L,558L,236L,632L,532L,536L,21L,717L,471L,681L,295L,790L,665L,670L,579L,876L,768L,771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255352Inst : IEnumerable<long>
{
public static readonly long[] Value=A255352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255352.Bytes);
public long this[int i]=>Value[i];

public static A255352Inst Instance=new A255352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255353
{
public static readonly long[] Value={ 2L,3L,6L,15L,24L,40L,104L,168L,273L,714L,1155L,1870L,4895L,7920L,12816L,33552L,54288L,87841L,229970L,372099L,602070L,1576239L,2550408L,4126648L,10803704L,17480760L,28284465L,74049690L,119814915L,193864606L,507544127L,821223648L,1328767776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255353Inst : IEnumerable<long>
{
public static readonly long[] Value=A255353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255353.Bytes);
public long this[int i]=>Value[i];

public static A255353Inst Instance=new A255353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255354
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,5L,110L,3L,2L,3L,2L,5L,50145L,3L,2L,3L,2L,5L,53115L,3L,2L,7L,189L,5L,273L,3L,2L,3L,2L,7L,75L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255354Inst : IEnumerable<long>
{
public static readonly long[] Value=A255354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255354.Bytes);
public long this[int i]=>Value[i];

public static A255354Inst Instance=new A255354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255355
{
public static readonly long[] Value={ 3L,3L,22L,6936609593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255355Inst : IEnumerable<long>
{
public static readonly long[] Value=A255355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255355.Bytes);
public long this[int i]=>Value[i];

public static A255355Inst Instance=new A255355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255356
{
public static readonly long[] Value={ 1547L,2737L,4305L,6545L,13585L,39997L,52633L,57505L,65773L,77441L,93023L,115855L,202895L,214415L,285649L,308865L,315905L,352495L,352735L,443555L,449497L,510229L,510655L,523439L,611295L,627095L,650845L,700321L,722545L,881705L,936845L,1088255L,1103795L,1392047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255356Inst : IEnumerable<long>
{
public static readonly long[] Value=A255356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255356.Bytes);
public long this[int i]=>Value[i];

public static A255356Inst Instance=new A255356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255357
{
public static readonly long[] Value={ 2L,3L,7L,62L,63L,65L,66L,67L,74L,76L,77L,78L,84L,86L,87L,92L,93L,94L,95L,202L,207L,274L,275L,282L,284L,287L,288L,292L,295L,298L,305L,307L,452L,453L,457L,587L,588L,592L,594L,607L,624L,632L,635L,636L,637L,638L,653L,664L,665L,666L,667L,668L,675L,686L,688L,695L,697L,698L,702L,703L,705L,707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255357Inst : IEnumerable<long>
{
public static readonly long[] Value=A255357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255357.Bytes);
public long this[int i]=>Value[i];

public static A255357Inst Instance=new A255357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255358
{
public static readonly BigInteger[] Value={ 1L,1L,40320L,BigInteger.Parse("439039216240867959122165760000000") };
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
public class A255358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255358Inst Instance=new A255358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255359
{
public static readonly long[] Value={ 1L,1L,20922789888000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255359Inst : IEnumerable<long>
{
public static readonly long[] Value=A255359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255359.Bytes);
public long this[int i]=>Value[i];

public static A255359Inst Instance=new A255359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255360
{
public static readonly BigInteger[] Value={ 1L,1L,BigInteger.Parse("263130836933693530167218012160000000") };
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
public class A255360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255360Inst Instance=new A255360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255361
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,2L,1L,0L,1L,1L,0L,2L,0L,1L,1L,0L,1L,3L,0L,0L,1L,2L,0L,2L,0L,1L,2L,0L,0L,3L,1L,1L,1L,1L,0L,2L,1L,2L,1L,0L,0L,4L,0L,0L,2L,2L,1L,2L,0L,1L,1L,2L,0L,4L,0L,0L,2L,1L,1L,2L,0L,3L,2L,0L,0L,4L,1L,0L,1L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255361Inst : IEnumerable<long>
{
public static readonly long[] Value=A255361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255361.Bytes);
public long this[int i]=>Value[i];

public static A255361Inst Instance=new A255361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255362
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,12L,21L,36L,45L,57L,60L,72L,81L,105L,156L,165L,177L,192L,225L,261L,276L,312L,345L,357L,381L,396L,420L,456L,465L,477L,501L,540L,561L,585L,612L,660L,672L,717L,732L,756L,837L,861L,876L,885L,981L,996L,1017L,1092L,1152L,1185L,1200L,1212L,1236L,1281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255362Inst : IEnumerable<long>
{
public static readonly long[] Value=A255362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255362.Bytes);
public long this[int i]=>Value[i];

public static A255362Inst Instance=new A255362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255363
{
public static readonly long[] Value={ 5L,7L,11L,13L,14L,17L,19L,21L,22L,23L,26L,29L,31L,33L,34L,37L,38L,39L,41L,43L,44L,46L,47L,51L,52L,53L,55L,57L,58L,59L,61L,62L,65L,67L,68L,69L,71L,73L,74L,76L,78L,79L,82L,83L,85L,86L,87L,88L,89L,92L,93L,94L,95L,97L,101L,102L,103L,106L,107L,109L,111L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255363Inst : IEnumerable<long>
{
public static readonly long[] Value=A255363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255363.Bytes);
public long this[int i]=>Value[i];

public static A255363Inst Instance=new A255363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255364
{
public static readonly long[] Value={ 1L,27L,53L,177L,203L,879L,1003L,2403L,2429L,3105L,3781L,7005L,7129L,10353L,11753L,21753L,21779L,22455L,23131L,26355L,27031L,44607L,47831L,84231L,84355L,87579L,90803L,106179L,107579L,143979L,153979L,243483L,243509L,244185L,244861L,248085L,248761L,266337L,269561L,305961L,306637L,324213L,341789L,425613L,428837L,512661L,549061L,809061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255364Inst : IEnumerable<long>
{
public static readonly long[] Value=A255364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255364.Bytes);
public long this[int i]=>Value[i];

public static A255364Inst Instance=new A255364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255365
{
public static readonly long[] Value={ 1L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,0L,-2L,2L,0L,0L,0L,1L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,0L,-2L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,3L,0L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255365Inst : IEnumerable<long>
{
public static readonly long[] Value=A255365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255365.Bytes);
public long this[int i]=>Value[i];

public static A255365Inst Instance=new A255365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255366
{
public static readonly long[] Value={ 1L,5L,9L,21L,25L,37L,53L,85L,89L,101L,117L,149L,165L,205L,257L,341L,345L,357L,373L,405L,421L,461L,513L,597L,613L,653L,705L,797L,857L,989L,1141L,1365L,1369L,1381L,1397L,1429L,1445L,1485L,1537L,1621L,1637L,1677L,1729L,1821L,1881L,2013L,2165L,2389L,2405L,2445L,2497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255366Inst : IEnumerable<long>
{
public static readonly long[] Value=A255366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255366.Bytes);
public long this[int i]=>Value[i];

public static A255366Inst Instance=new A255366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255367
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,6L,10L,14L,15L,21L,19L,7L,29L,19L,27L,30L,31L,34L,61L,44L,53L,42L,30L,39L,51L,62L,54L,91L,38L,85L,66L,46L,70L,75L,126L,63L,82L,67L,87L,90L,91L,181L,116L,99L,133L,106L,149L,114L,191L,78L,205L,69L,42L,86L,158L,135L,226L,111L,94L,189L,147L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255367Inst : IEnumerable<long>
{
public static readonly long[] Value=A255367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255367.Bytes);
public long this[int i]=>Value[i];

public static A255367Inst Instance=new A255367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255368
{
public static readonly long[] Value={ 0L,1L,-2L,2L,-4L,5L,-4L,7L,-8L,6L,-10L,11L,-8L,13L,-14L,10L,-16L,17L,-12L,19L,-20L,14L,-22L,23L,-16L,25L,-26L,18L,-28L,29L,-20L,31L,-32L,22L,-34L,35L,-24L,37L,-38L,26L,-40L,41L,-28L,43L,-44L,30L,-46L,47L,-32L,49L,-50L,34L,-52L,53L,-36L,55L,-56L,38L,-58L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255368Inst : IEnumerable<long>
{
public static readonly long[] Value=A255368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255368.Bytes);
public long this[int i]=>Value[i];

public static A255368Inst Instance=new A255368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255369
{
public static readonly long[] Value={ -1L,0L,0L,4L,0L,5L,0L,12L,6L,7L,0L,30L,0L,9L,8L,28L,0L,40L,0L,42L,10L,13L,0L,70L,10L,15L,24L,54L,0L,123L,0L,60L,14L,19L,12L,108L,0L,21L,16L,98L,0L,159L,0L,78L,64L,25L,0L,150L,14L,84L,20L,90L,0L,130L,16L,126L,22L,31L,0L,214L,0L,33L,80L,124L,18L,231L,0L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255369Inst : IEnumerable<long>
{
public static readonly long[] Value=A255369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255369.Bytes);
public long this[int i]=>Value[i];

public static A255369Inst Instance=new A255369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255370
{
public static readonly long[] Value={ 2L,11L,15L,19L,3L,105L,58L,83L,296L,291L,157L,667L,123L,325L,211L,273L,133L,122L,184L,421L,183L,2767L,170L,703L,2060L,2437L,442L,785L,401L,2203L,931L,678L,1795L,1226L,382L,2732L,381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255370Inst : IEnumerable<long>
{
public static readonly long[] Value=A255370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255370.Bytes);
public long this[int i]=>Value[i];

public static A255370Inst Instance=new A255370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255371
{
public static readonly BigInteger[] Value={ 0L,1L,18L,252L,3177L,37764L,432315L,4821867L,52767711L,569171142L,6070198824L,64154357361L,673034324472L,7017585817887L,72795938474871L,751858421307975L,7736579039166894L,79354228046171004L,811679794900979769L,8282239107946760700L,BigInteger.Parse("84331460977774328115") };
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
public class A255371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255371Inst Instance=new A255371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255372
{
public static readonly ulong[] Value={ 0L,0L,1L,18L,261L,3411L,42057L,499383L,5775480L,65506986L,731953926L,8082054387L,88382960316L,958831580700L,10332164902851L,110698940875149L,1180155371168034L,12527193711780981L,132468636134059128L,1396061253467955315L,14668489189614036627UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255372Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255372.Bytes);
public ulong this[int i]=>Value[i];

public static A255372Inst Instance=new A255372Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255373
{
public static readonly ulong[] Value={ 0L,0L,0L,1L,18L,261L,3420L,42291L,503757L,5845383L,66525399L,745904151L,8264888316L,90700808526L,987461965116L,10678505242392L,114817381566435L,1228431892382460L,13086248073415290L,138875261344657416L,1468815363559657773L,15488131104999233505UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255373Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255373.Bytes);
public ulong this[int i]=>Value[i];

public static A255373Inst Instance=new A255373Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255374
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,1L,18L,261L,3420L,42300L,503991L,5849757L,66595383L,746925399L,8278904070L,90884885481L,989800742916L,10707460718526L,115168484215116L,1232617054343121L,13135427089598511L,139446180653268195L,1475374347592901460L,15562803326717545290UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255374Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255374.Bytes);
public ulong this[int i]=>Value[i];

public static A255374Inst Instance=new A255374Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255375
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,0L,1L,18L,261L,3420L,42300L,504000L,5849991L,66599757L,746995383L,8279925399L,90898904070L,989984885400L,10709800740081L,115197460652916L,1232968482968526L,13139617033315116L,139495426762343121L,1475946175849599240L,15569374280153300271UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255375Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255375.Bytes);
public ulong this[int i]=>Value[i];

public static A255375Inst Instance=new A255375Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255376
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,0L,0L,1L,18L,261L,3420L,42300L,504000L,5850000L,66599991L,746999757L,8279995383L,90899925399L,989998904070L,10709984885400L,115199800740000L,1232997460650081L,13139968482902916L,139499617032068526L,1475995426741315116L,15569946175522343121UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255376Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255376.Bytes);
public ulong this[int i]=>Value[i];

public static A255376Inst Instance=new A255376Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255377
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,18L,261L,3420L,42300L,504000L,5850000L,66600000L,746999991L,8279999757L,90899995383L,989999925399L,10709998904070L,115199984885400L,1232999800740000L,13139997460650000L,139499968482900081L,1475999617032002916L,15569995426740068526UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255377Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255377.Bytes);
public ulong this[int i]=>Value[i];

public static A255377Inst Instance=new A255377Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255378
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,18L,261L,3420L,42300L,504000L,5850000L,66600000L,747000000L,8279999991L,90899999757L,989999995383L,10709999925399L,115199998904070L,1232999984885400L,13139999800740000L,139499997460650000L,1475999968482900000L,15569999617032000081UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255378Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255378.Bytes);
public ulong this[int i]=>Value[i];

public static A255378Inst Instance=new A255378Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255379
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,18L,261L,3420L,42300L,504000L,5850000L,66600000L,747000000L,8280000000L,90899999991L,989999999757L,10709999995383L,115199999925399L,1232999998904070L,13139999984885400L,139499999800740000L,1475999997460650000L,15569999968482900000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255379Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255379.Bytes);
public ulong this[int i]=>Value[i];

public static A255379Inst Instance=new A255379Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255380
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,18L,261L,3420L,42300L,504000L,5850000L,66600000L,747000000L,8280000000L,90900000000L,989999999991L,10709999999757L,115199999995383L,1232999999925399L,13139999998904070L,139499999984885400L,1475999999800740000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255380Inst : IEnumerable<long>
{
public static readonly long[] Value=A255380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255380.Bytes);
public long this[int i]=>Value[i];

public static A255380Inst Instance=new A255380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255381
{
public static readonly BigInteger[] Value={ 1L,18L,261L,3420L,42300L,504000L,5850000L,66600000L,747000000L,8280000000L,90900000000L,990000000000L,10710000000000L,115200000000000L,1233000000000000L,13140000000000000L,139500000000000000L,1476000000000000000L,15570000000000000000UL,BigInteger.Parse("163800000000000000000") };
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
public class A255381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255381Inst Instance=new A255381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}