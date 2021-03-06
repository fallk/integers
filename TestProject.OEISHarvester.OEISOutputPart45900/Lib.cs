using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A053445
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,3L,1L,4L,2L,7L,3L,10L,7L,14L,11L,22L,17L,32L,28L,45L,43L,67L,63L,95L,96L,134L,139L,192L,199L,269L,287L,373L,406L,521L,566L,718L,792L,983L,1092L,1346L,1496L,1827L,2045L,2465L,2772L,3323L,3733L,4449L,5016L,5929L,6696L,7882L,8897L,10426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053445Inst : IEnumerable<long>
{
public static readonly long[] Value=A053445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053445.Bytes);
public long this[int i]=>Value[i];

public static A053445Inst Instance=new A053445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053446
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,2L,4L,5L,3L,6L,4L,16L,18L,4L,5L,11L,20L,3L,6L,28L,30L,8L,16L,12L,18L,18L,4L,8L,42L,10L,11L,23L,42L,20L,6L,52L,20L,6L,28L,29L,10L,30L,16L,12L,22L,16L,12L,35L,12L,18L,18L,30L,78L,4L,8L,41L,16L,42L,10L,88L,6L,22L,23L,36L,48L,42L,20L,100L,34L,6L,52L,53L,27L,20L,12L,112L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053446Inst : IEnumerable<long>
{
public static readonly long[] Value=A053446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053446.Bytes);
public long this[int i]=>Value[i];

public static A053446Inst Instance=new A053446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053447
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,6L,2L,4L,9L,3L,11L,10L,9L,14L,5L,5L,6L,18L,6L,10L,7L,6L,23L,21L,4L,26L,10L,9L,29L,30L,3L,6L,33L,11L,35L,9L,10L,15L,39L,27L,41L,4L,14L,11L,6L,5L,18L,24L,15L,50L,51L,6L,53L,18L,18L,14L,22L,6L,12L,55L,10L,50L,7L,7L,65L,9L,18L,34L,69L,23L,30L,14L,21L,74L,15L,12L,10L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053447Inst : IEnumerable<long>
{
public static readonly long[] Value=A053447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053447.Bytes);
public long this[int i]=>Value[i];

public static A053447Inst Instance=new A053447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053448
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,6L,2L,6L,5L,2L,4L,6L,4L,16L,6L,9L,6L,5L,22L,2L,4L,18L,6L,14L,3L,8L,10L,16L,6L,36L,9L,4L,20L,6L,42L,5L,22L,46L,4L,42L,16L,4L,52L,18L,6L,18L,14L,29L,30L,3L,6L,16L,10L,22L,16L,22L,5L,6L,72L,36L,9L,30L,4L,39L,54L,20L,82L,6L,42L,14L,10L,44L,12L,22L,6L,46L,8L,96L,42L,30L,25L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053448Inst : IEnumerable<long>
{
public static readonly long[] Value=A053448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053448.Bytes);
public long this[int i]=>Value[i];

public static A053448Inst Instance=new A053448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053449
{
public static readonly long[] Value={ 1L,1L,2L,10L,12L,16L,9L,11L,5L,14L,6L,2L,4L,40L,3L,23L,14L,26L,10L,58L,60L,12L,33L,35L,36L,10L,78L,82L,16L,88L,12L,9L,12L,10L,102L,106L,108L,112L,11L,16L,110L,25L,126L,130L,18L,136L,23L,60L,14L,37L,150L,6L,156L,22L,27L,83L,156L,43L,10L,178L,60L,4L,80L,19L,96L,14L,198L,14L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053449Inst : IEnumerable<long>
{
public static readonly long[] Value=A053449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053449.Bytes);
public long this[int i]=>Value[i];

public static A053449Inst Instance=new A053449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053450
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,1L,2L,3L,4L,10L,2L,12L,4L,2L,16L,3L,3L,4L,10L,22L,2L,4L,12L,9L,7L,4L,15L,4L,10L,16L,6L,9L,3L,12L,4L,40L,6L,10L,12L,22L,23L,2L,4L,16L,12L,26L,9L,20L,3L,7L,29L,4L,60L,15L,8L,12L,10L,66L,16L,22L,70L,6L,24L,9L,4L,6L,12L,78L,4L,27L,40L,41L,16L,6L,7L,10L,88L,12L,22L,15L,23L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053450Inst : IEnumerable<long>
{
public static readonly long[] Value=A053450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053450.Bytes);
public long this[int i]=>Value[i];

public static A053450Inst Instance=new A053450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053451
{
public static readonly long[] Value={ 1L,2L,4L,1L,2L,10L,4L,4L,8L,6L,2L,11L,20L,6L,28L,5L,10L,4L,12L,4L,20L,14L,4L,23L,7L,8L,52L,20L,6L,58L,20L,2L,4L,22L,22L,35L,3L,20L,10L,13L,18L,82L,8L,28L,11L,4L,10L,12L,16L,10L,100L,17L,4L,106L,12L,12L,28L,44L,4L,8L,110L,20L,100L,7L,14L,130L,6L,12L,68L,46L,46L,20L,28L,14L,148L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053451Inst : IEnumerable<long>
{
public static readonly long[] Value=A053451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053451.Bytes);
public long this[int i]=>Value[i];

public static A053451Inst Instance=new A053451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053452
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,2L,5L,3L,3L,2L,8L,9L,2L,5L,11L,10L,3L,3L,14L,15L,4L,8L,6L,9L,9L,2L,4L,21L,5L,11L,23L,21L,10L,3L,26L,10L,3L,14L,29L,5L,15L,8L,6L,11L,8L,6L,35L,6L,9L,9L,15L,39L,2L,4L,41L,8L,21L,5L,44L,3L,11L,23L,18L,24L,21L,10L,50L,17L,3L,26L,53L,27L,10L,6L,56L,22L,14L,29L,24L,5L,5L,15L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053452Inst : IEnumerable<long>
{
public static readonly long[] Value=A053452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053452.Bytes);
public long this[int i]=>Value[i];

public static A053452Inst Instance=new A053452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053453
{
public static readonly long[] Value={ 1L,1L,6L,1L,2L,6L,16L,18L,6L,22L,3L,28L,15L,2L,3L,6L,5L,21L,46L,42L,16L,13L,18L,58L,60L,6L,33L,22L,35L,8L,6L,13L,9L,41L,28L,44L,6L,15L,96L,2L,4L,34L,53L,108L,3L,112L,6L,48L,22L,5L,42L,21L,130L,18L,8L,46L,46L,6L,42L,148L,75L,16L,78L,13L,66L,81L,166L,78L,18L,43L,58L,178L,180L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053453Inst : IEnumerable<long>
{
public static readonly long[] Value=A053453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053453.Bytes);
public long this[int i]=>Value[i];

public static A053453Inst Instance=new A053453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053454
{
public static readonly long[] Value={ 1L,4L,12L,53L,237L,1306L,7537L,47913L,322253L,2297874L,17191216L,134505656L,1095715055L,9267223594L,81162609328L,734511656413L,6856030049629L,65899370570285L,651338242941020L,6611459646337423L,68842439737228261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053454Inst : IEnumerable<long>
{
public static readonly long[] Value=A053454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053454.Bytes);
public long this[int i]=>Value[i];

public static A053454Inst Instance=new A053454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053455
{
public static readonly long[] Value={ 0L,1L,2L,52L,200L,2896L,15392L,169792L,1078400L,10306816L,72376832L,639480832L,4753049600L,40201179136L,308548739072L,2546754076672L,19903847628800L,162051890937856L,1279488468058112L,10337467701133312L,82090381869056000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053455Inst : IEnumerable<long>
{
public static readonly long[] Value=A053455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053455.Bytes);
public long this[int i]=>Value[i];

public static A053455Inst Instance=new A053455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053456
{
public static readonly long[] Value={ 0L,1L,1L,9L,9L,21L,25L,37L,45L,69L,69L,97L,109L,137L,145L,177L,193L,225L,249L,293L,305L,349L,373L,421L,437L,489L,517L,577L,609L,665L,697L,749L,793L,861L,889L,973L,1005L,1085L,1125L,1201L,1245L,1313L,1369L,1457L,1513L,1597L,1649L,1741L,1789L,1885L,1941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053456Inst : IEnumerable<long>
{
public static readonly long[] Value=A053456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053456.Bytes);
public long this[int i]=>Value[i];

public static A053456Inst Instance=new A053456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053457
{
public static readonly long[] Value={ 0L,0L,2L,6L,12L,16L,26L,38L,48L,60L,78L,94L,108L,128L,154L,174L,196L,224L,250L,278L,312L,344L,378L,410L,452L,484L,526L,574L,612L,652L,698L,754L,800L,848L,906L,958L,1012L,1068L,1130L,1190L,1252L,1316L,1378L,1446L,1516L,1588L,1654L,1730L,1808L,1880L,1954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053457Inst : IEnumerable<long>
{
public static readonly long[] Value=A053457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053457.Bytes);
public long this[int i]=>Value[i];

public static A053457Inst Instance=new A053457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053458
{
public static readonly long[] Value={ 0L,1L,1L,7L,13L,19L,31L,43L,55L,73L,85L,109L,121L,151L,169L,199L,235L,253L,295L,313L,361L,397L,433L,475L,511L,571L,595L,661L,703L,757L,817L,859L,925L,979L,1039L,1111L,1159L,1237L,1285L,1381L,1453L,1519L,1597L,1663L,1759L,1813L,1915L,1993L,2077L,2173L,2257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053458Inst : IEnumerable<long>
{
public static readonly long[] Value=A053458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053458.Bytes);
public long this[int i]=>Value[i];

public static A053458Inst Instance=new A053458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053459
{
public static readonly long[] Value={ 0L,0L,4L,8L,14L,22L,30L,42L,60L,74L,92L,108L,130L,148L,178L,206L,230L,262L,288L,324L,364L,400L,442L,480L,522L,562L,614L,662L,712L,764L,812L,868L,922L,988L,1050L,1106L,1176L,1234L,1312L,1376L,1452L,1528L,1598L,1678L,1750L,1838L,1920L,2006L,2092L,2172L,2266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053459Inst : IEnumerable<long>
{
public static readonly long[] Value=A053459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053459.Bytes);
public long this[int i]=>Value[i];

public static A053459Inst Instance=new A053459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053460
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,25L,26L,27L,28L,29L,31L,33L,34L,35L,37L,38L,39L,41L,43L,45L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053460Inst : IEnumerable<long>
{
public static readonly long[] Value=A053460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053460.Bytes);
public long this[int i]=>Value[i];

public static A053460Inst Instance=new A053460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053461
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,55L,19L,68L,4L,85L,185L,64L,208L,39L,235L,10L,266L,555L,231L,592L,192L,633L,149L,678L,102L,727L,51L,780L,1564L,723L,1623L,662L,1686L,597L,1753L,528L,1824L,455L,1899L,378L,1978L,297L,2061L,212L,2148L,123L,2239L,4448L,2144L,4545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053461Inst : IEnumerable<long>
{
public static readonly long[] Value=A053461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053461.Bytes);
public long this[int i]=>Value[i];

public static A053461Inst Instance=new A053461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053462
{
public static readonly long[] Value={ 0L,6L,61L,608L,6083L,60794L,607926L,6079291L,60792694L,607927124L,6079270942L,60792710280L,607927102274L,6079271018294L,60792710185947L,607927101854103L,6079271018540405L,60792710185403794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053462Inst : IEnumerable<long>
{
public static readonly long[] Value=A053462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053462.Bytes);
public long this[int i]=>Value[i];

public static A053462Inst Instance=new A053462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053463
{
public static readonly long[] Value={ 0L,8L,9L,1L,7L,9L,2L,6L,9L,4L,5L,9L,5L,4L,9L,6L,2L,9L,7L,1L,9L,8L,0L,8L,9L,1L,7L,9L,2L,6L,9L,4L,5L,9L,5L,4L,9L,6L,2L,9L,7L,1L,9L,8L,0L,8L,9L,1L,7L,9L,2L,6L,9L,3L,5L,9L,5L,4L,9L,6L,3L,9L,7L,1L,9L,8L,0L,8L,8L,1L,7L,9L,2L,6L,9L,3L,5L,9L,5L,4L,9L,6L,3L,9L,7L,1L,9L,8L,0L,8L,8L,1L,7L,9L,2L,6L,9L,3L,5L,9L,5L,4L,9L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053463Inst : IEnumerable<long>
{
public static readonly long[] Value=A053463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053463.Bytes);
public long this[int i]=>Value[i];

public static A053463Inst Instance=new A053463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053464
{
public static readonly long[] Value={ 0L,1L,10L,75L,500L,3125L,18750L,109375L,625000L,3515625L,19531250L,107421875L,585937500L,3173828125L,17089843750L,91552734375L,488281250000L,2593994140625L,13732910156250L,72479248046875L,381469726562500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053464Inst : IEnumerable<long>
{
public static readonly long[] Value=A053464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053464.Bytes);
public long this[int i]=>Value[i];

public static A053464Inst Instance=new A053464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053465
{
public static readonly BigInteger[] Value={ 1L,2L,7L,53L,712L,24576L,2275616L,589543159L,420188096140L,819411181635025L,4381819315336997184L,BigInteger.Parse("64583749250393921183423"),BigInteger.Parse("2638507778912832094660037006"),BigInteger.Parse("300397569392490080058575760090548") };
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
public class A053465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053465Inst Instance=new A053465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053466
{
public static readonly BigInteger[] Value={ 1L,3L,16L,250L,10364L,1590368L,890704748L,1798888780974L,13040687516840812L,BigInteger.Parse("341365122121400763818"),BigInteger.Parse("32525985067651643920408364"),BigInteger.Parse("11367070802646570246017825177796") };
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
public class A053466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053466Inst Instance=new A053466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053467
{
public static readonly BigInteger[] Value={ 1L,6L,138L,22815L,29197989L,286181094816L,21712697070199704L,BigInteger.Parse("12980080058620326927885"),BigInteger.Parse("62082385554465497895132149640"),BigInteger.Parse("2405193620328895144597707267893468286") };
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
public class A053467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053467Inst Instance=new A053467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053468
{
public static readonly BigInteger[] Value={ 1L,10L,720L,703760L,9168331776L,1601371799340544L,BigInteger.Parse("3837878966366932639744"),BigInteger.Parse("128777257564337108286016980992"),BigInteger.Parse("61454877497308462618188532330410573824"),BigInteger.Parse("422314689395950135433730499958070655419345928192") };
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
public class A053468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053468Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053468.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053468Inst Instance=new A053468Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053469
{
public static readonly long[] Value={ 1L,12L,108L,864L,6480L,46656L,326592L,2239488L,15116544L,100776960L,665127936L,4353564672L,28298170368L,182849716224L,1175462461440L,7522959753216L,47958868426752L,304679870005248L,1929639176699904L,12187194800209920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053469Inst : IEnumerable<long>
{
public static readonly long[] Value=A053469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053469.Bytes);
public long this[int i]=>Value[i];

public static A053469Inst Instance=new A053469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053470
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,2L,1L,4L,0L,4L,0L,4L,1L,4L,0L,8L,0L,8L,3L,8L,0L,8L,1L,8L,3L,8L,0L,12L,0L,8L,1L,12L,1L,16L,0L,12L,7L,16L,0L,22L,0L,16L,9L,16L,0L,16L,1L,22L,1L,16L,0L,24L,7L,16L,9L,22L,0L,24L,0L,16L,9L,16L,1L,24L,0L,24L,5L,24L,0L,32L,0L,20L,11L,24L,1L,36L,0L,32L,9L,30L,0L,44L,9L,24L,1L,32L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053470Inst : IEnumerable<long>
{
public static readonly long[] Value=A053470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053470.Bytes);
public long this[int i]=>Value[i];

public static A053470Inst Instance=new A053470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053471
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,2L,0L,2L,0L,2L,0L,4L,0L,4L,1L,4L,0L,4L,0L,4L,1L,4L,0L,8L,0L,4L,0L,8L,0L,8L,0L,8L,1L,8L,0L,12L,0L,8L,3L,8L,0L,8L,0L,12L,0L,8L,0L,16L,1L,8L,3L,12L,0L,16L,0L,8L,3L,8L,0L,16L,0L,16L,1L,16L,0L,16L,0L,12L,1L,16L,0L,24L,0L,16L,3L,22L,0L,24L,3L,16L,0L,16L,0L,24L,0L,16L,1L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053471Inst : IEnumerable<long>
{
public static readonly long[] Value=A053471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053471.Bytes);
public long this[int i]=>Value[i];

public static A053471Inst Instance=new A053471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053472
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,4L,0L,2L,0L,4L,0L,4L,0L,4L,0L,4L,0L,8L,0L,4L,1L,4L,0L,4L,0L,8L,0L,4L,0L,8L,0L,4L,1L,8L,0L,8L,0L,4L,1L,4L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,16L,0L,8L,1L,12L,0L,16L,1L,8L,0L,8L,0L,16L,0L,8L,0L,8L,0L,8L,0L,8L,1L,16L,0L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053472Inst : IEnumerable<long>
{
public static readonly long[] Value=A053472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053472.Bytes);
public long this[int i]=>Value[i];

public static A053472Inst Instance=new A053472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053473
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,2L,0L,2L,0L,2L,0L,4L,0L,2L,0L,2L,0L,2L,0L,4L,0L,2L,0L,4L,0L,2L,0L,4L,0L,4L,0L,2L,0L,2L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,8L,0L,4L,0L,8L,0L,8L,0L,4L,0L,4L,0L,8L,0L,4L,0L,4L,0L,4L,0L,4L,0L,8L,0L,8L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053473Inst : IEnumerable<long>
{
public static readonly long[] Value=A053473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053473.Bytes);
public long this[int i]=>Value[i];

public static A053473Inst Instance=new A053473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053474
{
public static readonly long[] Value={ 6L,14L,18L,30L,28L,30L,44L,60L,60L,62L,82L,68L,74L,94L,106L,88L,126L,102L,104L,110L,150L,120L,124L,164L,158L,136L,138L,178L,148L,150L,190L,164L,212L,176L,174L,182L,246L,252L,194L,198L,204L,208L,220L,234L,286L,318L,242L,322L,302L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053474Inst : IEnumerable<long>
{
public static readonly long[] Value=A053474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053474.Bytes);
public long this[int i]=>Value[i];

public static A053474Inst Instance=new A053474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053475
{
public static readonly long[] Value={ 2L,3L,3L,4L,3L,5L,3L,5L,4L,6L,3L,6L,3L,6L,4L,6L,3L,7L,3L,7L,5L,7L,3L,7L,4L,7L,5L,7L,3L,8L,3L,7L,4L,8L,4L,8L,3L,8L,5L,8L,3L,9L,3L,8L,6L,8L,3L,8L,4L,9L,4L,8L,3L,9L,5L,8L,6L,9L,3L,9L,3L,8L,6L,8L,4L,9L,3L,9L,5L,9L,3L,9L,3L,9L,5L,9L,4L,10L,3L,9L,6L,10L,3L,10L,6L,9L,4L,9L,3L,10L,4L,9L,5L,9L,4L,9L,3L,9L,6L,10L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053475Inst : IEnumerable<long>
{
public static readonly long[] Value=A053475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053475.Bytes);
public long this[int i]=>Value[i];

public static A053475Inst Instance=new A053475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053476
{
public static readonly long[] Value={ 9L,21L,42L,82L,130L,330L,450L,666L,1050L,1470L,1950L,2922L,4074L,5586L,7770L,11154L,15810L,22638L,30702L,42570L,53130L,68970L,107690L,159390L,206910L,289830L,395190L,610350L,823290L,1185570L,1522290L,2168250L,3011850L,4103490L,5364450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053476Inst : IEnumerable<long>
{
public static readonly long[] Value=A053476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053476.Bytes);
public long this[int i]=>Value[i];

public static A053476Inst Instance=new A053476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053477
{
public static readonly long[] Value={ 1L,2L,5L,9L,7L,15L,9L,17L,14L,19L,13L,27L,15L,23L,24L,23L,19L,33L,21L,35L,30L,31L,25L,41L,30L,35L,36L,43L,31L,47L,33L,47L,42L,43L,44L,50L,39L,47L,48L,57L,43L,59L,45L,59L,60L,55L,49L,67L,54L,65L,60L,67L,55L,71L,64L,73L,66L,67L,61L,87L,63L,71L,78L,73L,74L,83L,69L,83L,78L,87L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053477Inst : IEnumerable<long>
{
public static readonly long[] Value=A053477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053477.Bytes);
public long this[int i]=>Value[i];

public static A053477Inst Instance=new A053477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053478
{
public static readonly long[] Value={ 1L,3L,6L,7L,12L,9L,16L,15L,18L,17L,28L,19L,32L,23L,30L,31L,48L,27L,46L,35L,40L,39L,62L,39L,60L,45L,54L,47L,76L,45L,76L,63L,68L,65L,74L,55L,92L,65L,78L,71L,112L,61L,104L,79L,84L,85L,132L,79L,110L,85L,114L,91L,144L,81L,126L,95L,112L,105L,164L,91L,152L,107L,118L,127L,144L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053478Inst : IEnumerable<long>
{
public static readonly long[] Value=A053478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053478.Bytes);
public long this[int i]=>Value[i];

public static A053478Inst Instance=new A053478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053479
{
public static readonly long[] Value={ 0L,0L,3L,6L,12L,21L,30L,42L,54L,69L,90L,102L,129L,150L,174L,198L,225L,258L,288L,327L,354L,396L,435L,471L,522L,558L,609L,654L,702L,759L,807L,864L,924L,981L,1038L,1104L,1173L,1230L,1308L,1368L,1443L,1512L,1590L,1671L,1746L,1830L,1908L,2001L,2076L,2166L,2265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053479Inst : IEnumerable<long>
{
public static readonly long[] Value=A053479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053479.Bytes);
public long this[int i]=>Value[i];

public static A053479Inst Instance=new A053479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053480
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,13L,8L,15L,13L,23L,12L,27L,14L,29L,23L,31L,18L,45L,20L,47L,34L,49L,24L,55L,31L,55L,40L,59L,30L,79L,32L,63L,47L,79L,47L,91L,38L,85L,62L,95L,42L,121L,44L,99L,79L,101L,48L,111L,57L,129L,71L,111L,54L,145L,78L,119L,91L,137L,60L,159L,62L,125L,103L,127L,83L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053480Inst : IEnumerable<long>
{
public static readonly long[] Value=A053480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053480.Bytes);
public long this[int i]=>Value[i];

public static A053480Inst Instance=new A053480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053481
{
public static readonly BigInteger[] Value={ 2L,11L,76L,654L,6816L,83880L,1193760L,19318320L,350622720L,7056927360L,156031142400L,3760042809600L,98093779660800L,2754553785984000L,82841868639129600L,2656672553703168000L,BigInteger.Parse("90498598469959680000"),BigInteger.Parse("3263440333591646208000") };
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
public class A053481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053481Inst Instance=new A053481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053482
{
public static readonly BigInteger[] Value={ 1L,4L,21L,142L,1201L,12336L,149989L,2113546L,33926337L,611660476L,12243073621L,269456124774L,6468249055921L,168191402251432L,4709596238204901L,141291441773619106L,4521383010795364609L,BigInteger.Parse("153727989225714801396"),BigInteger.Parse("5534225015581836134677") };
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
public class A053482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053482Inst Instance=new A053482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053483
{
public static readonly BigInteger[] Value={ 1L,4L,18L,114L,900L,8845L,103861L,1427122L,22486706L,399906140L,7922936720L,173013117604L,4127746294408L,106806183646594L,2978731438384738L,89065499057526433L,2842061902985159593L,BigInteger.Parse("96395720127638538076"),BigInteger.Parse("3462922846509648162418") };
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
public class A053483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053483Inst Instance=new A053483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053484
{
public static readonly long[] Value={ 1L,3L,5L,19L,7L,109L,331L,155L,2327L,20947L,34913L,164591L,691283L,14977801L,314533829L,4718007451L,1572669151L,16041225341L,103122162907L,4571749222213L,68576238333199L,110777000384399L,55582845806909L,364345554264288511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053484Inst : IEnumerable<long>
{
public static readonly long[] Value=A053484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053484.Bytes);
public long this[int i]=>Value[i];

public static A053484Inst Instance=new A053484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053485
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,15L,45L,21L,315L,2835L,4725L,22275L,93555L,2027025L,42567525L,638512875L,212837625L,2170943775L,13956067125L,618718975875L,9280784638125L,14992036723125L,7522320180375L,49308808782358125L,147926426347074375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053485Inst : IEnumerable<long>
{
public static readonly long[] Value=A053485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053485.Bytes);
public long this[int i]=>Value[i];

public static A053485Inst Instance=new A053485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053486
{
public static readonly BigInteger[] Value={ 1L,4L,17L,78L,393L,2208L,13977L,100026L,806769L,7280604L,72865089L,801693126L,9620848953L,125072630712L,1751021612937L,26265338542962L,420245459734113L,7144172944620084L,128595113390582001L,2443307155583319486L,BigInteger.Parse("48866143115153174121") };
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
public class A053486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053486Inst Instance=new A053486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053487
{
public static readonly BigInteger[] Value={ 1L,5L,26L,142L,824L,5144L,34960L,261104L,2154368L,19651456L,197563136L,2177388800L,26145442816L,339957865472L,4759678552064L,71396252022784L,1142344327331840L,19419870744510464L,349557742120665088L,6641597375170543616L,BigInteger.Parse("132831948602922500096") };
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
public class A053487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053487Inst Instance=new A053487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053488
{
public static readonly long[] Value={ 0L,1L,2L,6L,23L,103L,535L,3153L,20676L,149148L,1172343L,9960085L,90864801L,885278605L,9167936406L,100508961982L,1162366436355L,14136151459043L,180287711599455L,2405321659729837L,33495442060505752L,485880832780748932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053488Inst : IEnumerable<long>
{
public static readonly long[] Value=A053488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053488.Bytes);
public long this[int i]=>Value[i];

public static A053488Inst Instance=new A053488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053489
{
public static readonly BigInteger[] Value={ 1L,0L,4L,6L,64L,300L,2568L,20160L,193856L,1989792L,22687200L,279956160L,3737966208L,53589444480L,821522026752L,13407498599040L,232106716968960L,4248256958023680L,81968803604600832L,1662870215019018240L,BigInteger.Parse("35384007384670648320"),BigInteger.Parse("788053048823608565760") };
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
public class A053489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053489Inst Instance=new A053489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053490
{
public static readonly BigInteger[] Value={ 1L,0L,6L,9L,132L,630L,6642L,55440L,608976L,6790392L,85413960L,1145077560L,16600386888L,256806229680L,4233767671728L,74015194485960L,1368023697469440L,26649263762049600L,545697922821501888L,11717708270380421760UL,BigInteger.Parse("263276186128105633920") };
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
public class A053490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053490Inst Instance=new A053490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053491
{
public static readonly BigInteger[] Value={ 1L,0L,4L,12L,112L,960L,10848L,141120L,2122496L,36094464L,685578240L,14385761280L,330532435968L,8253827112960L,222587077558272L,6447285982126080L,199630453605335040L,6580280144225894400L,BigInteger.Parse("230056747973625249792"),BigInteger.Parse("8503148524089755566080") };
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
public class A053491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053491Inst Instance=new A053491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053492
{
public static readonly BigInteger[] Value={ 1L,2L,15L,184L,3155L,69516L,1871583L,59542064L,2185497819L,90909876100L,4226300379983L,217152013181544L,12219893000227107L,747440554689309404L,BigInteger.Parse("49374719534173925055"),BigInteger.Parse("3503183373320829575008"),BigInteger.Parse("265693897270211120103563"),BigInteger.Parse("21451116469521758657525748") };
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
public class A053492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053492Inst Instance=new A053492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053493
{
public static readonly long[] Value={ 1L,10L,56L,214L,641L,1620L,3616L,7340L,13825L,24510L,41336L,66850L,104321L,157864L,232576L,334680L,471681L,652530L,887800L,1189870L,1573121L,2054140L,2651936L,3388164L,4287361L,5377190L,6688696L,8256570L,10119425L,12320080L,14905856L,17928880L,21446401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053493Inst : IEnumerable<long>
{
public static readonly long[] Value=A053493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053493.Bytes);
public long this[int i]=>Value[i];

public static A053493Inst Instance=new A053493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053494
{
public static readonly long[] Value={ 1L,26L,348L,2698L,14751L,62781L,222190L,681460L,1865715L,4655535L,10756921L,23290026L,47700173L,93104473L,174248451L,314246511L,548380980L,929209095L,1533389605L,2470568045L,3894914166L,6019752376L,9136114923L,13635769173L,20039850376L,29033765566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053494Inst : IEnumerable<long>
{
public static readonly long[] Value=A053494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053494.Bytes);
public long this[int i]=>Value[i];

public static A053494Inst Instance=new A053494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053495
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,2L,-2L,1L,-4L,6L,-6L,-1L,6L,-18L,24L,-24L,1L,-9L,36L,-96L,120L,-120L,-1L,12L,-72L,240L,-600L,720L,-720L,1L,-16L,120L,-600L,1800L,-4320L,5040L,-5040L,-1L,20L,-200L,1200L,-5400L,15120L,-35280L,40320L,-40320L,1L,-25L,300L,-2400L,12600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053495Inst : IEnumerable<long>
{
public static readonly long[] Value=A053495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053495.Bytes);
public long this[int i]=>Value[i];

public static A053495Inst Instance=new A053495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053496
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,18L,66L,396L,2052L,12636L,91548L,625176L,4673736L,43575192L,377205336L,3624289488L,38829340656L,397695226896L,4338579616272L,54018173703456L,641634784488288L,8208962893594656L,113809776294348576L,1526808627197721792L,BigInteger.Parse("21533423236302943296") };
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
public class A053496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053496Inst Instance=new A053496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053497
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,721L,5761L,25921L,86401L,237601L,570241L,1235521L,892045441L,13348249201L,106757164801L,604924594561L,2722120577281L,10344007402561L,34479959558401L,24928970490633601L,546446134633639681L,6281586217487489041L,BigInteger.Parse("50248618811434961281") };
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
public class A053497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053497Inst Instance=new A053497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053498
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,16L,56L,256L,1072L,11264L,78976L,672256L,4653056L,49810432L,433429504L,4448608256L,39221579776L,607251736576L,7244686764032L,101611422797824L,1170362064019456L,19281174853615616L,261583327556386816L,4084459360167657472L,BigInteger.Parse("54366023748591386624") };
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
public class A053498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053498Inst Instance=new A053498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053499
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,9L,21L,81L,351L,1233L,46089L,434241L,2359611L,27387801L,264333213L,1722161169L,16514298711L,163094452641L,1216239520401L,50883607918593L,866931703203699L,8473720481213481L,166915156382509221L,2699805625227141201L,BigInteger.Parse("28818706120636531023") };
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
public class A053499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053499Inst Instance=new A053499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053500
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,10L,50L,220L,1240L,6140L,32860L,602200L,5668400L,62030200L,522328600L,4487190800L,62591332000L,715163146000L,9573774122000L,105731659828000L,1187355279592000L,29205778751300000L,481597207656340000L,9086318388933400000L,BigInteger.Parse("132525988426667120000") };
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
public class A053500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053500Inst Instance=new A053500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053501
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3628801L,43545601L,283046401L,1320883201L,4953312001L,15850598401L,44910028801L,115482931201L,274271961601L,609493248001L,1279935820801L,4644633666390681601L,BigInteger.Parse("106826520356358566401"),BigInteger.Parse("1281918194457262387201") };
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
public class A053501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053501Inst Instance=new A053501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053502
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,24L,96L,576L,3312L,21456L,152784L,1237536L,9984096L,133494912L,1412107776L,16369357824L,206123325696L,2866280276736L,36809077162752L,592066290710016L,8800038127378944L,136876273991755776L,2197453620220010496L,BigInteger.Parse("37915306084793106432") };
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
public class A053502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053502Inst Instance=new A053502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053503
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,16L,56L,256L,1072L,11264L,78976L,672256L,4653056L,49810432L,433429504L,4448608256L,39221579776L,1914926104576L,29475151020032L,501759779405824L,6238907914387456L,120652091860975616L,1751735807564578816L,BigInteger.Parse("29062253310781161472"),BigInteger.Parse("398033706586943258624") };
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
public class A053503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053503Inst Instance=new A053503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053504
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,96L,576L,3312L,26496L,198144L,1691136L,14973696L,193370112L,2034809856L,25087186944L,313539434496L,4421478721536L,58307347556352L,915011420737536L,13553664911437824L,240637745416421376L,3965015057937924096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053504Inst : IEnumerable<long>
{
public static readonly long[] Value=A053504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053504.Bytes);
public long this[int i]=>Value[i];

public static A053504Inst Instance=new A053504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053505
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,18L,90L,540L,3060L,20700L,145980L,1459800L,13854600L,140059800L,1514748600L,15869034000L,285268878000L,4109761962000L,59488383690000L,935767530036000L,13364309726748000L,240338216104020000L,4540941256642020000L,BigInteger.Parse("79739974380153240000") };
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
public class A053505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053505Inst Instance=new A053505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053506
{
public static readonly BigInteger[] Value={ 0L,1L,6L,48L,500L,6480L,100842L,1835008L,38263752L,900000000L,23579476910L,681091006464L,21505924728444L,737020860878848L,27246730957031250L,1080863910568919040L,BigInteger.Parse("45798768824157052688"),BigInteger.Parse("2064472028642102280192") };
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
public class A053506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053506Inst Instance=new A053506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053507
{
public static readonly BigInteger[] Value={ 0L,0L,1L,12L,150L,2160L,36015L,688128L,14880348L,360000000L,9646149645L,283787919360L,9098660462034L,315866083233792L,11806916748046875L,472877960873902080L,BigInteger.Parse("20205339187128111480"),BigInteger.Parse("917543123840934346752"),BigInteger.Parse("44131536275846038655193") };
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
public class A053507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053507Inst Instance=new A053507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053508
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,20L,360L,6860L,143360L,3306744L,84000000L,2338460520L,70946979840L,2332989862060L,82726831323136L,3148511132812500L,128071114403348480L,5546563698427324720L,BigInteger.Parse("254873089955815096320"),BigInteger.Parse("12387799656377835411984") };
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
public class A053508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053508Inst Instance=new A053508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053509
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,30L,735L,17920L,459270L,12600000L,372027810L,11824496640L,403786706895L,14772648450560L,577227041015625L,24013333950627840L,1060372471758165020L,BigInteger.Parse("49558656380297379840"),BigInteger.Parse("2444960458495625410260"),BigInteger.Parse("127008768000000000000000") };
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
public class A053509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053509Inst Instance=new A053509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053510
{
public static readonly long[] Value={ 1L,1L,4L,4L,7L,2L,9L,8L,8L,5L,8L,4L,9L,4L,0L,0L,1L,7L,4L,1L,4L,3L,4L,2L,7L,3L,5L,1L,3L,5L,3L,0L,5L,8L,7L,1L,1L,6L,4L,7L,2L,9L,4L,8L,1L,2L,9L,1L,5L,3L,1L,1L,5L,7L,1L,5L,1L,3L,6L,2L,3L,0L,7L,1L,4L,7L,2L,1L,3L,7L,7L,6L,9L,8L,8L,4L,8L,2L,6L,0L,7L,9L,7L,8L,3L,6L,2L,3L,2L,7L,0L,2L,7L,5L,4L,8L,9L,7L,0L,7L,7L,0L,2L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053510Inst : IEnumerable<long>
{
public static readonly long[] Value=A053510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053510.Bytes);
public long this[int i]=>Value[i];

public static A053510Inst Instance=new A053510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053511
{
public static readonly long[] Value={ 4L,9L,7L,1L,4L,9L,8L,7L,2L,6L,9L,4L,1L,3L,3L,8L,5L,4L,3L,5L,1L,2L,6L,8L,2L,8L,8L,2L,9L,0L,8L,9L,8L,8L,7L,3L,6L,5L,1L,6L,7L,8L,3L,2L,4L,3L,8L,0L,4L,4L,2L,4L,4L,6L,1L,3L,4L,0L,5L,3L,4L,9L,9L,9L,2L,4L,9L,4L,7L,1L,1L,2L,0L,8L,9L,5L,5L,2L,6L,7L,4L,6L,5L,5L,5L,4L,7L,3L,8L,6L,4L,6L,4L,2L,9L,1L,2L,2L,2L,3L,6L,9L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053511Inst : IEnumerable<long>
{
public static readonly long[] Value=A053511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053511.Bytes);
public long this[int i]=>Value[i];

public static A053511Inst Instance=new A053511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053512
{
public static readonly BigInteger[] Value={ 1L,6L,92L,4256L,631408L,287890282L,394680026626L,1633299243490821L,BigInteger.Parse("20522104351316248402"),BigInteger.Parse("784379015232375006607050"),BigInteger.Parse("91206645757124024620735442618"),BigInteger.Parse("32264019671635009481678592579241059"),BigInteger.Parse("34725332380760680832137350774453679498244") };
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
public class A053512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053512Inst Instance=new A053512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053513
{
public static readonly BigInteger[] Value={ 3L,18L,165L,3132L,137268L,15548004L,4679446950L,3771927027864L,8186669639820081L,BigInteger.Parse("48184182482857319682"),BigInteger.Parse("774912347548961791914585"),BigInteger.Parse("34299111628183837790980740312"),BigInteger.Parse("4205499936656520106909422649497294") };
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
public class A053513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053513Inst Instance=new A053513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053514
{
public static readonly BigInteger[] Value={ 4L,40L,816L,48400L,9333312L,6202675584L,14372025574144L,117323908831879296L,BigInteger.Parse("3413309842639341263872"),BigInteger.Parse("357775914831345583881365504"),BigInteger.Parse("136403808102564598893326677037056") };
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
public class A053514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053514Inst Instance=new A053514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053515
{
public static readonly BigInteger[] Value={ 1L,9L,710L,702995L,9167621626L,1601362624429243L,BigInteger.Parse("3837877364912125546166"),BigInteger.Parse("128777253726443722899317880176"),BigInteger.Parse("61454877368531170511811727162658812448"),BigInteger.Parse("422314689334495256777424027741114845781285378061") };
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
public class A053515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053515Inst Instance=new A053515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053516
{
public static readonly BigInteger[] Value={ 5L,325L,327125L,6360324375L,2483590604688125L,BigInteger.Parse("20211024423069510171875"),BigInteger.Parse("3524517841661451239027963515625"),BigInteger.Parse("13444967478414031326768049544880110156250") };
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
public class A053516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053516Inst Instance=new A053516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053517
{
public static readonly BigInteger[] Value={ 1L,5L,132L,22662L,29174514L,286151774704L,21712410740238954L,BigInteger.Parse("12980058344488389640470"),BigInteger.Parse("62082372574276838787463958455"),BigInteger.Parse("2405193558246444686967534052419452898") };
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
public class A053517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053517Inst Instance=new A053517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053518
{
public static readonly long[] Value={ 1L,5L,23L,45L,925L,7285L,7195L,641075L,6993545L,27779915L,1077005935L,15001154095L,6788401045L,3570274674605L,60484653310955L,40198648188145L,1869525647793155L,31559031031400605L,2865359642850975565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053518Inst : IEnumerable<long>
{
public static readonly long[] Value=A053518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053518.Bytes);
public long this[int i]=>Value[i];

public static A053518Inst Instance=new A053518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053519
{
public static readonly long[] Value={ 1L,3L,15L,29L,597L,4701L,4643L,413691L,4512993L,17926611L,695000919L,9680369943L,4380611853L,2303928046437L,39031251610227L,25940523189513L,1206420504316107L,20365306128628437L,1849040492948486661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053519Inst : IEnumerable<long>
{
public static readonly long[] Value=A053519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053519.Bytes);
public long this[int i]=>Value[i];

public static A053519Inst Instance=new A053519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053520
{
public static readonly long[] Value={ 2L,8L,38L,74L,1522L,11986L,11838L,1054766L,11506538L,45706526L,1772006854L,24681524038L,11169012898L,5874202721042L,99515904921182L,66139171377658L,3075946152109262L,51924337160029042L,4714400135799462226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053520Inst : IEnumerable<long>
{
public static readonly long[] Value=A053520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053520.Bytes);
public long this[int i]=>Value[i];

public static A053520Inst Instance=new A053520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053521
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,15L,25L,41L,67L,109L,177L,287L,465L,753L,1219L,1973L,3193L,5167L,8361L,6765L,1891L,8657L,5275L,6967L,3061L,5015L,8077L,6547L,7313L,6931L,7123L,1757L,881L,665L,9547L,5107L,229L,5337L,5567L,5453L,5511L,5483L,2749L,8233L,1373L,9607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053521Inst : IEnumerable<long>
{
public static readonly long[] Value=A053521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053521.Bytes);
public long this[int i]=>Value[i];

public static A053521Inst Instance=new A053521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053522
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,15L,25L,41L,67L,109L,177L,287L,465L,753L,1219L,1973L,3193L,323L,3517L,3841L,115L,3957L,4073L,251L,4325L,4577L,1113L,1423L,2537L,3961L,1625L,1397L,3023L,4421L,3723L,4073L,3899L,3987L,493L,4481L,4975L,4729L,4853L,599L,2727L,3327L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053522Inst : IEnumerable<long>
{
public static readonly long[] Value=A053522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053522.Bytes);
public long this[int i]=>Value[i];

public static A053522Inst Instance=new A053522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053523
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,15L,25L,41L,67L,109L,177L,287L,465L,753L,305L,265L,571L,837L,705L,193L,899L,547L,181L,729L,911L,821L,867L,845L,857L,213L,67L,281L,349L,631L,981L,807L,895L,213L,555L,769L,663L,717L,691L,705L,699L,703L,351L,33L,385L,419L,805L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053523Inst : IEnumerable<long>
{
public static readonly long[] Value=A053523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053523.Bytes);
public long this[int i]=>Value[i];

public static A053523Inst Instance=new A053523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053524
{
public static readonly long[] Value={ 0L,1L,4L,28L,160L,976L,5824L,35008L,209920L,1259776L,7558144L,45349888L,272097280L,1632587776L,9795518464L,58773127168L,352638730240L,2115832446976L,12694994550784L,76169967566848L,457019804876800L,2742118830309376L,16452712979759104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053524Inst : IEnumerable<long>
{
public static readonly long[] Value=A053524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053524.Bytes);
public long this[int i]=>Value[i];

public static A053524Inst Instance=new A053524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053525
{
public static readonly BigInteger[] Value={ 1L,0L,1L,4L,23L,166L,1437L,14512L,167491L,2174746L,31374953L,497909380L,8619976719L,161667969646L,3265326093109L,70663046421208L,1631123626335707L,40004637435452866L,1038860856732399105L,BigInteger.Parse("28476428717448349996"),BigInteger.Parse("821656049857815980455") };
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
public class A053525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053525Inst Instance=new A053525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053526
{
public static readonly long[] Value={ 0L,0L,0L,0L,16L,110L,435L,1295L,3220L,7056L,14070L,26070L,45540L,75790L,121121L,187005L,280280L,409360L,584460L,817836L,1124040L,1520190L,2026255L,2665355L,3464076L,4452800L,5666050L,7142850L,8927100L,11067966L,13620285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053526Inst : IEnumerable<long>
{
public static readonly long[] Value=A053526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053526.Bytes);
public long this[int i]=>Value[i];

public static A053526Inst Instance=new A053526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053527
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,140L,1125L,5355L,19075L,56133L,143955L,332475L,706860L,1404975L,2640638L,4733820L,8149050L,13543390L,21825450L,34227018L,52388985L,78463350L,115233195L,166252625L,236008773L,330108075L,455489125L,620664525L,835994250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053527Inst : IEnumerable<long>
{
public static readonly long[] Value=A053527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053527.Bytes);
public long this[int i]=>Value[i];

public static A053527Inst Instance=new A053527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053528
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,60L,1701L,14952L,81228L,331884L,1116675L,3256407L,8500734L,20306286L,45093048L,94189095L,186736368L,353904096L,644842674L,1134910242L,1936817820L,3215467584L,5207403663L,8245956642L,12793342716L,19481177100L,29161079805L,42967291185L,62393475690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053528Inst : IEnumerable<long>
{
public static readonly long[] Value=A053528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053528.Bytes);
public long this[int i]=>Value[i];

public static A053528Inst Instance=new A053528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053529
{
public static readonly BigInteger[] Value={ 1L,1L,4L,18L,120L,840L,7920L,75600L,887040L,10886400L,152409600L,2235340800L,36883123200L,628929100800L,11769069312000L,230150688768000L,4833164464128000L,105639166144512000L,2464913876705280000L,BigInteger.Parse("59606099200327680000"),BigInteger.Parse("1525429559126753280000") };
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
public class A053529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053529Inst Instance=new A053529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053530
{
public static readonly long[] Value={ 1L,0L,1L,3L,7L,35L,171L,847L,5041L,32643L,223705L,1659581L,13182159L,110802133L,984241363L,9212696235L,90477239521L,929604133343L,9969157068273L,111329454692485L,1291932988047775L,15550838026589061L,193833398512358011L,2498039016973836491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053530Inst : IEnumerable<long>
{
public static readonly long[] Value=A053530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053530.Bytes);
public long this[int i]=>Value[i];

public static A053530Inst Instance=new A053530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053531
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,1L,15L,72L,420L,2915L,24570L,245070L,2633400L,30588783L,383841315L,5197243590L,75666140550L,1177491151785L,19496256883740L,342184849138188L,6346249258076280L,124023565540658025L,2547445128977720475L,BigInteger.Parse("54865546632888272820") };
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
public class A053531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053531Inst Instance=new A053531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053532
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,3L,12L,60L,360L,2835L,24696L,237384L,2503440L,28941165L,363593340L,4930388892L,71759200968L,1115892704745L,18465120087120L,323965034820720L,6007037150742624L,117377605956803571L,2410702829834021820L,BigInteger.Parse("51917379915449131020") };
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
public class A053532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053532Inst Instance=new A053532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053533
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,12L,60L,360L,2520L,20160L,199584L,2147040L,25043040L,315485280L,4274281440L,62237343168L,968728662720L,16046598597120L,281802435747840L,5229395457937920L,102253297006250496L,2101387824575550720L,BigInteger.Parse("45281611027331723520") };
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
public class A053533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053533Inst Instance=new A053533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053534
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,7L,4L,1L,1L,5L,13L,13L,5L,1L,1L,6L,23L,38L,23L,6L,1L,1L,7L,37L,108L,108L,37L,7L,1L,1L,8L,58L,325L,940L,325L,58L,8L,1L,1L,9L,87L,1275L,190214L,190214L,1275L,87L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053534Inst : IEnumerable<long>
{
public static readonly long[] Value=A053534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053534.Bytes);
public long this[int i]=>Value[i];

public static A053534Inst Instance=new A053534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053535
{
public static readonly long[] Value={ 1L,6L,63L,540L,4941L,44226L,398763L,3586680L,32286681L,290560446L,2615103063L,23535750420L,211822285221L,1906398972666L,17157595536963L,154418345483760L,1389765152400561L,12507886242464886L,112570976569604463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053535Inst : IEnumerable<long>
{
public static readonly long[] Value=A053535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053535.Bytes);
public long this[int i]=>Value[i];

public static A053535Inst Instance=new A053535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053536
{
public static readonly long[] Value={ 1L,8L,112L,1280L,15616L,186368L,2240512L,26869760L,322502656L,3869769728L,46438285312L,557255229440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053536Inst : IEnumerable<long>
{
public static readonly long[] Value=A053536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053536.Bytes);
public long this[int i]=>Value[i];

public static A053536Inst Instance=new A053536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053537
{
public static readonly long[] Value={ 1L,10L,175L,2500L,38125L,568750L,8546875L,128125000L,1922265625L,28832031250L,432490234375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053537Inst : IEnumerable<long>
{
public static readonly long[] Value=A053537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053537.Bytes);
public long this[int i]=>Value[i];

public static A053537Inst Instance=new A053537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053538
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,5L,5L,4L,1L,1L,8L,10L,7L,5L,1L,1L,13L,18L,16L,9L,6L,1L,1L,21L,33L,31L,23L,11L,7L,1L,1L,34L,59L,62L,47L,31L,13L,8L,1L,1L,55L,105L,119L,101L,66L,40L,15L,9L,1L,1L,89L,185L,227L,205L,151L,88L,50L,17L,10L,1L,1L,144L,324L,426L,414L,321L,213L,113L,61L,19L,11L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053538Inst : IEnumerable<long>
{
public static readonly long[] Value=A053538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053538.Bytes);
public long this[int i]=>Value[i];

public static A053538Inst Instance=new A053538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053539
{
public static readonly long[] Value={ 0L,1L,16L,192L,2048L,20480L,196608L,1835008L,16777216L,150994944L,1342177280L,11811160064L,103079215104L,893353197568L,7696581394432L,65970697666560L,562949953421312L,4785074604081152L,40532396646334464L,342273571680157696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053539Inst : IEnumerable<long>
{
public static readonly long[] Value=A053539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053539.Bytes);
public long this[int i]=>Value[i];

public static A053539Inst Instance=new A053539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053540
{
public static readonly BigInteger[] Value={ 1L,18L,243L,2916L,32805L,354294L,3720087L,38263752L,387420489L,3874204890L,38354628411L,376572715308L,3671583974253L,35586121596606L,343151886824415L,3294258113514384L,31501343210481297L,300189270593998242L,2851798070642983299L,BigInteger.Parse("27017034353459841780") };
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
public class A053540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A053540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A053540Inst Instance=new A053540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053541
{
public static readonly long[] Value={ 1L,20L,300L,4000L,50000L,600000L,7000000L,80000000L,900000000L,10000000000L,110000000000L,1200000000000L,13000000000000L,140000000000000L,1500000000000000L,16000000000000000L,170000000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053541Inst : IEnumerable<long>
{
public static readonly long[] Value=A053541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053541.Bytes);
public long this[int i]=>Value[i];

public static A053541Inst Instance=new A053541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053542
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,1L,3L,2L,1L,1L,3L,2L,1L,5L,4L,3L,2L,1L,1L,5L,4L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,1L,5L,4L,3L,2L,1L,3L,2L,1L,1L,5L,4L,3L,2L,1L,3L,2L,1L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,1L,3L,2L,1L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,3L,2L,1L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053542Inst : IEnumerable<long>
{
public static readonly long[] Value=A053542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053542.Bytes);
public long this[int i]=>Value[i];

public static A053542Inst Instance=new A053542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053543
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,2L,1L,1L,1L,2L,3L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,2L,1L,1L,2L,3L,2L,1L,1L,1L,2L,3L,2L,1L,1L,2L,1L,1L,1L,2L,3L,2L,1L,1L,2L,1L,1L,2L,3L,2L,1L,1L,2L,3L,4L,3L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,2L,1L,1L,2L,1L,1L,2L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053543Inst : IEnumerable<long>
{
public static readonly long[] Value=A053543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053543.Bytes);
public long this[int i]=>Value[i];

public static A053543Inst Instance=new A053543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A053544
{
public static readonly long[] Value={ 0L,0L,0L,0L,5L,1L,3L,5L,110L,11110L,1L,2L,20L,220L,220L,25L,25L,30L,30L,2L,2L,1L,0L,40L,1L,5L,4L,2L,5L,1L,8L,1L,2L,3L,15L,50L,23L,25L,25L,2L,1L,35L,40L,3L,1L,40L,45L,110L,100L,100L,155L,3L,10L,15L,1125L,100L,100L,8L,25L,30L,30L,3L,13L,10L,1L,8L,1L,2L,22L,5L,275L,13L,17L,2L,1L,150L,25L,1L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A053544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A053544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A053544Inst : IEnumerable<long>
{
public static readonly long[] Value=A053544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A053544.Bytes);
public long this[int i]=>Value[i];

public static A053544Inst Instance=new A053544Inst();

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