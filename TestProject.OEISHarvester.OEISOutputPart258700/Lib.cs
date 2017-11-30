using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191326
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,13L,14L,15L,19L,21L,22L,28L,31L,33L,35L,42L,45L,46L,49L,52L,63L,66L,67L,69L,73L,77L,78L,94L,98L,99L,100L,103L,108L,109L,115L,117L,122L,147L,148L,150L,154L,157L,161L,162L,163L,171L,172L,175L,182L,183L,220L,222L,225L,231L,234L,235L,241L,243L,244L,255L,256L,258L,262L,269L,273L,274L,343L,346L,350L,351L,352L,360L,361L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191326Inst : IEnumerable<long>
{
public static readonly long[] Value=A191326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191326.Bytes);
public long this[int i]=>Value[i];

public static A191326Inst Instance=new A191326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191327
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,12L,17L,24L,25L,30L,35L,42L,59L,60L,62L,75L,84L,87L,105L,122L,147L,150L,155L,187L,206L,210L,217L,262L,294L,304L,305L,367L,375L,387L,427L,467L,514L,515L,525L,542L,654L,655L,721L,735L,759L,760L,762L,917L,937L,967L,1029L,1064L,1067L,1167L,1284L,1285L,1287L,1312L,1354L,1355L,1494L,1634L,1635L,1637L,1799L,1802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191327Inst : IEnumerable<long>
{
public static readonly long[] Value=A191327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191327.Bytes);
public long this[int i]=>Value[i];

public static A191327Inst Instance=new A191327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191328
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,18L,21L,23L,25L,26L,30L,32L,35L,37L,38L,41L,42L,43L,49L,50L,53L,58L,60L,61L,63L,68L,70L,71L,74L,81L,83L,86L,88L,95L,96L,98L,100L,101L,105L,113L,114L,116L,118L,123L,135L,138L,140L,142L,143L,146L,147L,158L,160L,163L,165L,166L,168L,172L,175L,188L,189L,190L,193L,196L,200L,205L,221L,224L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191328Inst : IEnumerable<long>
{
public static readonly long[] Value=A191328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191328.Bytes);
public long this[int i]=>Value[i];

public static A191328Inst Instance=new A191328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191329
{
public static readonly long[] Value={ 1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191329Inst : IEnumerable<long>
{
public static readonly long[] Value=A191329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191329.Bytes);
public long this[int i]=>Value[i];

public static A191329Inst Instance=new A191329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191330
{
public static readonly long[] Value={ 4L,8L,10L,14L,20L,24L,26L,30L,36L,40L,46L,50L,52L,56L,62L,66L,68L,72L,76L,78L,82L,88L,92L,94L,98L,104L,108L,114L,118L,120L,124L,130L,134L,136L,140L,144L,146L,150L,156L,160L,162L,166L,172L,176L,178L,182L,186L,188L,192L,198L,202L,204L,208L,214L,218L,224L,228L,230L,234L,240L,244L,246L,250L,254L,256L,260L,266L,270L,272L,276L,282L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191330Inst : IEnumerable<long>
{
public static readonly long[] Value=A191330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191330.Bytes);
public long this[int i]=>Value[i];

public static A191330Inst Instance=new A191330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191331
{
public static readonly long[] Value={ 2L,6L,12L,16L,18L,22L,28L,32L,34L,38L,42L,44L,48L,54L,58L,60L,64L,70L,74L,80L,84L,86L,90L,96L,100L,102L,106L,110L,112L,116L,122L,126L,128L,132L,138L,142L,148L,152L,154L,158L,164L,168L,170L,174L,180L,184L,190L,194L,196L,200L,206L,210L,212L,216L,220L,222L,226L,232L,236L,238L,242L,248L,252L,258L,262L,264L,268L,274L,278L,280L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191331Inst : IEnumerable<long>
{
public static readonly long[] Value=A191331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191331.Bytes);
public long this[int i]=>Value[i];

public static A191331Inst Instance=new A191331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191332
{
public static readonly long[] Value={ 0L,1L,2L,5L,1L,5L,2L,3L,9L,2L,5L,6L,3L,2L,4L,2L,9L,1L,3L,6L,5L,4L,4L,3L,1L,3L,1L,7L,0L,5L,5L,1L,9L,5L,0L,6L,5L,3L,6L,5L,6L,1L,3L,5L,2L,5L,1L,3L,4L,4L,5L,7L,0L,1L,1L,8L,6L,3L,4L,3L,6L,2L,5L,4L,4L,2L,8L,1L,4L,6L,3L,0L,6L,6L,5L,7L,6L,7L,5L,6L,6L,8L,4L,8L,8L,3L,1L,3L,7L,1L,2L,7L,4L,4L,6L,4L,3L,9L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191332Inst : IEnumerable<long>
{
public static readonly long[] Value=A191332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191332.Bytes);
public long this[int i]=>Value[i];

public static A191332Inst Instance=new A191332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191333
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,4L,7L,6L,0L,7L,4L,3L,6L,7L,5L,7L,0L,8L,6L,3L,4L,5L,5L,6L,8L,6L,8L,2L,9L,4L,4L,8L,0L,4L,9L,3L,4L,6L,3L,4L,3L,8L,6L,4L,7L,4L,8L,6L,5L,5L,4L,2L,9L,8L,8L,1L,3L,6L,5L,6L,3L,7L,4L,5L,5L,7L,1L,8L,5L,3L,6L,9L,3L,3L,4L,2L,3L,2L,4L,3L,3L,1L,5L,1L,1L,6L,8L,6L,2L,8L,7L,2L,5L,5L,3L,5L,6L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191333Inst : IEnumerable<long>
{
public static readonly long[] Value=A191333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191333.Bytes);
public long this[int i]=>Value[i];

public static A191333Inst Instance=new A191333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191334
{
public static readonly long[] Value={ 1L,2L,8L,0L,4L,8L,7L,8L,0L,3L,9L,3L,3L,7L,1L,6L,5L,4L,6L,9L,2L,9L,5L,8L,2L,6L,5L,0L,9L,8L,6L,8L,7L,6L,5L,5L,3L,7L,5L,7L,5L,1L,6L,0L,8L,8L,3L,6L,5L,6L,0L,6L,8L,0L,5L,1L,1L,8L,8L,4L,0L,4L,0L,9L,5L,6L,8L,6L,6L,3L,2L,2L,5L,0L,4L,3L,2L,0L,2L,2L,3L,8L,5L,3L,8L,8L,1L,6L,6L,9L,8L,2L,3L,3L,9L,9L,8L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191334Inst : IEnumerable<long>
{
public static readonly long[] Value=A191334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191334.Bytes);
public long this[int i]=>Value[i];

public static A191334Inst Instance=new A191334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191335
{
public static readonly long[] Value={ 3L,7L,1L,9L,5L,1L,2L,1L,9L,6L,0L,6L,6L,2L,8L,3L,4L,5L,3L,0L,7L,0L,4L,1L,7L,3L,4L,9L,0L,1L,3L,1L,2L,3L,4L,4L,6L,2L,4L,2L,4L,8L,3L,9L,1L,1L,6L,3L,4L,3L,9L,3L,1L,9L,4L,8L,8L,1L,1L,5L,9L,5L,9L,0L,4L,3L,1L,3L,3L,6L,7L,7L,4L,9L,5L,6L,7L,9L,7L,7L,6L,1L,4L,6L,1L,1L,8L,3L,3L,0L,1L,7L,6L,5L,9L,5L,7L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191335Inst : IEnumerable<long>
{
public static readonly long[] Value=A191335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191335.Bytes);
public long this[int i]=>Value[i];

public static A191335Inst Instance=new A191335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191336
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,1L,2L,1L,1L,2L,1L,1L,0L,1L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,1L,2L,1L,1L,2L,1L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,1L,2L,1L,1L,0L,1L,1L,0L,1L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,1L,2L,1L,1L,2L,1L,1L,0L,1L,1L,2L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191336Inst : IEnumerable<long>
{
public static readonly long[] Value=A191336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191336.Bytes);
public long this[int i]=>Value[i];

public static A191336Inst Instance=new A191336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191337
{
public static readonly long[] Value={ 6L,7L,12L,13L,19L,22L,28L,29L,34L,35L,44L,50L,51L,56L,57L,66L,67L,72L,73L,79L,82L,88L,89L,94L,95L,101L,104L,110L,111L,116L,117L,126L,132L,133L,139L,148L,149L,154L,155L,161L,164L,170L,171L,176L,177L,183L,186L,192L,193L,198L,199L,208L,214L,215L,221L,230L,231L,236L,237L,243L,246L,252L,253L,258L,259L,265L,268L,274L,275L,280L,281L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191337Inst : IEnumerable<long>
{
public static readonly long[] Value=A191337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191337.Bytes);
public long this[int i]=>Value[i];

public static A191337Inst Instance=new A191337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191338
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,11L,14L,17L,18L,20L,21L,23L,24L,27L,30L,33L,36L,37L,39L,40L,42L,43L,45L,46L,49L,52L,55L,58L,59L,61L,62L,64L,65L,68L,71L,74L,77L,78L,80L,81L,83L,84L,86L,87L,90L,93L,96L,97L,99L,100L,102L,103L,105L,106L,109L,112L,115L,118L,119L,121L,122L,124L,125L,127L,128L,131L,134L,137L,138L,140L,141L,143L,144L,146L,147L,150L,153L,156L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191338Inst : IEnumerable<long>
{
public static readonly long[] Value=A191338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191338.Bytes);
public long this[int i]=>Value[i];

public static A191338Inst Instance=new A191338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191339
{
public static readonly long[] Value={ 3L,9L,10L,15L,16L,25L,26L,31L,32L,38L,41L,47L,48L,53L,54L,60L,63L,69L,70L,75L,76L,85L,91L,92L,98L,107L,108L,113L,114L,120L,123L,129L,130L,135L,136L,142L,145L,151L,152L,157L,158L,167L,173L,174L,180L,189L,190L,195L,196L,202L,205L,211L,212L,217L,218L,224L,227L,233L,234L,239L,240L,249L,250L,255L,256L,262L,271L,272L,277L,278L,284L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191339Inst : IEnumerable<long>
{
public static readonly long[] Value=A191339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191339.Bytes);
public long this[int i]=>Value[i];

public static A191339Inst Instance=new A191339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191500
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-5L,17L,249L,-1489L,-27453L,237537L,6037041L,-68649441L,-2107439157L,29789919345L,1092524775081L,-18492402857265L,-781266357571053L,15425010795541185L,739391174869277025L,BigInteger.Parse("-16695627953904545985"),BigInteger.Parse("-893468264544135234405"),BigInteger.Parse("22725280358984904476625") };
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
public class A191500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191500Inst Instance=new A191500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191501
{
public static readonly long[] Value={ 1L,2L,4L,10L,28L,96L,354L,1372L,5512L,22740L,95768L,410016L,1779210L,7807724L,34589432L,154488460L,694883528L,3144917888L,14311109396L,65439770904L,300534169744L,1385612474536L,6410981989808L,29757955549888L,138534010818650L,646663905140300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191501Inst : IEnumerable<long>
{
public static readonly long[] Value=A191501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191501.Bytes);
public long this[int i]=>Value[i];

public static A191501Inst Instance=new A191501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191502
{
public static readonly long[] Value={ 1L,9L,1L,8L,7L,2L,4L,6L,6L,5L,9L,7L,7L,6L,3L,4L,5L,2L,9L,6L,6L,0L,3L,7L,8L,2L,5L,0L,7L,4L,9L,8L,1L,5L,7L,5L,3L,0L,1L,6L,9L,1L,8L,3L,1L,2L,6L,6L,3L,0L,7L,2L,5L,4L,9L,5L,6L,4L,0L,5L,7L,7L,3L,9L,9L,8L,3L,8L,1L,0L,1L,8L,1L,1L,4L,5L,0L,1L,1L,6L,9L,9L,3L,7L,1L,3L,1L,5L,6L,7L,0L,6L,6L,7L,3L,3L,6L,7L,4L,7L,3L,4L,1L,6L,8L,6L,2L,4L,8L,7L,1L,1L,6L,3L,7L,7L,5L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191502Inst : IEnumerable<long>
{
public static readonly long[] Value=A191502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191502.Bytes);
public long this[int i]=>Value[i];

public static A191502Inst Instance=new A191502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191503
{
public static readonly long[] Value={ 1L,7L,5L,2L,3L,5L,1L,5L,5L,8L,0L,8L,1L,0L,8L,0L,8L,2L,6L,7L,1L,4L,0L,8L,6L,6L,6L,4L,8L,3L,9L,3L,6L,6L,6L,5L,3L,3L,5L,5L,7L,1L,4L,0L,1L,0L,7L,4L,2L,3L,9L,3L,0L,3L,3L,0L,8L,5L,7L,4L,1L,2L,7L,8L,3L,6L,1L,8L,4L,0L,9L,6L,0L,8L,2L,2L,9L,7L,2L,8L,0L,2L,2L,9L,5L,0L,1L,8L,2L,0L,5L,2L,8L,6L,8L,3L,0L,1L,2L,6L,9L,2L,9L,4L,8L,6L,9L,4L,9L,2L,3L,9L,8L,5L,3L,1L,4L,4L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191503Inst : IEnumerable<long>
{
public static readonly long[] Value=A191503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191503.Bytes);
public long this[int i]=>Value[i];

public static A191503Inst Instance=new A191503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191504
{
public static readonly long[] Value={ 6L,6L,2L,0L,9L,4L,2L,5L,1L,7L,8L,5L,1L,0L,3L,7L,5L,8L,8L,1L,2L,3L,1L,8L,1L,0L,8L,9L,8L,4L,1L,6L,3L,6L,8L,6L,0L,7L,3L,3L,8L,5L,4L,7L,7L,0L,8L,1L,2L,4L,4L,6L,6L,3L,2L,3L,2L,0L,1L,9L,3L,1L,2L,8L,5L,5L,4L,0L,4L,3L,3L,9L,7L,6L,2L,2L,7L,7L,5L,4L,4L,4L,2L,4L,3L,0L,1L,4L,4L,7L,8L,9L,8L,2L,6L,0L,6L,5L,3L,6L,4L,9L,6L,5L,7L,8L,9L,6L,6L,2L,5L,0L,5L,5L,9L,7L,2L,7L,0L,9L,8L,8L,0L,2L,6L,5L,0L,9L,6L,6L,2L,5L,0L,4L,3L,3L,9L,0L,2L,1L,4L,6L,5L,0L,2L,1L,7L,6L,8L,7L,3L,6L,2L,5L,8L,7L,7L,5L,5L,2L,8L,4L,8L,6L,8L,5L,5L,1L,1L,9L,9L,3L,4L,9L,5L,5L,7L,6L,4L,2L,3L,2L,5L,4L,8L,2L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191504Inst : IEnumerable<long>
{
public static readonly long[] Value=A191504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191504.Bytes);
public long this[int i]=>Value[i];

public static A191504Inst Instance=new A191504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191505
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,75L,7636L,4866965L,22256484426L,827473662052359L,BigInteger.Parse("280073424855627741304"),BigInteger.Parse("956136927041635596586248969"),BigInteger.Parse("36146438316110599447497305174316790"),BigInteger.Parse("16486165931975571004114967909531846539984907") };
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
public class A191505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191505Inst Instance=new A191505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191506
{
public static readonly BigInteger[] Value={ 2L,5L,25L,195L,2475L,53324L,1872113L,109037035L,10508450377L,1672058437225L,440124911303718L,191498508664286039L,BigInteger.Parse("137739615464486164780"),BigInteger.Parse("163796811382099494131871"),BigInteger.Parse("322006666961136384120723488") };
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
public class A191506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191506Inst Instance=new A191506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191507
{
public static readonly BigInteger[] Value={ 2L,8L,52L,646L,14570L,599702L,45191945L,6225542127L,1567856872728L,722008623925586L,607932060252871024L,BigInteger.Parse("935917819388424802645"),BigInteger.Parse("2634499346573878930718088"),BigInteger.Parse("13559220442178025486399949918") };
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
public class A191507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191507Inst Instance=new A191507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191508
{
public static readonly BigInteger[] Value={ 2L,8L,56L,792L,21984L,1188160L,125522112L,25932064896L,10472077118464L,8266074697979136L,12754433913314441216UL,BigInteger.Parse("38469498012053658897408"),BigInteger.Parse("226810241439860068417249280"),BigInteger.Parse("2613967215944945112514234085376") };
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
public class A191508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191508Inst Instance=new A191508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191509
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,13L,-4L,-59L,848L,1625L,-57968L,-82679L,5307072L,3378277L,-761466432L,-178851763L,155538255616L,13323839409L,-43026868334336L,-1145167641071L,15502018794828800L,110592144624061L,-7038075176027079680L,-12523284027203883L,BigInteger.Parse("3925127762389637074944"),1643266949074714633L,BigInteger.Parse("-2635567108489125092225024") };
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
public class A191509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191509Inst Instance=new A191509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191510
{
public static readonly BigInteger[] Value={ 1L,9L,648L,360000L,1518750000L,48243443062500L,11480517255997440000UL,BigInteger.Parse("20400479323264014247526400"),BigInteger.Parse("270090559531318533654528000000000"),BigInteger.Parse("26599911685677709861296622500000000000000"),BigInteger.Parse("19464564507161243794359748945629699456000000000000") };
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
public class A191510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191510Inst Instance=new A191510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191511
{
public static readonly BigInteger[] Value={ 3L,27L,1863L,259767L,63267723L,23850461907L,12872337567183L,9418588525038447L,8974900856105748243L,BigInteger.Parse("10799459611549296021387"),BigInteger.Parse("16014456358054037241378903"),BigInteger.Parse("28692834058049011948073522727"),BigInteger.Parse("61105982516981628849258186347163"),BigInteger.Parse("152570799245287136693700721604134467"),BigInteger.Parse("441413217492406160002632205611608461023") };
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
public class A191511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191511Inst Instance=new A191511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191512
{
public static readonly BigInteger[] Value={ 0L,1L,-5L,89L,-4717L,449073L,-69090581L,15583801609L,-4846181282685L,1987373846425697L,-1039121484066627877L,BigInteger.Parse("674707915373741222841"),BigInteger.Parse("-532627526452975709882765"),BigInteger.Parse("502375568363623615781076625"),BigInteger.Parse("-557965947638266639781208500277"),BigInteger.Parse("720767702359064719935712626879593"),BigInteger.Parse("-1071470941893105999704454019614019741") };
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
public class A191512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191512Inst Instance=new A191512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191513
{
public static readonly long[] Value={ 3L,5L,10L,11L,18L,127L,286L,560L,1025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191513Inst : IEnumerable<long>
{
public static readonly long[] Value=A191513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191513.Bytes);
public long this[int i]=>Value[i];

public static A191513Inst Instance=new A191513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191514
{
public static readonly long[] Value={ 51L,33L,13L,34L,1L,8L,7L,75L,28L,60L,93L,32L,26L,95L,44L,92L,63L,40L,71L,23L,57L,76L,85L,88L,79L,91L,49L,31L,53L,90L,69L,81L,39L,70L,89L,37L,5L,64L,41L,77L,38L,14L,47L,62L,83L,35L,3L,4L,56L,67L,2L,72L,68L,15L,87L,9L,65L,25L,80L,42L,12L,66L,21L,58L,55L,82L,59L,78L,94L,46L,61L,19L,84L,73L,43L,22L,52L,48L,20L,24L,96L,16L,98L,100L,97L,101L,99L,102L,18L,36L,10L,86L,54L,30L,45L,17L,6L,27L,29L,74L,50L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191514Inst : IEnumerable<long>
{
public static readonly long[] Value=A191514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191514.Bytes);
public long this[int i]=>Value[i];

public static A191514Inst Instance=new A191514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191515
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,0L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,3L,1L,2L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191515Inst : IEnumerable<long>
{
public static readonly long[] Value=A191515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191515.Bytes);
public long this[int i]=>Value[i];

public static A191515Inst Instance=new A191515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191548
{
public static readonly BigInteger[] Value={ 31L,5L,3221L,7L,25646167L,17L,19L,11L,23L,13L,11831L,5839L,31L,17L,137L,19L,BigInteger.Parse("751410597400064602523400427092397"),661L,127L,23L,47L,46644217L,101L,79L,2377L,29L,7193L,31L,BigInteger.Parse("1310825268269643509279336731098526398390609803239319801398048897"),97L,755569L };
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
public class A191548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191548Inst Instance=new A191548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191549
{
public static readonly BigInteger[] Value={ 10L,1L,644L,1L,3663738L,2L,2L,1L,2L,1L,910L,417L,2L,1L,8L,1L,BigInteger.Parse("39547926178950768553863180373284"),33L,6L,1L,2L,1943509L,4L,3L,88L,1L,248L,1L,BigInteger.Parse("42284686073214306750946346164468593496471283975461929077356416"),3L,22896L,1481424868782L,1634L,1L,22260L,1077L,2L,1L };
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
public class A191549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191549Inst Instance=new A191549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191550
{
public static readonly long[] Value={ 1L,1L,2L,5L,8L,37L,26984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191550Inst : IEnumerable<long>
{
public static readonly long[] Value=A191550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191550.Bytes);
public long this[int i]=>Value[i];

public static A191550Inst Instance=new A191550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191551
{
public static readonly BigInteger[] Value={ 2L,8L,33L,297L,4032L,91392L,3461143L,214272233L,22066261672L,3754762272000L,1054824912314030L,490291568481195135L,BigInteger.Parse("376674319103188012304"),BigInteger.Parse("478415094920126210097672"),BigInteger.Parse("1004588343161199901448153154") };
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
public class A191551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191551Inst Instance=new A191551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191552
{
public static readonly BigInteger[] Value={ 2L,8L,52L,528L,11275L,435987L,30448860L,3920809305L,920775496348L,394837552267029L,310020405028212730L,BigInteger.Parse("445022535834699088455"),BigInteger.Parse("1167728276848286755937076"),BigInteger.Parse("5603048100640429152817307256") };
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
public class A191552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191552Inst Instance=new A191552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191553
{
public static readonly BigInteger[] Value={ 2L,8L,60L,855L,24282L,1352976L,146740728L,31117674297L,12907153049676L,10462960655266920L,16578587764555196630UL,BigInteger.Parse("51351429814865700365643"),BigInteger.Parse("310919919699021477652128426"),BigInteger.Parse("3679876610343227082947024870052") };
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
public class A191553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191553Inst Instance=new A191553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191554
{
public static readonly BigInteger[] Value={ 2L,18L,11250L,64854011250L,BigInteger.Parse("2980024297506569894680811250"),BigInteger.Parse("1319492964487055911863581348741902326769016593763234907139211250") };
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
public class A191554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191554Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191554.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191554Inst Instance=new A191554Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191555
{
public static readonly BigInteger[] Value={ 2L,12L,720L,3628800L,144850083840000L,BigInteger.Parse("272760108249915378892800000000"),BigInteger.Parse("1264767303092594444142256488682840323816161280000000000000000") };
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
public class A191555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191555Inst Instance=new A191555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191556
{
public static readonly long[] Value={ 11L,203L,3971L,64771L,1011875L,16752659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191556Inst : IEnumerable<long>
{
public static readonly long[] Value=A191556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191556.Bytes);
public long this[int i]=>Value[i];

public static A191556Inst Instance=new A191556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191557
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-5L,6L,57L,-68L,-996L,1151L,23487L,-26316L,-703858L,769268L,25912425L,-27791388L,-1146924362L,1212941187L,60112150656L,-62911402588L,-3686975047595L,3828485422340L,262043300715095L,-270475215554448L,-21394371719691000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191557Inst : IEnumerable<long>
{
public static readonly long[] Value=A191557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191557.Bytes);
public long this[int i]=>Value[i];

public static A191557Inst Instance=new A191557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191558
{
public static readonly long[] Value={ 1L,0L,0L,4L,0L,6L,0L,8L,9L,10L,0L,12L,0L,14L,15L,16L,0L,18L,0L,20L,21L,22L,0L,24L,25L,26L,27L,28L,0L,30L,0L,32L,33L,34L,35L,36L,0L,38L,39L,40L,0L,42L,0L,44L,45L,46L,0L,48L,49L,50L,51L,52L,0L,54L,55L,56L,57L,58L,0L,60L,0L,62L,63L,64L,65L,66L,0L,68L,69L,70L,0L,72L,0L,74L,75L,76L,77L,78L,0L,80L,81L,82L,0L,84L,85L,86L,87L,88L,0L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191558Inst : IEnumerable<long>
{
public static readonly long[] Value=A191558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191558.Bytes);
public long this[int i]=>Value[i];

public static A191558Inst Instance=new A191558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191559
{
public static readonly BigInteger[] Value={ 25L,9765625L,3814697265625L,1490116119384765625L,BigInteger.Parse("582076609134674072265625"),BigInteger.Parse("227373675443232059478759765625"),BigInteger.Parse("88817841970012523233890533447265625"),BigInteger.Parse("34694469519536141888238489627838134765625"),BigInteger.Parse("13552527156068805425093160010874271392822265625") };
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
public class A191559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191559Inst Instance=new A191559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191560
{
public static readonly BigInteger[] Value={ 15625L,6103515625L,2384185791015625L,BigInteger.Parse("931322574615478515625"),BigInteger.Parse("363797880709171295166015625"),BigInteger.Parse("142108547152020037174224853515625"),BigInteger.Parse("55511151231257827021181583404541015625"),BigInteger.Parse("21684043449710088680149056017398834228515625"),BigInteger.Parse("8470329472543003390683225006796419620513916015625") };
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
public class A191560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191560Inst Instance=new A191560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191561
{
public static readonly long[] Value={ 2L,4L,8L,4L,2L,10L,2L,16L,26L,4L,2L,28L,2L,4L,8L,16L,2L,28L,2L,16L,8L,4L,2L,64L,32L,4L,80L,16L,2L,64L,2L,64L,8L,4L,53L,28L,2L,4L,8L,16L,2L,64L,2L,16L,107L,4L,2L,64L,128L,124L,8L,16L,2L,82L,98L,88L,8L,4L,2L,136L,2L,4L,134L,64L,32L,64L,2L,16L,8L,184L,2L,136L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191561Inst : IEnumerable<long>
{
public static readonly long[] Value=A191561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191561.Bytes);
public long this[int i]=>Value[i];

public static A191561Inst Instance=new A191561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191562
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,7L,1L,1L,19L,7L,1L,7L,7L,28L,1L,7L,1L,7L,1L,28L,49L,7L,1L,7L,49L,1L,49L,7L,19L,7L,1L,46L,49L,28L,1L,7L,49L,109L,1L,7L,91L,7L,25L,82L,49L,7L,1L,49L,49L,37L,61L,7L,1L,43L,49L,1L,49L,7L,1L,7L,49L,28L,1L,37L,37L,7L,157L,136L,49L,7L,1L,7L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191562Inst : IEnumerable<long>
{
public static readonly long[] Value=A191562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191562.Bytes);
public long this[int i]=>Value[i];

public static A191562Inst Instance=new A191562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191563
{
public static readonly BigInteger[] Value={ 1L,2L,4L,19L,136L,3036L,151848L,16814116L,3818273456L,1759237059488L,1637673128642016L,3074457382841680224L,BigInteger.Parse("11624286729262765320064"),BigInteger.Parse("88424288520685885682129216"),BigInteger.Parse("1352160640243480723729126645248"),BigInteger.Parse("41538374868278630828076760060403776"),BigInteger.Parse("2562126056816477844908944991509312669696") };
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
public class A191563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191563Inst Instance=new A191563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191740
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,11L,10L,8L,7L,20L,18L,15L,13L,9L,35L,31L,26L,23L,16L,12L,60L,53L,45L,40L,28L,21L,14L,101L,90L,76L,68L,48L,36L,25L,17L,170L,151L,128L,115L,81L,61L,43L,30L,19L,285L,253L,215L,193L,136L,103L,73L,51L,33L,22L,476L,423L,360L,323L,228L,173L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191740Inst : IEnumerable<long>
{
public static readonly long[] Value=A191740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191740.Bytes);
public long this[int i]=>Value[i];

public static A191740Inst Instance=new A191740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191741
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,4L,10L,11L,7L,8L,17L,20L,12L,15L,9L,30L,35L,21L,26L,16L,13L,51L,60L,36L,45L,27L,22L,14L,86L,101L,61L,76L,46L,37L,25L,18L,145L,170L,102L,127L,77L,62L,42L,31L,19L,242L,285L,171L,212L,130L,105L,71L,52L,32L,23L,405L,476L,286L,355L,217L,176L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191741Inst : IEnumerable<long>
{
public static readonly long[] Value=A191741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191741.Bytes);
public long this[int i]=>Value[i];

public static A191741Inst Instance=new A191741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191742
{
public static readonly BigInteger[] Value={ 2L,6L,34L,354L,6640L,226090L,13978062L,1567580958L,318961138670L,117759554854782L,78883071103925368L,BigInteger.Parse("95874600035087067128"),BigInteger.Parse("211425486715722284229326"),BigInteger.Parse("845949075122781758953188444"),BigInteger.Parse("6141355289964517541296446302562") };
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
public class A191742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191742Inst Instance=new A191742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191743
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,20L,24L,30L,32L,36L,40L,42L,48L,54L,60L,64L,72L,80L,84L,88L,90L,96L,100L,108L,120L,126L,128L,140L,144L,150L,156L,160L,162L,168L,176L,180L,192L,198L,200L,210L,216L,220L,240L,252L,256L,264L,270L,272L,280L,288L,294L,300L,312L,315L,320L,324L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191743Inst : IEnumerable<long>
{
public static readonly long[] Value=A191743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191743.Bytes);
public long this[int i]=>Value[i];

public static A191743Inst Instance=new A191743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191744
{
public static readonly long[] Value={ 24L,1152L,110592L,5308416L,995328000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191744Inst : IEnumerable<long>
{
public static readonly long[] Value=A191744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191744.Bytes);
public long this[int i]=>Value[i];

public static A191744Inst Instance=new A191744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191745
{
public static readonly long[] Value={ 0L,23L,136L,411L,920L,1735L,2928L,4571L,6736L,9495L,12920L,17083L,22056L,27911L,34720L,42555L,51488L,61591L,72936L,85595L,99640L,115143L,132176L,150811L,171120L,193175L,217048L,242811L,270536L,300295L,332160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191745Inst : IEnumerable<long>
{
public static readonly long[] Value=A191745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191745.Bytes);
public long this[int i]=>Value[i];

public static A191745Inst Instance=new A191745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191746
{
public static readonly long[] Value={ 15L,50L,193L,516L,1415L,3178L,6777L,11960L,22363L,34026L,53069L,75568L,107967L,144830L,184033L,236016L,293615L,366514L,446037L,543380L,664483L,840882L,1027505L,1240948L,1513431L,1838330L,2198329L,2580252L,2992415L,3428014L,4084113L,4759796L,5445379L,6181542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191746Inst : IEnumerable<long>
{
public static readonly long[] Value=A191746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191746.Bytes);
public long this[int i]=>Value[i];

public static A191746Inst Instance=new A191746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191747
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191747Inst : IEnumerable<long>
{
public static readonly long[] Value=A191747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191747.Bytes);
public long this[int i]=>Value[i];

public static A191747Inst Instance=new A191747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191748
{
public static readonly long[] Value={ 1L,2L,5L,6L,10L,14L,15L,20L,25L,30L,31L,37L,43L,49L,55L,56L,63L,70L,77L,84L,91L,92L,100L,108L,116L,124L,132L,140L,141L,150L,159L,168L,177L,186L,195L,204L,205L,215L,225L,235L,245L,255L,265L,275L,285L,286L,297L,308L,319L,330L,341L,352L,363L,374L,385L,386L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191748Inst : IEnumerable<long>
{
public static readonly long[] Value=A191748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191748.Bytes);
public long this[int i]=>Value[i];

public static A191748Inst Instance=new A191748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191749
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,12L,13L,16L,18L,20L,21L,25L,27L,28L,30L,32L,37L,43L,44L,45L,48L,49L,50L,52L,57L,60L,61L,64L,66L,67L,68L,70L,73L,75L,77L,78L,80L,81L,85L,87L,90L,91L,92L,97L,100L,101L,102L,104L,108L,110L,112L,115L,117L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191749Inst : IEnumerable<long>
{
public static readonly long[] Value=A191749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191749.Bytes);
public long this[int i]=>Value[i];

public static A191749Inst Instance=new A191749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191750
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,12L,8L,7L,7L,18L,12L,20L,14L,24L,24L,9L,18L,21L,20L,30L,32L,36L,24L,28L,11L,42L,10L,40L,30L,72L,32L,11L,48L,54L,48L,35L,38L,60L,56L,42L,42L,96L,44L,60L,42L,72L,48L,36L,15L,33L,72L,70L,54L,30L,72L,56L,80L,90L,60L,120L,62L,96L,56L,13L,84L,144L,68L,90L,96L,144L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191750Inst : IEnumerable<long>
{
public static readonly long[] Value=A191750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191750.Bytes);
public long this[int i]=>Value[i];

public static A191750Inst Instance=new A191750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191751
{
public static readonly long[] Value={ 0L,1L,3L,1L,1L,5L,3L,11L,1L,1L,25L,29L,3L,13L,3L,7L,39L,1L,13L,23L,3L,5L,69L,11L,39L,13L,15L,31L,99L,83L,117L,31L,9L,11L,25L,67L,45L,1L,39L,47L,45L,71L,69L,77L,1L,131L,67L,101L,55L,1L,9L,41L,13L,43L,33L,233L,1L,113L,7L,29L,45L,55L,99L,41L,261L,5L,15L,343L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191751Inst : IEnumerable<long>
{
public static readonly long[] Value=A191751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191751.Bytes);
public long this[int i]=>Value[i];

public static A191751Inst Instance=new A191751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191752
{
public static readonly long[] Value={ 100L,110L,111L,1010L,1112L,1120L,1121L,1122L,1200L,1210L,1211L,1220L,1221L,1222L,2000L,2100L,2110L,2111L,2200L,2210L,2211L,2220L,2221L,2222L,10010L,10101L,10110L,10200L,11010L,11011L,11113L,11123L,11130L,11131L,11132L,11133L,11212L,11223L,11230L,11231L,11232L,11233L,11300L,11310L,11311L,11320L,11321L,11322L,11330L,11331L,11332L,11333L,12120L,12121L,12223L,12230L,12231L,12232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191752Inst : IEnumerable<long>
{
public static readonly long[] Value=A191752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191752.Bytes);
public long this[int i]=>Value[i];

public static A191752Inst Instance=new A191752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191753
{
public static readonly long[] Value={ 1000L,1100L,1110L,1111L,10100L,11112L,11120L,11121L,11122L,11200L,11210L,11211L,11220L,11221L,11222L,12000L,12100L,12110L,12111L,12200L,12210L,12211L,12220L,12221L,12222L,20000L,21000L,21100L,21110L,21111L,22000L,22100L,22110L,22111L,22200L,22210L,22211L,22220L,22221L,22222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191753Inst : IEnumerable<long>
{
public static readonly long[] Value=A191753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191753.Bytes);
public long this[int i]=>Value[i];

public static A191753Inst Instance=new A191753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191754
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,41L,41L,-589L,-589L,8317L,8317L,-869807L,-869807L,43056421L,43056421L,-250158593L,-250158593L,67632514765L,67632514765L,-1581439548217L,-1581439548217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191754Inst : IEnumerable<long>
{
public static readonly long[] Value=A191754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191754.Bytes);
public long this[int i]=>Value[i];

public static A191754Inst Instance=new A191754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191755
{
public static readonly long[] Value={ 1L,2L,6L,22L,82L,320L,1268L,5102L,20632L,83972L,342468L,1399296L,5720966L,23396618L,95654386L,390868900L,1596000418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191755Inst : IEnumerable<long>
{
public static readonly long[] Value=A191755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191755.Bytes);
public long this[int i]=>Value[i];

public static A191755Inst Instance=new A191755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192316
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,9L,21L,35L,42L,70L,168L,330L,471L,561L,855L,1950L,4402L,8023L,11616L,14245L,18425L,33880L,78519L,172047L,320451L,500579L,668582L,819819L,1113658L,2046760L,4599060L,10174544L,20102845L,34677986L,52310993L,70115066L,87683799L,115847016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192316Inst : IEnumerable<long>
{
public static readonly long[] Value=A192316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192316.Bytes);
public long this[int i]=>Value[i];

public static A192316Inst Instance=new A192316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192317
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,21L,47L,103L,217L,451L,951L,2047L,4439L,9548L,20231L,42355L,88373L,185343L,392297L,836502L,1787158L,3803651L,8035998L,16846041L,35121641L,73103052L,152493454L,319600236L,673256721L,1423293503L,3011396839L,6358756643L,13372146841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192317Inst : IEnumerable<long>
{
public static readonly long[] Value=A192317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192317.Bytes);
public long this[int i]=>Value[i];

public static A192317Inst Instance=new A192317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192318
{
public static readonly long[] Value={ 1L,1L,2L,6L,18L,61L,218L,804L,3052L,11831L,46646L,186487L,754177L,3079767L,12681568L,52595999L,219515014L,921264092L,3885468897L,16459470468L,70001813240L,298785285316L,1279450906737L,5495145204550L,23665623371950L,102175095587827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192318Inst : IEnumerable<long>
{
public static readonly long[] Value=A192318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192318.Bytes);
public long this[int i]=>Value[i];

public static A192318Inst Instance=new A192318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192319
{
public static readonly long[] Value={ 1L,1358L,1359L,1360L,31464L,31465L,31466L,31467L,31468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192319Inst : IEnumerable<long>
{
public static readonly long[] Value=A192319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192319.Bytes);
public long this[int i]=>Value[i];

public static A192319Inst Instance=new A192319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192320
{
public static readonly long[] Value={ 1L,1352L,1353L,1354L,1355L,1356L,1357L,1358L,1359L,1360L,19657L,19658L,19659L,19660L,25522L,31451L,31452L,31453L,31454L,31455L,31456L,31457L,31458L,31459L,31460L,31461L,31462L,31463L,31464L,31465L,31466L,31467L,31468L,34116L,34117L,34118L,34119L,34120L,34121L,34122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192320Inst : IEnumerable<long>
{
public static readonly long[] Value=A192320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192320.Bytes);
public long this[int i]=>Value[i];

public static A192320Inst Instance=new A192320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192321
{
public static readonly long[] Value={ 6L,14L,15L,21L,33L,38L,57L,62L,69L,77L,111L,119L,141L,143L,155L,161L,194L,203L,206L,209L,215L,218L,278L,287L,309L,314L,329L,381L,395L,398L,447L,453L,489L,533L,537L,551L,554L,566L,579L,626L,635L,671L,755L,785L,818L,878L,899L,959L,974L,993L,1007L,1011L,1041L,1067L,1077L,1133L,1142L,1149L,1191L,1202L,1263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192321Inst : IEnumerable<long>
{
public static readonly long[] Value=A192321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192321.Bytes);
public long this[int i]=>Value[i];

public static A192321Inst Instance=new A192321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192322
{
public static readonly long[] Value={ 84L,120L,132L,168L,195L,228L,280L,312L,340L,372L,408L,435L,483L,520L,532L,555L,595L,627L,708L,715L,760L,795L,1012L,1435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192322Inst : IEnumerable<long>
{
public static readonly long[] Value=A192322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192322.Bytes);
public long this[int i]=>Value[i];

public static A192322Inst Instance=new A192322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192323
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,2L,0L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,4L,6L,0L,0L,0L,0L,4L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,0L,6L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,4L,4L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192323Inst : IEnumerable<long>
{
public static readonly long[] Value=A192323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192323.Bytes);
public long this[int i]=>Value[i];

public static A192323Inst Instance=new A192323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192324
{
public static readonly long[] Value={ 1L,0L,2L,1L,9L,11L,8L,8L,5L,8L,1L,25L,32L,0L,8L,27L,32L,26L,12L,47L,7L,35L,46L,3L,94L,19L,75L,61L,22L,3L,7L,116L,67L,24L,137L,63L,149L,42L,60L,9L,71L,155L,39L,11L,72L,50L,47L,40L,23L,25L,70L,47L,31L,15L,127L,172L,73L,109L,117L,58L,29L,246L,201L,207L,283L,52L,127L,31L,138L,55L,284L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192324Inst : IEnumerable<long>
{
public static readonly long[] Value=A192324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192324.Bytes);
public long this[int i]=>Value[i];

public static A192324Inst Instance=new A192324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192325
{
public static readonly BigInteger[] Value={ 1L,0L,2L,16L,244L,6938L,371342L,37280140L,7016898676L,2476338996046L,1638683680332022L,2033288154472125378L,BigInteger.Parse("4730646433644468299754"),BigInteger.Parse("20637618504497727985203276"),BigInteger.Parse("168817037972490215464239418020") };
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
public class A192325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192325Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192325.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192325Inst Instance=new A192325Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192326
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,2L,4L,4L,6L,10L,10L,14L,16L,16L,18L,22L,26L,26L,30L,32L,32L,36L,38L,42L,48L,50L,50L,52L,52L,54L,5L,5L,7L,5L,11L,9L,11L,13L,13L,15L,17L,15L,21L,19L,19L,17L,25L,33L,33L,31L,31L,33L,31L,37L,39L,41L,43L,41L,43L,43L,41L,47L,57L,57L,55L,55L,65L,67L,73L,71L,71L,73L,77L,79L,81L,81L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192326Inst : IEnumerable<long>
{
public static readonly long[] Value=A192326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192326.Bytes);
public long this[int i]=>Value[i];

public static A192326Inst Instance=new A192326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192327
{
public static readonly long[] Value={ 0L,3L,5L,7L,1L,1L,3L,3L,5L,9L,9L,13L,15L,15L,17L,21L,25L,25L,29L,31L,31L,35L,37L,41L,47L,49L,49L,51L,51L,53L,3L,3L,5L,3L,9L,7L,9L,11L,11L,13L,15L,13L,19L,17L,17L,15L,23L,31L,31L,29L,29L,31L,29L,35L,37L,39L,41L,39L,41L,41L,39L,45L,55L,55L,53L,53L,63L,65L,71L,69L,69L,71L,75L,77L,79L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192327Inst : IEnumerable<long>
{
public static readonly long[] Value=A192327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192327.Bytes);
public long this[int i]=>Value[i];

public static A192327Inst Instance=new A192327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192328
{
public static readonly long[] Value={ 27L,147L,507L,867L,1587L,2187L,3267L,4107L,5547L,6627L,8427L,9747L,11907L,13467L,15987L,17787L,20667L,22707L,25947L,28227L,31827L,34347L,38307L,41067L,45387L,48387L,53067L,56307L,61347L,64827L,70227L,73947L,79707L,83667L,89787L,93987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192328Inst : IEnumerable<long>
{
public static readonly long[] Value=A192328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192328.Bytes);
public long this[int i]=>Value[i];

public static A192328Inst Instance=new A192328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192329
{
public static readonly long[] Value={ 1L,-2L,-1L,6L,-7L,-2L,20L,-24L,-8L,56L,-61L,-18L,137L,-150L,-46L,312L,-327L,-94L,663L,-690L,-199L,1342L,-1366L,-384L,2603L,-2632L,-739L,4884L,-4869L,-1344L,8890L,-8808L,-2422L,15784L,-15487L,-4212L,27389L,-26728L,-7242L,46608L,-45155L,-12136L,77888L,-75102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192329Inst : IEnumerable<long>
{
public static readonly long[] Value=A192329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192329.Bytes);
public long this[int i]=>Value[i];

public static A192329Inst Instance=new A192329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192330
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,6L,5L,11L,3L,13L,7L,10L,2L,17L,6L,19L,5L,14L,11L,23L,3L,20L,13L,15L,7L,29L,10L,31L,2L,22L,17L,28L,6L,37L,19L,26L,5L,41L,14L,43L,11L,25L,23L,47L,3L,42L,20L,34L,13L,53L,15L,44L,7L,38L,29L,59L,10L,61L,31L,35L,2L,52L,22L,67L,17L,46L,28L,71L,6L,73L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192330Inst : IEnumerable<long>
{
public static readonly long[] Value=A192330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192330.Bytes);
public long this[int i]=>Value[i];

public static A192330Inst Instance=new A192330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192331
{
public static readonly long[] Value={ 0L,1L,4L,12L,57L,567L,7375L,140117L,4140556L,183075048L,11961299512L,1168852060539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192331Inst : IEnumerable<long>
{
public static readonly long[] Value=A192331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192331.Bytes);
public long this[int i]=>Value[i];

public static A192331Inst Instance=new A192331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192396
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,2L,1L,0L,0L,4L,4L,2L,0L,0L,8L,13L,8L,2L,0L,0L,16L,40L,32L,12L,3L,0L,0L,32L,121L,128L,62L,18L,3L,0L,0L,64L,364L,512L,312L,108L,24L,4L,0L,0L,128L,1093L,2048L,1562L,648L,171L,32L,4L,0L,0L,256L,3280L,8192L,7812L,3888L,1200L,256L,40L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192396Inst : IEnumerable<long>
{
public static readonly long[] Value=A192396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192396.Bytes);
public long this[int i]=>Value[i];

public static A192396Inst Instance=new A192396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192397
{
public static readonly BigInteger[] Value={ 2L,5L,31L,283L,743L,1600069L,60042893L,7438489991L,61215157711L,34041259347101651L,6564253087266573169L,BigInteger.Parse("22022174223585405703"),BigInteger.Parse("69454092876521107983605569601"),BigInteger.Parse("2360926164108571968813424783598971267"),BigInteger.Parse("462605180698333957063188362720170172617217"),BigInteger.Parse("14645575916792712592989131451003587034531413111"),BigInteger.Parse("214236369415820799335832514547376967536187180963") };
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
public class A192397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192397Inst Instance=new A192397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192398
{
public static readonly long[] Value={ 1L,34L,153L,436L,985L,1926L,3409L,5608L,8721L,12970L,18601L,25884L,35113L,46606L,60705L,77776L,98209L,122418L,150841L,183940L,222201L,266134L,316273L,373176L,437425L,509626L,590409L,680428L,780361L,890910L,1012801L,1146784L,1293633L,1454146L,1629145L,1819476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192398Inst : IEnumerable<long>
{
public static readonly long[] Value=A192398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192398.Bytes);
public long this[int i]=>Value[i];

public static A192398Inst Instance=new A192398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192399
{
public static readonly long[] Value={ 1L,1L,3L,11L,48L,233L,1218L,6722L,38668L,229864L,1403618L,8766186L,55818141L,361499355L,2376956264L,15845876429L,106988044753L,731026642533L,5051920683481L,35296182297157L,249249589433312L,1778775804736254L,12828718640894604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192399Inst : IEnumerable<long>
{
public static readonly long[] Value=A192399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192399.Bytes);
public long this[int i]=>Value[i];

public static A192399Inst Instance=new A192399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192400
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,26L,64L,158L,399L,1027L,2675L,7052L,18788L,50487L,136711L,372687L,1021942L,2816873L,7800510L,21691134L,60543553L,169561453L,476351239L,1342002198L,3790565335L,10732246631L,30453309502L,86589559266L,246672752090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192400Inst : IEnumerable<long>
{
public static readonly long[] Value=A192400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192400.Bytes);
public long this[int i]=>Value[i];

public static A192400Inst Instance=new A192400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192401
{
public static readonly long[] Value={ 1L,1L,2L,6L,16L,49L,156L,512L,1728L,5959L,20886L,74204L,266624L,967141L,3536814L,13025478L,48266972L,179831935L,673258626L,2531481990L,9555606112L,36196916933L,137554950152L,524265889839L,2003513188296L,7675473295796L,29471911733772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192401Inst : IEnumerable<long>
{
public static readonly long[] Value=A192401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192401.Bytes);
public long this[int i]=>Value[i];

public static A192401Inst Instance=new A192401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192402
{
public static readonly long[] Value={ 1L,2L,8L,34L,140L,586L,2476L,10522L,45048L,194210L,842672L,3678946L,16155140L,71328210L,316536532L,1411398138L,6321140080L,28426660498L,128325523272L,581349815466L,2642337533500L,12046547596514L,55076433751372L,252470682559914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192402Inst : IEnumerable<long>
{
public static readonly long[] Value=A192402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192402.Bytes);
public long this[int i]=>Value[i];

public static A192402Inst Instance=new A192402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192403
{
public static readonly long[] Value={ 1L,2L,6L,26L,106L,474L,2210L,10638L,52578L,265286L,1360702L,7074030L,37191694L,197398394L,1056255758L,5691813546L,30860701490L,168236407482L,921576598970L,5070138584230L,28002574339634L,155204886300414L,862985636296302L,4812513873922710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192403Inst : IEnumerable<long>
{
public static readonly long[] Value=A192403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192403.Bytes);
public long this[int i]=>Value[i];

public static A192403Inst Instance=new A192403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192404
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,5L,1L,1L,7L,14L,10L,1L,1L,11L,31L,38L,17L,1L,1L,16L,61L,114L,91L,26L,1L,1L,22L,111L,291L,357L,196L,37L,1L,1L,29L,190L,656L,1131L,971L,384L,50L,1L,1L,37L,309L,1345L,3092L,3771L,2367L,694L,65L,1L,1L,46L,481L,2563L,7575L,12393L,11150L,5286L,1173L,82L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192404Inst : IEnumerable<long>
{
public static readonly long[] Value=A192404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192404.Bytes);
public long this[int i]=>Value[i];

public static A192404Inst Instance=new A192404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192405
{
public static readonly long[] Value={ 1L,0L,1L,2L,4L,11L,33L,99L,310L,1016L,3413L,11682L,40751L,144476L,519013L,1886311L,6928012L,25684055L,96020957L,361742039L,1372442092L,5241062187L,20136335035L,77806111700L,302259125863L,1180207733657L,4630733662020L,18254415188073L,72283753111667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192405Inst : IEnumerable<long>
{
public static readonly long[] Value=A192405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192405.Bytes);
public long this[int i]=>Value[i];

public static A192405Inst Instance=new A192405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192406
{
public static readonly BigInteger[] Value={ 1L,1L,2L,14L,114L,1131L,12393L,146712L,1838094L,24088842L,327526513L,4593918125L,66198455671L,977113573208L,14741071612583L,226941948201964L,3561383719180100L,56926946565867437L,926444637518092848L,15347533201937448776UL,BigInteger.Parse("258809102457332568964") };
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
public class A192406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192406Inst Instance=new A192406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192407
{
public static readonly BigInteger[] Value={ 1L,4L,31L,291L,3092L,35839L,441925L,5721008L,77009425L,1071034612L,15319883964L,224628789200L,3368096726910L,51552652046550L,804490751228163L,12788591015038781L,206977224029107906L,3409582505289727239L,BigInteger.Parse("57165456138722305360") };
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
public class A192407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192407Inst Instance=new A192407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192408
{
public static readonly long[] Value={ 2L,6L,4L,9L,3L,2L,0L,8L,4L,6L,0L,2L,7L,7L,6L,8L,6L,2L,4L,3L,4L,1L,1L,6L,4L,9L,4L,7L,6L,2L,5L,7L,1L,0L,6L,8L,6L,5L,0L,1L,9L,0L,0L,6L,6L,0L,4L,1L,3L,6L,4L,4L,5L,2L,8L,7L,8L,7L,4L,4L,8L,9L,3L,2L,9L,2L,0L,9L,0L,2L,5L,0L,8L,7L,0L,6L,8L,8L,6L,3L,8L,9L,7L,2L,7L,3L,4L,9L,8L,5L,2L,3L,3L,7L,4L,6L,1L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192408Inst : IEnumerable<long>
{
public static readonly long[] Value=A192408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192408.Bytes);
public long this[int i]=>Value[i];

public static A192408Inst Instance=new A192408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192409
{
public static readonly long[] Value={ 8L,6L,7L,9L,5L,6L,7L,6L,8L,4L,6L,9L,9L,7L,10L,6L,8L,5L,9L,7L,8L,8L,8L,8L,9L,4L,6L,6L,6L,4L,7L,8L,7L,8L,8L,7L,8L,9L,7L,9L,7L,10L,10L,9L,7L,9L,6L,7L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192409Inst : IEnumerable<long>
{
public static readonly long[] Value=A192409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192409.Bytes);
public long this[int i]=>Value[i];

public static A192409Inst Instance=new A192409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192410
{
public static readonly BigInteger[] Value={ 2L,7L,29L,233L,2633L,47964L,1366601L,60548441L,4211296215L,457475364179L,77746107574743L,20666091342409561L,8591093418358446624L,BigInteger.Parse("5585965082182153010189"),BigInteger.Parse("5680505056847709316390907") };
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
public class A192410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192410Inst Instance=new A192410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192411
{
public static readonly BigInteger[] Value={ 2L,8L,48L,537L,10457L,350996L,20588719L,2097220139L,371447058811L,114409134039376L,61266947593618202L,BigInteger.Parse("57047805341101073322"),BigInteger.Parse("92361175252476980554309"),BigInteger.Parse("260002156555728478882116533") };
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
public class A192411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192411Inst Instance=new A192411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193004
{
public static readonly long[] Value={ 1L,1L,9L,29L,75L,165L,331L,623L,1123L,1963L,3357L,5651L,9405L,15525L,25477L,41633L,67831L,110281L,179031L,290339L,470511L,762111L,1234009L,1997639L,3233305L,5232745L,8468001L,13702853L,22173123L,35878413L,58054147L,93935351L,151992475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193004Inst : IEnumerable<long>
{
public static readonly long[] Value=A193004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193004.Bytes);
public long this[int i]=>Value[i];

public static A193004Inst Instance=new A193004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193005
{
public static readonly long[] Value={ 0L,1L,2L,11L,40L,115L,280L,611L,1234L,2357L,4320L,7677L,13328L,22733L,38258L,63735L,105368L,173199L,283480L,462511L,752850L,1223361L,1985472L,3219481L,5217120L,8450425L,13683170L,22151171L,35854024L,58027147L,93905560L,151959707L,245895058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193005Inst : IEnumerable<long>
{
public static readonly long[] Value=A193005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193005.Bytes);
public long this[int i]=>Value[i];

public static A193005Inst Instance=new A193005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193006
{
public static readonly long[] Value={ 1L,0L,8L,27L,72L,160L,323L,610L,1102L,1929L,3302L,5562L,9261L,15292L,25100L,41023L,66844L,108684L,176447L,286158L,463746L,751165L,1216298L,1968982L,3186937L,5157720L,8346608L,13506435L,21855312L,35364184L,57222107L,92589082L,149814166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193006Inst : IEnumerable<long>
{
public static readonly long[] Value=A193006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193006.Bytes);
public long this[int i]=>Value[i];

public static A193006Inst Instance=new A193006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193007
{
public static readonly long[] Value={ 0L,1L,1L,9L,36L,108L,268L,591L,1201L,2303L,4232L,7534L,13096L,22357L,37649L,62749L,103772L,170616L,279300L,455747L,741905L,1205651L,1956816L,3173114L,5142096L,8329033L,13486753L,21833361L,35339796L,57195108L,92559292L,149781399L,242370481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193007Inst : IEnumerable<long>
{
public static readonly long[] Value=A193007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193007.Bytes);
public long this[int i]=>Value[i];

public static A193007Inst Instance=new A193007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193008
{
public static readonly long[] Value={ 1L,2L,10L,31L,78L,170L,339L,636L,1144L,1997L,3412L,5740L,9549L,15758L,25854L,42243L,68818L,111878L,181615L,294520L,477276L,773057L,1251720L,2026296L,3279673L,5307770L,8589394L,13899271L,22490934L,36392642L,58886187L,95281620L,154170784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193008Inst : IEnumerable<long>
{
public static readonly long[] Value=A193008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193008.Bytes);
public long this[int i]=>Value[i];

public static A193008Inst Instance=new A193008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193009
{
public static readonly long[] Value={ 1L,2L,0L,0L,6L,2L,2L,0L,0L,3L,9L,6L,9L,0L,5L,8L,5L,2L,1L,0L,0L,7L,3L,9L,7L,6L,5L,9L,0L,4L,3L,8L,7L,8L,2L,6L,7L,1L,7L,8L,0L,5L,5L,0L,0L,2L,6L,3L,9L,4L,8L,2L,1L,8L,6L,6L,5L,1L,2L,1L,9L,2L,1L,0L,4L,2L,7L,7L,3L,8L,0L,7L,9L,4L,3L,8L,0L,8L,3L,4L,8L,6L,2L,5L,3L,9L,2L,5L,3L,7L,1L,6L,6L,4L,3L,8L,8L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193009Inst : IEnumerable<long>
{
public static readonly long[] Value=A193009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193009.Bytes);
public long this[int i]=>Value[i];

public static A193009Inst Instance=new A193009Inst();

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