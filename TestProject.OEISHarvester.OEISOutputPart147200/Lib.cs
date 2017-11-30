using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A176505
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,3L,2L,3L,2L,1L,1L,1L,2L,3L,4L,4L,4L,4L,3L,2L,1L,1L,2L,4L,5L,5L,6L,5L,5L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176505Inst : IEnumerable<long>
{
public static readonly long[] Value=A176505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176505.Bytes);
public long this[int i]=>Value[i];

public static A176505Inst Instance=new A176505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176506
{
public static readonly long[] Value={ 0L,1L,0L,2L,3L,1L,2L,4L,0L,5L,3L,6L,1L,7L,4L,8L,0L,5L,2L,6L,9L,10L,3L,7L,11L,1L,12L,4L,13L,8L,2L,9L,14L,5L,15L,10L,6L,16L,3L,0L,17L,11L,12L,4L,18L,13L,19L,1L,7L,20L,8L,21L,14L,5L,22L,0L,15L,23L,16L,9L,2L,24L,17L,25L,6L,10L,26L,3L,18L,27L,11L,7L,28L,19L,1L,29L,12L,20L,2L,21L,4L,30L,8L,31L,13L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176506Inst : IEnumerable<long>
{
public static readonly long[] Value=A176506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176506.Bytes);
public long this[int i]=>Value[i];

public static A176506Inst Instance=new A176506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176507
{
public static readonly long[] Value={ 1L,31L,52L,69L,78L,101L,120L,127L,137L,149L,177L,199L,206L,248L,259L,266L,277L,339L,359L,375L,406L,416L,426L,429L,452L,479L,501L,518L,540L,551L,579L,590L,603L,613L,623L,630L,640L,655L,662L,676L,704L,726L,732L,743L,757L,775L,795L,809L,816L,829L,837L,847L,900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176507Inst : IEnumerable<long>
{
public static readonly long[] Value=A176507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176507.Bytes);
public long this[int i]=>Value[i];

public static A176507Inst Instance=new A176507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176508
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,1L,2L,3L,4L,3L,2L,1L,1L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,1L,3L,5L,6L,7L,7L,7L,6L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176508Inst : IEnumerable<long>
{
public static readonly long[] Value=A176508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176508.Bytes);
public long this[int i]=>Value[i];

public static A176508Inst Instance=new A176508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176509
{
public static readonly long[] Value={ 8L,27L,125L,128L,343L,1331L,2187L,2197L,4913L,6859L,12167L,24389L,29791L,32768L,50653L,68921L,78125L,79507L,103823L,148877L,205379L,226981L,300763L,357911L,389017L,493039L,571787L,704969L,823543L,912673L,1030301L,1092727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176509Inst : IEnumerable<long>
{
public static readonly long[] Value=A176509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176509.Bytes);
public long this[int i]=>Value[i];

public static A176509Inst Instance=new A176509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176510
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,3L,3L,3L,3L,2L,1L,1L,3L,5L,5L,6L,5L,5L,3L,1L,1L,4L,7L,8L,9L,9L,8L,7L,4L,1L,1L,6L,10L,12L,14L,14L,14L,12L,10L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176510Inst : IEnumerable<long>
{
public static readonly long[] Value=A176510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176510.Bytes);
public long this[int i]=>Value[i];

public static A176510Inst Instance=new A176510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176511
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,-1L,2L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176511Inst : IEnumerable<long>
{
public static readonly long[] Value=A176511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176511.Bytes);
public long this[int i]=>Value[i];

public static A176511Inst Instance=new A176511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176512
{
public static readonly long[] Value={ 1L,16L,25L,33L,35L,45L,52L,55L,58L,62L,76L,82L,84L,100L,104L,107L,111L,133L,137L,143L,155L,158L,162L,164L,174L,183L,188L,194L,198L,202L,214L,218L,222L,225L,229L,231L,234L,241L,243L,249L,257L,263L,265L,269L,274L,281L,287L,292L,294L,299L,301L,304L,319L,320L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176512Inst : IEnumerable<long>
{
public static readonly long[] Value=A176512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176512.Bytes);
public long this[int i]=>Value[i];

public static A176512Inst Instance=new A176512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176513
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,3L,5L,7L,9L,15L,19L,29L,41L,57L,85L,117L,171L,243L,345L,499L,705L,1015L,1447L,2065L,2961L,4217L,6041L,8625L,12323L,17627L,25165L,35991L,51417L,73479L,105035L,150061L,214505L,306513L,438045L,626053L,894619L,1278603L,1827185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176513Inst : IEnumerable<long>
{
public static readonly long[] Value=A176513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176513.Bytes);
public long this[int i]=>Value[i];

public static A176513Inst Instance=new A176513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176514
{
public static readonly long[] Value={ 3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L,3L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176514Inst : IEnumerable<long>
{
public static readonly long[] Value=A176514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176514.Bytes);
public long this[int i]=>Value[i];

public static A176514Inst Instance=new A176514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176515
{
public static readonly long[] Value={ 9L,4L,7L,4L,9L,3L,7L,1L,8L,5L,5L,3L,3L,0L,9L,9L,7L,7L,3L,6L,7L,2L,3L,9L,9L,1L,0L,5L,0L,0L,6L,0L,3L,0L,0L,2L,5L,8L,9L,0L,6L,3L,2L,8L,1L,8L,3L,8L,4L,0L,3L,0L,3L,9L,5L,5L,8L,8L,0L,2L,3L,2L,1L,9L,1L,7L,4L,7L,2L,6L,9L,6L,3L,9L,1L,3L,5L,6L,5L,7L,7L,0L,0L,6L,3L,2L,6L,5L,0L,9L,8L,6L,9L,2L,4L,3L,5L,9L,7L,6L,3L,6L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176515Inst : IEnumerable<long>
{
public static readonly long[] Value=A176515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176515.Bytes);
public long this[int i]=>Value[i];

public static A176515Inst Instance=new A176515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176516
{
public static readonly long[] Value={ 9L,3L,2L,1L,8L,2L,5L,3L,8L,0L,4L,9L,6L,4L,7L,7L,4L,9L,7L,8L,8L,0L,0L,1L,5L,5L,2L,3L,7L,1L,6L,3L,3L,1L,5L,9L,1L,9L,5L,3L,4L,5L,1L,8L,4L,6L,5L,3L,1L,6L,2L,6L,2L,0L,3L,6L,5L,0L,0L,8L,8L,4L,4L,3L,8L,6L,5L,6L,4L,3L,2L,0L,9L,3L,3L,4L,3L,2L,4L,8L,6L,1L,4L,5L,0L,0L,2L,7L,3L,5L,4L,6L,4L,6L,8L,0L,4L,2L,9L,5L,5L,4L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176516Inst : IEnumerable<long>
{
public static readonly long[] Value=A176516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176516.Bytes);
public long this[int i]=>Value[i];

public static A176516Inst Instance=new A176516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176517
{
public static readonly long[] Value={ 9L,2L,4L,3L,4L,1L,6L,4L,9L,0L,2L,5L,2L,5L,6L,8L,9L,9L,7L,9L,9L,8L,3L,4L,0L,3L,1L,6L,6L,4L,9L,0L,7L,7L,8L,0L,0L,5L,7L,9L,3L,3L,2L,7L,0L,8L,9L,8L,7L,8L,2L,5L,2L,4L,0L,2L,8L,6L,2L,5L,7L,2L,7L,9L,1L,8L,8L,8L,9L,1L,6L,5L,7L,9L,5L,8L,8L,5L,7L,3L,3L,2L,0L,1L,6L,3L,7L,2L,1L,6L,2L,5L,6L,8L,9L,5L,0L,4L,4L,2L,7L,8L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176517Inst : IEnumerable<long>
{
public static readonly long[] Value=A176517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176517.Bytes);
public long this[int i]=>Value[i];

public static A176517Inst Instance=new A176517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176518
{
public static readonly long[] Value={ 9L,1L,9L,5L,7L,4L,2L,7L,5L,2L,7L,4L,9L,5L,5L,8L,3L,6L,2L,4L,5L,9L,2L,6L,4L,7L,0L,4L,3L,3L,5L,6L,8L,0L,0L,9L,4L,4L,2L,5L,2L,9L,8L,5L,5L,5L,1L,8L,4L,2L,0L,4L,0L,2L,0L,9L,6L,8L,8L,8L,4L,2L,1L,5L,3L,6L,2L,0L,9L,3L,9L,4L,3L,8L,3L,9L,3L,9L,0L,2L,8L,8L,7L,7L,0L,2L,7L,0L,2L,5L,7L,5L,9L,5L,4L,4L,2L,7L,7L,7L,4L,3L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176518Inst : IEnumerable<long>
{
public static readonly long[] Value=A176518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176518.Bytes);
public long this[int i]=>Value[i];

public static A176518Inst Instance=new A176518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176519
{
public static readonly long[] Value={ 9L,1L,6L,3L,6L,8L,9L,5L,2L,6L,5L,4L,4L,4L,0L,7L,5L,2L,2L,7L,7L,7L,2L,3L,7L,7L,7L,1L,1L,6L,0L,2L,7L,8L,4L,9L,1L,6L,3L,8L,1L,2L,0L,3L,4L,7L,0L,9L,5L,8L,2L,7L,3L,3L,5L,5L,2L,8L,0L,9L,8L,6L,4L,9L,2L,2L,3L,3L,9L,2L,2L,7L,4L,4L,0L,3L,6L,2L,4L,8L,3L,9L,2L,0L,7L,1L,1L,0L,2L,8L,1L,4L,5L,5L,9L,4L,1L,0L,0L,8L,0L,0L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176519Inst : IEnumerable<long>
{
public static readonly long[] Value=A176519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176519.Bytes);
public long this[int i]=>Value[i];

public static A176519Inst Instance=new A176519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176520
{
public static readonly long[] Value={ 9L,1L,4L,0L,6L,5L,8L,8L,2L,0L,2L,2L,3L,0L,8L,1L,8L,2L,8L,9L,5L,4L,1L,8L,5L,9L,4L,7L,1L,6L,9L,5L,3L,7L,9L,9L,2L,3L,1L,0L,5L,6L,8L,0L,4L,3L,5L,9L,7L,1L,2L,3L,8L,2L,8L,2L,0L,6L,5L,9L,8L,7L,8L,0L,1L,9L,4L,8L,4L,5L,0L,1L,5L,2L,5L,1L,9L,0L,5L,7L,7L,7L,0L,9L,5L,5L,5L,1L,3L,9L,8L,1L,8L,0L,8L,5L,1L,0L,6L,2L,9L,1L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176520Inst : IEnumerable<long>
{
public static readonly long[] Value=A176520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176520.Bytes);
public long this[int i]=>Value[i];

public static A176520Inst Instance=new A176520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176521
{
public static readonly long[] Value={ 9L,1L,2L,3L,3L,1L,0L,5L,0L,2L,2L,2L,6L,7L,3L,2L,3L,3L,7L,6L,8L,7L,6L,4L,4L,2L,8L,6L,0L,9L,0L,6L,8L,3L,1L,6L,8L,9L,2L,6L,7L,1L,8L,0L,1L,7L,5L,8L,3L,4L,3L,0L,9L,0L,8L,6L,5L,5L,9L,2L,9L,0L,5L,4L,3L,4L,3L,7L,9L,9L,7L,3L,7L,6L,9L,7L,7L,4L,8L,1L,5L,9L,7L,2L,5L,0L,4L,7L,3L,4L,9L,3L,9L,9L,1L,7L,4L,9L,5L,8L,8L,6L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176521Inst : IEnumerable<long>
{
public static readonly long[] Value=A176521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176521.Bytes);
public long this[int i]=>Value[i];

public static A176521Inst Instance=new A176521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176522
{
public static readonly long[] Value={ 9L,1L,0L,9L,7L,7L,2L,2L,2L,8L,6L,4L,6L,4L,4L,3L,6L,5L,5L,0L,0L,1L,1L,3L,7L,1L,4L,0L,8L,8L,1L,3L,9L,6L,5L,7L,8L,6L,2L,3L,4L,0L,2L,5L,2L,4L,3L,6L,1L,2L,3L,2L,0L,0L,4L,0L,0L,3L,8L,7L,6L,1L,0L,2L,7L,2L,1L,3L,3L,5L,5L,1L,3L,4L,0L,0L,9L,3L,7L,7L,3L,0L,3L,8L,3L,9L,4L,7L,0L,4L,5L,3L,9L,6L,6L,4L,0L,2L,8L,2L,4L,7L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176522Inst : IEnumerable<long>
{
public static readonly long[] Value=A176522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176522.Bytes);
public long this[int i]=>Value[i];

public static A176522Inst Instance=new A176522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176523
{
public static readonly long[] Value={ 9L,0L,9L,8L,9L,1L,2L,9L,1L,5L,0L,2L,6L,7L,6L,7L,4L,9L,6L,9L,6L,6L,1L,0L,4L,5L,9L,7L,4L,7L,1L,6L,1L,4L,6L,1L,3L,2L,0L,7L,9L,8L,1L,9L,7L,7L,8L,6L,6L,9L,4L,0L,8L,7L,5L,6L,9L,9L,4L,3L,8L,2L,2L,1L,2L,5L,4L,3L,8L,4L,7L,9L,4L,3L,9L,9L,9L,5L,5L,0L,9L,1L,5L,6L,4L,6L,0L,7L,3L,1L,1L,1L,6L,7L,0L,3L,4L,6L,8L,8L,2L,6L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176523Inst : IEnumerable<long>
{
public static readonly long[] Value=A176523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176523.Bytes);
public long this[int i]=>Value[i];

public static A176523Inst Instance=new A176523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176524
{
public static readonly long[] Value={ 1L,5L,3L,2L,9L,7L,0L,9L,7L,1L,6L,7L,5L,5L,8L,9L,1L,6L,5L,6L,5L,5L,3L,6L,8L,1L,9L,9L,1L,5L,7L,2L,0L,4L,8L,7L,1L,0L,6L,9L,3L,2L,7L,3L,2L,5L,9L,5L,5L,6L,4L,6L,9L,5L,8L,5L,6L,6L,4L,7L,9L,4L,0L,7L,0L,8L,4L,7L,9L,4L,9L,3L,1L,4L,6L,6L,6L,5L,1L,6L,9L,7L,1L,8L,8L,2L,0L,2L,4L,3L,7L,0L,5L,5L,6L,7L,8L,2L,2L,9L,4L,2L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176524Inst : IEnumerable<long>
{
public static readonly long[] Value=A176524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176524.Bytes);
public long this[int i]=>Value[i];

public static A176524Inst Instance=new A176524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176525
{
public static readonly long[] Value={ 6L,8L,10L,12L,14L,15L,18L,20L,21L,22L,26L,27L,28L,32L,33L,34L,35L,36L,38L,39L,44L,45L,46L,48L,50L,51L,52L,55L,57L,58L,62L,63L,64L,65L,68L,69L,74L,75L,76L,77L,80L,82L,85L,86L,87L,91L,92L,93L,94L,95L,98L,99L,100L,106L,111L,112L,115L,116L,117L,118L,119L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176525Inst : IEnumerable<long>
{
public static readonly long[] Value=A176525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176525.Bytes);
public long this[int i]=>Value[i];

public static A176525Inst Instance=new A176525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176526
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,25L,28L,30L,35L,36L,40L,42L,45L,48L,50L,60L,70L,72L,75L,80L,84L,90L,100L,105L,120L,140L,144L,150L,180L,200L,210L,240L,300L,360L,420L,600L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176526Inst : IEnumerable<long>
{
public static readonly long[] Value=A176526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176526.Bytes);
public long this[int i]=>Value[i];

public static A176526Inst Instance=new A176526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176527
{
public static readonly BigInteger[] Value={ 1L,2L,5L,21L,166L,2277L,49901L,1675904L,84239935L,6231045077L,668949067432L,103005162942955L,22511886374045653L,6918461813753405930L,BigInteger.Parse("2965189776573865320121"),BigInteger.Parse("1759287329824925168339697") };
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
public class A176527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176527Inst Instance=new A176527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176528
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,8L,8L,12L,20L,26L,36L,44L,56L,64L,64L,76L,108L,128L,200L,226L,286L,322L,432L,476L,572L,628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176528Inst : IEnumerable<long>
{
public static readonly long[] Value=A176528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176528.Bytes);
public long this[int i]=>Value[i];

public static A176528Inst Instance=new A176528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176529
{
public static readonly long[] Value={ 1L,0L,4L,7L,7L,2L,2L,5L,5L,7L,5L,0L,5L,1L,6L,6L,1L,1L,3L,4L,5L,6L,9L,6L,9L,7L,8L,2L,8L,0L,0L,8L,0L,2L,1L,3L,3L,9L,5L,2L,7L,4L,4L,6L,9L,4L,9L,9L,7L,9L,8L,3L,2L,5L,4L,2L,2L,6L,8L,9L,4L,4L,4L,9L,7L,3L,2L,4L,9L,3L,2L,7L,7L,1L,2L,2L,7L,2L,2L,7L,3L,3L,8L,0L,0L,8L,5L,8L,4L,3L,6L,1L,6L,3L,8L,7L,0L,6L,2L,5L,7L,6L,4L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176529Inst : IEnumerable<long>
{
public static readonly long[] Value=A176529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176529.Bytes);
public long this[int i]=>Value[i];

public static A176529Inst Instance=new A176529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176530
{
public static readonly long[] Value={ 1L,0L,3L,2L,2L,9L,0L,6L,4L,7L,4L,2L,2L,3L,7L,7L,0L,6L,6L,6L,3L,5L,6L,7L,4L,8L,3L,9L,2L,3L,2L,6L,8L,7L,1L,2L,8L,0L,5L,2L,2L,4L,4L,9L,9L,0L,1L,4L,5L,8L,4L,7L,5L,5L,5L,7L,7L,4L,5L,6L,1L,2L,5L,4L,8L,6L,8L,7L,4L,6L,4L,8L,4L,1L,9L,5L,8L,7L,8L,0L,9L,7L,4L,2L,8L,2L,1L,8L,7L,4L,3L,7L,1L,4L,1L,9L,4L,6L,3L,9L,7L,9L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176530Inst : IEnumerable<long>
{
public static readonly long[] Value=A176530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176530.Bytes);
public long this[int i]=>Value[i];

public static A176530Inst Instance=new A176530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176531
{
public static readonly long[] Value={ 1L,0L,2L,4L,4L,0L,4L,4L,2L,4L,0L,8L,5L,0L,7L,5L,7L,7L,3L,4L,9L,5L,7L,2L,6L,7L,5L,6L,8L,3L,9L,9L,6L,8L,7L,9L,9L,2L,3L,7L,6L,3L,5L,9L,2L,8L,8L,4L,0L,7L,5L,1L,9L,9L,2L,4L,3L,7L,8L,7L,7L,8L,8L,1L,7L,9L,0L,0L,0L,2L,9L,6L,2L,7L,5L,0L,5L,5L,0L,3L,4L,5L,7L,0L,9L,6L,9L,2L,6L,4L,4L,4L,6L,6L,5L,9L,7L,2L,0L,8L,9L,0L,1L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176531Inst : IEnumerable<long>
{
public static readonly long[] Value=A176531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176531.Bytes);
public long this[int i]=>Value[i];

public static A176531Inst Instance=new A176531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176532
{
public static readonly long[] Value={ 1L,0L,1L,9L,6L,1L,5L,2L,4L,2L,2L,7L,0L,6L,6L,3L,1L,8L,8L,0L,5L,8L,2L,3L,3L,9L,0L,2L,4L,5L,1L,7L,6L,1L,7L,1L,0L,0L,8L,2L,8L,4L,1L,5L,7L,6L,1L,4L,3L,1L,1L,4L,1L,8L,8L,4L,1L,6L,7L,4L,2L,0L,9L,3L,8L,3L,5L,5L,7L,9L,9L,0L,5L,0L,7L,2L,6L,4L,0L,0L,1L,1L,1L,2L,4L,3L,4L,3L,8L,5L,6L,0L,2L,7L,1L,7L,4L,5L,7L,2L,7L,0L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176532Inst : IEnumerable<long>
{
public static readonly long[] Value=A176532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176532.Bytes);
public long this[int i]=>Value[i];

public static A176532Inst Instance=new A176532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176533
{
public static readonly long[] Value={ 1L,0L,1L,6L,3L,9L,7L,7L,7L,9L,4L,9L,4L,3L,2L,2L,2L,5L,1L,3L,5L,7L,2L,3L,5L,3L,8L,6L,6L,3L,7L,6L,5L,3L,2L,8L,1L,4L,4L,4L,3L,8L,9L,5L,6L,0L,7L,0L,5L,5L,4L,5L,4L,4L,3L,5L,4L,5L,0L,0L,9L,8L,3L,5L,4L,8L,1L,7L,9L,7L,7L,4L,5L,5L,9L,1L,5L,9L,7L,2L,0L,4L,4L,6L,9L,2L,3L,8L,3L,1L,6L,9L,1L,4L,4L,8L,9L,8L,0L,2L,3L,8L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176533Inst : IEnumerable<long>
{
public static readonly long[] Value=A176533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176533.Bytes);
public long this[int i]=>Value[i];

public static A176533Inst Instance=new A176533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176534
{
public static readonly long[] Value={ 1L,0L,1L,4L,0L,8L,7L,2L,6L,3L,2L,9L,8L,4L,7L,3L,7L,5L,9L,9L,1L,6L,1L,2L,4L,5L,2L,0L,7L,9L,6L,8L,1L,8L,4L,4L,3L,0L,6L,4L,9L,8L,7L,4L,1L,7L,1L,2L,2L,8L,4L,5L,0L,6L,2L,9L,4L,6L,5L,7L,5L,2L,4L,8L,0L,7L,9L,3L,1L,2L,3L,6L,5L,7L,5L,2L,4L,3L,3L,1L,7L,2L,8L,7L,0L,7L,4L,7L,0L,0L,0L,3L,0L,5L,5L,8L,7L,5L,9L,5L,5L,2L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176534Inst : IEnumerable<long>
{
public static readonly long[] Value=A176534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176534.Bytes);
public long this[int i]=>Value[i];

public static A176534Inst Instance=new A176534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176535
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,7L,5L,3L,8L,2L,9L,7L,9L,7L,9L,9L,1L,9L,1L,6L,1L,0L,5L,1L,9L,3L,4L,0L,2L,6L,0L,5L,2L,5L,9L,9L,5L,3L,6L,7L,5L,1L,6L,3L,3L,1L,7L,2L,7L,4L,1L,6L,4L,6L,4L,7L,7L,0L,9L,8L,9L,2L,4L,9L,9L,4L,5L,1L,7L,3L,9L,9L,2L,8L,5L,2L,6L,7L,7L,0L,3L,6L,4L,6L,3L,6L,1L,5L,8L,1L,4L,1L,8L,9L,2L,7L,3L,3L,6L,8L,4L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176535Inst : IEnumerable<long>
{
public static readonly long[] Value=A176535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176535.Bytes);
public long this[int i]=>Value[i];

public static A176535Inst Instance=new A176535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176536
{
public static readonly long[] Value={ 1L,0L,1L,0L,9L,9L,0L,3L,2L,3L,8L,9L,1L,8L,6L,3L,0L,5L,5L,2L,1L,8L,4L,5L,6L,0L,6L,6L,3L,8L,5L,7L,3L,4L,9L,5L,7L,0L,2L,3L,1L,0L,9L,1L,0L,8L,6L,5L,1L,8L,8L,2L,3L,1L,9L,5L,2L,2L,1L,5L,9L,8L,0L,2L,3L,6L,1L,5L,9L,8L,3L,1L,0L,4L,8L,8L,8L,8L,3L,8L,9L,9L,0L,6L,2L,7L,3L,4L,1L,4L,5L,6L,8L,5L,2L,2L,6L,0L,7L,6L,4L,7L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176536Inst : IEnumerable<long>
{
public static readonly long[] Value=A176536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176536.Bytes);
public long this[int i]=>Value[i];

public static A176536Inst Instance=new A176536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176537
{
public static readonly long[] Value={ 1L,0L,0L,9L,9L,0L,1L,9L,5L,1L,3L,5L,9L,2L,7L,8L,4L,8L,3L,0L,0L,2L,8L,2L,2L,4L,1L,0L,9L,0L,2L,2L,7L,8L,1L,9L,8L,9L,5L,6L,3L,7L,7L,0L,9L,4L,6L,0L,9L,9L,5L,9L,6L,4L,0L,7L,5L,8L,4L,9L,7L,0L,8L,0L,4L,4L,2L,5L,9L,3L,3L,6L,3L,2L,0L,6L,2L,2L,2L,4L,1L,9L,5L,5L,8L,8L,3L,4L,8L,8L,5L,1L,0L,9L,3L,9L,3L,2L,0L,0L,8L,3L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176537Inst : IEnumerable<long>
{
public static readonly long[] Value=A176537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176537.Bytes);
public long this[int i]=>Value[i];

public static A176537Inst Instance=new A176537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176538
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,4L,5L,8L,10L,17L,26L,43L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176538Inst : IEnumerable<long>
{
public static readonly long[] Value=A176538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176538.Bytes);
public long this[int i]=>Value[i];

public static A176538Inst Instance=new A176538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176539
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,12L,13L,16L,17L,19L,20L,23L,24L,25L,27L,28L,31L,33L,34L,36L,37L,38L,41L,42L,44L,47L,48L,50L,52L,53L,54L,56L,57L,58L,59L,63L,66L,68L,69L,70L,71L,72L,73L,75L,77L,78L,81L,82L,83L,84L,85L,88L,90L,91L,92L,94L,96L,98L,99L,102L,103L,104L,107L,110L,111L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176539Inst : IEnumerable<long>
{
public static readonly long[] Value=A176539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176539.Bytes);
public long this[int i]=>Value[i];

public static A176539Inst Instance=new A176539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176540
{
public static readonly long[] Value={ 1L,4L,6L,9L,10L,14L,15L,21L,22L,25L,26L,33L,34L,35L,38L,39L,46L,49L,51L,55L,57L,58L,62L,65L,69L,74L,77L,82L,85L,86L,87L,91L,93L,94L,95L,106L,111L,115L,118L,119L,121L,122L,123L,129L,133L,134L,141L,142L,143L,145L,146L,155L,158L,159L,161L,166L,169L,177L,178L,183L,185L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176540Inst : IEnumerable<long>
{
public static readonly long[] Value=A176540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176540.Bytes);
public long this[int i]=>Value[i];

public static A176540Inst Instance=new A176540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176541
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,11L,13L,22L,23L,25L,27L,32L,37L,39L,46L,47L,48L,49L,50L,52L,59L,66L,71L,73L,83L,94L,98L,100L,104L,107L,109L,111L,118L,121L,128L,143L,146L,147L,148L,157L,167L,176L,179L,181L,183L,191L,192L,193L,194L,200L,214L,219L,227L,239L,241L,242L,243L,244L,253L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176541Inst : IEnumerable<long>
{
public static readonly long[] Value=A176541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176541.Bytes);
public long this[int i]=>Value[i];

public static A176541Inst Instance=new A176541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176542
{
public static readonly long[] Value={ 32L,50L,98L,128L,200L,242L,338L,392L,512L,578L,722L,800L,968L,1058L,1250L,1352L,1568L,1682L,1922L,2048L,2312L,2450L,2738L,2888L,3200L,3362L,3698L,3872L,4232L,4418L,4802L,5000L,5408L,5618L,6050L,6272L,6728L,6962L,7442L,7688L,8192L,8450L,8978L,9248L,9800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176542Inst : IEnumerable<long>
{
public static readonly long[] Value=A176542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176542.Bytes);
public long this[int i]=>Value[i];

public static A176542Inst Instance=new A176542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176543
{
public static readonly long[] Value={ 7L,36L,44L,63L,68L,79L,128L,148L,157L,192L,244L,303L,323L,335L,410L,421L,475L,483L,535L,606L,616L,669L,776L,849L,862L,868L,947L,964L,986L,1039L,1046L,1256L,1264L,1403L,1406L,1422L,1579L,1700L,1733L,1874L,1971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176543Inst : IEnumerable<long>
{
public static readonly long[] Value=A176543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176543.Bytes);
public long this[int i]=>Value[i];

public static A176543Inst Instance=new A176543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176544
{
public static readonly long[] Value={ 7L,37L,19L,67L,19L,19L,37L,37L,73L,37L,73L,337L,367L,163L,73L,109L,127L,73L,109L,163L,127L,181L,163L,433L,181L,163L,199L,181L,271L,163L,199L,199L,271L,271L,397L,307L,307L,487L,379L,541L,433L,577L,397L,271L,631L,433L,379L,487L,919L,1459L,541L,937L,811L,631L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176544Inst : IEnumerable<long>
{
public static readonly long[] Value=A176544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176544.Bytes);
public long this[int i]=>Value[i];

public static A176544Inst Instance=new A176544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176545
{
public static readonly long[] Value={ 2L,9L,11L,12L,14L,17L,21L,24L,26L,39L,44L,47L,59L,77L,86L,87L,89L,101L,116L,117L,122L,126L,131L,137L,147L,152L,161L,164L,177L,179L,189L,191L,192L,201L,212L,219L,222L,231L,249L,257L,261L,264L,284L,287L,296L,306L,317L,326L,329L,336L,347L,369L,387L,389L,411L,417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176545Inst : IEnumerable<long>
{
public static readonly long[] Value=A176545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176545.Bytes);
public long this[int i]=>Value[i];

public static A176545Inst Instance=new A176545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176546
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-1L,1L,-1L,5L,-691L,7L,-3617L,43867L,-174611L,854513L,-236364091L,8553103L,-23749461029L,8615841276005L,-7709321041217L,2577687858367L,BigInteger.Parse("-26315271553053477373"),2929993913841559L,BigInteger.Parse("-261082718496449122051") };
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
public class A176546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176546Inst Instance=new A176546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176547
{
public static readonly long[] Value={ 3L,6L,15L,18L,21L,24L,27L,33L,57L,60L,63L,66L,75L,78L,87L,90L,96L,108L,111L,117L,129L,138L,141L,144L,147L,153L,159L,165L,168L,171L,180L,186L,189L,201L,204L,222L,228L,231L,234L,237L,243L,246L,249L,252L,255L,258L,264L,273L,294L,309L,312L,315L,321L,339L,348L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176547Inst : IEnumerable<long>
{
public static readonly long[] Value=A176547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176547.Bytes);
public long this[int i]=>Value[i];

public static A176547Inst Instance=new A176547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176548
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,16L,17L,20L,30L,31L,32L,37L,50L,70L,71L,73L,76L,79L,92L,97L,98L,101L,104L,107L,110L,112L,113L,124L,125L,128L,130L,131L,136L,140L,149L,151L,152L,157L,160L,164L,167L,170L,172L,175L,179L,181L,182L,188L,191L,196L,199L,200L,300L,310L,311L,313L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176548Inst : IEnumerable<long>
{
public static readonly long[] Value=A176548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176548.Bytes);
public long this[int i]=>Value[i];

public static A176548Inst Instance=new A176548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176549
{
public static readonly long[] Value={ 37L,109L,541L,757L,1009L,1297L,1621L,2377L,6841L,7561L,8317L,9109L,11701L,12637L,15661L,16741L,19009L,23977L,25309L,28081L,34057L,38917L,40609L,42337L,44101L,47737L,51517L,55441L,57457L,59509L,65881L,70309L,72577L,82009L,84457L,99901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176549Inst : IEnumerable<long>
{
public static readonly long[] Value=A176549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176549.Bytes);
public long this[int i]=>Value[i];

public static A176549Inst Instance=new A176549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176550
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,11L,18L,20L,21L,22L,24L,29L,34L,35L,42L,43L,57L,61L,74L,79L,81L,95L,101L,102L,111L,112L,118L,120L,123L,128L,136L,151L,153L,154L,163L,166L,167L,170L,173L,177L,190L,194L,195L,198L,199L,203L,205L,208L,212L,213L,239L,242L,245L,263L,267L,271L,278L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176550Inst : IEnumerable<long>
{
public static readonly long[] Value=A176550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176550.Bytes);
public long this[int i]=>Value[i];

public static A176550Inst Instance=new A176550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176551
{
public static readonly long[] Value={ 4L,10L,14L,22L,25L,26L,34L,35L,38L,46L,49L,55L,58L,62L,65L,74L,77L,82L,85L,86L,91L,94L,95L,106L,115L,118L,119L,121L,122L,133L,134L,142L,143L,145L,146L,155L,158L,161L,166L,169L,178L,185L,187L,194L,202L,203L,205L,206L,209L,214L,215L,217L,218L,221L,226L,235L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176551Inst : IEnumerable<long>
{
public static readonly long[] Value=A176551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176551.Bytes);
public long this[int i]=>Value[i];

public static A176551Inst Instance=new A176551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176552
{
public static readonly long[] Value={ 1L,6L,10L,12L,14L,18L,20L,22L,24L,26L,28L,30L,34L,36L,38L,40L,44L,45L,46L,48L,50L,52L,54L,56L,58L,60L,62L,63L,66L,68L,70L,72L,74L,75L,76L,80L,82L,84L,86L,88L,90L,82L,94L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176552Inst : IEnumerable<long>
{
public static readonly long[] Value=A176552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176552.Bytes);
public long this[int i]=>Value[i];

public static A176552Inst Instance=new A176552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176553
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,21L,31L,37L,67L,73L,79L,97L,103L,109L,121L,151L,163L,181L,183L,193L,219L,223L,229L,237L,27L,283L,307L,363L,367L,373L,381L,409L,433L,439L,471L,487L,489L,499L,511L,523L,571L,601L,603L,607L,63L,619L,657L,669L,709L,733L,787L,811L,817L,819L,823L,841L,867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176553Inst : IEnumerable<long>
{
public static readonly long[] Value=A176553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176553.Bytes);
public long this[int i]=>Value[i];

public static A176553Inst Instance=new A176553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176554
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176554Inst : IEnumerable<long>
{
public static readonly long[] Value=A176554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176554.Bytes);
public long this[int i]=>Value[i];

public static A176554Inst Instance=new A176554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176555
{
public static readonly long[] Value={ 1L,13L,17L,139L,113L,13721L,131L,137L,167L,173L,179L,197L,1103L,1109L,111121L,1151L,1163L,1181L,1361183L,1193L,1373219L,1223L,1229L,1379237L,1277L,1283L,1307L,131133121363L,1367L,1373L,13127381L,1409L,1433L,1439L,13157471L,1487L,13163489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176555Inst : IEnumerable<long>
{
public static readonly long[] Value=A176555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176555.Bytes);
public long this[int i]=>Value[i];

public static A176555Inst Instance=new A176555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176556
{
public static readonly long[] Value={ 1L,12L,124L,15L,1236L,1248L,12510L,111L,1234612L,12714L,13515L,124816L,117L,1236918L,119L,12451020L,121122L,123L,1234681224L,1525L,121326L,13927L,12471428L,129L,12356101530L,12481632L,131133L,121734L,15735L,123469121836L,121938L,131339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176556Inst : IEnumerable<long>
{
public static readonly long[] Value=A176556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176556.Bytes);
public long this[int i]=>Value[i];

public static A176556Inst Instance=new A176556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176557
{
public static readonly long[] Value={ 7L,23L,43L,67L,127L,163L,347L,463L,743L,823L,907L,1087L,1283L,1607L,1723L,2503L,2647L,3767L,3943L,5923L,6143L,6367L,6827L,7547L,8563L,9643L,9923L,11083L,11383L,13267L,14947L,15647L,16363L,17467L,18223L,19387L,20183L,21407L,24847L,25747L,26203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176557Inst : IEnumerable<long>
{
public static readonly long[] Value=A176557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176557.Bytes);
public long this[int i]=>Value[i];

public static A176557Inst Instance=new A176557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176558
{
public static readonly long[] Value={ 1L,21L,31L,421L,51L,6321L,71L,8421L,931L,10521L,111L,1264321L,131L,14721L,15531L,168421L,171L,1896321L,191L,20105421L,21731L,221121L,231L,2412864321L,2551L,261321L,27931L,28147421L,291L,30151065321L,311L,32168421L,331131L,341721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176558Inst : IEnumerable<long>
{
public static readonly long[] Value=A176558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176558.Bytes);
public long this[int i]=>Value[i];

public static A176558Inst Instance=new A176558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176559
{
public static readonly long[] Value={ 1L,6L,19L,996L,11222L,31138L,105054174L,55890483939986569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176559Inst : IEnumerable<long>
{
public static readonly long[] Value=A176559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176559.Bytes);
public long this[int i]=>Value[i];

public static A176559Inst Instance=new A176559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176560
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,16L,16L,1L,1L,35L,85L,35L,1L,1L,71L,351L,351L,71L,1L,1L,140L,1295L,2590L,1295L,140L,1L,1L,274L,4488L,16108L,16108L,4488L,274L,1L,1L,537L,14943L,89409L,157953L,89409L,14943L,537L,1L,1L,1057L,48379L,457711L,1315645L,1315645L,457711L,48379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176560Inst : IEnumerable<long>
{
public static readonly long[] Value=A176560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176560.Bytes);
public long this[int i]=>Value[i];

public static A176560Inst Instance=new A176560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176561
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,18L,18L,1L,1L,38L,90L,38L,1L,1L,75L,360L,360L,75L,1L,1L,145L,1309L,2609L,1309L,145L,1L,1L,280L,4508L,16142L,16142L,4508L,280L,1L,1L,544L,14970L,89464L,158022L,89464L,14970L,544L,1L,1L,1065L,48414L,457794L,1315770L,1315770L,457794L,48414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176561Inst : IEnumerable<long>
{
public static readonly long[] Value=A176561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176561.Bytes);
public long this[int i]=>Value[i];

public static A176561Inst Instance=new A176561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176562
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,12L,18L,22L,30L,38L,48L,56L,66L,78L,96L,110L,120L,136L,154L,168L,192L,208L,232L,250L,278L,298L,320L,346L,372L,396L,426L,454L,490L,518L,556L,586L,620L,650L,688L,728L,766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176562Inst : IEnumerable<long>
{
public static readonly long[] Value=A176562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176562.Bytes);
public long this[int i]=>Value[i];

public static A176562Inst Instance=new A176562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176563
{
public static readonly long[] Value={ 1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L,-3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176563Inst : IEnumerable<long>
{
public static readonly long[] Value=A176563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176563.Bytes);
public long this[int i]=>Value[i];

public static A176563Inst Instance=new A176563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176564
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,-6L,-14L,-6L,1L,1L,-32L,-87L,-87L,-32L,1L,1L,-120L,-363L,-484L,-363L,-120L,1L,1L,-415L,-1339L,-2067L,-2067L,-1339L,-415L,1L,1L,-1414L,-4742L,-7942L,-9230L,-7942L,-4742L,-1414L,1L,1L,-4844L,-16643L,-29240L,-36992L,-36992L,-29240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176564Inst : IEnumerable<long>
{
public static readonly long[] Value=A176564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176564.Bytes);
public long this[int i]=>Value[i];

public static A176564Inst Instance=new A176564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176565
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-6L,-6L,1L,1L,-64L,-84L,-64L,1L,1L,-454L,-636L,-636L,-454L,1L,1L,-7996L,-10933L,-11648L,-10933L,-7996L,1L,1L,-116264L,-154904L,-165852L,-165852L,-154904L,-116264L,1L,1L,-4292122L,-5475909L,-5769895L,-5823025L,-5769895L,-5475909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176565Inst : IEnumerable<long>
{
public static readonly long[] Value=A176565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176565.Bytes);
public long this[int i]=>Value[i];

public static A176565Inst Instance=new A176565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176566
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,4L,10L,20L,1L,7L,28L,84L,210L,1L,11L,66L,286L,1001L,3003L,1L,16L,136L,816L,3876L,15504L,54264L,1L,22L,253L,2024L,12650L,65780L,296010L,1184040L,1L,29L,435L,4495L,35960L,237336L,1344904L,6724520L,30260340L,1L,37L,703L,9139L,91390L,749398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176566Inst : IEnumerable<long>
{
public static readonly long[] Value=A176566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176566.Bytes);
public long this[int i]=>Value[i];

public static A176566Inst Instance=new A176566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176567
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,-6L,-6L,1L,1L,-119L,-154L,-119L,1L,1L,-1991L,-2651L,-2651L,-1991L,1L,1L,-38744L,-50252L,-52632L,-50252L,-38744L,1L,1L,-888008L,-1118007L,-1169366L,-1169366L,-1118007L,-888008L,1L,1L,-23535791L,-28915001L,-30018509L,-30188420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176567Inst : IEnumerable<long>
{
public static readonly long[] Value=A176567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176567.Bytes);
public long this[int i]=>Value[i];

public static A176567Inst Instance=new A176567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176568
{
public static readonly long[] Value={ 0L,117L,121L,207L,245L,289L,297L,325L,343L,363L,405L,425L,475L,483L,495L,513L,529L,531L,625L,627L,637L,665L,705L,715L,747L,765L,777L,783L,801L,805L,833L,845L,847L,867L,873L,891L,897L,903L,915L,925L,957L,961L,963L,987L,1001L,1005L,1025L,1045L,1075L,1083L,1113L,1143L,1175L,1197L,1209L,1245L,1265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176568Inst : IEnumerable<long>
{
public static readonly long[] Value=A176568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176568.Bytes);
public long this[int i]=>Value[i];

public static A176568Inst Instance=new A176568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176569
{
public static readonly long[] Value={ 1L,6L,6L,12L,12L,18L,18L,24L,28L,32L,36L,42L,42L,48L,52L,60L,60L,68L,70L,74L,78L,84L,88L,98L,100L,104L,106L,110L,112L,128L,130L,138L,138L,150L,150L,158L,162L,168L,172L,180L,180L,192L,192L,198L,198L,212L,222L,228L,228L,234L,238L,242L,250L,258L,262L,270L,270L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176569Inst : IEnumerable<long>
{
public static readonly long[] Value=A176569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176569.Bytes);
public long this[int i]=>Value[i];

public static A176569Inst Instance=new A176569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176570
{
public static readonly long[] Value={ 2L,3L,9L,5L,7L,15L,21L,11L,25L,13L,33L,17L,35L,19L,39L,23L,49L,51L,55L,57L,29L,31L,65L,69L,37L,77L,41L,85L,43L,87L,91L,93L,47L,95L,53L,111L,115L,59L,119L,121L,61L,123L,129L,133L,67L,141L,71L,143L,145L,73L,155L,79L,159L,161L,83L,169L,177L,89L,183L,185L,187L,97L,201L,101L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176570Inst : IEnumerable<long>
{
public static readonly long[] Value=A176570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176570.Bytes);
public long this[int i]=>Value[i];

public static A176570Inst Instance=new A176570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176571
{
public static readonly long[] Value={ 313L,577L,703L,785L,865L,949L,1111L,1703L,2041L,2071L,2579L,2677L,2809L,3157L,3379L,3545L,4001L,4135L,4873L,5143L,5513L,5549L,5659L,5695L,5731L,5917L,6031L,6277L,6427L,6547L,7951L,8027L,8425L,8873L,9569L,9995L,10147L,10393L,10511L,10717L,11321L,11479L,12127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176571Inst : IEnumerable<long>
{
public static readonly long[] Value=A176571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176571.Bytes);
public long this[int i]=>Value[i];

public static A176571Inst Instance=new A176571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176572
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,5L,1L,3L,3L,7L,1L,3L,4L,5L,11L,1L,4L,5L,7L,7L,15L,1L,4L,6L,8L,9L,11L,22L,1L,5L,7L,11L,10L,15L,15L,30L,1L,5L,9L,12L,13L,17L,19L,22L,42L,1L,6L,10L,16L,15L,22L,21L,29L,30L,56L,1L,6L,12L,18L,19L,25L,26L,32L,38L,42L,77L,1L,7L,14L,23L,22L,33L,29L,41L,42L,54L,56L,101L,1L,7L,16L,26L,28L,37L,37L,45L,52L,59L,70L,77L,135L,1L,8L,18L,32L,33L,47L,42L,58L,57L,74L,76L,98L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176572Inst : IEnumerable<long>
{
public static readonly long[] Value=A176572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176572.Bytes);
public long this[int i]=>Value[i];

public static A176572Inst Instance=new A176572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176573
{
public static readonly long[] Value={ 1L,4L,11L,31L,92L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176573Inst : IEnumerable<long>
{
public static readonly long[] Value=A176573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176573.Bytes);
public long this[int i]=>Value[i];

public static A176573Inst Instance=new A176573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176574
{
public static readonly long[] Value={ 1L,4L,11L,43L,143L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176574Inst : IEnumerable<long>
{
public static readonly long[] Value=A176574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176574.Bytes);
public long this[int i]=>Value[i];

public static A176574Inst Instance=new A176574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176575
{
public static readonly long[] Value={ 1L,10L,36L,42L,136L,146L,170L,292L,528L,546L,586L,682L,1092L,1170L,2080L,2114L,2184L,2186L,2340L,2346L,2730L,4228L,4370L,4706L,8256L,8322L,8456L,8458L,8738L,8740L,8746L,9362L,9386L,10922L,16644L,16912L,16914L,17476L,17482L,18724L,18730L,32896L,33026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176575Inst : IEnumerable<long>
{
public static readonly long[] Value=A176575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176575.Bytes);
public long this[int i]=>Value[i];

public static A176575Inst Instance=new A176575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176576
{
public static readonly long[] Value={ 1L,4L,11L,43L,161L,871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176576Inst : IEnumerable<long>
{
public static readonly long[] Value=A176576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176576.Bytes);
public long this[int i]=>Value[i];

public static A176576Inst Instance=new A176576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176577
{
public static readonly long[] Value={ 1L,2L,10L,3L,18L,36L,4L,21L,68L,42L,5L,34L,73L,74L,136L,7L,37L,132L,85L,264L,146L,8L,43L,137L,138L,273L,274L,170L,9L,66L,147L,149L,520L,293L,298L,292L,11L,69L,260L,171L,529L,530L,341L,548L,528L,15L,75L,265L,266L,547L,549L,554L,585L,1040L,546L,16L,87L,275L,277L,1032L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176577Inst : IEnumerable<long>
{
public static readonly long[] Value=A176577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176577.Bytes);
public long this[int i]=>Value[i];

public static A176577Inst Instance=new A176577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176578
{
public static readonly long[] Value={ 2L,7L,23L,89L,1607L,1753L,2351L,7393L,19543L,20593L,46639L,54449L,284527L,344249L,407791L,512009L,812431L,844433L,1214407L,1316033L,2109671L,2233601L,11251351L,11267777L,13903271L,14449489L,16203287L,16451713L,18219679L,18367721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176578Inst : IEnumerable<long>
{
public static readonly long[] Value=A176578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176578.Bytes);
public long this[int i]=>Value[i];

public static A176578Inst Instance=new A176578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176579
{
public static readonly long[] Value={ 5L,7L,11L,13L,19L,29L,59L,67L,73L,79L,89L,103L,127L,149L,163L,167L,181L,191L,227L,241L,251L,257L,263L,269L,271L,277L,283L,311L,347L,353L,359L,373L,383L,389L,397L,401L,409L,433L,439L,449L,457L,467L,479L,487L,503L,523L,541L,557L,571L,599L,601L,613L,643L,647L,659L,677L,691L,709L,719L,733L,739L,751L,757L,769L,811L,827L,839L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176579Inst : IEnumerable<long>
{
public static readonly long[] Value=A176579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176579.Bytes);
public long this[int i]=>Value[i];

public static A176579Inst Instance=new A176579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176580
{
public static readonly long[] Value={ 0L,2L,12L,52L,128L,246L,412L,667L,996L,1458L,1961L,2627L,3409L,4313L,5448L,6739L,8192L,9813L,11608L,13583L,15921L,18477L,21257L,24267L,27513L,31250L,35000L,39283L,43856L,48725L,53896L,59375L,65529L,71658L,78508L,85724L,93312L,101278L,109628L,118368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176580Inst : IEnumerable<long>
{
public static readonly long[] Value=A176580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176580.Bytes);
public long this[int i]=>Value[i];

public static A176580Inst Instance=new A176580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176581
{
public static readonly long[] Value={ 0L,2L,17L,63L,128L,269L,441L,704L,1041L,1458L,2024L,2700L,3492L,4406L,5553L,6856L,8192L,9954L,11761L,13748L,16100L,18670L,21464L,24488L,27748L,31250L,35265L,39564L,44153L,49038L,54225L,59720L,65892L,72037L,78905L,86139L,93312L,101729L,110097L,118855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176581Inst : IEnumerable<long>
{
public static readonly long[] Value=A176581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176581.Bytes);
public long this[int i]=>Value[i];

public static A176581Inst Instance=new A176581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176582
{
public static readonly long[] Value={ 0L,2L,5L,17L,24L,33L,63L,76L,128L,145L,164L,185L,269L,294L,321L,441L,472L,505L,540L,704L,743L,784L,827L,1041L,1088L,1137L,1188L,1458L,1513L,1570L,1629L,1690L,2024L,2089L,2156L,2225L,2296L,2700L,2775L,2852L,2931L,3012L,3492L,3577L,3664L,3753L,3844L,4406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176582Inst : IEnumerable<long>
{
public static readonly long[] Value=A176582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176582.Bytes);
public long this[int i]=>Value[i];

public static A176582Inst Instance=new A176582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176583
{
public static readonly long[] Value={ 0L,2L,12L,36L,43L,52L,100L,113L,128L,206L,225L,246L,360L,385L,412L,568L,599L,632L,667L,873L,912L,953L,996L,1258L,1305L,1354L,1405L,1458L,1784L,1841L,1900L,1961L,2355L,2420L,2487L,2556L,2627L,3097L,3172L,3249L,3328L,3409L,3961L,4046L,4133L,4222L,4313L,4953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176583Inst : IEnumerable<long>
{
public static readonly long[] Value=A176583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176583.Bytes);
public long this[int i]=>Value[i];

public static A176583Inst Instance=new A176583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176584
{
public static readonly long[] Value={ 2L,194057L,601067L,1607173L,3283993L,3630257L,3721363L,4918999L,5255713L,5848307L,6749569L,9999907L,17992913L,20432729L,23393483L,34746203L,44845993L,73843813L,84277273L,107165033L,109735649L,120469409L,125138873L,130898927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176584Inst : IEnumerable<long>
{
public static readonly long[] Value=A176584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176584.Bytes);
public long this[int i]=>Value[i];

public static A176584Inst Instance=new A176584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176585
{
public static readonly long[] Value={ 2L,17L,269L,281233L,1770217L,1826609L,2520841L,3907529L,7595017L,8665471L,9828089L,11280377L,12259063L,17235221L,27654961L,54008809L,70583033L,75196799L,85018949L,87240233L,106316057L,111499057L,168061561L,176255669L,201105409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176585Inst : IEnumerable<long>
{
public static readonly long[] Value=A176585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176585.Bytes);
public long this[int i]=>Value[i];

public static A176585Inst Instance=new A176585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176586
{
public static readonly long[] Value={ 3L,222601L,2824933L,3573761L,4215749L,5183821L,6001997L,6592613L,7886597L,8592401L,9725393L,10127813L,10531813L,12751093L,13720661L,15263009L,18087529L,30232597L,52730113L,68727469L,79395353L,109787269L,139967461L,162040453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176586Inst : IEnumerable<long>
{
public static readonly long[] Value=A176586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176586.Bytes);
public long this[int i]=>Value[i];

public static A176586Inst Instance=new A176586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176587
{
public static readonly long[] Value={ 1L,6L,10L,12L,14L,18L,20L,22L,24L,26L,28L,30L,34L,36L,38L,40L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,66L,68L,70L,72L,74L,75L,80L,82L,86L,88L,90L,92L,94L,96L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176587Inst : IEnumerable<long>
{
public static readonly long[] Value=A176587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176587.Bytes);
public long this[int i]=>Value[i];

public static A176587Inst Instance=new A176587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176588
{
public static readonly long[] Value={ 1L,21L,51L,6321L,8421L,931L,10521L,111L,1264321L,14721L,15531L,168421L,171L,1896321L,20105421L,21731L,221121L,231L,2412864321L,261321L,27931L,28147421L,291L,30151065321L,32168421L,331131L,341721L,35751L,361812964321L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176588Inst : IEnumerable<long>
{
public static readonly long[] Value=A176588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176588.Bytes);
public long this[int i]=>Value[i];

public static A176588Inst Instance=new A176588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176589
{
public static readonly long[] Value={ 1L,3L,7L,13L,31L,97L,103L,109L,151L,181L,193L,367L,409L,439L,487L,523L,571L,601L,613L,733L,811L,823L,1069L,1117L,1279L,1483L,1489L,1579L,1597L,1789L,1831L,1867L,1897L,1939L,2161L,2203L,2239L,2251L,2269L,2281L,2437L,2503L,2509L,2539L,2659L,2671L,2689L,2953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176589Inst : IEnumerable<long>
{
public static readonly long[] Value=A176589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176589.Bytes);
public long this[int i]=>Value[i];

public static A176589Inst Instance=new A176589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176590
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,10L,11L,12L,14L,15L,16L,17L,18L,20L,22L,23L,24L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,38L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176590Inst : IEnumerable<long>
{
public static readonly long[] Value=A176590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176590.Bytes);
public long this[int i]=>Value[i];

public static A176590Inst Instance=new A176590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176591
{
public static readonly long[] Value={ 1L,1L,6L,2L,30L,2L,42L,2L,30L,2L,66L,2L,2730L,2L,6L,2L,510L,2L,798L,2L,330L,2L,138L,2L,2730L,2L,6L,2L,870L,2L,14322L,2L,510L,2L,6L,2L,1919190L,2L,6L,2L,13530L,2L,1806L,2L,690L,2L,282L,2L,46410L,2L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176591Inst : IEnumerable<long>
{
public static readonly long[] Value=A176591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176591.Bytes);
public long this[int i]=>Value[i];

public static A176591Inst Instance=new A176591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176592
{
public static readonly long[] Value={ 1L,11L,2L,22L,3L,33L,4L,44L,5L,55L,6L,66L,7L,77L,8L,88L,9L,99L,10L,110L,11L,121L,12L,132L,13L,143L,14L,154L,15L,165L,16L,176L,17L,187L,18L,198L,19L,209L,20L,220L,21L,231L,22L,242L,23L,253L,24L,264L,25L,275L,26L,286L,27L,297L,28L,308L,29L,319L,30L,330L,31L,341L,32L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176592Inst : IEnumerable<long>
{
public static readonly long[] Value=A176592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176592.Bytes);
public long this[int i]=>Value[i];

public static A176592Inst Instance=new A176592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176593
{
public static readonly long[] Value={ 1L,13L,2L,26L,3L,39L,4L,52L,5L,65L,6L,78L,7L,91L,8L,104L,9L,117L,10L,130L,11L,143L,12L,156L,13L,169L,14L,182L,15L,195L,16L,208L,17L,221L,18L,234L,19L,247L,20L,260L,21L,273L,22L,286L,23L,299L,24L,312L,25L,325L,26L,338L,27L,351L,28L,364L,29L,377L,30L,390L,31L,403L,32L,416L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176593Inst : IEnumerable<long>
{
public static readonly long[] Value=A176593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176593.Bytes);
public long this[int i]=>Value[i];

public static A176593Inst Instance=new A176593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176594
{
public static readonly BigInteger[] Value={ 5L,25L,625L,390625L,152587890625L,BigInteger.Parse("23283064365386962890625"),BigInteger.Parse("542101086242752217003726400434970855712890625"),BigInteger.Parse("293873587705571876992184134305561419454666389193021880377187926569604314863681793212890625") };
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
public class A176594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176594Inst Instance=new A176594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176595
{
public static readonly BigInteger[] Value={ 11L,121L,14641L,214358881L,45949729863572161L,BigInteger.Parse("2111377674535255285545615254209921"),BigInteger.Parse("4457915684525902395869512133369841539490161434991526715513934826241") };
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
public class A176595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176595Inst Instance=new A176595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176596
{
public static readonly BigInteger[] Value={ 13L,169L,28561L,815730721L,665416609183179841L,BigInteger.Parse("442779263776840698304313192148785281"),BigInteger.Parse("196053476430761073330659760423566015424403280004115787589590963842248961") };
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
public class A176596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176596Inst Instance=new A176596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176597
{
public static readonly long[] Value={ 22L,33L,55L,77L,1111L,1313L,1717L,1919L,2323L,2929L,3131L,3737L,4141L,4343L,4747L,5353L,5959L,6161L,6767L,7171L,7373L,7979L,8383L,8989L,9797L,101101L,103103L,107107L,109109L,113113L,127127L,131131L,137137L,139139L,149149L,151151L,157157L,163163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176597Inst : IEnumerable<long>
{
public static readonly long[] Value=A176597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176597.Bytes);
public long this[int i]=>Value[i];

public static A176597Inst Instance=new A176597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176598
{
public static readonly long[] Value={ 410L,820L,1640L,2050L,3280L,4100L,6560L,8200L,10250L,13120L,16400L,16810L,20500L,26240L,32800L,33620L,41000L,51250L,52480L,65600L,67240L,82000L,84050L,102500L,104960L,131200L,134480L,164000L,168100L,205000L,209920L,256250L,262400L,268960L,328000L,336200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176598Inst : IEnumerable<long>
{
public static readonly long[] Value=A176598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176598.Bytes);
public long this[int i]=>Value[i];

public static A176598Inst Instance=new A176598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176599
{
public static readonly BigInteger[] Value={ 1L,-1L,-1L,-5L,-7L,-1631L,-96547L,-40291823L,-16870575007L,-7075000252463L,-2969301738826267L,BigInteger.Parse("-13713149169712887583"),BigInteger.Parse("-10557203537780702505907") };
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
public class A176599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176599Inst Instance=new A176599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176600
{
public static readonly long[] Value={ 19L,190L,250L,346L,378L,400L,402L,456L,516L,553L,567L,586L,664L,759L,762L,853L,931L,972L,1140L,1156L,1161L,1242L,1266L,1284L,1314L,1317L,1338L,1398L,1440L,1645L,1744L,1785L,1840L,1875L,1930L,1944L,2227L,2248L,2271L,2287L,2316L,2397L,2401L,2467L,2568L,2602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176600Inst : IEnumerable<long>
{
public static readonly long[] Value=A176600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176600.Bytes);
public long this[int i]=>Value[i];

public static A176600Inst Instance=new A176600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176601
{
public static readonly long[] Value={ 19L,853L,2287L,2467L,4243L,4513L,4621L,5431L,5701L,7243L,7477L,7591L,7927L,8221L,8317L,9283L,9439L,9817L,10039L,12781L,13933L,14461L,14923L,15727L,16693L,17443L,18199L,18217L,19207L,20749L,21139L,22147L,23761L,25471L,26701L,26953L,27481L,28111L,28447L,28579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176601Inst : IEnumerable<long>
{
public static readonly long[] Value=A176601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176601.Bytes);
public long this[int i]=>Value[i];

public static A176601Inst Instance=new A176601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176602
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-2L,-2L,1L,1L,-8L,-10L,-8L,1L,1L,-27L,-35L,-35L,-27L,1L,1L,-89L,-116L,-122L,-116L,-89L,1L,1L,-296L,-385L,-410L,-410L,-385L,-296L,1L,1L,-1000L,-1296L,-1383L,-1402L,-1383L,-1296L,-1000L,1L,1L,-3431L,-4431L,-4725L,-4806L,-4806L,-4725L,-4431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176602Inst : IEnumerable<long>
{
public static readonly long[] Value=A176602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176602.Bytes);
public long this[int i]=>Value[i];

public static A176602Inst Instance=new A176602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176603
{
public static readonly long[] Value={ 11L,17L,19L,83L,101L,281L,347L,349L,379L,401L,547L,641L,701L,839L,1103L,1151L,1171L,1187L,1279L,1303L,1409L,1439L,1489L,1823L,2089L,2243L,2857L,2861L,2927L,2999L,3083L,3203L,3347L,3359L,3467L,4639L,5087L,5233L,5861L,5879L,5881L,5923L,5953L,6007L,6299L,6491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176603Inst : IEnumerable<long>
{
public static readonly long[] Value=A176603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176603.Bytes);
public long this[int i]=>Value[i];

public static A176603Inst Instance=new A176603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176604
{
public static readonly long[] Value={ 1L,0L,1L,3L,7L,16L,39L,102L,279L,782L,2227L,6427L,18769L,55376L,164801L,494071L,1490663L,4522690L,13790171L,42234621L,129866725L,400765128L,1240796725L,3853055776L,11997619209L,37451945874L,117181432493L,367428949069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176604Inst : IEnumerable<long>
{
public static readonly long[] Value=A176604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176604.Bytes);
public long this[int i]=>Value[i];

public static A176604Inst Instance=new A176604Inst();

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