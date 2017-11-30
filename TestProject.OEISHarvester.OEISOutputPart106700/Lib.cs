using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A132021
{
public static readonly long[] Value={ 4L,3L,8L,7L,9L,6L,8L,3L,7L,2L,0L,3L,6L,3L,8L,5L,3L,1L,2L,6L,6L,7L,2L,9L,9L,9L,7L,1L,7L,7L,2L,5L,8L,3L,5L,9L,6L,0L,4L,5L,7L,4L,6L,3L,1L,2L,3L,9L,3L,5L,1L,1L,6L,5L,4L,1L,7L,7L,3L,6L,7L,5L,6L,4L,3L,6L,7L,9L,1L,0L,6L,6L,5L,6L,9L,8L,6L,6L,5L,0L,0L,6L,9L,2L,8L,9L,6L,6L,7L,2L,3L,8L,9L,8L,5L,4L,4L,0L,0L,6L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132021Inst : IEnumerable<long>
{
public static readonly long[] Value=A132021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132021.Bytes);
public long this[int i]=>Value[i];

public static A132021Inst Instance=new A132021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132022
{
public static readonly long[] Value={ 4L,5L,0L,7L,1L,2L,6L,2L,5L,2L,2L,6L,0L,3L,9L,1L,3L,0L,8L,3L,0L,0L,0L,0L,7L,8L,9L,5L,8L,3L,5L,2L,7L,1L,5L,5L,6L,0L,4L,4L,6L,7L,8L,5L,0L,0L,5L,4L,0L,0L,8L,5L,4L,7L,4L,3L,9L,0L,4L,5L,8L,3L,4L,8L,9L,2L,4L,4L,0L,9L,6L,0L,7L,5L,4L,0L,6L,2L,9L,4L,0L,7L,8L,2L,4L,3L,5L,3L,4L,5L,3L,1L,8L,6L,0L,8L,9L,6L,2L,6L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132022Inst : IEnumerable<long>
{
public static readonly long[] Value=A132022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132022.Bytes);
public long this[int i]=>Value[i];

public static A132022Inst Instance=new A132022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132023
{
public static readonly long[] Value={ 4L,5L,8L,7L,6L,6L,7L,2L,6L,6L,9L,9L,7L,6L,8L,9L,8L,5L,0L,2L,0L,0L,0L,5L,1L,5L,3L,3L,6L,9L,7L,4L,3L,7L,2L,1L,7L,8L,2L,5L,4L,6L,6L,8L,8L,7L,1L,4L,7L,3L,1L,8L,7L,0L,0L,7L,8L,2L,4L,4L,0L,1L,3L,8L,5L,0L,6L,9L,9L,7L,4L,4L,0L,3L,2L,6L,5L,9L,3L,0L,3L,6L,5L,2L,3L,7L,8L,1L,7L,1L,0L,9L,0L,4L,0L,5L,8L,4L,7L,5L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132023Inst : IEnumerable<long>
{
public static readonly long[] Value=A132023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132023.Bytes);
public long this[int i]=>Value[i];

public static A132023Inst Instance=new A132023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132024
{
public static readonly long[] Value={ 4L,6L,4L,5L,6L,8L,8L,8L,3L,6L,8L,6L,4L,7L,6L,3L,9L,0L,9L,8L,1L,9L,5L,9L,5L,6L,9L,7L,4L,8L,4L,7L,8L,0L,1L,0L,8L,7L,0L,0L,5L,8L,5L,1L,5L,4L,9L,5L,1L,2L,3L,0L,6L,5L,5L,6L,6L,0L,8L,5L,6L,0L,5L,9L,7L,0L,6L,0L,9L,9L,5L,7L,6L,2L,7L,4L,4L,1L,5L,4L,3L,8L,4L,8L,7L,8L,8L,8L,1L,2L,5L,0L,7L,6L,2L,1L,9L,4L,7L,0L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132024Inst : IEnumerable<long>
{
public static readonly long[] Value=A132024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132024.Bytes);
public long this[int i]=>Value[i];

public static A132024Inst Instance=new A132024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132025
{
public static readonly long[] Value={ 4L,6L,8L,9L,4L,5L,1L,7L,8L,3L,6L,7L,0L,2L,3L,6L,9L,3L,2L,8L,3L,2L,8L,0L,0L,3L,5L,4L,1L,8L,6L,5L,6L,3L,9L,4L,0L,6L,8L,0L,4L,5L,7L,5L,8L,6L,9L,8L,9L,8L,5L,6L,0L,1L,6L,7L,1L,9L,7L,9L,9L,2L,3L,2L,7L,4L,7L,5L,7L,3L,2L,8L,3L,4L,6L,7L,0L,4L,3L,8L,1L,7L,5L,4L,9L,5L,0L,9L,4L,2L,7L,5L,7L,0L,0L,0L,1L,5L,9L,1L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132025Inst : IEnumerable<long>
{
public static readonly long[] Value=A132025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132025.Bytes);
public long this[int i]=>Value[i];

public static A132025Inst Instance=new A132025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132026
{
public static readonly long[] Value={ 4L,7L,2L,3L,6L,2L,4L,4L,3L,8L,1L,6L,5L,7L,2L,2L,3L,6L,5L,5L,1L,4L,1L,3L,3L,8L,3L,3L,3L,2L,3L,2L,7L,3L,5L,3L,3L,4L,9L,6L,6L,4L,2L,9L,5L,8L,5L,0L,2L,2L,1L,9L,4L,6L,2L,1L,8L,8L,9L,0L,9L,6L,1L,1L,7L,7L,8L,7L,1L,9L,9L,4L,4L,2L,6L,0L,1L,3L,0L,7L,7L,9L,5L,4L,2L,9L,4L,3L,2L,5L,3L,0L,7L,2L,3L,0L,7L,8L,1L,1L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132026Inst : IEnumerable<long>
{
public static readonly long[] Value=A132026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132026.Bytes);
public long this[int i]=>Value[i];

public static A132026Inst Instance=new A132026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132027
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,12L,14L,16L,27L,30L,33L,48L,52L,56L,75L,80L,85L,216L,228L,240L,294L,308L,322L,384L,400L,416L,729L,756L,783L,900L,930L,960L,1089L,1122L,1155L,1728L,1776L,1824L,2028L,2080L,2132L,2352L,2408L,2464L,3375L,3450L,3525L,3840L,3920L,4000L,4335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132027Inst : IEnumerable<long>
{
public static readonly long[] Value=A132027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132027.Bytes);
public long this[int i]=>Value[i];

public static A132027Inst Instance=new A132027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132028
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,16L,18L,20L,22L,36L,39L,42L,45L,64L,68L,72L,76L,100L,105L,110L,115L,144L,150L,156L,162L,196L,203L,210L,217L,512L,528L,544L,560L,648L,666L,684L,702L,800L,820L,840L,860L,968L,990L,1012L,1034L,1728L,1764L,1800L,1836L,2028L,2067L,2106L,2145L,2352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132028Inst : IEnumerable<long>
{
public static readonly long[] Value=A132028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132028.Bytes);
public long this[int i]=>Value[i];

public static A132028Inst Instance=new A132028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132029
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,20L,22L,24L,26L,28L,45L,48L,51L,54L,57L,80L,84L,88L,92L,96L,125L,130L,135L,140L,145L,180L,186L,192L,198L,204L,245L,252L,259L,266L,273L,320L,328L,336L,344L,352L,405L,414L,423L,432L,441L,1000L,1020L,1040L,1060L,1080L,1210L,1232L,1254L,1276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132029Inst : IEnumerable<long>
{
public static readonly long[] Value=A132029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132029.Bytes);
public long this[int i]=>Value[i];

public static A132029Inst Instance=new A132029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132030
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,24L,26L,28L,30L,32L,34L,54L,57L,60L,63L,66L,69L,96L,100L,104L,108L,112L,116L,150L,155L,160L,165L,170L,175L,216L,222L,228L,234L,240L,246L,294L,301L,308L,315L,322L,329L,384L,392L,400L,408L,416L,424L,486L,495L,504L,513L,522L,531L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132030Inst : IEnumerable<long>
{
public static readonly long[] Value=A132030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132030.Bytes);
public long this[int i]=>Value[i];

public static A132030Inst Instance=new A132030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132031
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,28L,30L,32L,34L,36L,38L,40L,63L,66L,69L,72L,75L,78L,81L,112L,116L,120L,124L,128L,132L,136L,175L,180L,185L,190L,195L,200L,205L,252L,258L,264L,270L,276L,282L,288L,343L,350L,357L,364L,371L,378L,385L,448L,456L,464L,472L,480L,488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132031Inst : IEnumerable<long>
{
public static readonly long[] Value=A132031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132031.Bytes);
public long this[int i]=>Value[i];

public static A132031Inst Instance=new A132031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132032
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,32L,34L,36L,38L,40L,42L,44L,46L,72L,75L,78L,81L,84L,87L,90L,93L,128L,132L,136L,140L,144L,148L,152L,156L,200L,205L,210L,215L,220L,225L,230L,235L,288L,294L,300L,306L,312L,318L,324L,330L,392L,399L,406L,413L,420L,427L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132032Inst : IEnumerable<long>
{
public static readonly long[] Value=A132032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132032.Bytes);
public long this[int i]=>Value[i];

public static A132032Inst Instance=new A132032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132033
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,36L,38L,40L,42L,44L,46L,48L,50L,52L,81L,84L,87L,90L,93L,96L,99L,102L,105L,144L,148L,152L,156L,160L,164L,168L,172L,176L,225L,230L,235L,240L,245L,250L,255L,260L,265L,324L,330L,336L,342L,348L,354L,360L,366L,372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132033Inst : IEnumerable<long>
{
public static readonly long[] Value=A132033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132033.Bytes);
public long this[int i]=>Value[i];

public static A132033Inst Instance=new A132033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132034
{
public static readonly long[] Value={ 8L,0L,5L,6L,8L,7L,7L,2L,8L,1L,6L,2L,1L,6L,4L,9L,4L,0L,9L,2L,3L,7L,5L,0L,2L,1L,5L,4L,9L,6L,2L,9L,8L,9L,6L,8L,9L,1L,7L,9L,9L,7L,6L,2L,8L,6L,9L,3L,9L,2L,6L,6L,9L,2L,0L,8L,5L,7L,5L,6L,8L,1L,0L,0L,7L,2L,1L,9L,4L,1L,0L,5L,4L,8L,2L,0L,3L,6L,2L,0L,2L,0L,4L,5L,6L,3L,0L,4L,3L,7L,7L,0L,0L,5L,3L,2L,8L,0L,2L,7L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132034Inst : IEnumerable<long>
{
public static readonly long[] Value=A132034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132034.Bytes);
public long this[int i]=>Value[i];

public static A132034Inst Instance=new A132034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132035
{
public static readonly long[] Value={ 8L,3L,6L,7L,9L,5L,4L,0L,7L,0L,8L,9L,0L,3L,7L,8L,7L,1L,0L,2L,6L,7L,2L,9L,7L,9L,8L,1L,4L,6L,1L,3L,6L,2L,4L,1L,3L,5L,2L,4L,3L,6L,4L,3L,5L,8L,7L,6L,7L,1L,6L,5L,1L,9L,9L,6L,4L,1L,1L,5L,1L,0L,1L,7L,7L,0L,0L,9L,1L,6L,0L,1L,2L,6L,5L,4L,2L,7L,6L,0L,5L,8L,7L,8L,7L,5L,5L,5L,4L,2L,8L,4L,9L,0L,5L,1L,2L,0L,2L,1L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132035Inst : IEnumerable<long>
{
public static readonly long[] Value=A132035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132035.Bytes);
public long this[int i]=>Value[i];

public static A132035Inst Instance=new A132035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132036
{
public static readonly long[] Value={ 8L,5L,9L,4L,0L,5L,9L,9L,4L,4L,0L,0L,7L,0L,2L,8L,6L,6L,2L,0L,0L,7L,5L,8L,5L,8L,0L,0L,6L,4L,4L,1L,8L,8L,9L,4L,9L,0L,9L,4L,8L,4L,9L,7L,9L,5L,8L,8L,0L,4L,0L,9L,1L,7L,7L,4L,2L,4L,6L,9L,8L,8L,5L,8L,3L,1L,0L,0L,1L,3L,2L,3L,0L,2L,2L,9L,0L,2L,3L,9L,6L,5L,5L,2L,3L,6L,8L,9L,6L,5L,3L,7L,4L,9L,8L,3L,5L,3L,1L,4L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132036Inst : IEnumerable<long>
{
public static readonly long[] Value=A132036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132036.Bytes);
public long this[int i]=>Value[i];

public static A132036Inst Instance=new A132036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132037
{
public static readonly long[] Value={ 8L,7L,6L,5L,6L,0L,3L,5L,4L,0L,3L,5L,9L,6L,4L,2L,0L,5L,8L,3L,6L,0L,1L,9L,8L,3L,8L,4L,1L,7L,8L,6L,2L,0L,1L,0L,1L,0L,6L,6L,3L,5L,1L,0L,1L,1L,7L,4L,6L,7L,1L,8L,3L,3L,6L,1L,4L,9L,3L,5L,2L,8L,0L,1L,5L,8L,7L,0L,8L,5L,4L,2L,3L,1L,7L,1L,8L,2L,9L,9L,6L,9L,9L,0L,4L,4L,4L,7L,7L,7L,6L,9L,2L,0L,7L,9L,1L,9L,6L,4L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132037Inst : IEnumerable<long>
{
public static readonly long[] Value=A132037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132037.Bytes);
public long this[int i]=>Value[i];

public static A132037Inst Instance=new A132037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132038
{
public static readonly long[] Value={ 8L,9L,0L,0L,1L,0L,0L,9L,9L,9L,9L,8L,9L,9L,9L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,9L,9L,9L,9L,9L,9L,9L,9L,8L,9L,9L,9L,9L,9L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,8L,9L,9L,9L,9L,9L,9L,9L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132038Inst : IEnumerable<long>
{
public static readonly long[] Value=A132038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132038.Bytes);
public long this[int i]=>Value[i];

public static A132038Inst Instance=new A132038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132039
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,74L,2122L,267292L,194323504L,980945301116L,39560543100700028L,BigInteger.Parse("14356125485861852659544"),BigInteger.Parse("52095666080476161483596777824"),BigInteger.Parse("2079492908949143825845786572097662328"),BigInteger.Parse("996080457608702027557335524810508733871848312") };
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
public class A132039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132039Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132039.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132039Inst Instance=new A132039Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132056
{
public static readonly long[] Value={ 1L,8L,1L,120L,24L,1L,2640L,672L,48L,1L,76560L,22800L,2160L,80L,1L,2756160L,920160L,104880L,5280L,120L,1L,118514880L,43243200L,5639760L,347760L,10920L,168L,1L,5925744000L,2323918080L,336510720L,24071040L,937440L,20160L,224L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132056Inst : IEnumerable<long>
{
public static readonly long[] Value=A132056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132056.Bytes);
public long this[int i]=>Value[i];

public static A132056Inst Instance=new A132056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132057
{
public static readonly long[] Value={ 1L,28L,1L,980L,56L,1L,37730L,2744L,84L,1L,1531838L,130340L,5292L,112L,1L,64337196L,6136956L,299782L,8624L,140L,1L,2766499428L,288408120L,16120314L,568008L,12740L,168L,1L,121034349975L,13561837212L,841627332L,34401528L,956970L,17640L,196L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132057Inst : IEnumerable<long>
{
public static readonly long[] Value=A132057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132057.Bytes);
public long this[int i]=>Value[i];

public static A132057Inst Instance=new A132057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132058
{
public static readonly BigInteger[] Value={ 1L,29L,1037L,40559L,1667583L,70782699L,3071608779L,135473190854L,6049729693582L,272822775416318L,12401578633961126L,567447248339504450L,BigInteger.Parse("26107796156861857866"),BigInteger.Parse("1206858263561650517658"),BigInteger.Parse("56014709781906608746434") };
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
public class A132058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132058Inst Instance=new A132058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132059
{
public static readonly BigInteger[] Value={ 1L,27L,925L,35069L,1406679L,58491537L,2493656187L,108280678092L,4768395658314L,212335592489544L,9540877059969102L,431908789303835976L,BigInteger.Parse("19675192863275361294"),BigInteger.Parse("901089855844979674068"),BigInteger.Parse("41459199062515242868098") };
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
public class A132059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132059Inst Instance=new A132059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132060
{
public static readonly BigInteger[] Value={ 1L,9L,145L,3361L,101601L,3786601L,167756689L,8611201665L,502522701121L,32854723149961L,2378687990172561L,188913154677765409L,16328988725252964385UL,BigInteger.Parse("1525987835722540609641"),BigInteger.Parse("153312690475268723848081") };
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
public class A132060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132060Inst Instance=new A132060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132061
{
public static readonly BigInteger[] Value={ 1L,7L,97L,2015L,55841L,1935719L,80574433L,3915183103L,217530794305L,13603055116679L,945542295992801L,72321915976403807L,6036466379411066977L,BigInteger.Parse("545983089637963491175"),BigInteger.Parse("53194885608199879974241") };
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
public class A132061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132061Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132061.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132061Inst Instance=new A132061Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132062
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,3L,1L,0L,15L,15L,6L,1L,0L,105L,105L,45L,10L,1L,0L,945L,945L,420L,105L,15L,1L,0L,10395L,10395L,4725L,1260L,210L,21L,1L,0L,135135L,135135L,62370L,17325L,3150L,378L,28L,1L,0L,2027025L,2027025L,945945L,270270L,51975L,6930L,630L,36L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132062Inst : IEnumerable<long>
{
public static readonly long[] Value=A132062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132062.Bytes);
public long this[int i]=>Value[i];

public static A132062Inst Instance=new A132062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132063
{
public static readonly BigInteger[] Value={ 1L,2L,13L,137L,1996L,37109L,838993L,22336292L,684256123L,23705447669L,916278718246L,39088637286467L,1824146816097373L,92434987026468722L,5054207258536066681L,BigInteger.Parse("296598839923053166109"),BigInteger.Parse("18593246768511584995468") };
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
public class A132063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132063Inst Instance=new A132063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132064
{
public static readonly BigInteger[] Value={ 1L,4L,61L,442L,8671L,48643L,275491L,4691011L,44046781L,421781671L,4866217861L,44417846491L,469583176771L,4807072338781L,42155398282291L,461921395126861L,4447050855867481L,42996432430288771L,480551127927589171L,4866530171154022291L,BigInteger.Parse("46198061648602166491") };
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
public class A132064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132064Inst Instance=new A132064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132065
{
public static readonly long[] Value={ 1L,3L,4L,9L,6L,22L,8L,27L,16L,32L,12L,123L,14L,42L,40L,81L,18L,164L,20L,171L,52L,62L,24L,704L,36L,72L,64L,219L,30L,808L,32L,243L,76L,92L,72L,1765L,38L,102L,88L,944L,42L,1016L,44L,315L,276L,122L,48L,4075L,64L,336L,112L,363L,54L,1224L,104L,1170L,124L,152L,60L,17815L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132065Inst : IEnumerable<long>
{
public static readonly long[] Value=A132065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132065.Bytes);
public long this[int i]=>Value[i];

public static A132065Inst Instance=new A132065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132066
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,1L,4L,1L,1L,1L,3L,1L,6L,1L,1L,2L,4L,1L,2L,6L,1L,1L,3L,5L,1L,10L,1L,1L,1L,1L,2L,6L,1L,12L,1L,1L,5L,7L,1L,2L,2L,10L,1L,1L,2L,4L,8L,1L,16L,1L,1L,1L,3L,3L,9L,1L,18L,1L,1L,2L,1L,5L,10L,1L,2L,4L,14L,1L,1L,9L,11L,1L,22L,1L,1L,1L,1L,2L,2L,4L,12L,1L,4L,20L,1L,1L,11L,13L,1L,2L,6L,18L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132066Inst : IEnumerable<long>
{
public static readonly long[] Value=A132066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132066.Bytes);
public long this[int i]=>Value[i];

public static A132066Inst Instance=new A132066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132067
{
public static readonly long[] Value={ 20L,30L,35L,40L,42L,56L,60L,63L,70L,72L,77L,80L,84L,88L,90L,99L,100L,105L,110L,112L,117L,120L,126L,130L,132L,140L,143L,144L,150L,154L,156L,160L,165L,168L,175L,176L,180L,182L,187L,189L,195L,198L,200L,204L,208L,209L,210L,216L,220L,221L,224L,238L,240L,245L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132067Inst : IEnumerable<long>
{
public static readonly long[] Value=A132067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132067.Bytes);
public long this[int i]=>Value[i];

public static A132067Inst Instance=new A132067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132068
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,4L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,2L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,4L,2L,2L,1L,1L,2L,3L,1L,3L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,2L,4L,2L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132068Inst : IEnumerable<long>
{
public static readonly long[] Value=A132068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132068.Bytes);
public long this[int i]=>Value[i];

public static A132068Inst Instance=new A132068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132069
{
public static readonly long[] Value={ 1L,-1L,-3L,2L,1L,-1L,6L,6L,-7L,-7L,-3L,-12L,-2L,12L,18L,2L,9L,16L,-21L,-20L,1L,-12L,-36L,22L,14L,-1L,36L,20L,-6L,-30L,6L,-32L,-23L,24L,48L,6L,7L,36L,-60L,-24L,-7L,-42L,-36L,42L,12L,-7L,66L,46L,-18L,-43L,-3L,-32L,-12L,52L,60L,-12L,42L,40L,-90L,-60L,-2L,-62L,-96L,42L,41L,12L,72L,66L,-16L,-44L,18L,-72L,-49L,72L,108L,2L,20L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132069Inst : IEnumerable<long>
{
public static readonly long[] Value=A132069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132069.Bytes);
public long this[int i]=>Value[i];

public static A132069Inst Instance=new A132069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132070
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,121L,1166L,13508L,181616L,2769085L,47109136L,883639920L,18107148225L,402374973506L,9637795235498L,247545497301618L,6787859682565805L,197933312666622029L,6116627434424525916L,BigInteger.Parse("199695744998600583128"),BigInteger.Parse("6868763166262716491823"),BigInteger.Parse("248281343442023732418598") };
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
public class A132070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132070Inst Instance=new A132070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132071
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,7L,7L,4L,5L,9L,11L,9L,5L,6L,11L,16L,16L,11L,6L,7L,13L,22L,27L,22L,13L,7L,8L,15L,29L,43L,43L,29L,15L,8L,9L,17L,37L,65L,79L,65L,37L,17L,9L,10L,19L,46L,94L,136L,136L,94L,46L,19L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132071Inst : IEnumerable<long>
{
public static readonly long[] Value=A132071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132071.Bytes);
public long this[int i]=>Value[i];

public static A132071Inst Instance=new A132071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132120
{
public static readonly long[] Value={ 3L,6L,2L,3L,0L,6L,2L,2L,2L,3L,6L,6L,4L,9L,8L,0L,4L,8L,7L,9L,8L,6L,2L,6L,3L,7L,2L,2L,2L,4L,0L,9L,3L,4L,6L,1L,8L,1L,1L,1L,7L,9L,8L,5L,8L,5L,3L,4L,4L,2L,0L,9L,9L,9L,7L,5L,9L,9L,5L,1L,0L,1L,7L,0L,2L,7L,8L,4L,1L,8L,8L,6L,3L,0L,6L,8L,9L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132120Inst : IEnumerable<long>
{
public static readonly long[] Value=A132120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132120.Bytes);
public long this[int i]=>Value[i];

public static A132120Inst Instance=new A132120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132121
{
public static readonly long[] Value={ 0L,1L,2L,5L,11L,17L,14L,32L,50L,68L,30L,70L,110L,150L,190L,55L,130L,205L,280L,355L,430L,91L,217L,343L,469L,595L,721L,847L,140L,336L,532L,728L,924L,1120L,1316L,1512L,204L,492L,780L,1068L,1356L,1644L,1932L,2220L,2508L,285L,690L,1095L,1500L,1905L,2310L,2715L,3120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132121Inst : IEnumerable<long>
{
public static readonly long[] Value=A132121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132121.Bytes);
public long this[int i]=>Value[i];

public static A132121Inst Instance=new A132121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132122
{
public static readonly long[] Value={ 0L,3L,33L,164L,550L,1455L,3283L,6608L,12204L,21075L,34485L,53988L,81458L,119119L,169575L,235840L,321368L,430083L,566409L,735300L,942270L,1193423L,1495483L,1855824L,2282500L,2784275L,3370653L,4051908L,4839114L,5744175L,6779855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132122Inst : IEnumerable<long>
{
public static readonly long[] Value=A132122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132122.Bytes);
public long this[int i]=>Value[i];

public static A132122Inst Instance=new A132122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132123
{
public static readonly long[] Value={ 0L,11L,110L,469L,1356L,3135L,6266L,11305L,18904L,29811L,44870L,65021L,91300L,124839L,166866L,218705L,281776L,357595L,447774L,554021L,678140L,822031L,987690L,1177209L,1392776L,1636675L,1911286L,2219085L,2562644L,2944631L,3367810L,3835041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132123Inst : IEnumerable<long>
{
public static readonly long[] Value=A132123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132123.Bytes);
public long this[int i]=>Value[i];

public static A132123Inst Instance=new A132123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132124
{
public static readonly long[] Value={ 0L,3L,17L,50L,110L,205L,343L,532L,780L,1095L,1485L,1958L,2522L,3185L,3955L,4840L,5848L,6987L,8265L,9690L,11270L,13013L,14927L,17020L,19300L,21775L,24453L,27342L,30450L,33785L,37355L,41168L,45232L,49555L,54145L,59010L,64158L,69597L,75335L,81380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132124Inst : IEnumerable<long>
{
public static readonly long[] Value=A132124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132124.Bytes);
public long this[int i]=>Value[i];

public static A132124Inst Instance=new A132124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132125
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,7L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132125Inst : IEnumerable<long>
{
public static readonly long[] Value=A132125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132125.Bytes);
public long this[int i]=>Value[i];

public static A132125Inst Instance=new A132125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132126
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132126Inst : IEnumerable<long>
{
public static readonly long[] Value=A132126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132126.Bytes);
public long this[int i]=>Value[i];

public static A132126Inst Instance=new A132126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132127
{
public static readonly long[] Value={ 1L,6L,17L,37L,69L,116L,181L,267L,377L,514L,681L,881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132127Inst : IEnumerable<long>
{
public static readonly long[] Value=A132127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132127.Bytes);
public long this[int i]=>Value[i];

public static A132127Inst Instance=new A132127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132128
{
public static readonly long[] Value={ 1L,2L,4L,4L,5L,8L,7L,8L,9L,13L,11L,12L,13L,14L,19L,16L,17L,18L,19L,20L,26L,22L,23L,24L,25L,26L,27L,34L,29L,30L,31L,32L,33L,34L,35L,43L,37L,38L,39L,40L,41L,42L,43L,44L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132128Inst : IEnumerable<long>
{
public static readonly long[] Value=A132128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132128.Bytes);
public long this[int i]=>Value[i];

public static A132128Inst Instance=new A132128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132129
{
public static readonly BigInteger[] Value={ 2L,19L,19L,577L,7417L,114229L,2053313L,42373937L,987654103L,25678048763L,736867805209L,23136292864193L,789018236128391L,29043982525257901L,1147797409030815779L,BigInteger.Parse("48471109094902530293"),BigInteger.Parse("2178347851919531491093"),BigInteger.Parse("103805969587115219167613"),BigInteger.Parse("5228356786703601108008083") };
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
public class A132129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132129Inst Instance=new A132129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132130
{
public static readonly long[] Value={ 1L,6L,21L,62L,162L,378L,819L,1680L,3276L,6138L,11145L,19662L,33840L,57048L,94362L,153432L,245757L,388218L,605466L,933414L,1423614L,2149586L,3215844L,4769544L,7016572L,10243896L,14848809L,21378276L,30582360L,43484304L,61473438L,86428896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132130Inst : IEnumerable<long>
{
public static readonly long[] Value=A132130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132130.Bytes);
public long this[int i]=>Value[i];

public static A132130Inst Instance=new A132130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132131
{
public static readonly long[] Value={ 1L,13L,22L,24L,33L,35L,44L,46L,55L,57L,66L,68L,77L,79L,88L,90L,100L,102L,113L,124L,133L,143L,153L,163L,173L,183L,193L,203L,224L,235L,244L,254L,264L,274L,284L,294L,304L,335L,346L,355L,365L,375L,385L,395L,405L,446L,457L,466L,476L,486L,496L,506L,557L,568L,577L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132131Inst : IEnumerable<long>
{
public static readonly long[] Value=A132131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132131.Bytes);
public long this[int i]=>Value[i];

public static A132131Inst Instance=new A132131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132132
{
public static readonly long[] Value={ 12L,21L,23L,31L,34L,41L,45L,51L,56L,61L,67L,71L,78L,81L,89L,91L,101L,110L,121L,131L,141L,151L,161L,171L,181L,191L,201L,210L,231L,241L,251L,261L,271L,281L,291L,301L,310L,341L,351L,361L,371L,381L,391L,401L,410L,451L,461L,471L,481L,491L,501L,510L,561L,571L,581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132132Inst : IEnumerable<long>
{
public static readonly long[] Value=A132132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132132.Bytes);
public long this[int i]=>Value[i];

public static A132132Inst Instance=new A132132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132133
{
public static readonly long[] Value={ 9L,45L,270L,2104L,16941L,142245L,1226146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132133Inst : IEnumerable<long>
{
public static readonly long[] Value=A132133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132133.Bytes);
public long this[int i]=>Value[i];

public static A132133Inst Instance=new A132133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132134
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,11L,15L,18L,27L,29L,30L,32L,33L,35L,42L,45L,54L,60L,81L,83L,86L,87L,89L,92L,95L,96L,98L,99L,101L,104L,105L,107L,123L,126L,135L,141L,153L,162L,243L,245L,248L,249L,251L,252L,254L,257L,258L,260L,261L,263L,266L,267L,269L,275L,276L,278L,285L,287L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132134Inst : IEnumerable<long>
{
public static readonly long[] Value=A132134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132134.Bytes);
public long this[int i]=>Value[i];

public static A132134Inst Instance=new A132134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132135
{
public static readonly long[] Value={ 2L,3L,4L,10L,20L,51L,133L,359L,975L,2700L,7506L,20962L,58968L,166170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132135Inst : IEnumerable<long>
{
public static readonly long[] Value=A132135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132135.Bytes);
public long this[int i]=>Value[i];

public static A132135Inst Instance=new A132135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132168
{
public static readonly long[] Value={ 1L,20L,295L,3485L,33496L,247799L,1010905L,-7422100L,-238118825L,-3513857515L,-38530770320L,-329008652665L,-1926925302575L,-594574697500L,188633380315975L,3451130126965325L,42502627523897800L,406764806549554775L,2912899847916711625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132168Inst : IEnumerable<long>
{
public static readonly long[] Value=A132168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132168.Bytes);
public long this[int i]=>Value[i];

public static A132168Inst Instance=new A132168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132169
{
public static readonly long[] Value={ 2L,3L,6L,4L,8L,5L,12L,10L,6L,15L,12L,7L,20L,18L,14L,8L,24L,21L,16L,9L,30L,28L,24L,18L,10L,35L,32L,27L,20L,11L,42L,40L,36L,30L,22L,12L,48L,45L,40L,33L,24L,13L,56L,54L,50L,44L,36L,26L,14L,63L,60L,55L,48L,39L,28L,15L,72L,70L,66L,60L,52L,42L,30L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132169Inst : IEnumerable<long>
{
public static readonly long[] Value=A132169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132169.Bytes);
public long this[int i]=>Value[i];

public static A132169Inst Instance=new A132169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132170
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,29L,37L,47L,53L,97L,101L,107L,109L,127L,137L,149L,151L,157L,179L,181L,197L,257L,263L,269L,277L,293L,307L,313L,317L,337L,347L,349L,373L,389L,397L,457L,461L,487L,509L,541L,547L,557L,569L,571L,577L,587L,599L,607L,613L,641L,643L,647L,661L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132170Inst : IEnumerable<long>
{
public static readonly long[] Value=A132170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132170.Bytes);
public long this[int i]=>Value[i];

public static A132170Inst Instance=new A132170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132171
{
public static readonly long[] Value={ 1L,3L,3L,3L,9L,9L,9L,9L,9L,9L,9L,9L,9L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,27L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132171Inst : IEnumerable<long>
{
public static readonly long[] Value=A132171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132171.Bytes);
public long this[int i]=>Value[i];

public static A132171Inst Instance=new A132171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132172
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,6L,7L,7L,8L,8L,10L,9L,11L,10L,13L,10L,14L,12L,15L,13L,17L,13L,18L,14L,19L,15L,19L,16L,24L,16L,23L,19L,24L,16L,30L,17L,25L,21L,30L,16L,33L,22L,30L,20L,43L,15L,38L,20L,48L,10L,50L,13L,40L,16L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132172Inst : IEnumerable<long>
{
public static readonly long[] Value=A132172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132172.Bytes);
public long this[int i]=>Value[i];

public static A132172Inst Instance=new A132172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132173
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132173Inst : IEnumerable<long>
{
public static readonly long[] Value=A132173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132173.Bytes);
public long this[int i]=>Value[i];

public static A132173Inst Instance=new A132173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132174
{
public static readonly long[] Value={ 1L,5L,10L,21L,44L,92L,189L,385L,778L,1565L,3141L,6294L,12602L,25219L,50454L,100926L,201871L,403763L,807548L,1615119L,3230263L,6460552L,12921132L,25842293L,51684616L,103369264L,206738561L,413477157L,826954350L,1653908737L,3307817513L,6615635066L,13231270174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132174Inst : IEnumerable<long>
{
public static readonly long[] Value=A132174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132174.Bytes);
public long this[int i]=>Value[i];

public static A132174Inst Instance=new A132174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132175
{
public static readonly long[] Value={ 4L,9L,20L,43L,91L,188L,384L,777L,1564L,3140L,6293L,12601L,25218L,50453L,100925L,201870L,403762L,807547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132175Inst : IEnumerable<long>
{
public static readonly long[] Value=A132175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132175.Bytes);
public long this[int i]=>Value[i];

public static A132175Inst Instance=new A132175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132176
{
public static readonly long[] Value={ 1L,2L,6L,12L,24L,49L,98L,197L,394L,788L,1577L,3154L,6309L,12618L,25236L,50473L,100946L,201893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132176Inst : IEnumerable<long>
{
public static readonly long[] Value=A132176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132176.Bytes);
public long this[int i]=>Value[i];

public static A132176Inst Instance=new A132176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132177
{
public static readonly long[] Value={ 1L,5L,11L,23L,48L,97L,196L,393L,787L,1576L,3153L,6308L,12617L,25235L,50472L,100945L,201892L,403785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132177Inst : IEnumerable<long>
{
public static readonly long[] Value=A132177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132177.Bytes);
public long this[int i]=>Value[i];

public static A132177Inst Instance=new A132177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132178
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,2L,0L,1L,0L,2L,4L,4L,2L,0L,1L,6L,19L,16L,15L,2L,1L,6L,36L,84L,108L,90L,24L,12L,0L,44L,230L,542L,722L,602L,266L,98L,14L,2L,208L,1284L,3478L,5272L,5202L,3004L,1378L,264L,70L,0L,912L,6856L,21784L,39496L,46816L,35680L,20824L,6616L,2224L,184L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132178Inst : IEnumerable<long>
{
public static readonly long[] Value=A132178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132178.Bytes);
public long this[int i]=>Value[i];

public static A132178Inst Instance=new A132178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132179
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,-3L,4L,1L,-6L,5L,1L,-10L,11L,4L,-19L,17L,4L,-31L,31L,9L,-50L,46L,11L,-79L,77L,21L,-122L,112L,28L,-183L,173L,46L,-273L,249L,62L,-396L,370L,98L,-573L,521L,130L,-815L,751L,193L,-1149L,1041L,261L,-1599L,1461L,373L,-2214L,1998L,498L,-3031L,2750L,696L,-4125L,3708L,923L,-5567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132179Inst : IEnumerable<long>
{
public static readonly long[] Value=A132179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132179.Bytes);
public long this[int i]=>Value[i];

public static A132179Inst Instance=new A132179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132180
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,3L,12L,5L,21L,10L,36L,15L,60L,26L,96L,39L,150L,63L,228L,92L,342L,140L,504L,201L,732L,295L,1050L,415L,1488L,591L,2088L,818L,2901L,1140L,3996L,1554L,5460L,2126L,7404L,2861L,9972L,3855L,13344L,5126L,17748L,6816L,23472L,8970L,30876L,11793L,40413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132180Inst : IEnumerable<long>
{
public static readonly long[] Value=A132180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132180.Bytes);
public long this[int i]=>Value[i];

public static A132180Inst Instance=new A132180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132181
{
public static readonly long[] Value={ 1L,2L,6L,1L,28L,1L,1L,58L,1L,708L,1L,1L,2L,1L,2836L,1L,1L,22696L,1L,1L,1L,590122L,1L,12L,1L,1L,2L,1L,1180246L,1L,9441976L,1L,1L,1L,169955586L,1L,2L,1L,2L,1L,2719289392L,1L,1L,1L,1L,5438578786L,1L,32631472722L,1L,2L,1L,391577672676L,1L,1L,2L,1L,1566310690708L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132181Inst : IEnumerable<long>
{
public static readonly long[] Value=A132181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132181.Bytes);
public long this[int i]=>Value[i];

public static A132181Inst Instance=new A132181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132182
{
public static readonly BigInteger[] Value={ 1L,2L,15L,128L,1397L,19047L,311269L,5931641L,129140163L,3162277660L,86024705429L,2573856496961L,84002440529229L,2969808744337971L,113063716323402969L,4611686018427387904L,BigInteger.Parse("200635233971822464589"),BigInteger.Parse("9274037321791771775305") };
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
public class A132182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132182Inst Instance=new A132182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132183
{
public static readonly long[] Value={ 2L,3L,5L,10L,27L,119L,1173L,44315L,16175190L,284432730176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132183Inst : IEnumerable<long>
{
public static readonly long[] Value=A132183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132183.Bytes);
public long this[int i]=>Value[i];

public static A132183Inst Instance=new A132183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132280
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,9L,6L,1L,21L,16L,3L,51L,45L,12L,1L,127L,126L,40L,4L,323L,357L,135L,20L,1L,835L,1016L,441L,80L,5L,2188L,2907L,1428L,315L,30L,1L,5798L,8350L,4572L,1176L,140L,6L,15511L,24068L,14535L,4284L,630L,42L,1L,41835L,69576L,45925L,15240L,2646L,224L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132280Inst : IEnumerable<long>
{
public static readonly long[] Value=A132280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132280.Bytes);
public long this[int i]=>Value[i];

public static A132280Inst Instance=new A132280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132281
{
public static readonly long[] Value={ 0L,1L,3L,5L,29L,71L,83L,113L,173L,263L,311L,419L,431L,491L,503L,509L,683L,701L,761L,773L,839L,911L,953L,1031L,1091L,1103L,1151L,1193L,1259L,1283L,1373L,1451L,1523L,1583L,1601L,1733L,1823L,1889L,1931L,2099L,2153L,2213L,2273L,2339L,2351L,2441L,2531L,2543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132281Inst : IEnumerable<long>
{
public static readonly long[] Value=A132281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132281.Bytes);
public long this[int i]=>Value[i];

public static A132281Inst Instance=new A132281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132282
{
public static readonly long[] Value={ 2L,3L,29L,127L,24391L,357913L,571789L,1442899L,5177719L,18191449L,30080233L,73560061L,80062993L,118370773L,127263529L,131872231L,318611989L,344472103L,440711083L,461889919L,590589721L,756058033L,865523179L,1095912793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132282Inst : IEnumerable<long>
{
public static readonly long[] Value=A132282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132282.Bytes);
public long this[int i]=>Value[i];

public static A132282Inst Instance=new A132282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132283
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,3L,2L,4L,1L,3L,5L,2L,4L,1L,6L,3L,5L,2L,4L,1L,6L,3L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,6L,3L,8L,5L,2L,7L,4L,9L,1L,6L,3L,8L,5L,10L,2L,7L,4L,9L,1L,6L,11L,3L,8L,5L,10L,2L,7L,4L,9L,1L,6L,11L,3L,8L,5L,10L,2L,7L,12L,4L,9L,1L,6L,11L,3L,8L,13L,5L,10L,2L,7L,12L,4L,9L,1L,14L,6L,11L,3L,8L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132283Inst : IEnumerable<long>
{
public static readonly long[] Value=A132283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132283.Bytes);
public long this[int i]=>Value[i];

public static A132283Inst Instance=new A132283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132284
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,9L,8L,10L,11L,14L,12L,15L,13L,16L,20L,18L,21L,19L,17L,22L,26L,24L,28L,25L,23L,27L,29L,34L,31L,36L,33L,30L,35L,32L,37L,42L,39L,44L,41L,38L,43L,40L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132284Inst : IEnumerable<long>
{
public static readonly long[] Value=A132284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132284.Bytes);
public long this[int i]=>Value[i];

public static A132284Inst Instance=new A132284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132285
{
public static readonly long[] Value={ 11L,33L,55L,77L,99L,1001L,1111L,1221L,1331L,1441L,1551L,1661L,1771L,1881L,1991L,3003L,3113L,3223L,3333L,3443L,3553L,3663L,3773L,3883L,3993L,5005L,5115L,5225L,5335L,5445L,5555L,5665L,5775L,5885L,5995L,7007L,7117L,7227L,7337L,7447L,7557L,7667L,7777L,7887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132285Inst : IEnumerable<long>
{
public static readonly long[] Value=A132285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132285.Bytes);
public long this[int i]=>Value[i];

public static A132285Inst Instance=new A132285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132286
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,91L,101L,111L,121L,131L,141L,151L,161L,171L,181L,273L,283L,293L,303L,313L,323L,333L,343L,353L,363L,455L,465L,475L,485L,495L,505L,515L,525L,535L,545L,637L,647L,657L,667L,677L,687L,697L,707L,717L,727L,819L,829L,839L,849L,859L,869L,879L,889L,899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132286Inst : IEnumerable<long>
{
public static readonly long[] Value=A132286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132286.Bytes);
public long this[int i]=>Value[i];

public static A132286Inst Instance=new A132286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132287
{
public static readonly long[] Value={ 3L,5L,7L,101L,131L,151L,181L,283L,293L,313L,353L,647L,677L,727L,829L,839L,859L,9091L,9391L,9491L,9791L,10301L,10501L,10601L,11311L,11411L,11821L,12421L,12721L,13331L,13841L,14341L,14551L,14851L,14951L,15451L,15461L,15661L,15761L,16061L,16361L,16871L,17581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132287Inst : IEnumerable<long>
{
public static readonly long[] Value=A132287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132287.Bytes);
public long this[int i]=>Value[i];

public static A132287Inst Instance=new A132287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132288
{
public static readonly long[] Value={ 33L,55L,77L,1111L,1441L,1661L,1991L,3113L,3223L,3443L,3883L,7117L,7447L,7997L,9119L,9229L,9449L,100001L,103301L,104401L,107701L,113311L,115511L,116611L,124421L,125521L,130031L,136631L,139931L,146641L,152251L,157751L,160061L,163361L,164461L,169961L,170071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132288Inst : IEnumerable<long>
{
public static readonly long[] Value=A132288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132288.Bytes);
public long this[int i]=>Value[i];

public static A132288Inst Instance=new A132288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132289
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,6L,9L,12L,12L,15L,19L,25L,34L,46L,58L,58L,70L,85L,104L,129L,163L,209L,267L,325L,325L,383L,453L,538L,642L,771L,934L,1143L,1410L,1735L,2060L,2060L,2385L,2768L,3221L,3759L,4401L,5172L,6106L,7249L,8659L,10394L,12454L,14514L,14514L,16574L,18959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132289Inst : IEnumerable<long>
{
public static readonly long[] Value=A132289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132289.Bytes);
public long this[int i]=>Value[i];

public static A132289Inst Instance=new A132289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132290
{
public static readonly long[] Value={ 1L,2L,6L,25L,129L,771L,5172L,38280L,308987L,2695586L,25231269L,251869681L,2667876382L,29856632341L,351717286357L,4347357161694L,56222019376378L,758836553993985L,10665452531786380L,155785594704483911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132290Inst : IEnumerable<long>
{
public static readonly long[] Value=A132290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132290.Bytes);
public long this[int i]=>Value[i];

public static A132290Inst Instance=new A132290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132291
{
public static readonly long[] Value={ 12132003L,23121300L,30023121L,31213200L,1214230043L,1312432004L,2342131400L,2412134003L,3004312142L,3400324121L,4002342131L,4131243200L,1213267345006475L,1213275364005746L,1214267540036573L,1214273645300765L,1214275640035763L,1215247365430076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132291Inst : IEnumerable<long>
{
public static readonly long[] Value=A132291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132291.Bytes);
public long this[int i]=>Value[i];

public static A132291Inst Instance=new A132291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132292
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132292Inst : IEnumerable<long>
{
public static readonly long[] Value=A132292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132292.Bytes);
public long this[int i]=>Value[i];

public static A132292Inst Instance=new A132292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132293
{
public static readonly long[] Value={ 1L,4L,3L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132293Inst : IEnumerable<long>
{
public static readonly long[] Value=A132293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132293.Bytes);
public long this[int i]=>Value[i];

public static A132293Inst Instance=new A132293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132294
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-1L,-1L,1L,3L,9L,77L,5917L,35010803L,1225756326698815L,BigInteger.Parse("1502478572442172090395687387505"),BigInteger.Parse("2257441860647867366107450759398738024116019978304775668415407") };
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
public class A132294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132294Inst Instance=new A132294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132295
{
public static readonly long[] Value={ 0L,2L,5L,5L,10L,16L,23L,31L,31L,41L,52L,64L,77L,91L,106L,106L,123L,141L,160L,180L,201L,223L,246L,270L,270L,296L,323L,351L,380L,410L,441L,473L,506L,540L,575L,575L,612L,650L,689L,729L,770L,812L,855L,899L,944L,990L,1037L,1085L,1085L,1135L,1186L,1238L,1291L,1345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132295Inst : IEnumerable<long>
{
public static readonly long[] Value=A132295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132295.Bytes);
public long this[int i]=>Value[i];

public static A132295Inst Instance=new A132295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132328
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,8L,8L,8L,10L,10L,10L,12L,12L,12L,21L,21L,21L,24L,24L,24L,27L,27L,27L,80L,80L,80L,88L,88L,88L,96L,96L,96L,130L,130L,130L,140L,140L,140L,150L,150L,150L,192L,192L,192L,204L,204L,204L,216L,216L,216L,399L,399L,399L,420L,420L,420L,441L,441L,441L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132328Inst : IEnumerable<long>
{
public static readonly long[] Value=A132328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132328.Bytes);
public long this[int i]=>Value[i];

public static A132328Inst Instance=new A132328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132329
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132329Inst : IEnumerable<long>
{
public static readonly long[] Value=A132329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132329.Bytes);
public long this[int i]=>Value[i];

public static A132329Inst Instance=new A132329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132330
{
public static readonly long[] Value={ 1L,1L,0L,3L,0L,3L,9L,1L,18L,9L,36L,45L,57L,90L,114L,351L,165L,558L,738L,1044L,1791L,1908L,3915L,4926L,8568L,8553L,17217L,26271L,30474L,50967L,68526L,113319L,144324L,219195L,299359L,473454L,665424L,860733L,1396350L,1895913L,2762550L,3790935L,5695974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132330Inst : IEnumerable<long>
{
public static readonly long[] Value=A132330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132330.Bytes);
public long this[int i]=>Value[i];

public static A132330Inst Instance=new A132330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132331
{
public static readonly long[] Value={ 1L,3L,3L,10L,18L,18L,72L,93L,141L,381L,423L,990L,1701L,2304L,4998L,7275L,12960L,21195L,34812L,58860L,90576L,163603L,239445L,413964L,669096L,1017918L,1768608L,2639988L,4383036L,6880680L,10911267L,17411292L,26930250L,43797420L,66324909L,107180772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132331Inst : IEnumerable<long>
{
public static readonly long[] Value=A132331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132331.Bytes);
public long this[int i]=>Value[i];

public static A132331Inst Instance=new A132331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132332
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,10L,23L,44L,93L,193L,398L,828L,1711L,3548L,7352L,15238L,31569L,65414L,135557L,280856L,581970L,1205860L,2498520L,5177008L,10726715L,22225674L,46051484L,95417966L,197704676L,409640915L,848768686L,1758633069L,3643854113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132332Inst : IEnumerable<long>
{
public static readonly long[] Value=A132332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132332.Bytes);
public long this[int i]=>Value[i];

public static A132332Inst Instance=new A132332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132333
{
public static readonly long[] Value={ 1L,2L,3L,8L,17L,36L,85L,184L,405L,898L,1962L,4296L,9371L,20376L,44244L,95844L,207217L,447264L,963835L,2073900L,4456374L,9563620L,20499344L,43891176L,93877423L,200594560L,428231448L,913400192L,1946652868L,4145533218L,8821743618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132333Inst : IEnumerable<long>
{
public static readonly long[] Value=A132333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132333.Bytes);
public long this[int i]=>Value[i];

public static A132333Inst Instance=new A132333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132334
{
public static readonly long[] Value={ 1L,1L,1L,4L,7L,16L,43L,89L,216L,502L,1154L,2715L,6268L,14583L,33936L,78787L,183141L,425547L,988765L,2297533L,5338321L,12403697L,28819646L,66962219L,155583912L,361492693L,839915741L,1951499287L,4534218339L,10535031491L,24477592379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132334Inst : IEnumerable<long>
{
public static readonly long[] Value=A132334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132334.Bytes);
public long this[int i]=>Value[i];

public static A132334Inst Instance=new A132334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132335
{
public static readonly long[] Value={ 1L,3L,6L,19L,51L,129L,361L,939L,2433L,6376L,16362L,41970L,107206L,271881L,687999L,1733695L,4352877L,10899381L,27208492L,67745649L,168275466L,417023747L,1031321451L,2545496316L,6271166097L,15423190770L,37869769518L,92842013185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132335Inst : IEnumerable<long>
{
public static readonly long[] Value=A132335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132335.Bytes);
public long this[int i]=>Value[i];

public static A132335Inst Instance=new A132335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132336
{
public static readonly long[] Value={ 0L,2L,5L,9L,14L,20L,27L,35L,44L,54L,65L,77L,90L,104L,119L,135L,152L,170L,189L,209L,230L,252L,275L,299L,324L,350L,377L,405L,434L,464L,495L,495L,528L,562L,597L,633L,670L,708L,747L,787L,828L,870L,913L,957L,1002L,1048L,1095L,1143L,1192L,1242L,1293L,1345L,1398L,1452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132336Inst : IEnumerable<long>
{
public static readonly long[] Value=A132336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132336.Bytes);
public long this[int i]=>Value[i];

public static A132336Inst Instance=new A132336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132337
{
public static readonly long[] Value={ 0L,2L,5L,9L,14L,20L,27L,35L,44L,54L,65L,77L,90L,104L,119L,135L,152L,170L,189L,209L,230L,252L,275L,299L,324L,350L,377L,405L,434L,464L,495L,527L,560L,594L,629L,665L,702L,740L,779L,819L,860L,902L,945L,989L,1034L,1080L,1127L,1175L,1224L,1274L,1325L,1377L,1430L,1484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132337Inst : IEnumerable<long>
{
public static readonly long[] Value=A132337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132337.Bytes);
public long this[int i]=>Value[i];

public static A132337Inst Instance=new A132337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132338
{
public static readonly long[] Value={ 3L,8L,1L,9L,6L,6L,0L,1L,1L,2L,5L,0L,1L,0L,5L,1L,5L,1L,7L,9L,5L,4L,1L,3L,1L,6L,5L,6L,3L,4L,3L,6L,1L,8L,8L,2L,2L,7L,9L,6L,9L,0L,8L,2L,0L,1L,9L,4L,2L,3L,7L,1L,3L,7L,8L,6L,4L,5L,5L,1L,3L,7L,7L,2L,9L,4L,7L,3L,9L,5L,3L,7L,1L,8L,1L,0L,9L,7L,5L,5L,0L,2L,9L,2L,7L,9L,2L,7L,9L,5L,8L,1L,0L,6L,0L,8L,8L,6L,2L,5L,1L,5L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132338Inst : IEnumerable<long>
{
public static readonly long[] Value=A132338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132338.Bytes);
public long this[int i]=>Value[i];

public static A132338Inst Instance=new A132338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132339
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,2L,0L,0L,-2L,-2L,0L,0L,2L,10L,2L,0L,0L,-2L,-28L,-28L,-2L,0L,0L,2L,60L,168L,60L,2L,0L,0L,-2L,-110L,-660L,-660L,-110L,-2L,0L,0L,2L,182L,2002L,4290L,2002L,182L,2L,0L,0L,-2L,-280L,-5096L,-20020L,-20020L,-5096L,-280L,-2L,0L,0L,2L,408L,11424L,74256L,136136L,74256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132339Inst : IEnumerable<long>
{
public static readonly long[] Value=A132339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132339.Bytes);
public long this[int i]=>Value[i];

public static A132339Inst Instance=new A132339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132340
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,10L,9L,8L,7L,14L,13L,12L,11L,22L,21L,20L,19L,18L,17L,16L,15L,30L,29L,28L,27L,26L,25L,24L,23L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,94L,93L,92L,91L,90L,89L,88L,87L,86L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132340Inst : IEnumerable<long>
{
public static readonly long[] Value=A132340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132340.Bytes);
public long this[int i]=>Value[i];

public static A132340Inst Instance=new A132340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132341
{
public static readonly BigInteger[] Value={ 1L,2L,10L,168L,4290L,136136L,4938024L,196125600L,8318177010L,370784099400L,17184867259560L,821870841735840L,40334204896057800L,2022686389717666848L,BigInteger.Parse("103312949950998743200"),BigInteger.Parse("5360873347802169267840"),BigInteger.Parse("282015983963437605168210") };
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
public class A132341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132341Inst Instance=new A132341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132342
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,-1L,1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132342Inst : IEnumerable<long>
{
public static readonly long[] Value=A132342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132342.Bytes);
public long this[int i]=>Value[i];

public static A132342Inst Instance=new A132342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132343
{
public static readonly long[] Value={ 1L,0L,-2L,0L,1L,0L,1L,-1L,-10L,-30L,-67L,-138L,-291L,-642L,-1446L,-3250L,-7244L,-16065L,-35601L,-78985L,-175416L,-389695L,-865609L,-1922362L,-4268854L,-9479595L,-21051458L,-46750171L,-103821058L,-230560902L,-512016658L,-1137056340L,-2525108865L,-5607619809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132343Inst : IEnumerable<long>
{
public static readonly long[] Value=A132343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132343.Bytes);
public long this[int i]=>Value[i];

public static A132343Inst Instance=new A132343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132488
{
public static readonly BigInteger[] Value={ 4L,26L,1035L,1310496L,2594200953135L,BigInteger.Parse("17106515987265424535833667"),BigInteger.Parse("8248865873823279748817696266000461593761373712215106") };
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
public class A132488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132488Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132488.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132488Inst Instance=new A132488Inst();

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