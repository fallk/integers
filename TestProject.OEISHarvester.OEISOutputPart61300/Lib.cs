using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A072621
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,11L,8L,9L,10L,7L,12L,13L,14L,15L,29L,16L,34L,38L,20L,25L,22L,23L,24L,31L,26L,27L,28L,17L,19L,21L,32L,39L,18L,35L,36L,37L,30L,33L,40L,41L,42L,43L,85L,44L,99L,113L,45L,47L,46L,104L,108L,86L,118L,122L,127L,57L,71L,90L,76L,80L,62L,67L,64L,65L,66L,73L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072621Inst : IEnumerable<long>
{
public static readonly long[] Value=A072621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072621.Bytes);
public long this[int i]=>Value[i];

public static A072621Inst Instance=new A072621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072622
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,11L,8L,9L,10L,7L,12L,13L,14L,15L,17L,29L,34L,30L,20L,31L,22L,23L,24L,21L,26L,27L,28L,16L,38L,25L,32L,39L,18L,35L,36L,37L,19L,33L,40L,41L,42L,43L,45L,48L,50L,49L,85L,113L,99L,104L,100L,86L,108L,88L,89L,57L,71L,90L,101L,91L,62L,92L,64L,65L,66L,63L,68L,69L,70L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072622Inst : IEnumerable<long>
{
public static readonly long[] Value=A072622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072622.Bytes);
public long this[int i]=>Value[i];

public static A072622Inst Instance=new A072622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072623
{
public static readonly long[] Value={ 4L,5L,6L,11L,19L,25L,34L,36L,75L,82L,87L,90L,94L,237L,604L,609L,614L,1583L,1592L,10466L,10467L,10498L,10504L,10505L,70501L,70511L,180227L,180294L,180358L,180443L,180447L,466078L,8103422L,21058343L,21058649L,143052872L,143052877L,143053068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072623Inst : IEnumerable<long>
{
public static readonly long[] Value=A072623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072623.Bytes);
public long this[int i]=>Value[i];

public static A072623Inst Instance=new A072623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072624
{
public static readonly long[] Value={ 0L,3L,5L,5L,22L,7L,31L,55L,14L,41L,56L,107L,164L,17L,77L,83L,145L,199L,271L,341L,437L,73L,100L,179L,262L,319L,416L,519L,594L,697L,846L,993L,25L,93L,131L,259L,369L,497L,575L,699L,879L,989L,1085L,1259L,1409L,1533L,1799L,1961L,2183L,2307L,2519L,23L,188L,329L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072624Inst : IEnumerable<long>
{
public static readonly long[] Value=A072624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072624.Bytes);
public long this[int i]=>Value[i];

public static A072624Inst Instance=new A072624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072625
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,3L,1L,3L,1L,1L,3L,3L,1L,4L,1L,2L,1L,3L,4L,3L,4L,2L,1L,3L,2L,4L,3L,2L,1L,2L,4L,5L,1L,1L,1L,5L,5L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,5L,5L,1L,5L,5L,5L,5L,1L,1L,5L,1L,5L,1L,5L,1L,5L,1L,1L,5L,1L,5L,5L,1L,1L,1L,5L,5L,1L,5L,3L,6L,1L,4L,6L,5L,2L,1L,2L,6L,1L,5L,3L,4L,1L,2L,6L,5L,3L,5L,2L,1L,4L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072625Inst : IEnumerable<long>
{
public static readonly long[] Value=A072625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072625.Bytes);
public long this[int i]=>Value[i];

public static A072625Inst Instance=new A072625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072626
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072626Inst : IEnumerable<long>
{
public static readonly long[] Value=A072626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072626.Bytes);
public long this[int i]=>Value[i];

public static A072626Inst Instance=new A072626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072627
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,0L,2L,1L,0L,0L,4L,0L,1L,1L,2L,0L,3L,0L,2L,1L,0L,0L,6L,0L,0L,1L,2L,0L,3L,0L,3L,1L,0L,0L,5L,0L,1L,1L,3L,0L,4L,0L,2L,1L,0L,0L,7L,0L,0L,1L,1L,0L,4L,0L,3L,1L,0L,0L,7L,0L,1L,1L,3L,0L,2L,0L,2L,1L,1L,0L,8L,0L,1L,1L,2L,0L,2L,0L,4L,1L,0L,0L,7L,0L,0L,1L,3L,0L,5L,0L,1L,1L,0L,0L,8L,0L,2L,1L,2L,0L,3L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072627Inst : IEnumerable<long>
{
public static readonly long[] Value=A072627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072627.Bytes);
public long this[int i]=>Value[i];

public static A072627Inst Instance=new A072627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072644
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,4L,4L,3L,4L,3L,4L,5L,5L,5L,5L,4L,4L,5L,5L,4L,5L,5L,6L,6L,6L,6L,6L,6L,7L,6L,7L,4L,5L,4L,5L,6L,6L,6L,6L,4L,5L,5L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,7L,8L,7L,7L,8L,8L,7L,8L,8L,9L,5L,4L,6L,5L,5L,4L,6L,5L,7L,6L,7L,6L,7L,6L,7L,6L,5L,6L,6L,7L,6L,6L,7L,7L,7L,8L,7L,8L,8L,8L,8L,8L,8L,7L,8L,7L,8L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072644Inst : IEnumerable<long>
{
public static readonly long[] Value=A072644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072644.Bytes);
public long this[int i]=>Value[i];

public static A072644Inst Instance=new A072644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072645
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,4L,3L,3L,5L,3L,4L,4L,4L,7L,4L,4L,5L,3L,6L,5L,5L,9L,4L,5L,5L,5L,6L,4L,5L,7L,6L,6L,6L,5L,10L,5L,4L,5L,4L,5L,6L,6L,6L,4L,5L,6L,5L,8L,7L,7L,7L,6L,8L,6L,7L,11L,5L,6L,5L,6L,6L,5L,4L,6L,7L,6L,6L,6L,8L,5L,6L,7L,5L,7L,6L,6L,10L,8L,7L,7L,7L,7L,7L,8L,8L,7L,7L,8L,6L,12L,6L,5L,6L,4L,7L,7L,7L,8L,5L,6L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072645Inst : IEnumerable<long>
{
public static readonly long[] Value=A072645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072645.Bytes);
public long this[int i]=>Value[i];

public static A072645Inst Instance=new A072645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072646
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,3L,9L,17L,15L,27L,14L,36L,62L,12L,5L,10L,38L,43L,11L,22L,93L,161L,150L,159L,91L,993L,1624L,28L,35L,61L,384L,413L,69L,235L,2591L,4243L,16L,46L,25L,37L,39L,19L,20L,24L,242L,415L,44L,237L,1606L,2627L,33L,8L,23L,72L,56L,58L,98L,1004L,1080L,100L,111L,614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072646Inst : IEnumerable<long>
{
public static readonly long[] Value=A072646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072646.Bytes);
public long this[int i]=>Value[i];

public static A072646Inst Instance=new A072646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072647
{
public static readonly long[] Value={ 0L,1L,2L,6L,3L,15L,4L,5L,52L,7L,16L,19L,14L,466L,11L,9L,37L,8L,112L,42L,43L,5095L,20L,53L,44L,39L,127L,10L,28L,481L,123L,121L,149L,51L,17231L,29L,12L,40L,17L,41L,154L,155L,153L,18L,47L,156L,38L,1512L,477L,475L,385L,151L,1234L,122L,376L,69829L,55L,159L,56L,113L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072647Inst : IEnumerable<long>
{
public static readonly long[] Value=A072647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072647.Bytes);
public long this[int i]=>Value[i];

public static A072647Inst Instance=new A072647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072648
{
public static readonly long[] Value={ 1L,3L,3L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072648Inst : IEnumerable<long>
{
public static readonly long[] Value=A072648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072648.Bytes);
public long this[int i]=>Value[i];

public static A072648Inst Instance=new A072648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072649
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072649Inst : IEnumerable<long>
{
public static readonly long[] Value=A072649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072649.Bytes);
public long this[int i]=>Value[i];

public static A072649Inst Instance=new A072649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072650
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,3L,2L,3L,8L,5L,6L,5L,4L,3L,6L,3L,16L,9L,10L,9L,12L,7L,10L,7L,8L,5L,6L,5L,12L,7L,6L,7L,32L,17L,18L,17L,20L,11L,18L,11L,24L,13L,14L,13L,20L,11L,14L,11L,16L,9L,10L,9L,12L,7L,10L,7L,24L,13L,14L,13L,12L,7L,14L,7L,64L,33L,34L,33L,36L,19L,34L,19L,40L,21L,22L,21L,36L,19L,22L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072650Inst : IEnumerable<long>
{
public static readonly long[] Value=A072650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072650.Bytes);
public long this[int i]=>Value[i];

public static A072650Inst Instance=new A072650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072651
{
public static readonly BigInteger[] Value={ 1L,1L,4L,1L,16L,27L,1L,0L,0L,16L,1L,65536L,7625597484987L,256L,3125L,1L,0L,0L,0L,0L,46656L,1L,0L,0L,4294967296L,0L,BigInteger.Parse("10314424798490535546171949056"),823543L,1L,0L,0L,0L,0L };
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
public class A072651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072651Inst Instance=new A072651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072652
{
public static readonly long[] Value={ 4L,16L,16L,27L,64L,256L,256L,729L,1024L,3125L,4096L,4096L,16384L,19683L,46656L,65536L,65536L,65536L,262144L,531441L,823543L,1048576L,1048576L,4194304L,9765625L,14348907L,16777216L,16777216L,16777216L,67108864L,268435456L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072652Inst : IEnumerable<long>
{
public static readonly long[] Value=A072652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072652.Bytes);
public long this[int i]=>Value[i];

public static A072652Inst Instance=new A072652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072653
{
public static readonly long[] Value={ 1L,4L,16L,27L,64L,256L,729L,1024L,3125L,4096L,16384L,19683L,46656L,65536L,262144L,531441L,823543L,1048576L,4194304L,9765625L,14348907L,16777216L,67108864L,268435456L,387420489L,1073741824L,2176782336L,4294967296L,10000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072653Inst : IEnumerable<long>
{
public static readonly long[] Value=A072653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072653.Bytes);
public long this[int i]=>Value[i];

public static A072653Inst Instance=new A072653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072654
{
public static readonly BigInteger[] Value={ 0L,1L,4L,17L,161L,11107L,39099276L,308061560269405L,BigInteger.Parse("11825896447872143037989337832"),BigInteger.Parse("10770594215935749279482183269315609406974195761679603097") };
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
public class A072654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072654Inst Instance=new A072654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072655
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,14L,26L,49L,94L,183L,362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072655Inst : IEnumerable<long>
{
public static readonly long[] Value=A072655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072655.Bytes);
public long this[int i]=>Value[i];

public static A072655Inst Instance=new A072655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072656
{
public static readonly long[] Value={ 0L,1L,3L,2L,11L,6L,5L,7L,4L,100L,27L,24L,45L,14L,18L,10L,13L,62L,17L,8L,15L,28L,9L,1988L,477L,179L,1100L,116L,150L,61L,113L,2090L,147L,35L,189L,302L,58L,162L,44L,39L,73L,23L,34L,20L,102L,1229L,295L,29L,111L,680L,72L,21L,12L,26L,93L,38L,47L,70L,1292L,91L,16L,22L,117L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072656Inst : IEnumerable<long>
{
public static readonly long[] Value=A072656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072656.Bytes);
public long this[int i]=>Value[i];

public static A072656Inst Instance=new A072656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072657
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,5L,7L,19L,22L,15L,4L,52L,16L,13L,20L,60L,18L,14L,178L,43L,51L,61L,41L,11L,153L,53L,10L,21L,47L,555L,155L,177L,136L,42L,33L,64L,179L,55L,39L,557L,125L,151L,181L,38L,12L,150L,56L,1799L,479L,553L,417L,154L,552L,164L,135L,192L,117L,36L,471L,191L,29L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072657Inst : IEnumerable<long>
{
public static readonly long[] Value=A072657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072657.Bytes);
public long this[int i]=>Value[i];

public static A072657Inst Instance=new A072657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072658
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,11L,9L,28L,15L,17L,62L,8L,13L,10L,14L,45L,18L,24L,27L,100L,36L,187L,117L,91L,1292L,22L,70L,38L,72L,680L,93L,111L,295L,1229L,16L,47L,26L,29L,102L,12L,20L,23L,58L,302L,73L,189L,147L,2090L,21L,34L,39L,35L,113L,44L,61L,116L,1100L,162L,150L,179L,477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072658Inst : IEnumerable<long>
{
public static readonly long[] Value=A072658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072658.Bytes);
public long this[int i]=>Value[i];

public static A072658Inst Instance=new A072658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072659
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,14L,9L,16L,8L,42L,15L,17L,11L,37L,12L,19L,121L,43L,51L,28L,44L,20L,126L,39L,21L,10L,40L,385L,123L,149L,124L,52L,54L,23L,112L,30L,53L,376L,127L,154L,84L,56L,18L,163L,38L,1234L,387L,475L,388L,151L,503L,122L,152L,79L,156L,45L,480L,107L,57L,13L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072659Inst : IEnumerable<long>
{
public static readonly long[] Value=A072659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072659.Bytes);
public long this[int i]=>Value[i];

public static A072659Inst Instance=new A072659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072852
{
public static readonly long[] Value={ 1L,2L,6L,18L,54L,162L,454L,1267L,3613L,10344L,29572L,84436L,240868L,686884L,1959636L,5592181L,15957717L,45533682L,129922090L,370708166L,1057755082L,3018154342L,8611878218L,24572725639L,70114579881L,200061418144L,570845362600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072852Inst : IEnumerable<long>
{
public static readonly long[] Value=A072852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072852.Bytes);
public long this[int i]=>Value[i];

public static A072852Inst Instance=new A072852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072853
{
public static readonly long[] Value={ 1L,2L,6L,18L,54L,162L,486L,1394L,3991L,11593L,33772L,98320L,286072L,831952L,2418664L,7030816L,20441944L,59441521L,172843609L,502580846L,1461344622L,4249102850L,12354982862L,35924300898L,104456501102L,303726483778L,883140022543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072853Inst : IEnumerable<long>
{
public static readonly long[] Value=A072853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072853.Bytes);
public long this[int i]=>Value[i];

public static A072853Inst Instance=new A072853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072854
{
public static readonly long[] Value={ 1L,2L,6L,24L,96L,330L,1066L,3451L,11581L,39264L,132784L,446460L,1497108L,5023696L,16878488L,56739141L,190697893L,640763258L,2152824662L,7233281108L,24304468132L,81666680202L,274410023170L,922040339607L,3098121457769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072854Inst : IEnumerable<long>
{
public static readonly long[] Value=A072854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072854.Bytes);
public long this[int i]=>Value[i];

public static A072854Inst Instance=new A072854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072855
{
public static readonly long[] Value={ 1L,2L,6L,24L,96L,384L,1374L,4718L,16275L,57749L,206756L,739780L,2637348L,9378840L,33318804L,118439044L,421340612L,1499388117L,5335199213L,18980987054L,67522942850L,240204885524L,854523535096L,3040023558788L,10815153542594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072855Inst : IEnumerable<long>
{
public static readonly long[] Value=A072855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072855.Bytes);
public long this[int i]=>Value[i];

public static A072855Inst Instance=new A072855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072856
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,504L,1902L,6902L,25231L,95401L,365116L,1396948L,5316192L,20135712L,76227216L,288878956L,1095937420L,4159450913L,15783649241L,59878012558L,227128287882L,861543171080L,3268198646496L,12398132725784L,47033439463906L,178423731589482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072856Inst : IEnumerable<long>
{
public static readonly long[] Value=A072856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072856.Bytes);
public long this[int i]=>Value[i];

public static A072856Inst Instance=new A072856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072857
{
public static readonly long[] Value={ 1L,2L,13L,37L,107L,113L,137L,1013L,1037L,1079L,1237L,1367L,1379L,10079L,10123L,10136L,10139L,10237L,10279L,10367L,10379L,12379L,13679L,100279L,100379L,101237L,102347L,102379L,103679L,123479L,1001237L,1002347L,1002379L,1003679L,1012349L,1012379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072857Inst : IEnumerable<long>
{
public static readonly long[] Value=A072857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072857.Bytes);
public long this[int i]=>Value[i];

public static A072857Inst Instance=new A072857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072858
{
public static readonly long[] Value={ 2L,3L,5L,17L,101L,163L,257L,577L,883L,1297L,1801L,3137L,3529L,5477L,7057L,7351L,8929L,9397L,11831L,12101L,13457L,13553L,14401L,15361L,15377L,15973L,19841L,20809L,21401L,21601L,23549L,24337L,25601L,29401L,30977L,33301L,33751L,33857L,38237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072858Inst : IEnumerable<long>
{
public static readonly long[] Value=A072858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072858.Bytes);
public long this[int i]=>Value[i];

public static A072858Inst Instance=new A072858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072859
{
public static readonly long[] Value={ 11L,37L,41L,53L,79L,83L,107L,173L,227L,239L,271L,317L,347L,359L,467L,479L,563L,587L,643L,719L,733L,773L,797L,839L,907L,1031L,1187L,1231L,1283L,1307L,1319L,1439L,1493L,1523L,1627L,1637L,1879L,1907L,1987L,2027L,2039L,2467L,2477L,2677L,2791L,2837L,2879L,2963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072859Inst : IEnumerable<long>
{
public static readonly long[] Value=A072859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072859.Bytes);
public long this[int i]=>Value[i];

public static A072859Inst Instance=new A072859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072860
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,3L,1L,9L,1L,1L,3L,3L,1L,3L,1L,1L,1L,3L,3L,1L,1L,1L,1L,1L,3L,1L,1L,1L,27L,1L,3L,1L,1L,1L,1L,3L,3L,81L,1L,1L,1L,9L,1L,3L,1L,9L,3L,3L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,3L,1L,9L,1L,3L,1L,1L,3L,1L,1L,1L,1L,3L,3L,27L,1L,1L,9L,1L,3L,1L,1L,1L,27L,3L,1L,1L,1L,1L,1L,1L,1L,243L,1L,3L,1L,1L,1L,9L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072860Inst : IEnumerable<long>
{
public static readonly long[] Value=A072860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072860.Bytes);
public long this[int i]=>Value[i];

public static A072860Inst Instance=new A072860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072861
{
public static readonly long[] Value={ 1L,9L,16L,49L,36L,144L,64L,225L,169L,324L,144L,784L,196L,576L,576L,961L,324L,1521L,400L,1764L,1024L,1296L,576L,3600L,961L,1764L,1600L,3136L,900L,5184L,1024L,3969L,2304L,2916L,2304L,8281L,1444L,3600L,3136L,8100L,1764L,9216L,1936L,7056L,6084L,5184L,2304L,15376L,3249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072861Inst : IEnumerable<long>
{
public static readonly long[] Value=A072861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072861.Bytes);
public long this[int i]=>Value[i];

public static A072861Inst Instance=new A072861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072862
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,36L,64L,81L,100L,121L,144L,225L,256L,289L,324L,400L,484L,529L,576L,625L,729L,841L,900L,1024L,1089L,1156L,1296L,1600L,1681L,1936L,2025L,2116L,2209L,2304L,2401L,2500L,2601L,2809L,2916L,3025L,3364L,3481L,3600L,4096L,4356L,4624L,4761L,5041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072862Inst : IEnumerable<long>
{
public static readonly long[] Value=A072862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072862.Bytes);
public long this[int i]=>Value[i];

public static A072862Inst Instance=new A072862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072863
{
public static readonly long[] Value={ 1L,3L,9L,26L,72L,192L,496L,1248L,3072L,7424L,17664L,41472L,96256L,221184L,503808L,1138688L,2555904L,5701632L,12648448L,27918336L,61341696L,134217728L,292552704L,635437056L,1375731712L,2969567232L,6392119296L,13723762688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072863Inst : IEnumerable<long>
{
public static readonly long[] Value=A072863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072863.Bytes);
public long this[int i]=>Value[i];

public static A072863Inst Instance=new A072863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072864
{
public static readonly long[] Value={ 7L,13L,14L,19L,21L,26L,28L,31L,35L,37L,38L,39L,42L,43L,52L,56L,57L,61L,62L,63L,65L,67L,70L,73L,74L,76L,77L,78L,79L,84L,86L,91L,93L,95L,97L,103L,104L,105L,109L,111L,112L,114L,117L,119L,122L,124L,126L,127L,129L,130L,133L,134L,139L,140L,143L,146L,148L,151L,152L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072864Inst : IEnumerable<long>
{
public static readonly long[] Value=A072864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072864.Bytes);
public long this[int i]=>Value[i];

public static A072864Inst Instance=new A072864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072865
{
public static readonly long[] Value={ 2L,4L,2L,2L,2L,2L,2L,10L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,10L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072865Inst : IEnumerable<long>
{
public static readonly long[] Value=A072865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072865.Bytes);
public long this[int i]=>Value[i];

public static A072865Inst Instance=new A072865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072866
{
public static readonly long[] Value={ 2L,4L,2L,10L,2L,3L,2L,6L,2L,4L,2L,3L,2L,4L,2L,12L,2L,3L,2L,5L,2L,4L,2L,3L,2L,4L,2L,7L,2L,3L,2L,6L,2L,4L,2L,3L,2L,4L,2L,5L,2L,3L,2L,6L,2L,4L,2L,3L,2L,4L,2L,12L,2L,3L,2L,6L,2L,4L,2L,3L,2L,4L,2L,10L,2L,3L,2L,6L,2L,4L,2L,3L,2L,4L,2L,12L,2L,3L,2L,5L,2L,4L,2L,3L,2L,4L,2L,11L,2L,3L,2L,6L,2L,4L,2L,3L,2L,4L,2L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072866Inst : IEnumerable<long>
{
public static readonly long[] Value=A072866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072866.Bytes);
public long this[int i]=>Value[i];

public static A072866Inst Instance=new A072866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072867
{
public static readonly BigInteger[] Value={ 9825688L,690587635751L,3895157555937180L,5870824778815109405L,BigInteger.Parse("3785163537257390979782"),BigInteger.Parse("1331088890498177501120122"),BigInteger.Parse("295175742637140311468159615"),BigInteger.Parse("45387116230097904962420628542") };
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
public class A072867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072867Inst Instance=new A072867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072900
{
public static readonly long[] Value={ 8L,12L,5L,28L,44L,13L,17L,76L,92L,29L,124L,37L,41L,172L,188L,53L,236L,61L,268L,284L,73L,316L,332L,89L,97L,101L,412L,428L,109L,113L,508L,524L,137L,556L,149L,604L,157L,652L,668L,173L,716L,181L,764L,193L,197L,796L,844L,892L,908L,229L,233L,956L,241L,1004L,257L,1052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072900Inst : IEnumerable<long>
{
public static readonly long[] Value=A072900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072900.Bytes);
public long this[int i]=>Value[i];

public static A072900Inst Instance=new A072900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072901
{
public static readonly long[] Value={ 6L,10L,14L,15L,22L,26L,30L,34L,35L,38L,39L,42L,46L,51L,55L,58L,62L,66L,70L,74L,78L,82L,86L,87L,91L,94L,95L,102L,106L,110L,111L,114L,115L,118L,119L,122L,123L,130L,134L,138L,142L,143L,146L,154L,155L,158L,159L,166L,170L,174L,178L,182L,183L,186L,187L,190L,194L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072901Inst : IEnumerable<long>
{
public static readonly long[] Value=A072901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072901.Bytes);
public long this[int i]=>Value[i];

public static A072901Inst Instance=new A072901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072902
{
public static readonly long[] Value={ 1L,8L,12L,21L,24L,28L,33L,40L,44L,56L,57L,60L,65L,69L,76L,77L,85L,88L,92L,93L,104L,105L,120L,124L,129L,133L,136L,140L,141L,145L,152L,156L,161L,165L,168L,172L,177L,184L,185L,188L,201L,204L,205L,209L,213L,217L,220L,221L,232L,236L,237L,248L,249L,253L,264L,265L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072902Inst : IEnumerable<long>
{
public static readonly long[] Value=A072902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072902.Bytes);
public long this[int i]=>Value[i];

public static A072902Inst Instance=new A072902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072903
{
public static readonly long[] Value={ 4L,9L,16L,18L,20L,25L,27L,32L,36L,45L,48L,49L,50L,52L,54L,63L,64L,68L,72L,75L,80L,81L,84L,90L,96L,98L,99L,100L,108L,112L,116L,117L,121L,125L,126L,128L,132L,135L,144L,147L,148L,150L,153L,160L,162L,164L,169L,171L,175L,176L,180L,189L,192L,196L,198L,200L,207L,208L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072903Inst : IEnumerable<long>
{
public static readonly long[] Value=A072903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072903.Bytes);
public long this[int i]=>Value[i];

public static A072903Inst Instance=new A072903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072904
{
public static readonly long[] Value={ 18L,20L,27L,32L,45L,48L,50L,52L,54L,63L,68L,72L,75L,80L,84L,90L,96L,98L,99L,108L,112L,116L,117L,125L,126L,128L,132L,135L,147L,148L,150L,153L,160L,162L,164L,171L,175L,176L,180L,189L,192L,198L,200L,207L,208L,212L,216L,224L,228L,234L,240L,242L,243L,244L,245L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072904Inst : IEnumerable<long>
{
public static readonly long[] Value=A072904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072904.Bytes);
public long this[int i]=>Value[i];

public static A072904Inst Instance=new A072904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072905
{
public static readonly long[] Value={ 4L,8L,12L,9L,20L,24L,28L,18L,16L,40L,44L,27L,52L,56L,60L,25L,68L,32L,76L,45L,84L,88L,92L,54L,36L,104L,48L,63L,116L,120L,124L,50L,132L,136L,140L,49L,148L,152L,156L,90L,164L,168L,172L,99L,80L,184L,188L,75L,64L,72L,204L,117L,212L,96L,220L,126L,228L,232L,236L,135L,244L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072905Inst : IEnumerable<long>
{
public static readonly long[] Value=A072905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072905.Bytes);
public long this[int i]=>Value[i];

public static A072905Inst Instance=new A072905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072906
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,3L,3L,1L,1L,2L,1L,1L,1L,3L,1L,3L,1L,2L,1L,1L,1L,4L,4L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,5L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,7L,7L,5L,1L,2L,1L,4L,1L,4L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,1L,1L,1L,5L,1L,1L,2L,2L,1L,1L,1L,3L,6L,1L,1L,2L,1L,1L,1L,3L,1L,3L,1L,2L,1L,1L,1L,5L,1L,5L,3L,3L,1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072906Inst : IEnumerable<long>
{
public static readonly long[] Value=A072906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072906.Bytes);
public long this[int i]=>Value[i];

public static A072906Inst Instance=new A072906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072907
{
public static readonly long[] Value={ 4L,2L,5L,1L,8L,4L,4L,7L,7L,2L,9L,2L,1L,8L,5L,8L,8L,1L,9L,8L,9L,5L,9L,5L,9L,3L,5L,7L,5L,9L,9L,0L,4L,2L,1L,2L,9L,8L,5L,1L,9L,0L,0L,3L,9L,7L,0L,3L,8L,3L,7L,1L,4L,1L,9L,8L,5L,4L,4L,7L,1L,6L,0L,4L,4L,4L,1L,9L,4L,7L,1L,5L,0L,1L,0L,5L,6L,9L,2L,7L,8L,2L,6L,3L,2L,6L,8L,1L,7L,7L,1L,2L,0L,7L,2L,9L,4L,6L,3L,6L,9L,8L,4L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072907Inst : IEnumerable<long>
{
public static readonly long[] Value=A072907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072907.Bytes);
public long this[int i]=>Value[i];

public static A072907Inst Instance=new A072907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072908
{
public static readonly long[] Value={ 9L,9L,6L,9L,5L,5L,8L,0L,2L,8L,8L,7L,7L,7L,2L,6L,8L,3L,7L,9L,3L,4L,6L,8L,8L,0L,9L,2L,9L,2L,4L,2L,2L,1L,3L,0L,5L,2L,2L,7L,3L,7L,5L,1L,3L,8L,9L,8L,5L,3L,0L,2L,3L,5L,0L,7L,5L,5L,5L,6L,4L,8L,0L,2L,8L,4L,7L,6L,9L,6L,4L,2L,2L,5L,7L,8L,1L,1L,4L,9L,1L,7L,0L,2L,9L,3L,5L,2L,2L,5L,3L,4L,5L,1L,2L,4L,0L,5L,0L,6L,6L,1L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072908Inst : IEnumerable<long>
{
public static readonly long[] Value=A072908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072908.Bytes);
public long this[int i]=>Value[i];

public static A072908Inst Instance=new A072908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072909
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,2L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,4L,3L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,4L,3L,2L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072909Inst : IEnumerable<long>
{
public static readonly long[] Value=A072909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072909.Bytes);
public long this[int i]=>Value[i];

public static A072909Inst Instance=new A072909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072910
{
public static readonly long[] Value={ 1L,3L,6L,6L,7L,8L,9L,10L,9L,12L,12L,15L,14L,12L,14L,13L,18L,19L,18L,15L,18L,15L,20L,14L,24L,21L,18L,21L,24L,18L,24L,21L,27L,33L,30L,28L,28L,32L,36L,30L,21L,26L,27L,24L,27L,38L,30L,36L,35L,45L,36L,42L,39L,26L,44L,28L,40L,51L,30L,36L,28L,48L,54L,42L,45L,38L,31L,39L,36L,48L,60L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072910Inst : IEnumerable<long>
{
public static readonly long[] Value=A072910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072910.Bytes);
public long this[int i]=>Value[i];

public static A072910Inst Instance=new A072910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072911
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072911Inst : IEnumerable<long>
{
public static readonly long[] Value=A072911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072911.Bytes);
public long this[int i]=>Value[i];

public static A072911Inst Instance=new A072911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072912
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,25L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072912Inst : IEnumerable<long>
{
public static readonly long[] Value=A072912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072912.Bytes);
public long this[int i]=>Value[i];

public static A072912Inst Instance=new A072912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072913
{
public static readonly BigInteger[] Value={ 1L,31L,3661L,76111L,58067611L,68165041L,187059457981L,3355156783231L,300222042894631L,327873266234371L,5194481903600608411L,5578681466128739761L,BigInteger.Parse("170044702211669500782121"),BigInteger.Parse("180514164422163370751221") };
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
public class A072913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072913Inst Instance=new A072913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072914
{
public static readonly BigInteger[] Value={ 1L,16L,1296L,20736L,12960000L,12960000L,31116960000L,497871360000L,40327580160000L,40327580160000L,590436101122560000L,590436101122560000L,BigInteger.Parse("16863445484161436160000"),BigInteger.Parse("16863445484161436160000") };
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
public class A072914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A072914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A072914Inst Instance=new A072914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072915
{
public static readonly long[] Value={ 9L,8L,0L,6L,6L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072915Inst : IEnumerable<long>
{
public static readonly long[] Value=A072915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072915.Bytes);
public long this[int i]=>Value[i];

public static A072915Inst Instance=new A072915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072996
{
public static readonly long[] Value={ 1L,1L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072996Inst : IEnumerable<long>
{
public static readonly long[] Value=A072996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072996.Bytes);
public long this[int i]=>Value[i];

public static A072996Inst Instance=new A072996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072997
{
public static readonly long[] Value={ 2L,3L,13L,31L,89L,239L,617L,1571L,4007L,10141L,25673L,64853L,163367L,412007L,1037759L,2614369L,6584857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072997Inst : IEnumerable<long>
{
public static readonly long[] Value=A072997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072997.Bytes);
public long this[int i]=>Value[i];

public static A072997Inst Instance=new A072997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072998
{
public static readonly long[] Value={ 1L,2L,20L,21L,22L,200L,201L,202L,210L,211L,212L,220L,221L,222L,2000L,2001L,2002L,2010L,2011L,2012L,2020L,2021L,2022L,2100L,2101L,2102L,2110L,2111L,2112L,2120L,2121L,2122L,2200L,2201L,2202L,2210L,2211L,2212L,2220L,2221L,2222L,20000L,20001L,20002L,20010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072998Inst : IEnumerable<long>
{
public static readonly long[] Value=A072998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072998.Bytes);
public long this[int i]=>Value[i];

public static A072998Inst Instance=new A072998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A072999
{
public static readonly ulong[] Value={ 2L,3L,5L,13L,31L,137L,853L,6961L,28697L,179143L,6836131L,68540453L,966402473L,15530980021L,94152282599L,203835545219L,2540178825227L,61168127350667L,6119352913891927L,220357873027460039L,16312601956945934813UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A072999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A072999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A072999Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A072999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A072999.Bytes);
public ulong this[int i]=>Value[i];

public static A072999Inst Instance=new A072999Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073000
{
public static readonly long[] Value={ 4L,6L,3L,6L,4L,7L,6L,0L,9L,0L,0L,0L,8L,0L,6L,1L,1L,6L,2L,1L,4L,2L,5L,6L,2L,3L,1L,4L,6L,1L,2L,1L,4L,4L,0L,2L,0L,2L,8L,5L,3L,7L,0L,5L,4L,2L,8L,6L,1L,2L,0L,2L,6L,3L,8L,1L,0L,9L,3L,3L,0L,8L,8L,7L,2L,0L,1L,9L,7L,8L,6L,4L,1L,6L,5L,7L,4L,1L,7L,0L,5L,3L,0L,0L,6L,0L,0L,2L,8L,3L,9L,8L,4L,8L,8L,7L,8L,9L,2L,5L,5L,6L,5L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073000Inst : IEnumerable<long>
{
public static readonly long[] Value=A073000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073000.Bytes);
public long this[int i]=>Value[i];

public static A073000Inst Instance=new A073000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073001
{
public static readonly long[] Value={ 2L,8L,0L,1L,6L,9L,4L,9L,9L,0L,2L,3L,8L,6L,9L,1L,3L,3L,0L,3L,6L,4L,3L,6L,4L,9L,1L,2L,3L,0L,6L,7L,2L,0L,0L,0L,0L,4L,2L,4L,8L,2L,1L,3L,9L,8L,1L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073001Inst : IEnumerable<long>
{
public static readonly long[] Value=A073001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073001.Bytes);
public long this[int i]=>Value[i];

public static A073001Inst Instance=new A073001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073002
{
public static readonly long[] Value={ 9L,3L,7L,5L,4L,8L,2L,5L,4L,3L,1L,5L,8L,4L,3L,7L,5L,3L,7L,0L,2L,5L,7L,4L,0L,9L,4L,5L,6L,7L,8L,6L,4L,9L,7L,7L,8L,9L,7L,8L,6L,0L,2L,8L,8L,6L,1L,4L,8L,2L,9L,9L,2L,5L,8L,8L,5L,4L,3L,3L,4L,8L,0L,3L,6L,0L,4L,4L,3L,8L,1L,1L,3L,1L,2L,7L,0L,7L,5L,2L,2L,7L,9L,3L,6L,8L,9L,4L,1L,5L,1L,4L,1L,1L,5L,1L,5L,1L,7L,4L,9L,3L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073002Inst : IEnumerable<long>
{
public static readonly long[] Value=A073002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073002.Bytes);
public long this[int i]=>Value[i];

public static A073002Inst Instance=new A073002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073003
{
public static readonly long[] Value={ 5L,9L,6L,3L,4L,7L,3L,6L,2L,3L,2L,3L,1L,9L,4L,0L,7L,4L,3L,4L,1L,0L,7L,8L,4L,9L,9L,3L,6L,9L,2L,7L,9L,3L,7L,6L,0L,7L,4L,1L,7L,7L,8L,6L,0L,1L,5L,2L,5L,4L,8L,7L,8L,1L,5L,7L,3L,4L,8L,4L,9L,1L,0L,4L,8L,2L,3L,2L,7L,2L,1L,9L,1L,1L,4L,8L,7L,4L,4L,1L,7L,4L,7L,0L,4L,3L,0L,4L,9L,7L,0L,9L,3L,6L,1L,2L,7L,6L,0L,3L,4L,4L,2L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073003Inst : IEnumerable<long>
{
public static readonly long[] Value=A073003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073003.Bytes);
public long this[int i]=>Value[i];

public static A073003Inst Instance=new A073003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073004
{
public static readonly long[] Value={ 1L,7L,8L,1L,0L,7L,2L,4L,1L,7L,9L,9L,0L,1L,9L,7L,9L,8L,5L,2L,3L,6L,5L,0L,4L,1L,0L,3L,1L,0L,7L,1L,7L,9L,5L,4L,9L,1L,6L,9L,6L,4L,5L,2L,1L,4L,3L,0L,3L,4L,3L,0L,2L,0L,5L,3L,5L,7L,6L,6L,5L,8L,7L,6L,5L,1L,2L,8L,4L,1L,0L,7L,6L,8L,1L,3L,5L,8L,8L,2L,9L,3L,7L,0L,7L,5L,7L,4L,2L,1L,6L,4L,8L,8L,4L,1L,8L,2L,8L,0L,3L,3L,4L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073004Inst : IEnumerable<long>
{
public static readonly long[] Value=A073004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073004.Bytes);
public long this[int i]=>Value[i];

public static A073004Inst Instance=new A073004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073005
{
public static readonly long[] Value={ 2L,6L,7L,8L,9L,3L,8L,5L,3L,4L,7L,0L,7L,7L,4L,7L,6L,3L,3L,6L,5L,5L,6L,9L,2L,9L,4L,0L,9L,7L,4L,6L,7L,7L,6L,4L,4L,1L,2L,8L,6L,8L,9L,3L,7L,7L,9L,5L,7L,3L,0L,1L,1L,0L,0L,9L,5L,0L,4L,2L,8L,3L,2L,7L,5L,9L,0L,4L,1L,7L,6L,1L,0L,1L,6L,7L,7L,4L,3L,8L,1L,9L,5L,4L,0L,9L,8L,2L,8L,8L,9L,0L,4L,1L,1L,8L,8L,7L,8L,9L,4L,1L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073005Inst : IEnumerable<long>
{
public static readonly long[] Value=A073005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073005.Bytes);
public long this[int i]=>Value[i];

public static A073005Inst Instance=new A073005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073006
{
public static readonly long[] Value={ 1L,3L,5L,4L,1L,1L,7L,9L,3L,9L,4L,2L,6L,4L,0L,0L,4L,1L,6L,9L,4L,5L,2L,8L,8L,0L,2L,8L,1L,5L,4L,5L,1L,3L,7L,8L,5L,5L,1L,9L,3L,2L,7L,2L,6L,6L,0L,5L,6L,7L,9L,3L,6L,9L,8L,3L,9L,4L,0L,2L,2L,4L,6L,7L,9L,6L,3L,7L,8L,2L,9L,6L,5L,4L,0L,1L,7L,4L,2L,5L,4L,1L,6L,7L,5L,8L,3L,4L,1L,4L,7L,9L,5L,2L,9L,7L,2L,9L,1L,1L,1L,0L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073006Inst : IEnumerable<long>
{
public static readonly long[] Value=A073006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073006.Bytes);
public long this[int i]=>Value[i];

public static A073006Inst Instance=new A073006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073007
{
public static readonly long[] Value={ 9L,2L,8L,9L,0L,2L,5L,4L,9L,1L,9L,2L,0L,8L,1L,8L,9L,1L,8L,7L,5L,5L,4L,4L,9L,4L,3L,5L,9L,5L,1L,7L,4L,5L,0L,6L,1L,0L,3L,1L,6L,9L,4L,8L,6L,7L,7L,5L,0L,1L,2L,4L,4L,0L,8L,2L,3L,9L,7L,0L,0L,6L,1L,4L,2L,1L,7L,2L,9L,3L,7L,5L,2L,4L,7L,2L,8L,6L,5L,0L,7L,0L,7L,0L,5L,2L,4L,1L,5L,8L,7L,0L,6L,1L,4L,2L,4L,7L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073007Inst : IEnumerable<long>
{
public static readonly long[] Value=A073007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073007.Bytes);
public long this[int i]=>Value[i];

public static A073007Inst Instance=new A073007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073008
{
public static readonly long[] Value={ 7L,1L,4L,7L,8L,2L,7L,0L,0L,7L,9L,1L,2L,9L,4L,2L,7L,2L,0L,1L,8L,9L,8L,4L,8L,7L,9L,6L,2L,1L,0L,8L,4L,0L,9L,6L,7L,3L,1L,3L,4L,5L,5L,9L,7L,0L,9L,4L,4L,3L,0L,3L,1L,9L,3L,9L,6L,4L,5L,7L,0L,0L,4L,1L,1L,5L,4L,6L,1L,1L,7L,7L,3L,8L,3L,3L,5L,8L,7L,9L,7L,0L,6L,7L,7L,0L,2L,1L,3L,4L,1L,3L,0L,9L,6L,2L,9L,4L,5L,3L,3L,5L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073008Inst : IEnumerable<long>
{
public static readonly long[] Value=A073008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073008.Bytes);
public long this[int i]=>Value[i];

public static A073008Inst Instance=new A073008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073009
{
public static readonly long[] Value={ 1L,2L,9L,1L,2L,8L,5L,9L,9L,7L,0L,6L,2L,6L,6L,3L,5L,4L,0L,4L,0L,7L,2L,8L,2L,5L,9L,0L,5L,9L,5L,6L,0L,0L,5L,4L,1L,4L,9L,8L,6L,1L,9L,3L,6L,8L,2L,7L,4L,5L,2L,2L,3L,1L,7L,3L,1L,0L,0L,0L,2L,4L,4L,5L,1L,3L,6L,9L,4L,4L,5L,3L,8L,7L,6L,5L,2L,3L,4L,4L,5L,5L,5L,5L,8L,8L,1L,7L,0L,4L,1L,1L,2L,9L,4L,2L,9L,7L,0L,8L,9L,8L,4L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073009Inst : IEnumerable<long>
{
public static readonly long[] Value=A073009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073009.Bytes);
public long this[int i]=>Value[i];

public static A073009Inst Instance=new A073009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073010
{
public static readonly long[] Value={ 6L,0L,4L,5L,9L,9L,7L,8L,8L,0L,7L,8L,0L,7L,2L,6L,1L,6L,8L,6L,4L,6L,9L,2L,7L,5L,2L,5L,4L,7L,3L,8L,5L,2L,4L,4L,0L,9L,4L,6L,8L,8L,7L,4L,9L,3L,6L,4L,2L,4L,6L,8L,5L,8L,5L,2L,3L,2L,9L,4L,9L,7L,8L,4L,6L,2L,7L,0L,7L,7L,2L,7L,0L,4L,2L,1L,1L,7L,9L,6L,1L,2L,2L,8L,0L,4L,1L,6L,6L,2L,7L,3L,7L,3L,5L,3L,3L,8L,9L,6L,1L,8L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073010Inst : IEnumerable<long>
{
public static readonly long[] Value=A073010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073010.Bytes);
public long this[int i]=>Value[i];

public static A073010Inst Instance=new A073010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073011
{
public static readonly long[] Value={ 1L,1L,7L,6L,2L,8L,0L,8L,1L,8L,2L,5L,9L,9L,1L,7L,5L,0L,6L,5L,4L,4L,0L,7L,0L,3L,3L,8L,4L,7L,4L,0L,3L,5L,0L,5L,0L,6L,9L,3L,4L,1L,5L,8L,0L,6L,5L,6L,4L,6L,9L,5L,2L,5L,9L,8L,3L,0L,1L,0L,6L,3L,4L,7L,0L,2L,9L,6L,8L,8L,3L,7L,6L,5L,4L,8L,5L,4L,9L,9L,6L,2L,0L,9L,6L,8L,3L,0L,1L,1L,5L,5L,8L,1L,8L,1L,5L,3L,9L,4L,6L,5L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073011Inst : IEnumerable<long>
{
public static readonly long[] Value=A073011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073011.Bytes);
public long this[int i]=>Value[i];

public static A073011Inst Instance=new A073011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073012
{
public static readonly long[] Value={ 6L,6L,1L,7L,0L,7L,1L,8L,2L,2L,6L,7L,1L,7L,6L,2L,3L,5L,1L,5L,5L,8L,3L,1L,1L,3L,3L,2L,4L,8L,4L,1L,3L,5L,8L,1L,7L,4L,6L,4L,0L,0L,1L,3L,5L,7L,9L,0L,9L,5L,3L,6L,0L,4L,8L,0L,8L,9L,4L,4L,2L,2L,9L,4L,7L,9L,5L,8L,4L,6L,4L,6L,1L,3L,8L,5L,9L,7L,6L,3L,1L,3L,0L,6L,6L,5L,2L,4L,8L,0L,7L,6L,8L,1L,0L,7L,1L,2L,0L,1L,5L,1L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073012Inst : IEnumerable<long>
{
public static readonly long[] Value=A073012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073012.Bytes);
public long this[int i]=>Value[i];

public static A073012Inst Instance=new A073012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073013
{
public static readonly long[] Value={ 1L,6L,37L,255L,1991L,17598L,174924L,1937715L,23696029L,317105778L,4608337064L,72249308222L,1215116713110L,21816229444012L,416367513788760L,8415762294812355L,179556294350582865L,4032049130587198650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073013Inst : IEnumerable<long>
{
public static readonly long[] Value=A073013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073013.Bytes);
public long this[int i]=>Value[i];

public static A073013Inst Instance=new A073013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073014
{
public static readonly BigInteger[] Value={ 1L,9L,127L,2835L,93901L,4336878L,266268402L,20961918435L,2057633544961L,246291719185578L,35300219800649134L,5967365133741366446L,BigInteger.Parse("1174674087014062487490"),BigInteger.Parse("266337973265724541242428") };
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
public class A073014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073014Inst Instance=new A073014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073015
{
public static readonly BigInteger[] Value={ 3L,4L,9L,64L,3969L,15745024L,247905749270529L,BigInteger.Parse("61457260521381894004129398784"),BigInteger.Parse("3776994870793005510047522464634252677140721938309041881089"),BigInteger.Parse("14265690253996672387291309349232388828298289458234016200317876247121873778287073518355813134107244701354409532063744") };
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
public class A073015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A073015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A073015Inst Instance=new A073015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073016
{
public static readonly long[] Value={ 7L,3L,6L,3L,9L,9L,8L,5L,8L,7L,1L,8L,7L,1L,5L,0L,7L,7L,9L,0L,9L,7L,9L,5L,1L,6L,8L,3L,6L,4L,9L,2L,3L,4L,9L,6L,0L,6L,3L,1L,2L,5L,8L,3L,2L,9L,0L,9L,4L,9L,7L,9L,0L,5L,6L,8L,2L,1L,9L,6L,6L,5L,2L,3L,0L,8L,4L,7L,1L,8L,1L,8L,0L,2L,8L,0L,7L,8L,6L,4L,0L,8L,1L,8L,6L,9L,4L,4L,4L,1L,8L,2L,4L,9L,0L,2L,2L,5L,9L,7L,4L,5L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073016Inst : IEnumerable<long>
{
public static readonly long[] Value=A073016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073016.Bytes);
public long this[int i]=>Value[i];

public static A073016Inst Instance=new A073016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073017
{
public static readonly long[] Value={ 2L,4L,2L,8L,1L,8L,9L,7L,9L,2L,0L,9L,8L,8L,7L,0L,3L,2L,8L,7L,3L,6L,0L,4L,1L,4L,3L,6L,1L,7L,9L,1L,4L,6L,3L,5L,8L,1L,1L,8L,3L,6L,2L,9L,4L,4L,7L,8L,3L,3L,9L,0L,4L,9L,7L,6L,3L,2L,7L,4L,9L,9L,7L,4L,7L,2L,6L,4L,4L,4L,7L,3L,4L,1L,2L,0L,8L,6L,8L,3L,6L,8L,1L,2L,3L,8L,0L,5L,5L,0L,1L,5L,7L,2L,0L,5L,9L,0L,4L,3L,8L,8L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073017Inst : IEnumerable<long>
{
public static readonly long[] Value=A073017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073017.Bytes);
public long this[int i]=>Value[i];

public static A073017Inst Instance=new A073017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073018
{
public static readonly long[] Value={ 2L,2L,4L,5L,1L,7L,2L,5L,1L,9L,8L,3L,2L,3L,2L,0L,6L,2L,6L,6L,5L,1L,2L,8L,2L,9L,3L,7L,4L,3L,9L,1L,4L,2L,8L,6L,8L,0L,9L,5L,8L,1L,7L,4L,6L,5L,7L,3L,1L,5L,8L,8L,7L,2L,9L,9L,9L,7L,6L,4L,4L,7L,4L,8L,9L,0L,5L,9L,2L,7L,5L,8L,4L,6L,4L,7L,9L,8L,5L,1L,2L,5L,1L,6L,8L,1L,9L,2L,8L,3L,6L,2L,5L,7L,2L,7L,0L,8L,2L,0L,9L,7L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073018Inst : IEnumerable<long>
{
public static readonly long[] Value=A073018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073018.Bytes);
public long this[int i]=>Value[i];

public static A073018Inst Instance=new A073018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073019
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,11L,13L,17L,19L,89L,163L,167L,233L,251L,349L,401L,757L,1423L,3049L,3643L,11987L,19801L,26393L,32303L,35363L,35863L,36607L,36683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073019Inst : IEnumerable<long>
{
public static readonly long[] Value=A073019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073019.Bytes);
public long this[int i]=>Value[i];

public static A073019Inst Instance=new A073019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073020
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,5L,8L,1L,5L,8L,16L,16L,1L,6L,12L,29L,38L,50L,1L,7L,16L,47L,79L,126L,133L,1L,8L,21L,72L,147L,280L,375L,440L,1L,9L,27L,104L,252L,561L,912L,1282L,1387L,1L,10L,33L,145L,406L,1032L,1980L,3260L,4262L,4752L,1L,11L,40L,195L,621L,1782L,3936L,7440L,11410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073020Inst : IEnumerable<long>
{
public static readonly long[] Value=A073020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073020.Bytes);
public long this[int i]=>Value[i];

public static A073020Inst Instance=new A073020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073021
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,11L,17L,29L,47L,79L,127L,211L,347L,563L,911L,1481L,2393L,3877L,6271L,10151L,16427L,26591L,43019L,69623L,112643L,182279L,294923L,477209L,772139L,1249361L,2021501L,3270863L,5292367L,8563237L,13855607L,22418849L,36274471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073021Inst : IEnumerable<long>
{
public static readonly long[] Value=A073021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073021.Bytes);
public long this[int i]=>Value[i];

public static A073021Inst Instance=new A073021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073022
{
public static readonly long[] Value={ 1L,1L,3L,5L,11L,17L,29L,47L,79L,127L,211L,347L,563L,911L,1481L,2393L,3877L,6271L,10151L,16427L,26591L,43019L,69623L,112643L,182279L,294923L,477209L,772139L,1249361L,2021501L,3270863L,5292367L,8563237L,13855607L,22418849L,36274471L,58693331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073022Inst : IEnumerable<long>
{
public static readonly long[] Value=A073022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073022.Bytes);
public long this[int i]=>Value[i];

public static A073022Inst Instance=new A073022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073023
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,5L,2L,4L,3L,7L,2L,8L,2L,6L,5L,7L,2L,11L,2L,8L,5L,11L,2L,12L,3L,9L,4L,14L,2L,18L,2L,7L,6L,12L,5L,16L,2L,10L,6L,19L,2L,22L,2L,9L,9L,16L,2L,19L,3L,13L,6L,18L,2L,20L,5L,14L,7L,21L,2L,28L,2L,10L,9L,17L,5L,29L,2L,17L,6L,31L,2L,23L,2L,10L,9L,23L,5L,32L,2L,16L,5L,26L,2L,28L,6L,14L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073023Inst : IEnumerable<long>
{
public static readonly long[] Value=A073023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073023.Bytes);
public long this[int i]=>Value[i];

public static A073023Inst Instance=new A073023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073024
{
public static readonly long[] Value={ 11L,23L,47L,59L,83L,107L,149L,167L,173L,179L,223L,227L,263L,269L,283L,293L,317L,347L,359L,367L,383L,389L,439L,467L,479L,499L,503L,509L,557L,563L,569L,587L,607L,619L,643L,653L,719L,773L,787L,797L,809L,823L,839L,857L,863L,887L,907L,983L,1019L,1031L,1039L,1049L,1087L,1091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073024Inst : IEnumerable<long>
{
public static readonly long[] Value=A073024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073024.Bytes);
public long this[int i]=>Value[i];

public static A073024Inst Instance=new A073024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073025
{
public static readonly long[] Value={ 23L,47L,59L,83L,107L,167L,179L,227L,263L,269L,293L,317L,347L,359L,383L,389L,467L,479L,503L,509L,557L,563L,587L,653L,719L,773L,797L,839L,863L,887L,983L,1019L,1109L,1187L,1229L,1283L,1307L,1319L,1367L,1399L,1439L,1447L,1487L,1493L,1523L,1543L,1579L,1619L,1627L,1637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073025Inst : IEnumerable<long>
{
public static readonly long[] Value=A073025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073025.Bytes);
public long this[int i]=>Value[i];

public static A073025Inst Instance=new A073025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073026
{
public static readonly long[] Value={ 269L,293L,317L,389L,509L,557L,653L,773L,797L,1109L,1229L,1399L,1447L,1493L,1543L,1579L,1627L,1637L,1663L,1699L,1733L,1759L,1867L,1879L,1949L,1987L,1997L,2083L,2203L,2239L,2309L,2383L,2477L,2659L,2693L,2767L,2803L,2837L,2909L,2957L,3019L,3343L,3413L,3463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073026Inst : IEnumerable<long>
{
public static readonly long[] Value=A073026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073026.Bytes);
public long this[int i]=>Value[i];

public static A073026Inst Instance=new A073026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073027
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,1L,0L,1L,7L,2L,0L,4L,3L,0L,2L,0L,2L,2L,0L,2L,2L,0L,1L,0L,0L,3L,4L,2L,0L,5L,0L,0L,0L,9L,4L,8L,3L,0L,6L,8L,0L,6L,4L,5L,2L,0L,3L,0L,2L,0L,0L,7L,8L,7L,8L,0L,1L,3L,0L,3L,7L,0L,9L,5L,5L,4L,0L,6L,3L,3L,0L,7L,5L,0L,7L,7L,1L,2L,0L,2L,1L,4L,3L,0L,3L,6L,0L,7L,4L,3L,7L,0L,2L,6L,6L,6L,3L,0L,0L,8L,0L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073027Inst : IEnumerable<long>
{
public static readonly long[] Value=A073027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073027.Bytes);
public long this[int i]=>Value[i];

public static A073027Inst Instance=new A073027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073028
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,10L,15L,21L,35L,56L,84L,126L,210L,330L,495L,792L,1287L,2002L,3003L,5005L,8008L,12376L,19448L,31824L,50388L,77520L,125970L,203490L,319770L,497420L,817190L,1307504L,2042975L,3268760L,5311735L,8436285L,13123110L,21474180L,34597290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073028Inst : IEnumerable<long>
{
public static readonly long[] Value=A073028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073028.Bytes);
public long this[int i]=>Value[i];

public static A073028Inst Instance=new A073028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073029
{
public static readonly long[] Value={ 26L,5L,18L,15L,15L,14L,5L,20L,23L,15L,20L,8L,18L,5L,5L,6L,15L,21L,18L,6L,9L,22L,5L,19L,9L,24L,19L,5L,22L,5L,14L,5L,9L,7L,8L,20L,14L,9L,14L,5L,20L,5L,14L,5L,12L,5L,22L,5L,14L,20L,23L,5L,12L,22L,5L,20L,8L,9L,18L,20L,5L,5L,14L,6L,15L,21L,18L,20L,5L,5L,14L,6L,9L,6L,20L,5L,5L,14L,19L,9L,24L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073029Inst : IEnumerable<long>
{
public static readonly long[] Value=A073029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073029.Bytes);
public long this[int i]=>Value[i];

public static A073029Inst Instance=new A073029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073030
{
public static readonly long[] Value={ 1L,11L,101L,1111L,10001L,111111L,1010101L,11011011L,101000101L,1111111111L,10001010001L,111111111111L,1010100010101L,11010011001011L,101010101010101L,1111111111111111L,10001010001010001L,111111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073030Inst : IEnumerable<long>
{
public static readonly long[] Value=A073030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073030.Bytes);
public long this[int i]=>Value[i];

public static A073030Inst Instance=new A073030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073031
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,15L,26L,44L,75L,129L,220L,377L,644L,1101L,1883L,3219L,5505L,9412L,16093L,27517L,47049L,80448L,137553L,235195L,402148L,687611L,1175712L,2010288L,3437288L,5877241L,10049189L,17182590L,29379620L,50234693L,85893702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073031Inst : IEnumerable<long>
{
public static readonly long[] Value=A073031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073031.Bytes);
public long this[int i]=>Value[i];

public static A073031Inst Instance=new A073031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073032
{
public static readonly long[] Value={ 18048976L,20100368L,18914992L,19252208L,18048976L,20100368L,18914992L,19252208L,18048976L,20100368L,18914992L,19252208L,18048976L,20100368L,18914992L,19252208L,18048976L,20100368L,18914992L,19252208L,18048976L,20100368L,18914992L,19252208L,18048976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073032Inst : IEnumerable<long>
{
public static readonly long[] Value=A073032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073032.Bytes);
public long this[int i]=>Value[i];

public static A073032Inst Instance=new A073032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073033
{
public static readonly long[] Value={ 18656380L,20522060L,28630036L,24289964L,18656380L,20522060L,28630036L,24289964L,18656380L,20522060L,28630036L,24289964L,18656380L,20522060L,28630036L,24289964L,18656380L,20522060L,28630036L,24289964L,18656380L,20522060L,28630036L,24289964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073033Inst : IEnumerable<long>
{
public static readonly long[] Value=A073033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073033.Bytes);
public long this[int i]=>Value[i];

public static A073033Inst Instance=new A073033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073034
{
public static readonly long[] Value={ 2L,3L,5L,7L,3L,7L,2L,3L,2L,3L,3L,7L,3L,7L,5L,3L,5L,7L,7L,7L,3L,7L,3L,7L,3L,7L,3L,2L,7L,3L,3L,7L,3L,5L,5L,7L,3L,7L,7L,3L,7L,3L,7L,2L,2L,2L,3L,2L,2L,7L,2L,2L,2L,3L,3L,2L,3L,2L,2L,5L,2L,5L,7L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073034Inst : IEnumerable<long>
{
public static readonly long[] Value=A073034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073034.Bytes);
public long this[int i]=>Value[i];

public static A073034Inst Instance=new A073034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073035
{
public static readonly long[] Value={ 23L,71L,11L,11L,13L,31L,17L,71L,19L,23L,29L,31L,13L,37L,41L,43L,47L,53L,59L,61L,67L,71L,17L,73L,37L,79L,83L,89L,97L,71L,11L,3L,31L,7L,71L,11L,13L,31L,71L,13L,31L,11L,13L,37L,71L,13L,11L,71L,31L,67L,71L,17L,73L,31L,17L,79L,11L,19L,11L,19L,31L,19L,97L,71L,19L,11L,23L,29L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073035Inst : IEnumerable<long>
{
public static readonly long[] Value=A073035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073035.Bytes);
public long this[int i]=>Value[i];

public static A073035Inst Instance=new A073035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073036
{
public static readonly long[] Value={ 571L,113L,131L,317L,719L,293L,313L,137L,347L,359L,167L,677L,173L,379L,983L,389L,997L,971L,101L,11L,103L,31L,107L,71L,109L,911L,113L,131L,127L,271L,131L,311L,113L,137L,139L,149L,491L,151L,157L,571L,163L,631L,167L,173L,317L,179L,181L,811L,191L,911L,193L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073036Inst : IEnumerable<long>
{
public static readonly long[] Value=A073036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073036.Bytes);
public long this[int i]=>Value[i];

public static A073036Inst Instance=new A073036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073037
{
public static readonly long[] Value={ 2357L,3571L,5711L,3137L,7717L,8389L,1103L,1031L,7109L,1091L,911L,2713L,9151L,1511L,1571L,3167L,9181L,1811L,1193L,1931L,9319L,9719L,1223L,7229L,3323L,9241L,7127L,1277L,1283L,8329L,3307L,1733L,7331L,3313L,3373L,7349L,3533L,3359L,3593L,3673L,6737L,3733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073037Inst : IEnumerable<long>
{
public static readonly long[] Value=A073037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073037.Bytes);
public long this[int i]=>Value[i];

public static A073037Inst Instance=new A073037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073038
{
public static readonly long[] Value={ 11131L,11317L,13171L,23293L,74143L,14347L,96167L,98389L,71011L,1103L,7109L,13127L,31271L,12713L,37139L,51157L,57163L,17317L,79181L,91811L,18119L,91193L,19319L,23227L,39241L,51257L,26927L,27127L,81283L,32933L,93307L,33073L,31337L,53359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073038Inst : IEnumerable<long>
{
public static readonly long[] Value=A073038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073038.Bytes);
public long this[int i]=>Value[i];

public static A073038Inst Instance=new A073038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073039
{
public static readonly long[] Value={ 1L,2L,6L,4L,30L,6L,210L,8L,36L,30L,2310L,12L,30030L,210L,30L,16L,510510L,36L,9699690L,60L,210L,2310L,223092870L,24L,900L,30030L,216L,420L,6469693230L,30L,200560490130L,32L,2310L,510510L,210L,36L,7420738134810L,9699690L,30030L,120L,304250263527210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073039Inst : IEnumerable<long>
{
public static readonly long[] Value=A073039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073039.Bytes);
public long this[int i]=>Value[i];

public static A073039Inst Instance=new A073039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A073040
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,12L,13L,15L,17L,19L,23L,24L,26L,29L,31L,37L,41L,43L,47L,53L,56L,59L,61L,67L,71L,73L,75L,76L,79L,83L,89L,90L,95L,97L,101L,103L,107L,109L,113L,119L,122L,124L,127L,131L,137L,139L,140L,143L,147L,149L,151L,153L,157L,163L,167L,173L,176L,179L,181L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A073040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A073040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A073040Inst : IEnumerable<long>
{
public static readonly long[] Value=A073040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A073040.Bytes);
public long this[int i]=>Value[i];

public static A073040Inst Instance=new A073040Inst();

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