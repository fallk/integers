using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A135877
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,3L,2L,2L,1L,1L,15L,15L,15L,12L,12L,9L,9L,6L,4L,4L,2L,1L,1L,105L,105L,105L,90L,90L,75L,75L,60L,48L,48L,36L,27L,27L,18L,12L,8L,8L,4L,2L,1L,1L,945L,945L,945L,840L,840L,735L,735L,630L,540L,540L,450L,375L,375L,300L,240L,192L,192L,144L,108L,81L,81L,54L,36L,24L,16L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135877Inst : IEnumerable<long>
{
public static readonly long[] Value=A135877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135877.Bytes);
public long this[int i]=>Value[i];

public static A135877Inst Instance=new A135877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135878
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,6L,6L,3L,1L,25L,25L,12L,4L,1L,138L,138L,63L,19L,5L,1L,970L,970L,421L,113L,28L,6L,1L,8390L,8390L,3472L,832L,190L,38L,7L,1L,86796L,86796L,34380L,7420L,1560L,283L,50L,8L,1L,1049546L,1049546L,399463L,78406L,15250L,2502L,411L,63L,9L,1L,14563135L,14563135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135878Inst : IEnumerable<long>
{
public static readonly long[] Value=A135878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135878.Bytes);
public long this[int i]=>Value[i];

public static A135878Inst Instance=new A135878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135879
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,6L,6L,4L,4L,2L,2L,1L,25L,25L,19L,19L,13L,13L,9L,5L,5L,3L,1L,1L,138L,138L,113L,113L,88L,88L,69L,50L,50L,37L,24L,24L,15L,10L,5L,5L,2L,1L,970L,970L,832L,832L,694L,694L,581L,468L,468L,380L,292L,292L,223L,173L,123L,123L,86L,62L,38L,38L,23L,13L,8L,3L,3L,1L,8390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135879Inst : IEnumerable<long>
{
public static readonly long[] Value=A135879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135879.Bytes);
public long this[int i]=>Value[i];

public static A135879Inst Instance=new A135879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136040
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,14L,16L,17L,19L,21L,22L,25L,26L,29L,31L,41L,49L,51L,52L,55L,58L,59L,60L,63L,65L,66L,67L,69L,71L,74L,77L,79L,81L,82L,87L,89L,108L,109L,113L,114L,116L,119L,122L,124L,127L,129L,130L,136L,137L,142L,143L,145L,147L,148L,151L,154L,158L,159L,161L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136040Inst : IEnumerable<long>
{
public static readonly long[] Value=A136040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136040.Bytes);
public long this[int i]=>Value[i];

public static A136040Inst Instance=new A136040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136041
{
public static readonly long[] Value={ 3L,7L,19L,43L,163L,487L,1459L,3079L,8803L,39367L,78787L,196831L,581743L,2125819L,6381667L,19131877L,86093443L,258280327L,516560659L,1214874127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136041Inst : IEnumerable<long>
{
public static readonly long[] Value=A136041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136041.Bytes);
public long this[int i]=>Value[i];

public static A136041Inst Instance=new A136041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136042
{
public static readonly long[] Value={ 5L,4L,1L,2L,3L,1L,1L,1L,2L,1L,1L,3L,2L,1L,5L,4L,1L,2L,3L,1L,1L,1L,2L,1L,1L,3L,2L,1L,5L,4L,1L,2L,3L,1L,1L,1L,2L,1L,1L,3L,2L,1L,5L,4L,1L,2L,3L,1L,1L,1L,2L,1L,1L,3L,2L,1L,5L,4L,1L,2L,3L,1L,1L,1L,2L,1L,1L,3L,2L,1L,5L,4L,1L,2L,3L,1L,1L,1L,2L,1L,1L,3L,2L,1L,5L,4L,1L,2L,3L,1L,1L,1L,2L,1L,1L,3L,2L,1L,5L,4L,1L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136042Inst : IEnumerable<long>
{
public static readonly long[] Value=A136042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136042.Bytes);
public long this[int i]=>Value[i];

public static A136042Inst Instance=new A136042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136043
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,5L,1L,6L,1L,1L,1L,4L,3L,9L,2L,2L,5L,4L,1L,10L,6L,9L,1L,14L,1L,1L,1L,5L,4L,5L,3L,18L,9L,4L,2L,10L,2L,7L,5L,5L,4L,9L,1L,10L,10L,2L,6L,26L,9L,8L,1L,9L,14L,29L,1L,30L,1L,1L,1L,6L,5L,33L,4L,11L,5L,14L,3L,3L,18L,9L,9L,15L,4L,17L,2L,27L,10L,41L,2L,2L,7L,11L,5L,4L,5L,4L,4L,3L,9L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136043Inst : IEnumerable<long>
{
public static readonly long[] Value=A136043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136043.Bytes);
public long this[int i]=>Value[i];

public static A136043Inst Instance=new A136043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136044
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,2L,1L,1L,1L,1L,1L,5L,2L,2L,4L,2L,1L,4L,2L,4L,2L,2L,1L,1L,2L,1L,2L,3L,2L,2L,3L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,4L,2L,2L,1L,4L,8L,3L,1L,1L,3L,1L,1L,1L,2L,3L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,2L,1L,4L,2L,1L,1L,3L,1L,1L,4L,2L,1L,6L,1L,1L,1L,3L,1L,1L,4L,2L,1L,2L,3L,1L,2L,1L,2L,3L,2L,2L,1L,2L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136044Inst : IEnumerable<long>
{
public static readonly long[] Value=A136044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136044.Bytes);
public long this[int i]=>Value[i];

public static A136044Inst Instance=new A136044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136045
{
public static readonly BigInteger[] Value={ 1L,4L,42L,660L,12810L,281736L,6727644L,170316432L,4504487130L,123255492360L,3465702008340L,99645553785960L,2918768920720380L,86852063374902000L,2619552500788984200L,BigInteger.Parse("79939673971478231760") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136045Inst Instance=new A136045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136046
{
public static readonly ulong[] Value={ 1L,3L,26L,345L,5754L,110586L,2341548L,53208441L,1276027610L,31930139670L,826963069140L,22035414489270L,601361536493340L,16749316314679500L,474777481850283240L,13665774112508864385UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136046Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A136046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136046.Bytes);
public ulong this[int i]=>Value[i];

public static A136046Inst Instance=new A136046Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136047
{
public static readonly long[] Value={ 1L,3L,12L,16L,41L,47L,96L,104L,185L,195L,316L,328L,497L,511L,736L,752L,1041L,1059L,1420L,1440L,1881L,1903L,2432L,2456L,3081L,3107L,3836L,3864L,4705L,4735L,5696L,5728L,6817L,6851L,8076L,8112L,9481L,9519L,11040L,11080L,12761L,12803L,14652L,14696L,16721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136047Inst : IEnumerable<long>
{
public static readonly long[] Value=A136047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136047.Bytes);
public long this[int i]=>Value[i];

public static A136047Inst Instance=new A136047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136048
{
public static readonly long[] Value={ 185L,497L,511L,1041L,1059L,1903L,3107L,4705L,4735L,6817L,9481L,12761L,16721L,33379L,48961L,49027L,68857L,80561L,80639L,93521L,179503L,201241L,250097L,306281L,306403L,405551L,482161L,482303L,523921L,885631L,947939L,1081001L,1081187L,1226177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136048Inst : IEnumerable<long>
{
public static readonly long[] Value=A136048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136048.Bytes);
public long this[int i]=>Value[i];

public static A136048Inst Instance=new A136048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136049
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,0L,2L,0L,2L,0L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,0L,1L,2L,2L,1L,0L,1L,3L,1L,0L,3L,2L,1L,1L,4L,0L,3L,1L,2L,3L,1L,2L,2L,2L,5L,1L,3L,1L,1L,1L,4L,2L,1L,1L,2L,3L,4L,4L,2L,2L,2L,4L,4L,5L,2L,3L,2L,3L,2L,3L,1L,1L,5L,3L,2L,2L,2L,3L,2L,2L,6L,4L,1L,2L,3L,4L,1L,3L,1L,3L,3L,2L,3L,4L,2L,5L,2L,3L,5L,3L,4L,2L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136049Inst : IEnumerable<long>
{
public static readonly long[] Value=A136049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136049.Bytes);
public long this[int i]=>Value[i];

public static A136049Inst Instance=new A136049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136050
{
public static readonly long[] Value={ 6L,8L,8L,8L,26L,17L,26L,17L,8L,17L,17L,26L,26L,26L,17L,26L,35L,35L,26L,26L,8L,35L,26L,17L,26L,35L,44L,26L,17L,35L,35L,35L,35L,26L,35L,26L,17L,26L,26L,26L,17L,35L,26L,35L,26L,35L,26L,17L,26L,17L,35L,35L,26L,26L,35L,35L,26L,35L,26L,35L,26L,26L,26L,35L,26L,44L,35L,26L,26L,35L,44L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136050Inst : IEnumerable<long>
{
public static readonly long[] Value=A136050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136050.Bytes);
public long this[int i]=>Value[i];

public static A136050Inst Instance=new A136050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136051
{
public static readonly long[] Value={ 3L,7L,13L,31L,37L,43L,67L,109L,127L,139L,151L,163L,199L,211L,241L,277L,307L,349L,367L,373L,433L,457L,463L,547L,571L,601L,613L,661L,673L,709L,727L,739L,787L,811L,823L,853L,919L,967L,991L,1021L,1087L,1117L,1129L,1171L,1231L,1291L,1297L,1399L,1471L,1483L,1549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136051Inst : IEnumerable<long>
{
public static readonly long[] Value=A136051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136051.Bytes);
public long this[int i]=>Value[i];

public static A136051Inst Instance=new A136051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136052
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,29L,31L,41L,61L,67L,71L,79L,89L,97L,101L,107L,109L,127L,131L,137L,139L,151L,157L,167L,197L,211L,227L,229L,239L,269L,277L,307L,317L,331L,347L,349L,379L,401L,409L,419L,431L,439L,449L,461L,479L,509L,547L,601L,607L,619L,641L,647L,661L,677L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136052Inst : IEnumerable<long>
{
public static readonly long[] Value=A136052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136052.Bytes);
public long this[int i]=>Value[i];

public static A136052Inst Instance=new A136052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136053
{
public static readonly long[] Value={ 3L,5L,13L,19L,23L,31L,43L,59L,61L,71L,83L,103L,113L,131L,163L,173L,181L,199L,223L,229L,233L,239L,241L,251L,281L,283L,311L,331L,353L,409L,433L,439L,463L,499L,503L,541L,563L,569L,619L,643L,653L,659L,691L,701L,709L,743L,761L,773L,853L,859L,863L,911L,919L,929L,941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136053Inst : IEnumerable<long>
{
public static readonly long[] Value=A136053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136053.Bytes);
public long this[int i]=>Value[i];

public static A136053Inst Instance=new A136053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136054
{
public static readonly long[] Value={ 3L,7L,19L,31L,37L,43L,61L,67L,79L,103L,163L,193L,199L,211L,271L,277L,313L,331L,337L,367L,373L,379L,397L,421L,487L,499L,523L,547L,571L,577L,613L,673L,691L,709L,733L,757L,787L,823L,829L,859L,907L,919L,967L,991L,997L,1033L,1051L,1117L,1123L,1129L,1237L,1249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136054Inst : IEnumerable<long>
{
public static readonly long[] Value=A136054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136054.Bytes);
public long this[int i]=>Value[i];

public static A136054Inst Instance=new A136054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136055
{
public static readonly long[] Value={ 5L,7L,11L,13L,41L,43L,47L,53L,67L,71L,73L,97L,101L,103L,151L,157L,173L,181L,197L,211L,223L,227L,241L,251L,257L,263L,271L,293L,313L,367L,383L,431L,461L,463L,521L,557L,563L,571L,577L,607L,617L,631L,661L,673L,683L,691L,727L,757L,773L,811L,823L,827L,883L,887L,907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136055Inst : IEnumerable<long>
{
public static readonly long[] Value=A136055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136055.Bytes);
public long this[int i]=>Value[i];

public static A136055Inst Instance=new A136055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136248
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,4L,6L,4L,3L,1L,1L,7L,13L,26L,31L,31L,25L,13L,6L,1L,1L,15L,40L,100L,171L,220L,255L,215L,156L,85L,35L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136248Inst : IEnumerable<long>
{
public static readonly long[] Value=A136248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136248.Bytes);
public long this[int i]=>Value[i];

public static A136248Inst Instance=new A136248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136249
{
public static readonly long[] Value={ 4L,-2L,1L,7L,-11L,43L,-59L,187L,-251L,763L,-1019L,3067L,-4091L,12283L,-16379L,49147L,-65531L,196603L,-262139L,786427L,-1048571L,3145723L,-4194299L,12582907L,-16777211L,50331643L,-67108859L,201326587L,-268435451L,805306363L,-1073741819L,3221225467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136249Inst : IEnumerable<long>
{
public static readonly long[] Value=A136249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136249.Bytes);
public long this[int i]=>Value[i];

public static A136249Inst Instance=new A136249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136250
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,14L,18L,23L,26L,28L,29L,30L,33L,35L,36L,39L,41L,50L,51L,52L,53L,58L,60L,65L,66L,69L,74L,81L,82L,83L,86L,89L,90L,95L,98L,99L,100L,105L,106L,113L,119L,130L,131L,134L,135L,138L,146L,148L,155L,158L,162L,172L,173L,174L,178L,179L,180L,183L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136250Inst : IEnumerable<long>
{
public static readonly long[] Value=A136250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136250.Bytes);
public long this[int i]=>Value[i];

public static A136250Inst Instance=new A136250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136251
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,9L,3L,7L,3L,7L,1L,1L,3L,5L,3L,5L,2L,7L,3L,15L,6L,4L,1L,1L,3L,3L,9L,3L,7L,1L,5L,9L,9L,4L,1L,3L,13L,8L,9L,1L,4L,11L,10L,9L,3L,6L,7L,8L,1L,1L,3L,3L,5L,10L,14L,1L,5L,6L,10L,13L,7L,1L,5L,9L,2L,12L,11L,13L,1L,2L,15L,9L,18L,5L,9L,17L,1L,6L,13L,1L,7L,3L,7L,3L,7L,9L,10L,8L,8L,19L,12L,1L,15L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136251Inst : IEnumerable<long>
{
public static readonly long[] Value=A136251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136251.Bytes);
public long this[int i]=>Value[i];

public static A136251Inst Instance=new A136251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136252
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,21L,29L,45L,61L,93L,125L,189L,253L,381L,509L,765L,1021L,1533L,2045L,3069L,4093L,6141L,8189L,12285L,16381L,24573L,32765L,49149L,65533L,98301L,131069L,196605L,262141L,393213L,524285L,786429L,1048573L,1572861L,2097149L,3145725L,4194301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136252Inst : IEnumerable<long>
{
public static readonly long[] Value=A136252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136252.Bytes);
public long this[int i]=>Value[i];

public static A136252Inst Instance=new A136252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136253
{
public static readonly long[] Value={ 1L,2L,4L,12L,24L,720L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136253Inst : IEnumerable<long>
{
public static readonly long[] Value=A136253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136253.Bytes);
public long this[int i]=>Value[i];

public static A136253Inst Instance=new A136253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136254
{
public static readonly long[] Value={ 4L,6L,8L,12L,20L,34L,56L,88L,132L,190L,264L,356L,468L,602L,760L,944L,1156L,1398L,1672L,1980L,2324L,2706L,3128L,3592L,4100L,4654L,5256L,5908L,6612L,7370L,8184L,9056L,9988L,10982L,12040L,13164L,14356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136254Inst : IEnumerable<long>
{
public static readonly long[] Value=A136254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136254.Bytes);
public long this[int i]=>Value[i];

public static A136254Inst Instance=new A136254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136255
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,3L,0L,0L,0L,4L,-3L,0L,-3L,0L,5L,0L,-6L,0L,-8L,0L,6L,5L,0L,-6L,0L,-15L,0L,7L,0L,16L,0L,0L,0L,-24L,0L,8L,-7L,0L,30L,0L,15L,0L,-35L,0L,9L,0L,-30L,0L,40L,0L,42L,0L,-48L,0L,10L,9L,0L,-75L,0L,35L,0L,84L,0L,-63L,0L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136255Inst : IEnumerable<long>
{
public static readonly long[] Value=A136255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136255.Bytes);
public long this[int i]=>Value[i];

public static A136255Inst Instance=new A136255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136256
{
public static readonly long[] Value={ 0L,-1L,1L,0L,-2L,1L,-1L,2L,-3L,1L,0L,0L,1L,-4L,1L,3L,-2L,3L,0L,-5L,1L,0L,6L,-3L,8L,-1L,-6L,1L,-5L,2L,6L,-3L,15L,-2L,-7L,1L,0L,-16L,5L,0L,-2L,24L,-3L,-8L,1L,7L,-2L,-30L,8L,-15L,0L,35L,-4L,-9L,1L,0L,30L,-7L,-40L,10L,-42L,3L,48L,-5L,-10L,1L,-9L,2L,75L,-15L,-35L,10L,-84L,7L,63L,-6L,-11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136256Inst : IEnumerable<long>
{
public static readonly long[] Value=A136256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136256.Bytes);
public long this[int i]=>Value[i];

public static A136256Inst Instance=new A136256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136257
{
public static readonly long[] Value={ 1L,20L,437L,10461L,270726L,7456194L,215666696L,6485151199L,201183083017L,6401210746834L,207969967925893L,6875935591529309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136257Inst : IEnumerable<long>
{
public static readonly long[] Value=A136257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136257.Bytes);
public long this[int i]=>Value[i];

public static A136257Inst Instance=new A136257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136258
{
public static readonly long[] Value={ 1L,5L,8L,6L,-4L,-20L,-32L,-24L,16L,80L,128L,96L,-64L,-320L,-512L,-384L,256L,1280L,2048L,1536L,-1024L,-5120L,-8192L,-6144L,4096L,20480L,32768L,24576L,-16384L,-81920L,-131072L,-98304L,65536L,327680L,524288L,393216L,-262144L,-1310720L,-2097152L,-1572864L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136258Inst : IEnumerable<long>
{
public static readonly long[] Value=A136258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136258.Bytes);
public long this[int i]=>Value[i];

public static A136258Inst Instance=new A136258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136259
{
public static readonly long[] Value={ 1L,3L,4L,5L,9L,13L,18L,19L,31L,32L,33L,38L,39L,55L,56L,57L,58L,59L,94L,95L,96L,97L,103L,104L,156L,157L,239L,244L,245L,249L,253L,254L,255L,256L,257L,258L,275L,276L,277L,419L,420L,609L,610L,787L,788L,789L,790L,791L,792L,1069L,1070L,1664L,1665L,1666L,1667L,1668L,1669L,1670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136259Inst : IEnumerable<long>
{
public static readonly long[] Value=A136259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136259.Bytes);
public long this[int i]=>Value[i];

public static A136259Inst Instance=new A136259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136260
{
public static readonly long[] Value={ 2L,3L,13L,23L,29L,31L,37L,43L,53L,73L,83L,103L,113L,127L,131L,137L,139L,163L,173L,193L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,347L,349L,353L,359L,367L,373L,379L,383L,389L,397L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136260Inst : IEnumerable<long>
{
public static readonly long[] Value=A136260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136260.Bytes);
public long this[int i]=>Value[i];

public static A136260Inst Instance=new A136260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136261
{
public static readonly long[] Value={ -1L,-1L,2L,1L,2L,-3L,-1L,-2L,-3L,4L,1L,2L,3L,4L,-5L,-1L,-2L,-3L,-4L,-5L,6L,1L,2L,3L,4L,5L,6L,-7L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,-9L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,-11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136261Inst : IEnumerable<long>
{
public static readonly long[] Value=A136261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136261.Bytes);
public long this[int i]=>Value[i];

public static A136261Inst Instance=new A136261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136262
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,5L,-2L,-3L,1L,0L,18L,-5L,-4L,1L,-33L,8L,42L,-9L,-5L,1L,0L,-174L,33L,80L,-14L,-6L,1L,279L,-48L,-555L,87L,135L,-20L,-7L,1L,0L,1950L,-279L,-1380L,185L,210L,-27L,-8L,1L,-2895L,384L,7920L,-975L,-2940L,345L,308L,-35L,-9L,1L,0L,-25290L,2895L,24360L,-2640L,-5628L,588L,432L,-44L,-10L,1L,35685L,-3840L,-125055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136262Inst : IEnumerable<long>
{
public static readonly long[] Value=A136262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136262.Bytes);
public long this[int i]=>Value[i];

public static A136262Inst Instance=new A136262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136263
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-2L,1L,0L,0L,3L,-1L,0L,0L,1L,-4L,1L,0L,0L,-1L,-2L,5L,-1L,0L,0L,1L,2L,3L,-6L,1L,0L,0L,-1L,-2L,-3L,-4L,7L,-1L,0L,0L,1L,2L,3L,4L,5L,-8L,1L,0L,0L,-1L,-2L,-3L,-4L,-5L,-6L,9L,-1L,0L,0L,1L,2L,3L,4L,5L,6L,7L,-10L,1L,0L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,11L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136263Inst : IEnumerable<long>
{
public static readonly long[] Value=A136263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136263.Bytes);
public long this[int i]=>Value[i];

public static A136263Inst Instance=new A136263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136296
{
public static readonly BigInteger[] Value={ 11L,13L,137L,9091L,909091L,5882353L,909090909090909091L,BigInteger.Parse("909090909090909090909090909091"),BigInteger.Parse("9090909090909090909090909090909090909090909090909091") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136296Inst Instance=new A136296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136297
{
public static readonly long[] Value={ 1L,3L,1L,-3L,-3L,3L,9L,9L,9L,27L,81L,189L,405L,891L,2025L,4617L,10449L,23571L,53217L,120285L,271917L,614547L,1388745L,3138345L,7092441L,16028523L,36223281L,81861597L,185000517L,418086603L,944843049L,2135270889L,4825543329L,10905346467L,24645222081L,55696256829L,125869143645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136297Inst : IEnumerable<long>
{
public static readonly long[] Value=A136297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136297.Bytes);
public long this[int i]=>Value[i];

public static A136297Inst Instance=new A136297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136298
{
public static readonly long[] Value={ 1L,2L,4L,9L,19L,41L,87L,185L,391L,825L,1735L,3641L,7623L,15929L,33223L,69177L,143815L,298553L,618951L,1281593L,2650567L,5475897L,11301319L,23301689L,48001479L,98799161L,203190727L,417566265L,857502151L,1759743545L,3608965575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136298Inst : IEnumerable<long>
{
public static readonly long[] Value=A136298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136298.Bytes);
public long this[int i]=>Value[i];

public static A136298Inst Instance=new A136298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136299
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,23L,41L,71L,121L,199L,313L,455L,569L,455L,-455L,-3641L,-12743L,-36409L,-94663L,-233017L,-553415L,-1281593L,-2912711L,-6524473L,-14447047L,-31690297L,-68972999L,-149130809L,-320631239L,-686001721L,-1461481927L,-3101920825L,-6561755591L,-13839339065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136299Inst : IEnumerable<long>
{
public static readonly long[] Value=A136299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136299.Bytes);
public long this[int i]=>Value[i];

public static A136299Inst Instance=new A136299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136300
{
public static readonly BigInteger[] Value={ 1L,0L,1L,5L,76L,1624L,52116L,2298708L,133929216L,9961180416L,921248743680L,103715841415680L,13967643016085760L,2217449301162071040L,BigInteger.Parse("409861043056032503040"),BigInteger.Parse("87262626872384643052800"),BigInteger.Parse("21202798521768886355558400"),BigInteger.Parse("5831660090586059239329792000"),BigInteger.Parse("1802587564536011525042697830400"),BigInteger.Parse("622185136016136818758343243366400"),BigInteger.Parse("238432510944919530702148531765248000"),BigInteger.Parse("100921590338431208107299482517995520000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136300Inst Instance=new A136300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136301
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,2L,1L,1L,13L,6L,13L,2L,6L,2L,1L,1L,29L,14L,73L,6L,42L,18L,29L,2L,18L,8L,14L,2L,6L,2L,1L,1L,61L,30L,301L,14L,186L,86L,301L,6L,102L,48L,186L,18L,102L,42L,61L,2L,42L,20L,86L,8L,48L,20L,30L,2L,18L,8L,14L,2L,6L,2L,1L,1L,125L,62L,1081L,30L,690L,330L,2069L,14L,414L,200L,1394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136301Inst : IEnumerable<long>
{
public static readonly long[] Value=A136301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136301.Bytes);
public long this[int i]=>Value[i];

public static A136301Inst Instance=new A136301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136302
{
public static readonly long[] Value={ 2L,6L,15L,35L,81L,188L,437L,1016L,2362L,5491L,12765L,29675L,68986L,160373L,372822L,866706L,2014847L,4683951L,10888865L,25313540L,58846841L,136802308L,318026782L,739322571L,1718716457L,3995531011L,9288482690L,21593102505L,50197873146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136302Inst : IEnumerable<long>
{
public static readonly long[] Value=A136302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136302.Bytes);
public long this[int i]=>Value[i];

public static A136302Inst Instance=new A136302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136303
{
public static readonly long[] Value={ 1L,5L,17L,48L,123L,300L,714L,1679L,3925L,9149L,21296L,49537L,115192L,267824L,622653L,1447533L,3365149L,7823068L,18186475L,42278476L,98285586L,228486323L,531166317L,1234811937L,2870589548L,6673311137L,15513566304L,36064666240L,83840177305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136303Inst : IEnumerable<long>
{
public static readonly long[] Value=A136303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136303.Bytes);
public long this[int i]=>Value[i];

public static A136303Inst Instance=new A136303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136304
{
public static readonly long[] Value={ 1L,2L,5L,14L,40L,116L,344L,1047L,3273L,10500L,34503L,115838L,396244L,1377221L,4851665L,17285662L,62173297L,225424527L,822919439L,3021713140L,11151957809L,41340655956L,153853915410L,574593145517L,2152679745351L,8087904580883L,30466311814036L,115036597198845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136304Inst : IEnumerable<long>
{
public static readonly long[] Value=A136304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136304.Bytes);
public long this[int i]=>Value[i];

public static A136304Inst Instance=new A136304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136305
{
public static readonly long[] Value={ 3L,8L,20L,47L,109L,253L,588L,1367L,3178L,7388L,17175L,39927L,92819L,215778L,501623L,1166132L,2710928L,6302143L,14650705L,34058757L,79177004L,184064203L,427897358L,994740672L,2312491503L,5375890523L,12497429235L,29052998162L,67540026539L,157011512528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136305Inst : IEnumerable<long>
{
public static readonly long[] Value=A136305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136305.Bytes);
public long this[int i]=>Value[i];

public static A136305Inst Instance=new A136305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136306
{
public static readonly long[] Value={ 1L,2L,6L,78L,8112L,81160560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136306Inst : IEnumerable<long>
{
public static readonly long[] Value=A136306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136306.Bytes);
public long this[int i]=>Value[i];

public static A136306Inst Instance=new A136306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136307
{
public static readonly long[] Value={ 1L,11L,211L,3211L,43211L,543211L,6543211L,76543211L,876543211L,9876543211L,109876543211L,11109876543211L,1211109876543211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136307Inst : IEnumerable<long>
{
public static readonly long[] Value=A136307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136307.Bytes);
public long this[int i]=>Value[i];

public static A136307Inst Instance=new A136307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136308
{
public static readonly BigInteger[] Value={ 1L,11L,1111L,11111111L,1111111111111111L,BigInteger.Parse("11111111111111111111111111111111"),BigInteger.Parse("1111111111111111111111111111111111111111111111111111111111111111") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136308Inst Instance=new A136308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136309
{
public static readonly long[] Value={ 1L,3L,8L,91L,1005L,1006010L,1006011006016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136309Inst : IEnumerable<long>
{
public static readonly long[] Value=A136309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136309.Bytes);
public long this[int i]=>Value[i];

public static A136309Inst Instance=new A136309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136310
{
public static readonly long[] Value={ 1L,2L,7L,34L,282L,2271L,36357L,581740L,18615716L,595702957L,19062494679L,1219999659522L,78079978209486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136310Inst : IEnumerable<long>
{
public static readonly long[] Value=A136310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136310.Bytes);
public long this[int i]=>Value[i];

public static A136310Inst Instance=new A136310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136311
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,6L,1L,2L,3L,4L,12L,1L,2L,3L,4L,8L,22L,1L,2L,3L,4L,5L,12L,43L,1L,2L,3L,4L,5L,10L,21L,79L,1L,2L,3L,4L,5L,6L,15L,37L,157L,1L,2L,3L,4L,5L,6L,12L,27L,73L,310L,1L,2L,3L,4L,5L,6L,7L,18L,49L,137L,610L,1L,2L,3L,4L,5L,6L,7L,14L,33L,84L,258L,1205L,1L,2L,3L,4L,5L,6L,7L,8L,21L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136311Inst : IEnumerable<long>
{
public static readonly long[] Value=A136311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136311.Bytes);
public long this[int i]=>Value[i];

public static A136311Inst Instance=new A136311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136568
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,3L,2L,1L,3L,1L,2L,1L,1L,1L,5L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,4L,2L,1L,2L,1L,1L,2L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,2L,6L,1L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136568Inst : IEnumerable<long>
{
public static readonly long[] Value=A136568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136568.Bytes);
public long this[int i]=>Value[i];

public static A136568Inst Instance=new A136568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136569
{
public static readonly long[] Value={ 1L,3L,6L,10L,21L,36L,61L,96L,156L,232L,357L,522L,768L,1092L,1563L,2174L,3039L,4164L,5695L,7686L,10362L,13792L,18333L,24138L,31706L,41316L,53712L,69348L,89319L,114396L,146114L,185724L,235482L,297252L,374316L,469578L,587646L,732888L,911961L,1131250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136569Inst : IEnumerable<long>
{
public static readonly long[] Value=A136569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136569.Bytes);
public long this[int i]=>Value[i];

public static A136569Inst Instance=new A136569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136570
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,17L,22L,32L,44L,62L,80L,112L,144L,193L,248L,323L,410L,530L,664L,845L,1054L,1324L,1634L,2037L,2498L,3082L,3760L,4601L,5580L,6789L,8186L,9891L,11876L,14271L,17052L,20393L,24260L,28876L,34224L,40557L,47888L,56540L,66516L,78240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136570Inst : IEnumerable<long>
{
public static readonly long[] Value=A136570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136570.Bytes);
public long this[int i]=>Value[i];

public static A136570Inst Instance=new A136570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136571
{
public static readonly long[] Value={ 1L,-2L,1L,2L,1L,1L,1L,0L,1L,1L,-1L,1L,-1L,1L,1L,-2L,-1L,1L,0L,-2L,1L,0L,-3L,1L,1L,-1L,-1L,1L,1L,-4L,-3L,3L,1L,1L,0L,-3L,1L,1L,-5L,-4L,6L,3L,-1L,1L,-1L,-2L,1L,1L,-1L,-4L,4L,1L,1L,0L,-4L,0L,2L,1L,1L,-7L,-6L,15L,10L,-10L,-4L,1L,1L,0L,-3L,-1L,1L,1L,-8L,-7L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136571Inst : IEnumerable<long>
{
public static readonly long[] Value=A136571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136571.Bytes);
public long this[int i]=>Value[i];

public static A136571Inst Instance=new A136571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136572
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,0L,6L,0L,0L,0L,0L,24L,0L,0L,0L,0L,0L,120L,0L,0L,0L,0L,0L,0L,720L,0L,0L,0L,0L,0L,0L,0L,5040L,0L,0L,0L,0L,0L,0L,0L,0L,40320L,0L,0L,0L,0L,0L,0L,0L,0L,0L,362880L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3628800L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136572Inst : IEnumerable<long>
{
public static readonly long[] Value=A136572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136572.Bytes);
public long this[int i]=>Value[i];

public static A136572Inst Instance=new A136572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136573
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,6L,6L,7L,11L,24L,24L,25L,29L,47L,120L,120L,121L,125L,143L,239L,720L,720L,721L,725L,743L,839L,1439L,5040L,5040L,5041L,5045L,5063L,5159L,5759L,10079L,40320L,40320L,40321L,40325L,40343L,40349L,41039L,45359L,80639L,362880L,362880L,362881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136573Inst : IEnumerable<long>
{
public static readonly long[] Value=A136573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136573.Bytes);
public long this[int i]=>Value[i];

public static A136573Inst Instance=new A136573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136574
{
public static readonly long[] Value={ 1L,1L,2L,7L,30L,149L,868L,5907L,46226L,409105L,4037904L,43954703L,522956302L,6749977101L,93928268300L,1401602636299L,22324392524298L,378011820620297L,6780385526348296L,128425485935180295L,2561327494111820294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136574Inst : IEnumerable<long>
{
public static readonly long[] Value=A136574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136574.Bytes);
public long this[int i]=>Value[i];

public static A136574Inst Instance=new A136574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136575
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,3L,2L,1L,1L,4L,2L,1L,1L,1L,5L,3L,2L,1L,1L,1L,6L,3L,2L,1L,1L,1L,1L,7L,4L,3L,2L,1L,1L,1L,1L,8L,4L,3L,2L,1L,1L,1L,1L,1L,9L,5L,3L,2L,1L,1L,1L,1L,1L,1L,10L,5L,3L,2L,1L,1L,1L,1L,1L,1L,1L,11L,6L,4L,3L,2L,1L,1L,1L,1L,1L,1L,1L,12L,6L,4L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,13L,7L,5L,4L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136575Inst : IEnumerable<long>
{
public static readonly long[] Value=A136575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136575.Bytes);
public long this[int i]=>Value[i];

public static A136575Inst Instance=new A136575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136576
{
public static readonly long[] Value={ 0L,1L,-3L,10L,-36L,136L,-532L,2136L,-8752L,36448L,-153824L,656448L,-2827904L,12281088L,-53709632L,236337536L,-1045603072L,4648306176L,-20753783296L,93022530560L,-418415228928L,1888065744896L,-8544699844608L,38774062837760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136576Inst : IEnumerable<long>
{
public static readonly long[] Value=A136576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136576.Bytes);
public long this[int i]=>Value[i];

public static A136576Inst Instance=new A136576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136577
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-16L,-256L,-4096L,0L,16777216L,4294967296L,1099511627776L,0L,-1152921504606846976L,BigInteger.Parse("-4722366482869645213696"),BigInteger.Parse("-19342813113834066795298816"),0L,BigInteger.Parse("5192296858534827628530496329220096"),BigInteger.Parse("340282366920938463463374607431768211456") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136577Inst Instance=new A136577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136578
{
public static readonly BigInteger[] Value={ 1L,5L,78L,6527L,3450452L,12594729052L,338284182093366L,BigInteger.Parse("70004091118158663618"),BigInteger.Parse("115159273597941035104859580"),BigInteger.Parse("1536760523930850376685165570432060"),BigInteger.Parse("168534058834325412618424268506407590697776") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136578Inst Instance=new A136578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136579
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,1L,0L,6L,1L,0L,2L,0L,24L,0L,1L,0L,6L,0L,120L,1L,0L,2L,0L,24L,0L,720L,0L,1L,0L,6L,0L,120L,0L,5040L,1L,0L,2L,0L,24L,0L,720L,0L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136579Inst : IEnumerable<long>
{
public static readonly long[] Value=A136579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136579.Bytes);
public long this[int i]=>Value[i];

public static A136579Inst Instance=new A136579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136580
{
public static readonly long[] Value={ 1L,1L,3L,7L,27L,127L,747L,5167L,41067L,368047L,3669867L,40284847L,482671467L,6267305647L,87660962667L,1313941673647L,21010450850667L,357001369769647L,6423384156578667L,122002101778601647L,2439325392333218667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136580Inst : IEnumerable<long>
{
public static readonly long[] Value=A136580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136580.Bytes);
public long this[int i]=>Value[i];

public static A136580Inst Instance=new A136580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136581
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,2L,0L,6L,0L,6L,24L,0L,24L,0L,24L,0L,120L,0L,120L,0L,120L,720L,0L,720L,0L,720L,0L,720L,0L,5040L,0L,5040L,0L,5040L,0L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136581Inst : IEnumerable<long>
{
public static readonly long[] Value=A136581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136581.Bytes);
public long this[int i]=>Value[i];

public static A136581Inst Instance=new A136581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136582
{
public static readonly BigInteger[] Value={ 3L,31L,3162277L,316227766016837933L,BigInteger.Parse("316227766016837933199889354443271") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136582Inst Instance=new A136582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136583
{
public static readonly long[] Value={ 1L,2L,7L,18L,33L,206L,468L,1061L,6831L,40377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136583Inst : IEnumerable<long>
{
public static readonly long[] Value=A136583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136583.Bytes);
public long this[int i]=>Value[i];

public static A136583Inst Instance=new A136583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136616
{
public static readonly long[] Value={ 1L,3L,6L,9L,11L,14L,17L,19L,22L,25L,28L,30L,33L,36L,38L,41L,44L,47L,49L,52L,55L,57L,60L,63L,66L,68L,71L,74L,76L,79L,82L,85L,87L,90L,93L,96L,98L,101L,104L,106L,109L,112L,115L,117L,120L,123L,125L,128L,131L,134L,136L,139L,142L,144L,147L,150L,153L,155L,158L,161L,163L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136616Inst : IEnumerable<long>
{
public static readonly long[] Value=A136616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136616.Bytes);
public long this[int i]=>Value[i];

public static A136616Inst Instance=new A136616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136617
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,11L,12L,14L,16L,18L,19L,21L,23L,24L,26L,28L,30L,31L,33L,35L,36L,38L,40L,42L,43L,45L,47L,48L,50L,52L,54L,55L,57L,59L,61L,62L,64L,66L,67L,69L,71L,73L,74L,76L,78L,79L,81L,83L,85L,86L,88L,90L,91L,93L,95L,97L,98L,100L,102L,103L,105L,107L,109L,110L,112L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136617Inst : IEnumerable<long>
{
public static readonly long[] Value=A136617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136617.Bytes);
public long this[int i]=>Value[i];

public static A136617Inst Instance=new A136617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136618
{
public static readonly long[] Value={ 5L,89L,107L,139L,313L,331L,409L,421L,443L,449L,461L,491L,503L,547L,653L,757L,761L,769L,941L,947L,1063L,1181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136618Inst : IEnumerable<long>
{
public static readonly long[] Value=A136618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136618.Bytes);
public long this[int i]=>Value[i];

public static A136618Inst Instance=new A136618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136619
{
public static readonly long[] Value={ 1L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136619Inst : IEnumerable<long>
{
public static readonly long[] Value=A136619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136619.Bytes);
public long this[int i]=>Value[i];

public static A136619Inst Instance=new A136619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136620
{
public static readonly long[] Value={ 1L,1L,-1L,0L,-1L,1L,-2L,4L,-2L,-4L,14L,-17L,8L,-1L,0L,4L,-13L,15L,-7L,1L,8L,-32L,46L,-25L,-1L,5L,-1L,8L,-48L,116L,-144L,96L,-32L,4L,0L,-24L,132L,-300L,361L,-244L,90L,-16L,1L,-16L,96L,-228L,252L,-79L,-109L,134L,-62L,13L,-1L,-32L,272L,-984L,1980L,-2416L,1811L,-787L,154L,10L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136620Inst : IEnumerable<long>
{
public static readonly long[] Value=A136620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136620.Bytes);
public long this[int i]=>Value[i];

public static A136620Inst Instance=new A136620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136621
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,5L,1L,1L,11L,20L,9L,1L,1L,18L,51L,48L,13L,1L,1L,26L,112L,169L,100L,20L,1L,1L,38L,221L,486L,461L,194L,28L,1L,1L,52L,411L,1210L,1667L,1128L,352L,40L,1L,1L,73L,720L,2761L,5095L,4959L,2517L,615L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136621Inst : IEnumerable<long>
{
public static readonly long[] Value=A136621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136621.Bytes);
public long this[int i]=>Value[i];

public static A136621Inst Instance=new A136621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136622
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,3L,5L,2L,1L,1L,3L,8L,4L,2L,1L,1L,3L,9L,10L,4L,2L,1L,1L,3L,9L,17L,8L,4L,2L,1L,1L,3L,9L,23L,16L,8L,4L,2L,1L,1L,3L,9L,27L,28L,14L,8L,4L,2L,1L,1L,3L,9L,28L,43L,26L,14L,8L,4L,2L,1L,1L,3L,9L,28L,60L,41L,24L,14L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136622Inst : IEnumerable<long>
{
public static readonly long[] Value=A136622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136622.Bytes);
public long this[int i]=>Value[i];

public static A136622Inst Instance=new A136622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136623
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,5L,7L,8L,9L,9L,11L,11L,13L,13L,13L,16L,17L,17L,19L,19L,19L,19L,23L,23L,25L,25L,27L,27L,29L,29L,31L,32L,31L,32L,31L,32L,37L,37L,37L,37L,41L,41L,43L,43L,43L,43L,47L,47L,49L,49L,49L,49L,53L,53L,53L,53L,53L,53L,59L,59L,61L,61L,61L,64L,61L,64L,67L,67L,67L,67L,71L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136623Inst : IEnumerable<long>
{
public static readonly long[] Value=A136623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136623.Bytes);
public long this[int i]=>Value[i];

public static A136623Inst Instance=new A136623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136624
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,3L,1L,2L,2L,6L,7L,6L,4L,1L,2L,2L,4L,8L,12L,15L,17L,14L,10L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136624Inst : IEnumerable<long>
{
public static readonly long[] Value=A136624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136624.Bytes);
public long this[int i]=>Value[i];

public static A136624Inst Instance=new A136624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136625
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,2L,3L,2L,2L,1L,6L,2L,2L,7L,4L,2L,2L,6L,8L,4L,2L,2L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136625Inst : IEnumerable<long>
{
public static readonly long[] Value=A136625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136625.Bytes);
public long this[int i]=>Value[i];

public static A136625Inst Instance=new A136625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136626
{
public static readonly long[] Value={ 4L,2L,3L,3L,2L,3L,2L,3L,3L,2L,3L,5L,3L,2L,2L,2L,2L,3L,3L,3L,3L,2L,2L,2L,1L,0L,2L,3L,3L,3L,2L,2L,3L,1L,2L,2L,2L,3L,3L,2L,2L,3L,2L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,2L,3L,2L,2L,2L,1L,2L,1L,2L,2L,1L,3L,3L,2L,1L,2L,3L,4L,4L,3L,3L,2L,0L,1L,2L,1L,1L,1L,1L,0L,1L,2L,2L,2L,1L,1L,2L,1L,0L,2L,2L,4L,3L,2L,1L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136626Inst : IEnumerable<long>
{
public static readonly long[] Value=A136626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136626.Bytes);
public long this[int i]=>Value[i];

public static A136626Inst Instance=new A136626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136627
{
public static readonly long[] Value={ 4L,3L,4L,3L,3L,3L,3L,3L,3L,2L,4L,5L,4L,2L,2L,2L,3L,3L,4L,3L,3L,2L,3L,2L,1L,0L,2L,3L,4L,3L,3L,2L,3L,1L,2L,2L,3L,3L,3L,2L,3L,3L,3L,1L,1L,2L,3L,2L,1L,1L,1L,1L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,1L,3L,3L,3L,1L,2L,3L,5L,4L,4L,3L,2L,0L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,0L,2L,2L,4L,3L,3L,1L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136627Inst : IEnumerable<long>
{
public static readonly long[] Value=A136627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136627.Bytes);
public long this[int i]=>Value[i];

public static A136627Inst Instance=new A136627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136628
{
public static readonly long[] Value={ 0L,1L,1L,3L,9L,29L,105L,390L,1528L,6119L,25140L,104936L,444637L,1905331L,8246619L,35988793L,158199975L,699788234L,3112679085L,13913394416L,62465305846L,281551756181L,1273583739390L,5779693081500L,26306751243309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136628Inst : IEnumerable<long>
{
public static readonly long[] Value=A136628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136628.Bytes);
public long this[int i]=>Value[i];

public static A136628Inst Instance=new A136628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136629
{
public static readonly BigInteger[] Value={ 0L,1L,1L,7L,68L,941L,16657L,360151L,9197036L,270900242L,9041240104L,337195959574L,13898017639838L,627328651766168L,30776662410513268L,1630608894822320320L,BigInteger.Parse("92788669297928611880"),BigInteger.Parse("5644035534941116506704") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136629Inst Instance=new A136629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136630
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,4L,0L,1L,0L,1L,0L,10L,0L,1L,0L,0L,16L,0L,20L,0L,1L,0L,1L,0L,91L,0L,35L,0L,1L,0L,0L,64L,0L,336L,0L,56L,0L,1L,0L,1L,0L,820L,0L,966L,0L,84L,0L,1L,0L,0L,256L,0L,5440L,0L,2352L,0L,120L,0L,1L,0L,1L,0L,7381L,0L,24970L,0L,5082L,0L,165L,0L,1L,0L,0L,1024L,0L,87296L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136630Inst : IEnumerable<long>
{
public static readonly long[] Value=A136630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136630.Bytes);
public long this[int i]=>Value[i];

public static A136630Inst Instance=new A136630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136631
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,28L,177L,1449L,14869L,185230L,2738962L,47287352L,939759621L,21241309681L,540698975061L,15370957337418L,484433735633218L,16817886069720724L,639545680226171989L,BigInteger.Parse("26507567678760284105") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A136631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A136631Inst Instance=new A136631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136696
{
public static readonly long[] Value={ 1L,1L,2L,6L,6L,3L,8L,2L,7L,7L,7L,5L,6L,6L,3L,2L,5L,4L,8L,8L,7L,3L,3L,6L,1L,7L,2L,6L,6L,3L,4L,7L,8L,3L,3L,6L,6L,6L,3L,7L,1L,5L,3L,3L,6L,3L,3L,6L,8L,5L,7L,6L,6L,3L,8L,8L,7L,3L,3L,6L,1L,7L,2L,5L,5L,1L,3L,3L,6L,4L,1L,8L,1L,1L,2L,6L,6L,3L,8L,2L,7L,7L,7L,5L,6L,6L,3L,2L,5L,4L,4L,4L,8L,6L,6L,3L,5L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136696Inst : IEnumerable<long>
{
public static readonly long[] Value=A136696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136696.Bytes);
public long this[int i]=>Value[i];

public static A136696Inst Instance=new A136696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136697
{
public static readonly long[] Value={ 1L,1L,2L,6L,2L,10L,5L,2L,5L,1L,10L,10L,10L,9L,5L,9L,1L,6L,9L,6L,10L,1L,2L,2L,4L,1L,4L,9L,10L,4L,10L,2L,9L,5L,5L,10L,8L,10L,6L,3L,10L,3L,5L,6L,2L,2L,4L,1L,4L,9L,10L,4L,10L,2L,9L,1L,1L,2L,6L,2L,10L,5L,2L,5L,1L,10L,5L,5L,10L,8L,10L,6L,3L,10L,3L,5L,6L,9L,9L,7L,10L,7L,2L,1L,7L,1L,9L,2L,5L,5L,10L,8L,10L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136697Inst : IEnumerable<long>
{
public static readonly long[] Value=A136697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136697.Bytes);
public long this[int i]=>Value[i];

public static A136697Inst Instance=new A136697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136698
{
public static readonly long[] Value={ 1L,1L,2L,6L,2L,10L,5L,11L,4L,6L,7L,5L,5L,5L,10L,6L,8L,4L,11L,5L,4L,7L,10L,2L,4L,4L,8L,6L,6L,6L,3L,9L,8L,10L,4L,8L,11L,11L,10L,6L,4L,8L,10L,10L,8L,6L,1L,11L,8L,8L,4L,2L,8L,4L,9L,3L,10L,6L,1L,11L,7L,7L,2L,6L,8L,4L,4L,4L,8L,4L,4L,8L,4L,4L,8L,2L,8L,4L,8L,8L,4L,3L,6L,6L,6L,6L,7L,9L,2L,10L,3L,9L,5L,9L,6L,6L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136698Inst : IEnumerable<long>
{
public static readonly long[] Value=A136698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136698.Bytes);
public long this[int i]=>Value[i];

public static A136698Inst Instance=new A136698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136699
{
public static readonly long[] Value={ 1L,1L,2L,6L,11L,3L,5L,9L,7L,11L,6L,1L,12L,12L,12L,11L,7L,2L,10L,8L,4L,6L,2L,7L,12L,1L,2L,2L,4L,12L,9L,6L,10L,5L,1L,9L,12L,2L,11L,7L,7L,1L,3L,12L,8L,9L,11L,10L,12L,3L,7L,6L,11L,11L,9L,1L,4L,7L,3L,8L,12L,4L,1L,11L,2L,10L,10L,7L,8L,6L,4L,11L,12L,5L,6L,8L,10L,3L,5L,5L,10L,4L,3L,2L,12L,6L,9L,3L,4L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136699Inst : IEnumerable<long>
{
public static readonly long[] Value=A136699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136699.Bytes);
public long this[int i]=>Value[i];

public static A136699Inst Instance=new A136699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136700
{
public static readonly long[] Value={ 1L,1L,2L,6L,10L,8L,6L,10L,10L,6L,4L,2L,10L,4L,4L,4L,8L,10L,12L,4L,10L,8L,8L,2L,6L,10L,8L,6L,12L,12L,10L,2L,8L,12L,2L,12L,12L,10L,2L,8L,12L,2L,6L,6L,12L,8L,4L,6L,8L,2L,2L,4L,12L,6L,2L,12L,6L,6L,12L,8L,4L,6L,8L,8L,8L,2L,6L,10L,8L,6L,2L,2L,4L,12L,6L,2L,12L,10L,10L,6L,4L,2L,10L,4L,10L,10L,6L,4L,2L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136700Inst : IEnumerable<long>
{
public static readonly long[] Value=A136700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136700.Bytes);
public long this[int i]=>Value[i];

public static A136700Inst Instance=new A136700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136701
{
public static readonly long[] Value={ 1L,1L,2L,6L,9L,8L,3L,6L,3L,12L,3L,3L,6L,3L,12L,12L,12L,9L,12L,3L,9L,9L,3L,9L,6L,9L,9L,3L,9L,6L,12L,12L,9L,12L,3L,12L,12L,9L,12L,3L,3L,3L,6L,3L,12L,6L,6L,12L,6L,9L,12L,12L,9L,12L,3L,6L,6L,12L,6L,9L,6L,6L,12L,6L,9L,9L,9L,3L,9L,6L,3L,3L,6L,3L,12L,9L,9L,3L,9L,6L,12L,12L,9L,12L,3L,12L,12L,9L,12L,3L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136701Inst : IEnumerable<long>
{
public static readonly long[] Value=A136701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136701.Bytes);
public long this[int i]=>Value[i];

public static A136701Inst Instance=new A136701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136702
{
public static readonly long[] Value={ 1L,1L,2L,6L,8L,8L,13L,11L,8L,8L,15L,5L,12L,12L,8L,8L,8L,8L,3L,9L,4L,4L,8L,8L,12L,12L,8L,8L,14L,6L,4L,12L,8L,8L,11L,1L,4L,4L,8L,8L,4L,4L,8L,8L,2L,10L,12L,4L,12L,12L,8L,8L,2L,10L,12L,4L,14L,14L,12L,4L,7L,11L,10L,6L,8L,8L,11L,1L,4L,4L,8L,8L,4L,4L,8L,8L,10L,2L,12L,4L,4L,4L,8L,8L,6L,14L,4L,12L,2L,2L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136702Inst : IEnumerable<long>
{
public static readonly long[] Value=A136702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136702.Bytes);
public long this[int i]=>Value[i];

public static A136702Inst Instance=new A136702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136703
{
public static readonly long[] Value={ 1L,0L,2L,3L,12L,26L,78L,195L,546L,1452L,4026L,11010L,30660L,85254L,239144L,672195L,1899120L,5379738L,15292914L,43581852L,124527988L,356594898L,1023295422L,2941952130L,8472886092L,24440956260L,70607383938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136703Inst : IEnumerable<long>
{
public static readonly long[] Value=A136703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136703.Bytes);
public long this[int i]=>Value[i];

public static A136703Inst Instance=new A136703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136704
{
public static readonly long[] Value={ 0L,1L,2L,5L,12L,30L,78L,205L,546L,1476L,4026L,11070L,30660L,85410L,239144L,672605L,1899120L,5380830L,15292914L,43584804L,124527988L,356602950L,1023295422L,2941974270L,8472886092L,24441017580L,70607383938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136704Inst : IEnumerable<long>
{
public static readonly long[] Value=A136704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136704.Bytes);
public long this[int i]=>Value[i];

public static A136704Inst Instance=new A136704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136705
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,-1L,1L,1L,0L,1L,-1L,-1L,0L,0L,-1L,1L,1L,0L,0L,0L,1L,-1L,-1L,0L,0L,0L,0L,-1L,1L,1L,0L,0L,0L,0L,0L,1L,-1L,-1L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136705Inst : IEnumerable<long>
{
public static readonly long[] Value=A136705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136705.Bytes);
public long this[int i]=>Value[i];

public static A136705Inst Instance=new A136705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136706
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,4L,1L,6L,1L,8L,1L,10L,1L,12L,2L,13L,2L,13L,2L,13L,2L,13L,2L,13L,3L,14L,3L,14L,3L,14L,3L,14L,3L,14L,4L,15L,4L,15L,4L,15L,4L,15L,4L,15L,5L,16L,5L,16L,5L,16L,5L,16L,5L,16L,6L,17L,6L,17L,6L,17L,6L,17L,6L,17L,7L,18L,7L,18L,7L,18L,7L,18L,7L,18L,8L,19L,8L,19L,8L,19L,8L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136706Inst : IEnumerable<long>
{
public static readonly long[] Value=A136706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136706.Bytes);
public long this[int i]=>Value[i];

public static A136706Inst Instance=new A136706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136707
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,2L,1L,1L,6L,2L,1L,9L,2L,1L,12L,3L,2L,13L,7L,2L,13L,10L,2L,13L,13L,3L,14L,14L,3L,14L,14L,3L,14L,14L,3L,14L,14L,4L,15L,15L,4L,15L,15L,4L,15L,15L,5L,16L,16L,5L,16L,16L,5L,16L,16L,6L,17L,17L,6L,17L,17L,6L,17L,17L,6L,17L,17L,7L,18L,18L,7L,18L,18L,7L,18L,18L,8L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136707Inst : IEnumerable<long>
{
public static readonly long[] Value=A136707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136707.Bytes);
public long this[int i]=>Value[i];

public static A136707Inst Instance=new A136707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136708
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,6L,2L,2L,1L,10L,2L,2L,2L,13L,6L,3L,2L,13L,10L,3L,2L,13L,13L,5L,3L,14L,14L,10L,3L,14L,14L,14L,4L,15L,15L,15L,4L,15L,15L,15L,4L,15L,15L,15L,5L,16L,16L,16L,5L,16L,16L,16L,6L,17L,17L,17L,6L,17L,17L,17L,6L,17L,17L,17L,7L,18L,18L,18L,7L,18L,18L,18L,8L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136708Inst : IEnumerable<long>
{
public static readonly long[] Value=A136708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136708.Bytes);
public long this[int i]=>Value[i];

public static A136708Inst Instance=new A136708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136709
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,4L,2L,2L,2L,1L,9L,2L,2L,2L,2L,13L,6L,3L,3L,2L,13L,11L,3L,3L,3L,14L,14L,8L,4L,3L,14L,14L,13L,4L,4L,15L,15L,15L,10L,4L,15L,15L,15L,15L,5L,16L,16L,16L,16L,5L,16L,16L,16L,16L,6L,17L,17L,17L,17L,6L,17L,17L,17L,17L,7L,18L,18L,18L,18L,7L,18L,18L,18L,18L,8L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136709Inst : IEnumerable<long>
{
public static readonly long[] Value=A136709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136709.Bytes);
public long this[int i]=>Value[i];

public static A136709Inst Instance=new A136709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136710
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,6L,2L,2L,2L,2L,1L,12L,3L,2L,2L,2L,2L,13L,10L,3L,3L,3L,3L,14L,14L,8L,4L,4L,3L,14L,14L,14L,5L,4L,4L,15L,15L,15L,12L,5L,4L,15L,15L,15L,15L,9L,5L,16L,16L,16L,16L,16L,6L,17L,17L,17L,17L,17L,6L,17L,17L,17L,17L,17L,7L,18L,18L,18L,18L,18L,7L,18L,18L,18L,18L,18L,8L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136710Inst : IEnumerable<long>
{
public static readonly long[] Value=A136710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136710.Bytes);
public long this[int i]=>Value[i];

public static A136710Inst Instance=new A136710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136711
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,8L,2L,2L,2L,2L,2L,2L,13L,7L,3L,3L,3L,3L,2L,13L,13L,5L,3L,3L,3L,3L,14L,14L,13L,4L,4L,4L,4L,15L,15L,15L,12L,5L,5L,4L,15L,15L,15L,15L,10L,5L,5L,16L,16L,16L,16L,16L,9L,6L,17L,17L,17L,17L,17L,17L,7L,18L,18L,18L,18L,18L,18L,7L,18L,18L,18L,18L,18L,18L,8L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136711Inst : IEnumerable<long>
{
public static readonly long[] Value=A136711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136711.Bytes);
public long this[int i]=>Value[i];

public static A136711Inst Instance=new A136711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A136984
{
public static readonly long[] Value={ 1L,3L,9L,11L,91L,111L,139L,911L,1389L,1823L,1839L,1983L,2983L,9123L,18391L,31339L,93989L,181339L,199823L,299823L,313339L,313391L,913139L,939889L,1811983L,1813339L,1983233L,2883123L,2981339L,2983139L,9122983L,9393239L,11128339L,11323833L,13828923L,13889323L,13921889L,18393989L,19833891L,19983323L,19998233L,19998323L,29813391L,29818333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A136984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A136984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A136984Inst : IEnumerable<long>
{
public static readonly long[] Value=A136984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A136984.Bytes);
public long this[int i]=>Value[i];

public static A136984Inst Instance=new A136984Inst();

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