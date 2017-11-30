using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A122841
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122841Inst : IEnumerable<long>
{
public static readonly long[] Value=A122841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122841.Bytes);
public long this[int i]=>Value[i];

public static A122841Inst Instance=new A122841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122842
{
public static readonly long[] Value={ 1L,3L,9L,27L,15L,243L,729L,45L,6561L,19683L,135L,177147L,225L,105L,4782969L,14348907L,1215L,675L,387420489L,3645L,3486784401L,10460353203L,315L,94143178827L,3375L,32805L,2541865828329L,6075L,98415L,68630377364883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122842Inst : IEnumerable<long>
{
public static readonly long[] Value=A122842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122842.Bytes);
public long this[int i]=>Value[i];

public static A122842Inst Instance=new A122842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122843
{
public static readonly long[] Value={ 1L,2L,1L,7L,4L,1L,32L,21L,6L,1L,180L,130L,41L,8L,1L,1200L,930L,312L,67L,10L,1L,9240L,7560L,2646L,602L,99L,12L,1L,80640L,68880L,24864L,5880L,1024L,137L,14L,1L,786240L,695520L,257040L,62496L,11304L,1602L,181L,16L,1L,8467200L,7711200L,2903040L,720720L,133920L,19710L,2360L,231L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122843Inst : IEnumerable<long>
{
public static readonly long[] Value=A122843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122843.Bytes);
public long this[int i]=>Value[i];

public static A122843Inst Instance=new A122843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122844
{
public static readonly long[] Value={ 1L,3L,1L,12L,5L,1L,60L,28L,7L,1L,360L,180L,50L,9L,1L,2520L,1320L,390L,78L,11L,1L,20160L,10920L,3360L,714L,112L,13L,1L,181440L,100800L,31920L,7056L,1176L,152L,15L,1L,1814400L,1028160L,332640L,75600L,13104L,1800L,198L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122844Inst : IEnumerable<long>
{
public static readonly long[] Value=A122844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122844.Bytes);
public long this[int i]=>Value[i];

public static A122844Inst Instance=new A122844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122845
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,3L,0L,5L,5L,5L,3L,3L,3L,7L,3L,3L,3L,3L,5L,3L,3L,0L,5L,5L,5L,7L,5L,5L,3L,3L,3L,7L,3L,3L,7L,3L,3L,3L,3L,5L,3L,3L,5L,3L,3L,0L,5L,5L,5L,7L,5L,5L,7L,5L,5L,3L,3L,3L,7L,3L,3L,7L,3L,3L,7L,3L,0L,5L,5L,5L,11L,5L,5L,17L,5L,5L,23L,5L,0L,0L,7L,7L,7L,11L,7L,7L,11L,7L,7L,11L,7L,3L,3L,3L,0L,3L,3L,13L,3L,3L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122845Inst : IEnumerable<long>
{
public static readonly long[] Value=A122845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122845.Bytes);
public long this[int i]=>Value[i];

public static A122845Inst Instance=new A122845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122846
{
public static readonly long[] Value={ 1L,9L,4L,36L,16L,9L,81L,4L,64L,35L,36L,49L,16L,25L,144L,15L,9L,16L,100L,81L,49L,4L,64L,35L,36L,196L,16L,15L,25L,49L,25L,144L,9L,60L,9L,100L,64L,100L,121L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122846Inst : IEnumerable<long>
{
public static readonly long[] Value=A122846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122846.Bytes);
public long this[int i]=>Value[i];

public static A122846Inst Instance=new A122846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122847
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,9L,14L,31L,43L,69L,76L,118L,141L,206L,235L,280L,331L,440L,493L,637L,704L,829L,926L,1152L,1247L,1470L,1613L,1841L,1996L,2375L,2494L,2932L,3144L,3428L,3656L,4032L,4216L,4824L,5122L,5544L,5820L,6582L,6802L,7647L,8000L,8451L,8870L,9850L,10159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122847Inst : IEnumerable<long>
{
public static readonly long[] Value=A122847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122847.Bytes);
public long this[int i]=>Value[i];

public static A122847Inst Instance=new A122847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122848
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,3L,1L,0L,0L,3L,6L,1L,0L,0L,0L,15L,10L,1L,0L,0L,0L,15L,45L,15L,1L,0L,0L,0L,0L,105L,105L,21L,1L,0L,0L,0L,0L,105L,420L,210L,28L,1L,0L,0L,0L,0L,0L,945L,1260L,378L,36L,1L,0L,0L,0L,0L,0L,945L,4725L,3150L,630L,45L,1L,0L,0L,0L,0L,0L,0L,10395L,17325L,6930L,990L,55L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122848Inst : IEnumerable<long>
{
public static readonly long[] Value=A122848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122848.Bytes);
public long this[int i]=>Value[i];

public static A122848Inst Instance=new A122848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122849
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,3L,4L,6L,16L,25L,46L,120L,211L,441L,1156L,2233L,5104L,13581L,28351L,69345L,188101L,419320L,1082566L,2998776L,7074211L,19099158L,54057004L,133993951L,375814531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122849Inst : IEnumerable<long>
{
public static readonly long[] Value=A122849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122849.Bytes);
public long this[int i]=>Value[i];

public static A122849Inst Instance=new A122849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122850
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,3L,-3L,1L,0L,-15L,15L,-6L,1L,0L,105L,-105L,45L,-10L,1L,0L,-945L,945L,-420L,105L,-15L,1L,0L,10395L,-10395L,4725L,-1260L,210L,-21L,1L,0L,-135135L,135135L,-62370L,17325L,-3150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122850Inst : IEnumerable<long>
{
public static readonly long[] Value=A122850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122850.Bytes);
public long this[int i]=>Value[i];

public static A122850Inst Instance=new A122850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122851
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,2L,1L,0L,0L,2L,3L,1L,0L,0L,0L,6L,4L,1L,0L,0L,0L,6L,12L,5L,1L,0L,0L,0L,0L,24L,20L,6L,1L,0L,0L,0L,0L,24L,60L,30L,7L,1L,0L,0L,0L,0L,0L,120L,120L,42L,8L,1L,0L,0L,0L,0L,0L,120L,360L,210L,56L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122851Inst : IEnumerable<long>
{
public static readonly long[] Value=A122851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122851.Bytes);
public long this[int i]=>Value[i];

public static A122851Inst Instance=new A122851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122852
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,11L,24L,51L,122L,291L,756L,1979L,5526L,15627L,46496L,140451L,442194L,1414931L,4687212L,15785451L,54764846L,193129659L,698978136L,2570480147L,9672977706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122852Inst : IEnumerable<long>
{
public static readonly long[] Value=A122852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122852.Bytes);
public long this[int i]=>Value[i];

public static A122852Inst Instance=new A122852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122853
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,109L,509L,661L,709L,1231L,12889L,13043L,26723L,43963L,44789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122853Inst : IEnumerable<long>
{
public static readonly long[] Value=A122853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122853.Bytes);
public long this[int i]=>Value[i];

public static A122853Inst Instance=new A122853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122854
{
public static readonly long[] Value={ 1L,8L,26L,48L,73L,120L,170L,208L,290L,360L,384L,528L,651L,656L,842L,960L,960L,1248L,1370L,1360L,1682L,1848L,1898L,2208L,2353L,2320L,2810L,3120L,2880L,3480L,3722L,3504L,4420L,4488L,4224L,5040L,5330L,5208L,5760L,6240L,5905L,6888L,7540L,6736L,7922L,8160L,7680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122854Inst : IEnumerable<long>
{
public static readonly long[] Value=A122854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122854.Bytes);
public long this[int i]=>Value[i];

public static A122854Inst Instance=new A122854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122855
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,1L,3L,2L,0L,2L,1L,0L,0L,2L,2L,1L,0L,1L,0L,0L,0L,2L,4L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,2L,3L,1L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,1L,2L,0L,0L,5L,0L,0L,0L,2L,2L,0L,0L,2L,0L,0L,1L,2L,0L,0L,2L,3L,1L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,2L,2L,0L,2L,4L,0L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122855Inst : IEnumerable<long>
{
public static readonly long[] Value=A122855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122855.Bytes);
public long this[int i]=>Value[i];

public static A122855Inst Instance=new A122855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122856
{
public static readonly long[] Value={ 1L,2L,1L,0L,0L,2L,2L,0L,2L,2L,1L,0L,0L,2L,0L,0L,3L,2L,0L,0L,0L,4L,2L,0L,2L,0L,2L,0L,0L,2L,0L,0L,1L,2L,2L,0L,0L,2L,2L,0L,2L,4L,1L,0L,0L,2L,0L,0L,2L,2L,0L,0L,0L,0L,2L,0L,4L,2L,0L,0L,0L,4L,0L,0L,2L,2L,3L,0L,0L,0L,2L,0L,2L,4L,0L,0L,0L,2L,0L,0L,1L,2L,0L,0L,0L,2L,4L,0L,0L,2L,2L,0L,0L,2L,0L,0L,4L,2L,2L,0L,0L,4L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122856Inst : IEnumerable<long>
{
public static readonly long[] Value=A122856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122856.Bytes);
public long this[int i]=>Value[i];

public static A122856Inst Instance=new A122856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122857
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,0L,2L,2L,4L,0L,2L,4L,0L,4L,2L,4L,2L,0L,4L,0L,0L,0L,2L,6L,4L,2L,0L,4L,4L,0L,2L,0L,4L,0L,2L,4L,0L,4L,4L,4L,0L,0L,0L,4L,0L,0L,2L,2L,6L,4L,4L,4L,2L,0L,0L,0L,4L,0L,4L,4L,0L,0L,2L,8L,0L,0L,4L,0L,0L,0L,2L,4L,4L,6L,0L,0L,4L,0L,4L,2L,4L,0L,0L,8L,0L,4L,0L,4L,4L,0L,0L,0L,0L,0L,2L,4L,2L,0L,6L,4L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122857Inst : IEnumerable<long>
{
public static readonly long[] Value=A122857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122857.Bytes);
public long this[int i]=>Value[i];

public static A122857Inst Instance=new A122857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122858
{
public static readonly long[] Value={ 1L,8L,-8L,32L,-40L,48L,-32L,64L,-104L,104L,-48L,96L,-160L,112L,-64L,192L,-232L,144L,-104L,160L,-240L,256L,-96L,192L,-416L,248L,-112L,320L,-320L,240L,-192L,256L,-488L,384L,-144L,384L,-520L,304L,-160L,448L,-624L,336L,-256L,352L,-480L,624L,-192L,384L,-928L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122858Inst : IEnumerable<long>
{
public static readonly long[] Value=A122858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122858.Bytes);
public long this[int i]=>Value[i];

public static A122858Inst Instance=new A122858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122859
{
public static readonly long[] Value={ 1L,-6L,12L,-6L,-6L,0L,12L,-12L,12L,-6L,0L,0L,-6L,-12L,24L,0L,-6L,0L,12L,-12L,0L,-12L,0L,0L,12L,-6L,24L,-6L,-12L,0L,0L,-12L,12L,0L,0L,0L,-6L,-12L,24L,-12L,0L,0L,24L,-12L,0L,0L,0L,0L,-6L,-18L,12L,0L,-12L,0L,12L,0L,24L,-12L,0L,0L,0L,-12L,24L,-12L,-6L,0L,0L,-12L,0L,0L,0L,0L,12L,-12L,24L,-6L,-12L,0L,24L,-12L,0L,-6L,0L,0L,-12L,0L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122859Inst : IEnumerable<long>
{
public static readonly long[] Value=A122859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122859.Bytes);
public long this[int i]=>Value[i];

public static A122859Inst Instance=new A122859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122860
{
public static readonly long[] Value={ 1L,-2L,1L,1L,0L,-2L,2L,-2L,1L,0L,0L,1L,2L,-4L,0L,1L,0L,-2L,2L,0L,2L,0L,0L,-2L,1L,-4L,1L,2L,0L,0L,2L,-2L,0L,0L,0L,1L,2L,-4L,2L,0L,0L,-4L,2L,0L,0L,0L,0L,1L,3L,-2L,0L,2L,0L,-2L,0L,-4L,2L,0L,0L,0L,2L,-4L,2L,1L,0L,0L,2L,0L,0L,0L,0L,-2L,2L,-4L,1L,2L,0L,-4L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122860Inst : IEnumerable<long>
{
public static readonly long[] Value=A122860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122860.Bytes);
public long this[int i]=>Value[i];

public static A122860Inst Instance=new A122860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122861
{
public static readonly long[] Value={ 1L,-3L,2L,0L,2L,-3L,2L,0L,1L,-6L,2L,0L,2L,0L,2L,0L,3L,-6L,0L,0L,2L,-3L,2L,0L,2L,-6L,2L,0L,0L,0L,4L,0L,2L,-3L,2L,0L,2L,-6L,0L,0L,1L,-6L,2L,0L,4L,0L,2L,0L,0L,-6L,2L,0L,2L,0L,2L,0L,3L,-6L,2L,0L,2L,0L,0L,0L,2L,-9L,2L,0L,0L,-6L,2L,0L,4L,0L,2L,0L,2L,0L,0L,0L,2L,-6L,4L,0L,0L,-3L,4L,0L,0L,-6L,2L,0L,2L,0L,2L,0L,1L,-6L,0L,0L,4L,-6L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122861Inst : IEnumerable<long>
{
public static readonly long[] Value=A122861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122861.Bytes);
public long this[int i]=>Value[i];

public static A122861Inst Instance=new A122861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122862
{
public static readonly long[] Value={ 2L,260L,650L,1928L,5768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122862Inst : IEnumerable<long>
{
public static readonly long[] Value=A122862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122862.Bytes);
public long this[int i]=>Value[i];

public static A122862Inst Instance=new A122862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122863
{
public static readonly long[] Value={ 1L,2L,6L,12L,24L,54L,108L,246L,510L,1218L,2742L,6930L,16242L,47706L,144018L,672732L,2756124L,5656266L,27943404L,75554226L,661653378L,1323306756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122863Inst : IEnumerable<long>
{
public static readonly long[] Value=A122863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122863.Bytes);
public long this[int i]=>Value[i];

public static A122863Inst Instance=new A122863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122864
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,0L,1L,-2L,2L,0L,2L,2L,0L,4L,1L,2L,-2L,0L,2L,0L,0L,0L,2L,3L,2L,2L,0L,2L,4L,0L,1L,0L,2L,0L,-2L,2L,0L,4L,2L,2L,0L,0L,0L,-4L,0L,0L,2L,1L,3L,4L,2L,2L,2L,0L,0L,0L,2L,0L,4L,2L,0L,0L,1L,4L,0L,0L,2L,0L,0L,0L,-2L,2L,2L,6L,0L,0L,4L,0L,2L,-2L,2L,0L,0L,4L,0L,4L,0L,2L,-4L,0L,0L,0L,0L,0L,2L,2L,1L,0L,3L,2L,4L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122864Inst : IEnumerable<long>
{
public static readonly long[] Value=A122864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122864.Bytes);
public long this[int i]=>Value[i];

public static A122864Inst Instance=new A122864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122865
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,1L,0L,0L,3L,0L,0L,2L,2L,2L,0L,0L,1L,2L,0L,2L,2L,1L,0L,0L,2L,0L,0L,2L,4L,0L,0L,0L,2L,3L,0L,2L,2L,0L,0L,0L,1L,0L,0L,4L,0L,2L,0L,0L,4L,2L,0L,0L,2L,2L,0L,0L,3L,0L,0L,2L,2L,0L,0L,0L,2L,1L,0L,2L,4L,2L,0L,0L,0L,0L,0L,2L,2L,2L,0L,0L,2L,2L,0L,4L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122865Inst : IEnumerable<long>
{
public static readonly long[] Value=A122865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122865.Bytes);
public long this[int i]=>Value[i];

public static A122865Inst Instance=new A122865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122866
{
public static readonly long[] Value={ 2L,3L,6L,4L,12L,10L,16L,12L,16L,24L,26L,24L,30L,28L,28L,44L,36L,42L,20L,38L,34L,54L,54L,56L,48L,44L,50L,52L,68L,56L,56L,60L,62L,66L,66L,70L,76L,84L,76L,58L,92L,90L,88L,90L,80L,88L,92L,102L,104L,102L,114L,104L,108L,98L,114L,108L,92L,100L,120L,126L,124L,130L,126L,142L,116L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122866Inst : IEnumerable<long>
{
public static readonly long[] Value=A122866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122866.Bytes);
public long this[int i]=>Value[i];

public static A122866Inst Instance=new A122866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122867
{
public static readonly long[] Value={ 2L,1L,1L,1L,3L,4L,2L,2L,2L,6L,1L,6L,6L,4L,10L,2L,2L,8L,8L,6L,8L,1L,4L,4L,4L,4L,12L,12L,4L,4L,6L,6L,14L,14L,8L,16L,3L,2L,2L,12L,12L,10L,10L,10L,14L,2L,2L,6L,6L,8L,8L,12L,12L,14L,24L,1L,6L,4L,10L,10L,10L,10L,20L,20L,18L,30L,2L,2L,12L,6L,8L,8L,14L,14L,18L,18L,22L,22L,1L,4L,4L,8L,8L,16L,16L,18L,18L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122867Inst : IEnumerable<long>
{
public static readonly long[] Value=A122867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122867.Bytes);
public long this[int i]=>Value[i];

public static A122867Inst Instance=new A122867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122868
{
public static readonly long[] Value={ 1L,3L,15L,81L,459L,2673L,15849L,95175L,576963L,3523257L,21640365L,133549155L,827418645L,5143397535L,32063180535L,200367960201L,1254816463923L,7873205412825L,49482344889261L,311457546052659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122868Inst : IEnumerable<long>
{
public static readonly long[] Value=A122868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122868.Bytes);
public long this[int i]=>Value[i];

public static A122868Inst Instance=new A122868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122869
{
public static readonly long[] Value={ 11L,19L,31L,59L,71L,79L,131L,139L,151L,179L,191L,199L,211L,239L,251L,271L,311L,331L,359L,379L,419L,431L,439L,479L,491L,499L,571L,599L,619L,631L,659L,691L,719L,739L,751L,811L,839L,859L,911L,919L,971L,991L,1019L,1031L,1039L,1051L,1091L,1151L,1171L,1231L,1259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122869Inst : IEnumerable<long>
{
public static readonly long[] Value=A122869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122869.Bytes);
public long this[int i]=>Value[i];

public static A122869Inst Instance=new A122869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122870
{
public static readonly long[] Value={ 3L,7L,23L,43L,47L,67L,83L,103L,107L,127L,163L,167L,223L,227L,263L,283L,307L,347L,367L,383L,443L,463L,467L,487L,503L,523L,547L,563L,587L,607L,643L,647L,683L,727L,743L,787L,823L,827L,863L,883L,887L,907L,947L,967L,983L,1063L,1087L,1103L,1123L,1163L,1187L,1223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122870Inst : IEnumerable<long>
{
public static readonly long[] Value=A122870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122870.Bytes);
public long this[int i]=>Value[i];

public static A122870Inst Instance=new A122870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122871
{
public static readonly long[] Value={ 1L,2L,7L,26L,106L,452L,1999L,9074L,42046L,198044L,945430L,4564100L,22243060L,109285256L,540738943L,2692103714L,13475973238L,67784600108L,342439638418L,1736727343436L,8839203054604L,45132514680248L,231121351433158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122871Inst : IEnumerable<long>
{
public static readonly long[] Value=A122871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122871.Bytes);
public long this[int i]=>Value[i];

public static A122871Inst Instance=new A122871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122872
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,5L,6L,4L,5L,8L,7L,8L,5L,6L,9L,12L,9L,10L,6L,7L,10L,13L,16L,11L,12L,7L,8L,11L,14L,17L,20L,13L,14L,8L,9L,16L,15L,18L,21L,24L,15L,16L,9L,10L,17L,24L,19L,22L,25L,28L,17L,18L,10L,11L,18L,25L,32L,23L,26L,29L,32L,19L,20L,11L,12L,19L,26L,33L,40L,27L,30L,33L,36L,21L,22L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122872Inst : IEnumerable<long>
{
public static readonly long[] Value=A122872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122872.Bytes);
public long this[int i]=>Value[i];

public static A122872Inst Instance=new A122872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122873
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,4L,0L,1L,3L,7L,0L,1L,6L,4L,2L,0L,1L,7L,3L,2L,14L,0L,1L,3L,11L,2L,6L,12L,0L,1L,4L,5L,2L,13L,7L,11L,0L,1L,10L,91L,2L,7L,28L,4L,20L,0L,1L,11L,111L,2L,5L,4L,24L,9L,3L,0L,1L,12L,5L,2L,4L,26L,9L,24L,3L,19L,0L,1L,5L,6L,2L,8L,19L,32L,10L,3L,11L,40L,0L,1L,14L,4L,2L,24L,9L,35L,28L,3L,6L,12L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122873Inst : IEnumerable<long>
{
public static readonly long[] Value=A122873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122873.Bytes);
public long this[int i]=>Value[i];

public static A122873Inst Instance=new A122873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122874
{
public static readonly long[] Value={ 7L,13L,8L,12L,9L,11L,10L,10L,11L,9L,12L,8L,13L,7L,14L,6L,15L,5L,16L,4L,17L,3L,18L,2L,19L,1L,20L,0L,21L,-1L,22L,-2L,23L,-3L,24L,-4L,25L,-5L,26L,-6L,27L,-7L,28L,-8L,29L,-9L,30L,-10L,31L,-11L,32L,-12L,33L,-13L,34L,-14L,35L,-15L,36L,-16L,37L,-17L,38L,-18L,39L,-19L,40L,-20L,41L,-21L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122874Inst : IEnumerable<long>
{
public static readonly long[] Value=A122874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122874.Bytes);
public long this[int i]=>Value[i];

public static A122874Inst Instance=new A122874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122875
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,26L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122875Inst : IEnumerable<long>
{
public static readonly long[] Value=A122875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122875.Bytes);
public long this[int i]=>Value[i];

public static A122875Inst Instance=new A122875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122876
{
public static readonly long[] Value={ 1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L,1L,2L,1L,-1L,-2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122876Inst : IEnumerable<long>
{
public static readonly long[] Value=A122876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122876.Bytes);
public long this[int i]=>Value[i];

public static A122876Inst Instance=new A122876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122877
{
public static readonly long[] Value={ 0L,1L,2L,7L,20L,65L,206L,679L,2248L,7569L,25690L,88055L,303964L,1056497L,3693158L,12977655L,45813008L,162400609L,577843890L,2063053991L,7388487460L,26535797729L,95552015614L,344897769991L,1247685613272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122877Inst : IEnumerable<long>
{
public static readonly long[] Value=A122877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122877.Bytes);
public long this[int i]=>Value[i];

public static A122877Inst Instance=new A122877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122878
{
public static readonly long[] Value={ 12L,12L,12L,12L,13L,13L,13L,23L,23L,23L,23L,12L,12L,12L,13L,13L,13L,13L,23L,23L,23L,12L,12L,12L,12L,13L,13L,13L,23L,23L,23L,23L,12L,12L,12L,13L,13L,13L,13L,23L,23L,23L,12L,12L,12L,12L,13L,13L,13L,23L,23L,23L,23L,12L,12L,12L,13L,13L,13L,13L,23L,23L,23L,12L,12L,12L,12L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122878Inst : IEnumerable<long>
{
public static readonly long[] Value=A122878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122878.Bytes);
public long this[int i]=>Value[i];

public static A122878Inst Instance=new A122878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122879
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122879Inst : IEnumerable<long>
{
public static readonly long[] Value=A122879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122879.Bytes);
public long this[int i]=>Value[i];

public static A122879Inst Instance=new A122879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122880
{
public static readonly long[] Value={ 0L,0L,0L,1L,8L,43L,196L,820L,3265L,12615L,47840L,179355L,667875L,2478022L,9180616L,34011401L,126120212L,468411235L,1743105373L,6500874434L,24300686879L,91049069203L,341924710480L,1286932932251L,4854167659403L,18346988061078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122880Inst : IEnumerable<long>
{
public static readonly long[] Value=A122880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122880.Bytes);
public long this[int i]=>Value[i];

public static A122880Inst Instance=new A122880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122881
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,5L,1L,2L,5L,13L,1L,2L,5L,14L,34L,1L,2L,5L,14L,42L,89L,1L,2L,5L,14L,42L,131L,233L,1L,2L,5L,14L,42L,132L,417L,610L,1L,2L,5L,14L,42L,132L,429L,1341L,1597L,1L,2L,5L,14L,42L,132L,429L,1429L,4334L,4181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122881Inst : IEnumerable<long>
{
public static readonly long[] Value=A122881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122881.Bytes);
public long this[int i]=>Value[i];

public static A122881Inst Instance=new A122881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122882
{
public static readonly long[] Value={ 1L,2L,6L,10L,6L,42L,60L,20L,28L,308L,390L,90L,70L,154L,2310L,2652L,468L,252L,308L,924L,17556L,18564L,2652L,1092L,924L,1540L,5852L,134596L,132600L,15912L,5304L,3432L,3960L,8360L,38456L,1038312L,961350L,99450L,27846L,14586L,12870L,18810L,48070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122882Inst : IEnumerable<long>
{
public static readonly long[] Value=A122882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122882.Bytes);
public long this[int i]=>Value[i];

public static A122882Inst Instance=new A122882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122883
{
public static readonly long[] Value={ 1L,3L,23L,123L,739L,4263L,24935L,145155L,846379L,4932351L,28749263L,167560155L,976617811L,5692134423L,33176213303L,193365096243L,1127014462459L,6568721481903L,38285314822175L,223143166664715L,1300573686738979L,7580298950623431L,44181220023293063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122883Inst : IEnumerable<long>
{
public static readonly long[] Value=A122883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122883.Bytes);
public long this[int i]=>Value[i];

public static A122883Inst Instance=new A122883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122884
{
public static readonly long[] Value={ 1L,7L,39L,231L,1339L,7819L,45543L,265503L,1547347L,9018835L,52565151L,306373095L,1785671371L,10407659227L,60660275799L,353554011951L,2060663763139L,12010428632419L,70001907900303L,408001019031543L,2378004205764667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122884Inst : IEnumerable<long>
{
public static readonly long[] Value=A122884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122884.Bytes);
public long this[int i]=>Value[i];

public static A122884Inst Instance=new A122884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122885
{
public static readonly long[] Value={ 1L,13L,61L,385L,2185L,12853L,74677L,435721L,2538625L,14798077L,86245741L,502684561L,2929845241L,17076419653L,99528607141L,580095354265L,3381043256305L,19706164707853L,114855943942237L,669429501042721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122885Inst : IEnumerable<long>
{
public static readonly long[] Value=A122885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122885.Bytes);
public long this[int i]=>Value[i];

public static A122885Inst Instance=new A122885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122886
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,3L,7L,13L,23L,39L,61L,123L,231L,385L,739L,1339L,2185L,4263L,7819L,12853L,24935L,45543L,74677L,145155L,265503L,435721L,846379L,1547347L,2538625L,4932351L,9018835L,14798077L,28749263L,52565151L,86245741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122886Inst : IEnumerable<long>
{
public static readonly long[] Value=A122886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122886.Bytes);
public long this[int i]=>Value[i];

public static A122886Inst Instance=new A122886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122887
{
public static readonly BigInteger[] Value={ 1L,10L,118L,1656L,27326L,520626L,11271436L,273613032L,7365210840L,217823497200L,7022714928604L,245186433880584L,9217032342988575L,371216529334562246L,15948164256621353088UL,BigInteger.Parse("728062466187371268960"),BigInteger.Parse("35197679178007576031784") };
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
public class A122887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122887Inst Instance=new A122887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122888
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,3L,6L,9L,10L,8L,4L,1L,1L,4L,12L,30L,64L,118L,188L,258L,302L,298L,244L,162L,84L,32L,8L,1L,1L,5L,20L,70L,220L,630L,1656L,4014L,8994L,18654L,35832L,63750L,105024L,160120L,225696L,293685L,352074L,387820L,391232L,359992L,300664L,226580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122888Inst : IEnumerable<long>
{
public static readonly long[] Value=A122888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122888.Bytes);
public long this[int i]=>Value[i];

public static A122888Inst Instance=new A122888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122889
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,12L,27L,67L,180L,528L,1676L,5721L,20924L,81634L,338322L,1484209L,6870492L,33460830L,170997842L,914764494L,5111445917L,29773148141L,180449216699L,1136060712131L,7418026238304L,50163775035664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122889Inst : IEnumerable<long>
{
public static readonly long[] Value=A122889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122889.Bytes);
public long this[int i]=>Value[i];

public static A122889Inst Instance=new A122889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122890
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,1L,5L,0L,0L,0L,10L,14L,0L,0L,0L,8L,70L,42L,0L,0L,0L,4L,160L,424L,132L,0L,0L,0L,1L,250L,1978L,2382L,429L,0L,0L,0L,0L,302L,6276L,19508L,12804L,1430L,0L,0L,0L,0L,298L,15674L,106492L,168608L,66946L,4862L,0L,0L,0L,0L,244L,33148L,451948L,1445208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122890Inst : IEnumerable<long>
{
public static readonly long[] Value=A122890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122890.Bytes);
public long this[int i]=>Value[i];

public static A122890Inst Instance=new A122890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122891
{
public static readonly BigInteger[] Value={ 1L,1L,3L,28L,1625L,3247268L,10649997137454L,BigInteger.Parse("113423713055030979289411081"),BigInteger.Parse("12864938683278671740537137672878980378983810317967737") };
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
public class A122891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122891Inst Instance=new A122891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122892
{
public static readonly long[] Value={ 1L,10L,70L,424L,2382L,12804L,66946L,343772L,1744314L,8780912L,43976688L,219546976L,1094132461L,5448766458L,27135655714L,135218356264L,674461583180L,3368432133000L,16847360404260L,84396523333080L,423485559461250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122892Inst : IEnumerable<long>
{
public static readonly long[] Value=A122892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122892.Bytes);
public long this[int i]=>Value[i];

public static A122892Inst Instance=new A122892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122893
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,19L,37L,74L,147L,294L,587L,1175L,2349L,4698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122893Inst : IEnumerable<long>
{
public static readonly long[] Value=A122893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122893.Bytes);
public long this[int i]=>Value[i];

public static A122893Inst Instance=new A122893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122894
{
public static readonly BigInteger[] Value={ 1L,2L,9L,258L,293685L,531124770570L,BigInteger.Parse("2439717292075827330588969"),BigInteger.Parse("72554628124279239546273779187960042205300343234178") };
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
public class A122894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122894Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122894.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122894Inst Instance=new A122894Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122895
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122895Inst : IEnumerable<long>
{
public static readonly long[] Value=A122895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122895.Bytes);
public long this[int i]=>Value[i];

public static A122895Inst Instance=new A122895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122896
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,4L,5L,3L,1L,0L,9L,12L,9L,4L,1L,0L,21L,30L,25L,14L,5L,1L,0L,51L,76L,69L,44L,20L,6L,1L,0L,127L,196L,189L,133L,70L,27L,7L,1L,0L,323L,512L,518L,392L,230L,104L,35L,8L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122896Inst : IEnumerable<long>
{
public static readonly long[] Value=A122896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122896.Bytes);
public long this[int i]=>Value[i];

public static A122896Inst Instance=new A122896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122897
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,8L,5L,1L,1L,22L,19L,7L,1L,1L,64L,67L,34L,9L,1L,1L,196L,232L,144L,53L,11L,1L,1L,625L,804L,573L,261L,76L,13L,1L,1L,2055L,2806L,2211L,1171L,426L,103L,15L,1L,1L,6917L,9878L,8399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122897Inst : IEnumerable<long>
{
public static readonly long[] Value=A122897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122897.Bytes);
public long this[int i]=>Value[i];

public static A122897Inst Instance=new A122897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122898
{
public static readonly long[] Value={ 1L,6L,37L,233L,1491L,9660L,63195L,416610L,2763595L,18426026L,123375927L,829053197L,5588050069L,37764371676L,255800207277L,1736181639585L,11804962371795L,80394249836010L,548283258074895L,3744067955618403L,25596986050620681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122898Inst : IEnumerable<long>
{
public static readonly long[] Value=A122898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122898.Bytes);
public long this[int i]=>Value[i];

public static A122898Inst Instance=new A122898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122899
{
public static readonly long[] Value={ 1L,1L,1L,0L,4L,1L,0L,3L,9L,1L,0L,0L,18L,16L,1L,0L,0L,10L,60L,25L,1L,0L,0L,0L,80L,150L,36L,1L,0L,0L,0L,35L,350L,315L,49L,1L,0L,0L,0L,0L,350L,1120L,588L,64L,1L,0L,0L,0L,0L,126L,1890L,2940L,1008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122899Inst : IEnumerable<long>
{
public static readonly long[] Value=A122899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122899.Bytes);
public long this[int i]=>Value[i];

public static A122899Inst Instance=new A122899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122900
{
public static readonly BigInteger[] Value={ 5L,13L,337L,41L,61L,3697L,113L,10657L,181L,BigInteger.Parse("2211377674535255285545615254209921"),1L,313L,66977L,421L,1L,149057L,613L,1L,761L,1L,BigInteger.Parse("4441930186581050471617"),1013L,188386299457L,1201L,1301L,988417L,1146097L,1L,1741L,1861L,1972097L,2113L,2522257L };
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
public class A122900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122900Inst Instance=new A122900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122901
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,2L,1L,5L,0L,1L,2L,1L,0L,2L,1L,0L,1L,0L,4L,1L,3L,1L,1L,2L,2L,0L,1L,1L,2L,1L,2L,1L,1L,2L,2L,2L,1L,2L,4L,1L,2L,0L,4L,0L,1L,2L,0L,1L,0L,0L,0L,2L,0L,4L,0L,0L,9L,1L,0L,0L,2L,0L,1L,3L,2L,2L,1L,1L,0L,1L,0L,2L,4L,3L,0L,2L,1L,4L,0L,1L,0L,1L,1L,8L,1L,2L,2L,1L,0L,0L,4L,0L,6L,4L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122901Inst : IEnumerable<long>
{
public static readonly long[] Value=A122901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122901.Bytes);
public long this[int i]=>Value[i];

public static A122901Inst Instance=new A122901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122902
{
public static readonly long[] Value={ 1L,3L,23L,21L,10L,95L,255L,86L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122902Inst : IEnumerable<long>
{
public static readonly long[] Value=A122902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122902.Bytes);
public long this[int i]=>Value[i];

public static A122902Inst Instance=new A122902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122903
{
public static readonly long[] Value={ 1L,3L,4L,12L,70L,90L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122903Inst : IEnumerable<long>
{
public static readonly long[] Value=A122903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122903.Bytes);
public long this[int i]=>Value[i];

public static A122903Inst Instance=new A122903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122904
{
public static readonly long[] Value={ 5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,20L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,45L,47L,48L,49L,51L,52L,53L,55L,56L,57L,59L,60L,61L,63L,64L,65L,67L,68L,69L,71L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,91L,92L,93L,95L,96L,97L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122904Inst : IEnumerable<long>
{
public static readonly long[] Value=A122904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122904.Bytes);
public long this[int i]=>Value[i];

public static A122904Inst Instance=new A122904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122905
{
public static readonly long[] Value={ 2L,6L,10L,14L,18L,22L,26L,30L,34L,38L,42L,46L,50L,54L,58L,62L,66L,74L,78L,82L,86L,94L,98L,102L,106L,114L,118L,122L,134L,138L,142L,146L,150L,158L,162L,166L,174L,178L,186L,194L,202L,206L,214L,218L,222L,226L,242L,246L,250L,254L,258L,262L,274L,278L,282L,294L,298L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122905Inst : IEnumerable<long>
{
public static readonly long[] Value=A122905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122905.Bytes);
public long this[int i]=>Value[i];

public static A122905Inst Instance=new A122905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122906
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,9L,11L,12L,13L,15L,16L,17L,19L,20L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,45L,47L,48L,49L,51L,52L,53L,55L,56L,57L,59L,60L,61L,63L,64L,65L,67L,68L,69L,70L,71L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122906Inst : IEnumerable<long>
{
public static readonly long[] Value=A122906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122906.Bytes);
public long this[int i]=>Value[i];

public static A122906Inst Instance=new A122906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122907
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,12L,14L,18L,22L,26L,30L,34L,38L,42L,46L,50L,54L,58L,62L,66L,70L,74L,78L,82L,86L,90L,94L,98L,102L,106L,114L,118L,122L,134L,138L,142L,146L,150L,158L,162L,166L,174L,178L,186L,194L,202L,206L,210L,214L,218L,222L,226L,242L,246L,250L,254L,258L,262L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122907Inst : IEnumerable<long>
{
public static readonly long[] Value=A122907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122907.Bytes);
public long this[int i]=>Value[i];

public static A122907Inst Instance=new A122907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122908
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,0L,0L,2L,3L,0L,0L,0L,3L,6L,0L,0L,0L,0L,6L,10L,0L,0L,0L,0L,0L,10L,20L,0L,0L,0L,0L,0L,0L,20L,35L,0L,0L,0L,0L,0L,0L,0L,35L,70L,0L,0L,0L,0L,0L,0L,0L,0L,70L,126L,0L,0L,0L,0L,0L,0L,0L,0L,0L,126L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122908Inst : IEnumerable<long>
{
public static readonly long[] Value=A122908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122908.Bytes);
public long this[int i]=>Value[i];

public static A122908Inst Instance=new A122908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122909
{
public static readonly long[] Value={ 1L,4L,19L,79L,338L,1427L,6053L,25628L,108583L,459931L,1948354L,8253271L,34961561L,148099316L,627359147L,2657535383L,11257501522L,47687540107L,202007664157L,855718193164L,3624880442591L,15355239954179L,65045840274434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122909Inst : IEnumerable<long>
{
public static readonly long[] Value=A122909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122909.Bytes);
public long this[int i]=>Value[i];

public static A122909Inst Instance=new A122909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122910
{
public static readonly long[] Value={ 1L,4L,45L,302L,2636L,20184L,165040L,1305952L,10504896L,83809664L,671394560L,5367485952L,42954566656L,343577810944L,2748857364480L,21989919383552L,175923113148416L,1407369872769024L,11259019111628800L,90071912374730752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122910Inst : IEnumerable<long>
{
public static readonly long[] Value=A122910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122910.Bytes);
public long this[int i]=>Value[i];

public static A122910Inst Instance=new A122910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122911
{
public static readonly long[] Value={ 1L,5L,139L,1645L,30506L,452860L,7520584L,118102640L,1907343136L,30375432640L,487141579904L,7785180808960L,124635539862016L,1993587347102720L,31902047417780224L,510395557925908480L,8166626525501136896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122911Inst : IEnumerable<long>
{
public static readonly long[] Value=A122911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122911.Bytes);
public long this[int i]=>Value[i];

public static A122911Inst Instance=new A122911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122912
{
public static readonly long[] Value={ 3L,5L,73L,17L,1153L,257L,1153L,257L,18433L,25601L,18433L,65537L,1179649L,65537L,1179649L,65537L,1179649L,26214401L,117964801L,26214401L,169869313L,104857601L,2717908993L,10485760001L,2717908993L,11341398017L,10871635969L,52613349377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122912Inst : IEnumerable<long>
{
public static readonly long[] Value=A122912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122912.Bytes);
public long this[int i]=>Value[i];

public static A122912Inst Instance=new A122912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122913
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,2L,3L,1L,6L,5L,3L,4L,12L,2L,6L,1L,3L,10L,15L,5L,9L,5L,18L,25L,9L,13L,9L,14L,12L,7L,6L,9L,3L,17L,9L,9L,15L,12L,9L,6L,6L,3L,3L,11L,42L,18L,21L,9L,66L,10L,33L,5L,27L,7L,48L,80L,24L,40L,12L,20L,6L,10L,3L,5L,3L,7L,3L,79L,75L,63L,96L,40L,48L,20L,24L,10L,12L,5L,6L,15L,3L,22L,72L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122913Inst : IEnumerable<long>
{
public static readonly long[] Value=A122913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122913.Bytes);
public long this[int i]=>Value[i];

public static A122913Inst Instance=new A122913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122914
{
public static readonly long[] Value={ 1L,4L,1L,8L,9L,3L,8L,5L,3L,3L,2L,0L,4L,6L,7L,2L,7L,4L,1L,7L,8L,0L,3L,2L,9L,7L,3L,6L,4L,0L,5L,6L,1L,7L,6L,3L,9L,8L,6L,1L,3L,9L,7L,4L,7L,3L,6L,3L,7L,7L,8L,3L,4L,1L,2L,8L,1L,7L,1L,5L,1L,5L,4L,0L,4L,8L,2L,7L,6L,5L,6L,9L,5L,9L,2L,7L,2L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122914Inst : IEnumerable<long>
{
public static readonly long[] Value=A122914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122914.Bytes);
public long this[int i]=>Value[i];

public static A122914Inst Instance=new A122914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122915
{
public static readonly long[] Value={ 1L,2L,2L,1L,1L,2L,2L,8L,1L,8L,4L,1L,4L,1L,3L,18L,1L,7L,1L,4L,2L,4L,2L,1L,2L,1L,4L,1L,1L,17L,1L,1L,1L,23L,1L,1L,2L,28L,3L,2L,4L,1L,2L,3L,1L,39L,12L,2L,1L,1L,120L,1L,6L,1L,5L,1L,1L,1L,1L,1L,1L,4L,3L,1L,1L,5L,1L,5L,14L,1L,3L,3L,1L,5L,1L,12L,2L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122915Inst : IEnumerable<long>
{
public static readonly long[] Value=A122915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122915.Bytes);
public long this[int i]=>Value[i];

public static A122915Inst Instance=new A122915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122916
{
public static readonly long[] Value={ 1L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122916Inst : IEnumerable<long>
{
public static readonly long[] Value=A122916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122916.Bytes);
public long this[int i]=>Value[i];

public static A122916Inst Instance=new A122916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122917
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-3L,1L,1L,5L,-5L,1L,-1L,-6L,14L,-7L,1L,0L,6L,-29L,27L,-9L,1L,1L,-6L,50L,-76L,44L,-11L,1L,-1L,7L,-77L,175L,-155L,65L,-13L,1L,0L,-9L,111L,-351L,441L,-274L,90L,-15L,1L,1L,11L,-154L,638L,-1078L,924L,-441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122917Inst : IEnumerable<long>
{
public static readonly long[] Value=A122917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122917.Bytes);
public long this[int i]=>Value[i];

public static A122917Inst Instance=new A122917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122918
{
public static readonly long[] Value={ 1L,0L,-2L,2L,1L,-4L,3L,2L,-6L,4L,3L,-8L,5L,4L,-10L,6L,5L,-12L,7L,6L,-14L,8L,7L,-16L,9L,8L,-18L,10L,9L,-20L,11L,10L,-22L,12L,11L,-24L,13L,12L,-26L,14L,13L,-28L,15L,14L,-30L,16L,15L,-32L,17L,16L,-34L,18L,17L,-36L,19L,18L,-38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122918Inst : IEnumerable<long>
{
public static readonly long[] Value=A122918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122918.Bytes);
public long this[int i]=>Value[i];

public static A122918Inst Instance=new A122918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122919
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,9L,10L,5L,1L,28L,34L,21L,7L,1L,90L,117L,83L,36L,9L,1L,297L,407L,319L,164L,55L,11L,1L,1001L,1430L,1209L,702L,285L,78L,13L,1L,3432L,5070L,4550L,2898L,1350L,454L,105L,15L,1L,11934L,18122L,17068L,11696L,6052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122919Inst : IEnumerable<long>
{
public static readonly long[] Value=A122919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122919.Bytes);
public long this[int i]=>Value[i];

public static A122919Inst Instance=new A122919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122920
{
public static readonly long[] Value={ 1L,1L,4L,12L,39L,129L,436L,1498L,5218L,18386L,65420L,234734L,848403L,3086001L,11288412L,41499354L,153247278L,568188606L,2114334312L,7893906144L,29561195238L,111007927386L,417918303144L,1577061975492L,5964172347604L,22601012748124L,85806694043116L,326343785428946L,1243200250005995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122920Inst : IEnumerable<long>
{
public static readonly long[] Value=A122920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122920.Bytes);
public long this[int i]=>Value[i];

public static A122920Inst Instance=new A122920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122921
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,3L,4L,4L,3L,4L,4L,4L,4L,3L,4L,4L,5L,4L,4L,4L,4L,5L,4L,5L,5L,4L,4L,4L,5L,4L,6L,5L,5L,6L,4L,5L,5L,5L,5L,6L,5L,4L,6L,5L,5L,5L,6L,5L,6L,6L,5L,6L,5L,5L,6L,6L,5L,6L,6L,5L,7L,5L,6L,6L,6L,6L,6L,6L,5L,6L,6L,7L,6L,8L,6L,6L,7L,5L,6L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122921Inst : IEnumerable<long>
{
public static readonly long[] Value=A122921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122921.Bytes);
public long this[int i]=>Value[i];

public static A122921Inst Instance=new A122921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122922
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,4L,4L,4L,3L,3L,4L,4L,3L,4L,4L,4L,4L,4L,3L,4L,5L,4L,4L,4L,4L,5L,4L,4L,5L,4L,4L,4L,5L,5L,4L,5L,5L,4L,4L,5L,5L,5L,4L,5L,5L,6L,5L,5L,4L,5L,6L,5L,5L,6L,6L,5L,5L,6L,5L,5L,5L,4L,6L,6L,5L,5L,6L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122922Inst : IEnumerable<long>
{
public static readonly long[] Value=A122922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122922.Bytes);
public long this[int i]=>Value[i];

public static A122922Inst Instance=new A122922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122923
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,3L,0L,2L,3L,3L,3L,2L,3L,2L,2L,3L,3L,3L,3L,3L,2L,3L,4L,4L,3L,3L,4L,2L,3L,2L,2L,4L,4L,3L,3L,4L,3L,3L,4L,3L,4L,4L,3L,4L,4L,3L,4L,4L,3L,4L,5L,4L,4L,5L,2L,4L,4L,3L,5L,3L,4L,5L,4L,4L,5L,5L,4L,4L,4L,5L,4L,4L,5L,4L,5L,5L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122923Inst : IEnumerable<long>
{
public static readonly long[] Value=A122923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122923.Bytes);
public long this[int i]=>Value[i];

public static A122923Inst Instance=new A122923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122924
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,2L,0L,1L,3L,1L,2L,1L,2L,0L,1L,3L,1L,2L,1L,2L,0L,1L,3L,1L,2L,2L,2L,1L,0L,3L,1L,3L,1L,2L,1L,2L,4L,2L,3L,1L,3L,1L,2L,1L,2L,4L,2L,3L,1L,3L,1L,2L,2L,2L,4L,3L,3L,2L,3L,1L,0L,1L,2L,4L,2L,4L,2L,3L,0L,3L,1L,3L,5L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122924Inst : IEnumerable<long>
{
public static readonly long[] Value=A122924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122924.Bytes);
public long this[int i]=>Value[i];

public static A122924Inst Instance=new A122924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122925
{
public static readonly long[] Value={ 0L,1L,5L,11L,24L,39L,53L,83L,96L,155L,176L,257L,224L,335L,376L,499L,384L,687L,701L,899L,704L,1043L,1104L,1379L,896L,1559L,1584L,1883L,1504L,2239L,2096L,2617L,1536L,2963L,2864L,3259L,2912L,3761L,3728L,3956L,2816L,4529L,4304L,5276L,4416L,5588L,5688L,5849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122925Inst : IEnumerable<long>
{
public static readonly long[] Value=A122925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122925.Bytes);
public long this[int i]=>Value[i];

public static A122925Inst Instance=new A122925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122926
{
public static readonly long[] Value={ 0L,1L,5L,11L,24L,39L,53L,83L,96L,155L,176L,224L,224L,335L,376L,384L,384L,687L,701L,704L,704L,896L,896L,896L,896L,1504L,1504L,1504L,1504L,1536L,1536L,1536L,1536L,2816L,2816L,2816L,2816L,2816L,2816L,2816L,2816L,3584L,3584L,3584L,3584L,3584L,3584L,3584L,3584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122926Inst : IEnumerable<long>
{
public static readonly long[] Value=A122926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122926.Bytes);
public long this[int i]=>Value[i];

public static A122926Inst Instance=new A122926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122927
{
public static readonly long[] Value={ 1L,4L,9L,15L,21L,24L,37L,38L,48L,50L,61L,62L,81L,75L,87L,93L,109L,99L,123L,109L,138L,132L,149L,133L,178L,154L,179L,171L,198L,179L,215L,196L,233L,211L,238L,221L,268L,236L,268L,246L,299L,269L,302L,282L,323L,295L,327L,305L,374L,322L,355L,337L,396L,339L,402L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122927Inst : IEnumerable<long>
{
public static readonly long[] Value=A122927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122927.Bytes);
public long this[int i]=>Value[i];

public static A122927Inst Instance=new A122927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122928
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,12L,18L,26L,37L,52L,72L,99L,134L,180L,240L,317L,416L,542L,702L,904L,1158L,1476L,1872L,2364L,2973L,3724L,4647L,5778L,7160L,8844L,10890L,13370L,16368L,19984L,24336L,29561L,35822L,43308L,52242L,62884L,75536L,90552L,108342L,129384L,154232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122928Inst : IEnumerable<long>
{
public static readonly long[] Value=A122928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122928.Bytes);
public long this[int i]=>Value[i];

public static A122928Inst Instance=new A122928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122929
{
public static readonly long[] Value={ 11L,28L,36L,52L,48L,60L,52L,148L,76L,68L,51L,52L,29L,92L,156L,92L,29L,179L,166L,100L,44L,102L,239L,156L,50L,25L,51L,364L,224L,204L,244L,166L,66L,346L,194L,388L,618L,92L,388L,102L,660L,371L,388L,29L,772L,828L,239L,460L,55L,292L,431L,166L,882L,1060L,532L,155L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122929Inst : IEnumerable<long>
{
public static readonly long[] Value=A122929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122929.Bytes);
public long this[int i]=>Value[i];

public static A122929Inst Instance=new A122929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122930
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,6L,1L,2L,0L,15L,2L,2L,6L,0L,40L,3L,4L,6L,15L,0L,104L,5L,6L,12L,15L,40L,0L,273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122930Inst : IEnumerable<long>
{
public static readonly long[] Value=A122930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122930.Bytes);
public long this[int i]=>Value[i];

public static A122930Inst Instance=new A122930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122931
{
public static readonly long[] Value={ 1L,2L,7L,18L,50L,132L,351L,924L,2431L,6380L,16732L,43848L,114869L,300846L,787815L,2062830L,5401054L,14140940L,37022755L,96928920L,253766591L,664375032L,1739365272L,4553731728L,11921847625L,31211839802L,81713718151L,213929389674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122931Inst : IEnumerable<long>
{
public static readonly long[] Value=A122931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122931.Bytes);
public long this[int i]=>Value[i];

public static A122931Inst Instance=new A122931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122932
{
public static readonly long[] Value={ 0L,0L,0L,2L,10L,44L,168L,636L,2364L,8984L,34672L,138104L,564408L,2382288L,10333152L,46173968L,211733776L,997182752L,4809439296L,23758139808L,119951644320L,618882541760L,3257839688320L,17492182188992L,95680426983360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122932Inst : IEnumerable<long>
{
public static readonly long[] Value=A122932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122932.Bytes);
public long this[int i]=>Value[i];

public static A122932Inst Instance=new A122932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122933
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,12L,14L,18L,23L,28L,42L,58L,61L,70L,91L,95L,101L,103L,132L,142L,150L,161L,167L,170L,248L,347L,361L,382L,409L,412L,424L,463L,476L,514L,532L,561L,645L,666L,710L,724L,736L,788L,795L,869L,999L,1010L,1083L,1106L,1124L,1136L,1143L,1149L,1163L,1205L,1244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122933Inst : IEnumerable<long>
{
public static readonly long[] Value=A122933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122933.Bytes);
public long this[int i]=>Value[i];

public static A122933Inst Instance=new A122933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122934
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,2L,1L,1L,1L,1L,3L,2L,2L,1L,1L,1L,3L,2L,4L,2L,2L,1L,1L,1L,2L,4L,2L,4L,2L,2L,1L,1L,1L,3L,4L,5L,3L,4L,2L,2L,1L,1L,1L,1L,3L,4L,5L,3L,4L,2L,2L,1L,1L,1L,5L,4L,6L,5L,6L,3L,4L,2L,2L,1L,1L,1L,1L,5L,4L,6L,5L,6L,3L,4L,2L,2L,1L,1L,1L,3L,4L,7L,6L,7L,6L,6L,3L,4L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122934Inst : IEnumerable<long>
{
public static readonly long[] Value=A122934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122934.Bytes);
public long this[int i]=>Value[i];

public static A122934Inst Instance=new A122934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122935
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,3L,1L,0L,1L,6L,6L,1L,0L,1L,10L,19L,10L,1L,0L,1L,15L,45L,45L,15L,1L,0L,1L,21L,90L,141L,90L,21L,1L,0L,1L,28L,161L,357L,357L,161L,28L,1L,0L,1L,36L,266L,784L,1107L,784L,266L,36L,1L,0L,1L,45L,414L,1554L,2907L,2907L,1554L,414L,45L,1L,0L,1L,55L,615L,2850L,6765L,8953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122935Inst : IEnumerable<long>
{
public static readonly long[] Value=A122935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122935.Bytes);
public long this[int i]=>Value[i];

public static A122935Inst Instance=new A122935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122936
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,30L,36L,42L,48L,54L,60L,66L,72L,78L,84L,90L,96L,102L,108L,114L,120L,150L,180L,210L,240L,270L,300L,330L,420L,630L,840L,1050L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122936Inst : IEnumerable<long>
{
public static readonly long[] Value=A122936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122936.Bytes);
public long this[int i]=>Value[i];

public static A122936Inst Instance=new A122936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122937
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,84L,90L,96L,102L,108L,114L,120L,126L,132L,138L,144L,150L,156L,162L,168L,174L,180L,186L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122937Inst : IEnumerable<long>
{
public static readonly long[] Value=A122937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122937.Bytes);
public long this[int i]=>Value[i];

public static A122937Inst Instance=new A122937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122938
{
public static readonly ulong[] Value={ 1L,1L,1L,2L,6L,27L,160L,1189L,10600L,110161L,1306629L,17408293L,257299241L,4177017722L,73872560359L,1413560616317L,29096001945172L,641010535303531L,15049350893772391L,375084409475304164L,9890697492431533299UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122938Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A122938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122938.Bytes);
public ulong this[int i]=>Value[i];

public static A122938Inst Instance=new A122938Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122939
{
public static readonly BigInteger[] Value={ 1L,2L,3L,6L,17L,70L,390L,2776L,24042L,244864L,2862185L,37715474L,552685976L,8910951840L,156709821779L,2984589501562L,61188398397436L,1343410717573876L,31445844702847347L,781689483100388326L,BigInteger.Parse("20564696601659697997") };
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
public class A122939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122939Inst Instance=new A122939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122940
{
public static readonly long[] Value={ 1L,1L,4L,17L,106L,796L,7176L,75057L,894100L,11946906L,176939192L,2876683340L,50931297912L,975391344376L,20090039762944L,442830738561585L,10400937450758286L,259318357362882148L,6839990934297006668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122940Inst : IEnumerable<long>
{
public static readonly long[] Value=A122940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122940.Bytes);
public long this[int i]=>Value[i];

public static A122940Inst Instance=new A122940Inst();

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