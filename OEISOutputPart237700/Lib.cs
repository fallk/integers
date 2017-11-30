using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A013653
{
public static readonly long[] Value={ 14L,19L,22L,23L,33L,34L,45L,47L,52L,54L,59L,60L,62L,69L,70L,71L,77L,78L,79L,95L,96L,98L,107L,114L,117L,118L,119L,127L,138L,140L,141L,142L,149L,153L,154L,164L,165L,167L,178L,187L,188L,189L,192L,194L,202L,205L,206L,216L,218L,219L,220L,221L,222L,223L,234L,238L,239L,248L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013653Inst : IEnumerable<long>
{
public static readonly long[] Value=A013653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013653.Bytes);
public long this[int i]=>Value[i];

public static A013653Inst Instance=new A013653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013654
{
public static readonly long[] Value={ 2L,8L,12L,24L,30L,48L,56L,80L,90L,120L,132L,168L,182L,224L,240L,288L,306L,360L,380L,440L,462L,528L,552L,624L,650L,728L,756L,840L,870L,960L,992L,1088L,1122L,1224L,1260L,1368L,1406L,1520L,1560L,1680L,1722L,1848L,1892L,2024L,2070L,2208L,2256L,2400L,2450L,2600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013654Inst : IEnumerable<long>
{
public static readonly long[] Value=A013654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013654.Bytes);
public long this[int i]=>Value[i];

public static A013654Inst Instance=new A013654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013655
{
public static readonly long[] Value={ 3L,2L,5L,7L,12L,19L,31L,50L,81L,131L,212L,343L,555L,898L,1453L,2351L,3804L,6155L,9959L,16114L,26073L,42187L,68260L,110447L,178707L,289154L,467861L,757015L,1224876L,1981891L,3206767L,5188658L,8395425L,13584083L,21979508L,35563591L,57543099L,93106690L,150649789L,243756479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013655Inst : IEnumerable<long>
{
public static readonly long[] Value=A013655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013655.Bytes);
public long this[int i]=>Value[i];

public static A013655Inst Instance=new A013655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013656
{
public static readonly long[] Value={ 0L,7L,32L,75L,136L,215L,312L,427L,560L,711L,880L,1067L,1272L,1495L,1736L,1995L,2272L,2567L,2880L,3211L,3560L,3927L,4312L,4715L,5136L,5575L,6032L,6507L,7000L,7511L,8040L,8587L,9152L,9735L,10336L,10955L,11592L,12247L,12920L,13611L,14320L,15047L,15792L,16555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013656Inst : IEnumerable<long>
{
public static readonly long[] Value=A013656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013656.Bytes);
public long this[int i]=>Value[i];

public static A013656Inst Instance=new A013656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013657
{
public static readonly long[] Value={ 14L,19L,22L,23L,33L,34L,45L,47L,52L,54L,59L,60L,61L,62L,69L,70L,71L,77L,78L,79L,95L,96L,98L,107L,109L,114L,116L,117L,118L,119L,127L,129L,138L,140L,141L,142L,149L,153L,154L,161L,162L,164L,165L,167L,178L,187L,188L,189L,192L,193L,194L,202L,205L,206L,216L,218L,219L,220L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013657Inst : IEnumerable<long>
{
public static readonly long[] Value=A013657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013657.Bytes);
public long this[int i]=>Value[i];

public static A013657Inst Instance=new A013657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013658
{
public static readonly long[] Value={ 39L,55L,56L,68L,84L,120L,132L,136L,155L,168L,184L,195L,203L,219L,228L,259L,280L,291L,292L,312L,323L,328L,340L,355L,372L,388L,408L,435L,483L,520L,532L,555L,568L,595L,627L,667L,708L,715L,723L,760L,763L,772L,795L,955L,1003L,1012L,1027L,1227L,1243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013658Inst : IEnumerable<long>
{
public static readonly long[] Value=A013658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013658.Bytes);
public long this[int i]=>Value[i];

public static A013658Inst Instance=new A013658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013659
{
public static readonly long[] Value={ 4L,2L,1L,8L,14L,4L,36L,18L,2L,9L,28L,6L,64L,32L,338L,16L,3L,392L,46L,8L,100L,50L,14L,25L,20L,3038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013659Inst : IEnumerable<long>
{
public static readonly long[] Value=A013659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013659.Bytes);
public long this[int i]=>Value[i];

public static A013659Inst Instance=new A013659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013660
{
public static readonly long[] Value={ 1L,2L,5L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013660Inst : IEnumerable<long>
{
public static readonly long[] Value=A013660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013660.Bytes);
public long this[int i]=>Value[i];

public static A013660Inst Instance=new A013660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013661
{
public static readonly long[] Value={ 1L,6L,4L,4L,9L,3L,4L,0L,6L,6L,8L,4L,8L,2L,2L,6L,4L,3L,6L,4L,7L,2L,4L,1L,5L,1L,6L,6L,6L,4L,6L,0L,2L,5L,1L,8L,9L,2L,1L,8L,9L,4L,9L,9L,0L,1L,2L,0L,6L,7L,9L,8L,4L,3L,7L,7L,3L,5L,5L,5L,8L,2L,2L,9L,3L,7L,0L,0L,0L,7L,4L,7L,0L,4L,0L,3L,2L,0L,0L,8L,7L,3L,8L,3L,3L,6L,2L,8L,9L,0L,0L,6L,1L,9L,7L,5L,8L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013661Inst : IEnumerable<long>
{
public static readonly long[] Value=A013661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013661.Bytes);
public long this[int i]=>Value[i];

public static A013661Inst Instance=new A013661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013678
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,9L,5L,3L,9L,6L,2L,0L,3L,3L,8L,7L,2L,7L,9L,6L,1L,1L,3L,1L,5L,2L,0L,3L,8L,6L,8L,3L,4L,4L,9L,3L,4L,5L,9L,4L,3L,7L,9L,4L,1L,8L,7L,4L,1L,0L,5L,9L,5L,7L,5L,0L,0L,5L,6L,4L,8L,9L,8L,5L,1L,1L,3L,7L,5L,1L,3L,7L,3L,1L,1L,4L,3L,9L,0L,0L,2L,5L,7L,8L,3L,6L,0L,9L,7L,9L,7L,6L,3L,8L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013678Inst : IEnumerable<long>
{
public static readonly long[] Value=A013678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013678.Bytes);
public long this[int i]=>Value[i];

public static A013678Inst Instance=new A013678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013679
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,2L,4L,7L,1L,4L,2L,3L,4L,10L,1L,2L,1L,1L,1L,15L,1L,3L,6L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,3L,1L,1L,5L,1L,2L,2L,1L,1L,6L,27L,20L,3L,97L,105L,1L,1L,1L,1L,1L,45L,2L,8L,19L,1L,4L,1L,1L,3L,1L,2L,1L,1L,1L,5L,1L,1L,2L,3L,6L,1L,1L,1L,2L,1L,5L,1L,1L,2L,9L,5L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013679Inst : IEnumerable<long>
{
public static readonly long[] Value=A013679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013679.Bytes);
public long this[int i]=>Value[i];

public static A013679Inst Instance=new A013679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013680
{
public static readonly long[] Value={ 1L,12L,6L,1L,3L,1L,4L,183L,1L,1L,2L,1L,3L,1L,1L,5L,4L,2L,7L,23L,1L,1L,1L,1L,3L,2L,4L,2L,2L,22L,1L,13L,5L,1L,4L,2L,1L,3L,1L,1L,1L,6L,11L,40L,1L,7L,5L,2L,4L,1L,2L,3L,14L,9L,1L,33L,78L,1L,12L,4L,1L,2L,551L,1L,1L,1L,1L,1L,1L,2L,1L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013680Inst : IEnumerable<long>
{
public static readonly long[] Value=A013680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013680.Bytes);
public long this[int i]=>Value[i];

public static A013680Inst Instance=new A013680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013681
{
public static readonly long[] Value={ 1L,27L,12L,1L,1L,15L,1L,5L,1L,2L,19L,1L,1L,32L,1L,13L,1L,1L,1L,3L,1L,3L,2L,16L,1L,12L,4L,1L,5L,1L,1L,1L,1L,1L,2L,2L,6L,1L,8L,8L,6L,2L,3L,2L,2L,1L,30L,1L,17L,116L,1L,7L,1L,1L,1L,1L,1L,1L,2L,2L,12L,1L,4L,1L,1L,94L,1L,1L,3L,3L,6L,6L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013681Inst : IEnumerable<long>
{
public static readonly long[] Value=A013681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013681.Bytes);
public long this[int i]=>Value[i];

public static A013681Inst Instance=new A013681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013682
{
public static readonly long[] Value={ 1L,57L,1L,1L,1L,15L,1L,6L,3L,61L,1L,5L,3L,1L,6L,1L,3L,3L,6L,1L,10L,1L,3L,2L,1L,4L,1L,1L,5L,1L,61L,1L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,2L,28L,1L,2L,18L,53L,2L,1L,17L,11L,3L,4L,3L,5L,2L,1L,27L,9L,8L,3L,3L,3L,9L,5L,1L,3L,29L,1L,4L,1L,2L,40L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013682Inst : IEnumerable<long>
{
public static readonly long[] Value=A013682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013682.Bytes);
public long this[int i]=>Value[i];

public static A013682Inst Instance=new A013682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013683
{
public static readonly long[] Value={ 1L,119L,1L,3L,2L,1L,2L,1L,39L,2L,3L,12L,3L,1L,1L,1L,2L,6L,5L,1L,5L,1L,2L,1L,23L,2L,1L,5L,34L,2L,1L,1L,3L,47L,2L,1L,8L,16L,1L,4L,1L,2L,1L,1L,1L,10L,72L,1L,1L,1L,1L,1L,2L,3L,13L,1L,2L,1L,5L,1L,27L,2L,9283L,1L,36L,1L,1L,1L,1L,3L,3L,23L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013683Inst : IEnumerable<long>
{
public static readonly long[] Value=A013683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013683.Bytes);
public long this[int i]=>Value[i];

public static A013683Inst Instance=new A013683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013684
{
public static readonly long[] Value={ 1L,245L,3L,1L,8L,4L,2L,3L,2L,1L,1L,4L,1L,3L,12L,2L,2L,34L,1L,1L,1L,1L,4L,9L,1L,56L,3L,38L,1L,1L,6L,1L,1L,1L,1L,3L,2L,1L,1L,5L,9L,3L,1L,11L,2L,3L,1L,5L,2L,2L,1L,4L,1L,27L,2L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,72L,17L,1L,36L,1L,5L,6L,1L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013684Inst : IEnumerable<long>
{
public static readonly long[] Value=A013684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013684.Bytes);
public long this[int i]=>Value[i];

public static A013684Inst Instance=new A013684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013685
{
public static readonly long[] Value={ 1L,497L,1L,10L,5L,1L,1L,8L,3L,2L,2L,1L,2L,1L,2L,5L,4L,2L,49L,1L,3L,3L,1L,1L,2L,1L,2L,30L,4L,1L,17L,3L,8L,2L,1L,2L,1L,1L,10L,6L,9L,2L,3L,1L,22L,1L,2L,1L,1L,2L,1L,1L,2L,18L,1L,1L,1L,9L,1L,2L,9L,1L,5L,2L,4L,1L,5L,1L,2L,2L,2L,6L,1L,8L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013685Inst : IEnumerable<long>
{
public static readonly long[] Value=A013685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013685.Bytes);
public long this[int i]=>Value[i];

public static A013685Inst Instance=new A013685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013686
{
public static readonly long[] Value={ 1L,1005L,2L,4L,1L,98L,7L,11L,2L,1L,1L,6L,2L,3L,28L,1L,37L,1L,2L,7L,9L,13L,85L,4L,3L,34L,5L,3L,7L,4L,7L,1L,3L,2L,1L,22L,1L,1L,1L,1L,3L,15L,1L,9L,12L,1L,3L,3L,3L,1L,3L,2L,1L,2L,1L,1L,2L,10L,8L,2L,2L,11L,54L,4L,5L,1L,2L,2L,1L,3L,2L,1L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013686Inst : IEnumerable<long>
{
public static readonly long[] Value=A013686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013686.Bytes);
public long this[int i]=>Value[i];

public static A013686Inst Instance=new A013686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013687
{
public static readonly long[] Value={ 1L,2023L,1L,1L,12L,1L,2L,2L,1L,102L,1L,44L,1L,2L,2L,1L,2L,3L,1L,5L,2L,1L,1L,2L,1L,13L,4L,14L,2L,5L,1L,5L,1L,6L,1L,2L,9L,1L,1L,1L,1L,7L,1L,2L,3L,1L,39L,3L,119L,12L,1L,1L,5L,1L,1L,151L,3L,4L,1L,2L,4L,98L,29L,6L,2L,1L,3L,9L,1L,1L,1L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013687Inst : IEnumerable<long>
{
public static readonly long[] Value=A013687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013687.Bytes);
public long this[int i]=>Value[i];

public static A013687Inst Instance=new A013687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013688
{
public static readonly long[] Value={ 1L,4063L,1L,1L,1L,1L,3L,14L,4L,5L,1L,8L,3L,1L,142L,1L,2L,1L,2L,2L,24L,1L,3L,20L,1L,1L,1L,60L,4L,1L,12L,1L,1L,1L,4L,23L,12L,1L,3L,11L,1L,2L,1L,13L,3L,16L,1L,91L,2L,2L,8L,1L,1L,1L,62L,1L,7L,1L,2L,15L,2L,5L,4L,1L,8L,1L,1L,20L,2L,2L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013688Inst : IEnumerable<long>
{
public static readonly long[] Value=A013688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013688.Bytes);
public long this[int i]=>Value[i];

public static A013688Inst Instance=new A013688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013689
{
public static readonly long[] Value={ 1L,8149L,13L,1L,2L,1L,6L,23L,3L,1L,7L,1L,1L,5L,1L,1L,4L,1L,1L,1L,4L,1L,1L,2L,2L,8L,1L,29L,32L,22L,2L,123L,1L,2L,1L,10L,1L,2L,2L,1L,4L,1L,13L,5L,8L,34L,2L,1L,7L,1L,2L,1L,3L,20L,8L,1L,4L,1L,5L,1L,59L,3L,7L,1L,1L,3L,2L,6L,1L,1L,2L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013689Inst : IEnumerable<long>
{
public static readonly long[] Value=A013689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013689.Bytes);
public long this[int i]=>Value[i];

public static A013689Inst Instance=new A013689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013690
{
public static readonly long[] Value={ 1L,16327L,36L,19L,2L,1L,35L,1L,4L,7L,5L,1L,1L,1L,3L,1L,2L,3L,2L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,7L,1L,4L,7L,4L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,4L,9L,2L,2L,1L,23L,6L,1L,2L,1L,2L,1L,1L,10L,1L,19L,7L,1L,1L,42L,1L,15L,1L,1L,4L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013690Inst : IEnumerable<long>
{
public static readonly long[] Value=A013690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013690.Bytes);
public long this[int i]=>Value[i];

public static A013690Inst Instance=new A013690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013691
{
public static readonly long[] Value={ 1L,32692L,3L,3L,1L,4L,1L,2L,3L,2L,1L,1L,1L,1L,1L,3L,1L,5L,1L,4L,1L,54L,1L,5L,5L,1L,20L,57L,5L,8L,1L,2L,26L,1L,1L,1L,1L,10L,1L,12L,1L,1L,7L,1L,2L,4L,1L,4L,1L,3L,5L,1L,1L,1L,1L,2L,4L,1L,18L,2L,2L,4L,1L,7L,4L,5L,1L,4L,2L,1L,1L,3L,1L,5L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013691Inst : IEnumerable<long>
{
public static readonly long[] Value=A013691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013691.Bytes);
public long this[int i]=>Value[i];

public static A013691Inst Instance=new A013691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013692
{
public static readonly long[] Value={ 1L,65435L,2L,1L,5L,1L,4L,1L,3L,3L,1L,7L,1L,2L,6L,2L,1L,7L,1L,1L,2L,1L,4L,4L,2L,3L,13L,1L,2L,1L,5L,1L,1L,8L,1L,5L,1L,1L,1L,4L,1L,2L,2L,2L,1L,44L,1L,2L,1L,2L,4L,2L,1L,6L,153L,41L,1L,26L,1L,4L,1L,3L,3L,1L,1L,1L,5L,6L,15L,4L,7L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013692Inst : IEnumerable<long>
{
public static readonly long[] Value=A013692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013692.Bytes);
public long this[int i]=>Value[i];

public static A013692Inst Instance=new A013692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013693
{
public static readonly long[] Value={ 1L,130938L,12L,2L,2L,8L,1L,6L,2L,3L,4L,2L,6L,1L,1L,7L,3L,10L,1L,5L,1L,2L,1L,2L,33L,3L,1L,4L,1L,1L,7L,5L,7L,1L,4L,1L,6L,1L,1L,2L,1L,1L,1L,5L,1L,1L,4L,1L,1L,1L,3L,1L,1L,3L,8L,2L,2L,2L,5L,5L,4L,2L,7L,2L,45L,5L,6L,2L,1L,1L,53L,1L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013693Inst : IEnumerable<long>
{
public static readonly long[] Value=A013693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013693.Bytes);
public long this[int i]=>Value[i];

public static A013693Inst Instance=new A013693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013694
{
public static readonly long[] Value={ 1L,261965L,1L,2L,1L,1L,1L,4L,3L,4L,3L,1L,1L,2L,1L,2L,2L,1L,1L,1L,1L,1L,1L,4L,1L,3L,3L,1L,2L,5L,1L,2L,3L,6L,1L,8L,3L,9L,1L,1L,1L,2L,3L,1L,1L,2L,1L,3L,1L,1L,1L,9L,1L,1L,21L,1L,3L,1L,3L,3L,3L,1L,1L,6L,4L,3L,5L,2L,1L,1L,26L,21L,6L,1L,11L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013694Inst : IEnumerable<long>
{
public static readonly long[] Value=A013694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013694.Bytes);
public long this[int i]=>Value[i];

public static A013694Inst Instance=new A013694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013695
{
public static readonly long[] Value={ 1L,524050L,1L,1L,2L,3L,1L,1L,1L,1L,3L,1L,2L,5L,14L,1L,5L,1L,3L,1L,3L,1L,3L,2L,1L,1L,1L,4L,1L,9L,1L,2L,1L,6L,2L,1L,1L,1L,76L,85L,1L,8L,1L,1L,7L,12L,7L,2L,1L,2L,4L,1L,3L,1L,22L,1L,3L,6L,1L,1L,1L,1L,1L,4L,1L,11L,1L,3L,1L,2L,1L,6L,1L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013695Inst : IEnumerable<long>
{
public static readonly long[] Value=A013695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013695.Bytes);
public long this[int i]=>Value[i];

public static A013695Inst Instance=new A013695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013696
{
public static readonly long[] Value={ 1L,1048259L,1L,2L,1L,18L,3L,1L,9L,7L,1L,1L,2L,1L,13L,3L,1L,1L,1L,2L,4L,2L,10L,2L,1L,1L,2L,8L,1L,1L,1L,3L,1L,3L,9L,2L,1L,2L,1L,1L,4L,2L,2L,56L,2L,2L,1L,1L,1L,6L,5L,2L,15L,1L,5L,2L,2L,1L,5L,1L,1L,39L,1L,6L,2L,6L,1L,1L,1L,3L,24L,11L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013696Inst : IEnumerable<long>
{
public static readonly long[] Value=A013696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013696.Bytes);
public long this[int i]=>Value[i];

public static A013696Inst Instance=new A013696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013697
{
public static readonly long[] Value={ 1L,4L,12L,27L,57L,119L,245L,497L,1005L,2023L,4063L,8149L,16327L,32692L,65435L,130938L,261965L,524050L,1048259L,2096730L,4193742L,8387859L,16776218L,33553102L,67107091L,134215364L,268432305L,536866711L,1073736223L,2147476180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013697Inst : IEnumerable<long>
{
public static readonly long[] Value=A013697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013697.Bytes);
public long this[int i]=>Value[i];

public static A013697Inst Instance=new A013697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013698
{
public static readonly long[] Value={ 1L,8L,55L,364L,2380L,15504L,100947L,657800L,4292145L,28048800L,183579396L,1203322288L,7898654920L,51915526432L,341643774795L,2250829575120L,14844575908435L,97997533741800L,647520696018735L,4282083008118300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013698Inst : IEnumerable<long>
{
public static readonly long[] Value=A013698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013698.Bytes);
public long this[int i]=>Value[i];

public static A013698Inst Instance=new A013698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013699
{
public static readonly long[] Value={ 1L,32L,610L,9842L,147798L,2145600L,30664890L,435668420L,6186432967L,88066807556L,1258885297696L,18084694597452L,261164661944060L,3791317346771584L,55316720239735242L,810944384733610356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013699Inst : IEnumerable<long>
{
public static readonly long[] Value=A013699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013699.Bytes);
public long this[int i]=>Value[i];

public static A013699Inst Instance=new A013699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013700
{
public static readonly BigInteger[] Value={ 1L,128L,6765L,265720L,9112264L,290926848L,8916942687L,266668876540L,7853149169635L,228982270335000L,6632994268595136L,191292945772217856L,5500214758962096400L,BigInteger.Parse("157819424038439232000"),BigInteger.Parse("4521902974531722618723") };
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
public class A013700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013700Inst Instance=new A013700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013701
{
public static readonly BigInteger[] Value={ 1L,512L,75025L,7174454L,562110290L,39541748736L,2610763825782L,165745451110910L,10262482704258873L,625250747214775916L,BigInteger.Parse("37701606156514031251"),BigInteger.Parse("2258713106034310399852"),BigInteger.Parse("134810129909509070121060") };
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
public class A013701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013701Inst Instance=new A013701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013702
{
public static readonly BigInteger[] Value={ 1L,2048L,832040L,193710244L,34673583028L,5372862566400L,763562937059280L,102703589621825280L,13319075453502743045UL,BigInteger.Parse("1684658996331320739600"),BigInteger.Parse("209381188023138094045641"),BigInteger.Parse("25698882980999585848747760") };
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
public class A013702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013702Inst Instance=new A013702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013703
{
public static readonly BigInteger[] Value={ 1L,2L,-6L,38L,-370L,4874L,-81046L,1628710L,-38393538L,1038795658L,-31730277062L,1080038539942L,-40538501660306L,1663428036271754L,-74080097240364918L,3558651343664651174L,BigInteger.Parse("-183423140013051563746"),BigInteger.Parse("10097324775041880827402"),BigInteger.Parse("-591270189493633774009510") };
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
public class A013703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013703Inst Instance=new A013703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013704
{
public static readonly long[] Value={ 2L,12L,44L,100L,203L,344L,558L,824L,1189L,1620L,2176L,2812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013704Inst : IEnumerable<long>
{
public static readonly long[] Value=A013704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013704.Bytes);
public long this[int i]=>Value[i];

public static A013704Inst Instance=new A013704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013705
{
public static readonly long[] Value={ 3L,1L,4L,1L,5L,9L,0L,6L,5L,3L,5L,8L,9L,7L,9L,3L,2L,4L,0L,4L,6L,2L,6L,4L,3L,3L,8L,3L,2L,6L,9L,5L,0L,2L,8L,8L,4L,1L,9L,7L,2L,9L,1L,3L,9L,9L,3L,7L,5L,1L,0L,3L,0L,5L,0L,9L,7L,4L,9L,4L,4L,6L,9L,3L,3L,4L,9L,8L,1L,6L,4L,0L,0L,8L,8L,0L,6L,8L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013705Inst : IEnumerable<long>
{
public static readonly long[] Value=A013705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013705.Bytes);
public long this[int i]=>Value[i];

public static A013705Inst Instance=new A013705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013706
{
public static readonly long[] Value={ 1L,5L,7L,0L,7L,8L,6L,3L,2L,6L,7L,9L,4L,8L,9L,7L,6L,1L,9L,2L,3L,1L,3L,2L,1L,1L,9L,1L,6L,3L,9L,7L,5L,2L,0L,5L,2L,0L,9L,8L,5L,8L,3L,3L,1L,4L,6L,8L,7L,5L,5L,7L,9L,6L,2L,5L,8L,7L,4L,4L,5L,2L,6L,8L,5L,0L,4L,1L,0L,7L,5L,6L,4L,1L,2L,2L,1L,6L,5L,3L,4L,8L,1L,2L,3L,5L,6L,6L,2L,0L,9L,0L,5L,5L,0L,9L,7L,3L,5L,2L,6L,8L,8L,4L,3L,6L,3L,2L,7L,4L,2L,5L,0L,9L,3L,7L,0L,4L,8L,2L,5L,0L,6L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013706Inst : IEnumerable<long>
{
public static readonly long[] Value=A013706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013706.Bytes);
public long this[int i]=>Value[i];

public static A013706Inst Instance=new A013706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013707
{
public static readonly long[] Value={ 6L,9L,3L,1L,3L,7L,1L,8L,0L,6L,5L,9L,9L,4L,5L,3L,0L,9L,3L,9L,7L,2L,3L,2L,1L,2L,1L,4L,7L,4L,1L,7L,6L,5L,6L,8L,0L,4L,8L,3L,0L,0L,1L,3L,4L,4L,3L,9L,6L,1L,5L,2L,5L,3L,7L,6L,6L,8L,8L,8L,0L,1L,1L,7L,3L,0L,2L,1L,9L,2L,0L,2L,9L,3L,2L,1L,2L,1L,8L,0L,5L,4L,7L,1L,2L,0L,3L,3L,9L,4L,1L,0L,7L,9L,5L,6L,9L,1L,9L,3L,2L,1L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013707Inst : IEnumerable<long>
{
public static readonly long[] Value=A013707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013707.Bytes);
public long this[int i]=>Value[i];

public static A013707Inst Instance=new A013707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013708
{
public static readonly long[] Value={ 3L,27L,243L,2187L,19683L,177147L,1594323L,14348907L,129140163L,1162261467L,10460353203L,94143178827L,847288609443L,7625597484987L,68630377364883L,617673396283947L,5559060566555523L,50031545098999707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013708Inst : IEnumerable<long>
{
public static readonly long[] Value=A013708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013708.Bytes);
public long this[int i]=>Value[i];

public static A013708Inst Instance=new A013708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013709
{
public static readonly long[] Value={ 4L,64L,1024L,16384L,262144L,4194304L,67108864L,1073741824L,17179869184L,274877906944L,4398046511104L,70368744177664L,1125899906842624L,18014398509481984L,288230376151711744L,4611686018427387904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013709Inst : IEnumerable<long>
{
public static readonly long[] Value=A013709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013709.Bytes);
public long this[int i]=>Value[i];

public static A013709Inst Instance=new A013709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013710
{
public static readonly BigInteger[] Value={ 5L,125L,3125L,78125L,1953125L,48828125L,1220703125L,30517578125L,762939453125L,19073486328125L,476837158203125L,11920928955078125L,298023223876953125L,7450580596923828125L,BigInteger.Parse("186264514923095703125") };
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
public class A013710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013710Inst Instance=new A013710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013711
{
public static readonly BigInteger[] Value={ 6L,216L,7776L,279936L,10077696L,362797056L,13060694016L,470184984576L,16926659444736L,609359740010496L,21936950640377856L,789730223053602816L,BigInteger.Parse("28430288029929701376"),BigInteger.Parse("1023490369077469249536"),BigInteger.Parse("36845653286788892983296") };
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
public class A013711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013711Inst Instance=new A013711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013712
{
public static readonly BigInteger[] Value={ 7L,343L,16807L,823543L,40353607L,1977326743L,96889010407L,4747561509943L,232630513987207L,11398895185373143L,558545864083284007L,BigInteger.Parse("27368747340080916343"),BigInteger.Parse("1341068619663964900807"),BigInteger.Parse("65712362363534280139543"),BigInteger.Parse("3219905755813179726837607") };
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
public class A013712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013712Inst Instance=new A013712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013713
{
public static readonly BigInteger[] Value={ 8L,512L,32768L,2097152L,134217728L,8589934592L,549755813888L,35184372088832L,2251799813685248L,144115188075855872L,9223372036854775808UL,BigInteger.Parse("590295810358705651712"),BigInteger.Parse("37778931862957161709568"),BigInteger.Parse("2417851639229258349412352") };
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
public class A013713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013713Inst Instance=new A013713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013714
{
public static readonly BigInteger[] Value={ 9L,729L,59049L,4782969L,387420489L,31381059609L,2541865828329L,205891132094649L,16677181699666569L,1350851717672992089L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("8862938119652501095929"),BigInteger.Parse("717897987691852588770249"),BigInteger.Parse("58149737003040059690390169") };
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
public class A013714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013714Inst Instance=new A013714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013715
{
public static readonly BigInteger[] Value={ 10L,1000L,100000L,10000000L,1000000000L,100000000000L,10000000000000L,1000000000000000L,100000000000000000L,10000000000000000000UL,BigInteger.Parse("1000000000000000000000"),BigInteger.Parse("100000000000000000000000") };
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
public class A013715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013715Inst Instance=new A013715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013716
{
public static readonly BigInteger[] Value={ 11L,1331L,161051L,19487171L,2357947691L,285311670611L,34522712143931L,4177248169415651L,505447028499293771L,BigInteger.Parse("61159090448414546291"),BigInteger.Parse("7400249944258160101211"),BigInteger.Parse("895430243255237372246531") };
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
public class A013716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013716Inst Instance=new A013716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013717
{
public static readonly BigInteger[] Value={ 12L,1728L,248832L,35831808L,5159780352L,743008370688L,106993205379072L,15407021574586368L,2218611106740436992L,BigInteger.Parse("319479999370622926848"),BigInteger.Parse("46005119909369701466112"),BigInteger.Parse("6624737266949237011120128") };
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
public class A013717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013717Inst Instance=new A013717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013718
{
public static readonly BigInteger[] Value={ 13L,2197L,371293L,62748517L,10604499373L,1792160394037L,302875106592253L,51185893014090757L,8650415919381337933L,BigInteger.Parse("1461920290375446110677"),BigInteger.Parse("247064529073450392704413"),BigInteger.Parse("41753905413413116367045797") };
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
public class A013718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013718Inst Instance=new A013718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013719
{
public static readonly BigInteger[] Value={ 14L,2744L,537824L,105413504L,20661046784L,4049565169664L,793714773254144L,155568095557812224L,BigInteger.Parse("30491346729331195904"),BigInteger.Parse("5976303958948914397184"),BigInteger.Parse("1171355575953987221848064"),BigInteger.Parse("229585692886981495482220544") };
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
public class A013719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013719Inst Instance=new A013719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013720
{
public static readonly BigInteger[] Value={ 15L,3375L,759375L,170859375L,38443359375L,8649755859375L,1946195068359375L,437893890380859375L,BigInteger.Parse("98526125335693359375"),BigInteger.Parse("22168378200531005859375"),BigInteger.Parse("4987885095119476318359375"),BigInteger.Parse("1122274146401882171630859375") };
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
public class A013720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013720Inst Instance=new A013720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013721
{
public static readonly BigInteger[] Value={ 16L,4096L,1048576L,268435456L,68719476736L,17592186044416L,4503599627370496L,1152921504606846976L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("4951760157141521099596496896") };
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
public class A013721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013721Inst Instance=new A013721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013722
{
public static readonly BigInteger[] Value={ 17L,4913L,1419857L,410338673L,118587876497L,34271896307633L,9904578032905937L,2862423051509815793L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("239072435685151324847153"),BigInteger.Parse("69091933913008732880827217") };
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
public class A013722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013722Inst Instance=new A013722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013723
{
public static readonly BigInteger[] Value={ 18L,5832L,1889568L,612220032L,198359290368L,64268410079232L,20822964865671168L,6746640616477458432L,BigInteger.Parse("2185911559738696531968"),BigInteger.Parse("708235345355337676357632"),BigInteger.Parse("229468251895129407139872768") };
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
public class A013723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013723Inst Instance=new A013723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013724
{
public static readonly BigInteger[] Value={ 19L,6859L,2476099L,893871739L,322687697779L,116490258898219L,42052983462257059L,15181127029874798299UL,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("1978419655660313589123979"),BigInteger.Parse("714209495693373205673756419") };
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
public class A013724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013724Inst Instance=new A013724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013725
{
public static readonly BigInteger[] Value={ 20L,8000L,3200000L,1280000000L,512000000000L,204800000000000L,81920000000000000L,BigInteger.Parse("32768000000000000000"),BigInteger.Parse("13107200000000000000000"),BigInteger.Parse("5242880000000000000000000"),BigInteger.Parse("2097152000000000000000000000") };
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
public class A013725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013725Inst Instance=new A013725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013726
{
public static readonly BigInteger[] Value={ 21L,9261L,4084101L,1801088541L,794280046581L,350277500542221L,154472377739119461L,BigInteger.Parse("68122318582951682301"),BigInteger.Parse("30041942495081691894741"),BigInteger.Parse("13248496640331026125580781"),BigInteger.Parse("5842587018385982521381124421") };
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
public class A013726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013726Inst Instance=new A013726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013727
{
public static readonly BigInteger[] Value={ 22L,10648L,5153632L,2494357888L,1207269217792L,584318301411328L,282810057883082752L,BigInteger.Parse("136880068015412051968"),BigInteger.Parse("66249952919459433152512"),BigInteger.Parse("32064977213018365645815808"),BigInteger.Parse("15519448971100888972574851072") };
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
public class A013727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013727Inst Instance=new A013727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013728
{
public static readonly BigInteger[] Value={ 23L,12167L,6436343L,3404825447L,1801152661463L,952809757913927L,504036361936467383L,BigInteger.Parse("266635235464391245607"),BigInteger.Parse("141050039560662968926103"),BigInteger.Parse("74615470927590710561908487"),BigInteger.Parse("39471584120695485887249589623") };
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
public class A013728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013728Inst Instance=new A013728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013729
{
public static readonly BigInteger[] Value={ 24L,13824L,7962624L,4586471424L,2641807540224L,1521681143169024L,876488338465357824L,BigInteger.Parse("504857282956046106624"),BigInteger.Parse("290797794982682557415424"),BigInteger.Parse("167499529910025153071284224"),BigInteger.Parse("96479729228174488169059713024") };
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
public class A013729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013729Inst Instance=new A013729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013730
{
public static readonly long[] Value={ 2L,16L,128L,1024L,8192L,65536L,524288L,4194304L,33554432L,268435456L,2147483648L,17179869184L,137438953472L,1099511627776L,8796093022208L,70368744177664L,562949953421312L,4503599627370496L,36028797018963968L,288230376151711744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013730Inst : IEnumerable<long>
{
public static readonly long[] Value=A013730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013730.Bytes);
public long this[int i]=>Value[i];

public static A013730Inst Instance=new A013730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013731
{
public static readonly long[] Value={ 4L,32L,256L,2048L,16384L,131072L,1048576L,8388608L,67108864L,536870912L,4294967296L,34359738368L,274877906944L,2199023255552L,17592186044416L,140737488355328L,1125899906842624L,9007199254740992L,72057594037927936L,576460752303423488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013731Inst : IEnumerable<long>
{
public static readonly long[] Value=A013731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013731.Bytes);
public long this[int i]=>Value[i];

public static A013731Inst Instance=new A013731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013732
{
public static readonly BigInteger[] Value={ 3L,81L,2187L,59049L,1594323L,43046721L,1162261467L,31381059609L,847288609443L,22876792454961L,617673396283947L,16677181699666569L,450283905890997363L,12157665459056928801UL,BigInteger.Parse("328256967394537077627"),BigInteger.Parse("8862938119652501095929") };
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
public class A013732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013732Inst Instance=new A013732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013733
{
public static readonly BigInteger[] Value={ 9L,243L,6561L,177147L,4782969L,129140163L,3486784401L,94143178827L,2541865828329L,68630377364883L,1853020188851841L,50031545098999707L,1350851717672992089L,BigInteger.Parse("36472996377170786403"),BigInteger.Parse("984770902183611232881"),BigInteger.Parse("26588814358957503287787") };
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
public class A013733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013733Inst Instance=new A013733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013734
{
public static readonly BigInteger[] Value={ 4L,256L,16384L,1048576L,67108864L,4294967296L,274877906944L,17592186044416L,1125899906842624L,72057594037927936L,4611686018427387904L,BigInteger.Parse("295147905179352825856"),BigInteger.Parse("18889465931478580854784"),BigInteger.Parse("1208925819614629174706176") };
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
public class A013734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013734Inst Instance=new A013734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013735
{
public static readonly BigInteger[] Value={ 16L,1024L,65536L,4194304L,268435456L,17179869184L,1099511627776L,70368744177664L,4503599627370496L,288230376151711744L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("1180591620717411303424"),BigInteger.Parse("75557863725914323419136"),BigInteger.Parse("4835703278458516698824704") };
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
public class A013735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013735Inst Instance=new A013735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013736
{
public static readonly BigInteger[] Value={ 5L,625L,78125L,9765625L,1220703125L,152587890625L,19073486328125L,2384185791015625L,298023223876953125L,BigInteger.Parse("37252902984619140625"),BigInteger.Parse("4656612873077392578125"),BigInteger.Parse("582076609134674072265625"),BigInteger.Parse("72759576141834259033203125") };
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
public class A013736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013736Inst Instance=new A013736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013737
{
public static readonly BigInteger[] Value={ 25L,3125L,390625L,48828125L,6103515625L,762939453125L,95367431640625L,11920928955078125L,1490116119384765625L,BigInteger.Parse("186264514923095703125"),BigInteger.Parse("23283064365386962890625"),BigInteger.Parse("2910383045673370361328125"),BigInteger.Parse("363797880709171295166015625") };
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
public class A013737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013737Inst Instance=new A013737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013738
{
public static readonly BigInteger[] Value={ 6L,1296L,279936L,60466176L,13060694016L,2821109907456L,609359740010496L,131621703842267136L,BigInteger.Parse("28430288029929701376"),BigInteger.Parse("6140942214464815497216"),BigInteger.Parse("1326443518324400147398656"),BigInteger.Parse("286511799958070431838109696") };
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
public class A013738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013738Inst Instance=new A013738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013739
{
public static readonly BigInteger[] Value={ 36L,7776L,1679616L,362797056L,78364164096L,16926659444736L,3656158440062976L,789730223053602816L,BigInteger.Parse("170581728179578208256"),BigInteger.Parse("36845653286788892983296"),BigInteger.Parse("7958661109946400884391936"),BigInteger.Parse("1719070799748422591028658176") };
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
public class A013739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013739Inst Instance=new A013739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013740
{
public static readonly BigInteger[] Value={ 7L,2401L,823543L,282475249L,96889010407L,33232930569601L,11398895185373143L,3909821048582988049L,BigInteger.Parse("1341068619663964900807"),BigInteger.Parse("459986536544739960976801"),BigInteger.Parse("157775382034845806615042743"),BigInteger.Parse("54116956037952111668959660849") };
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
public class A013740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013740Inst Instance=new A013740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013741
{
public static readonly BigInteger[] Value={ 49L,16807L,5764801L,1977326743L,678223072849L,232630513987207L,79792266297612001L,BigInteger.Parse("27368747340080916343"),BigInteger.Parse("9387480337647754305649"),BigInteger.Parse("3219905755813179726837607"),BigInteger.Parse("1104427674243920646305299201"),BigInteger.Parse("378818692265664781682717625943") };
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
public class A013741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013741Inst Instance=new A013741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013742
{
public static readonly BigInteger[] Value={ 8L,4096L,2097152L,1073741824L,549755813888L,281474976710656L,144115188075855872L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("37778931862957161709568"),BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("9903520314283042199192993792"),BigInteger.Parse("5070602400912917605986812821504") };
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
public class A013742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013742Inst Instance=new A013742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013743
{
public static readonly BigInteger[] Value={ 64L,32768L,16777216L,8589934592L,4398046511104L,2251799813685248L,1152921504606846976L,BigInteger.Parse("590295810358705651712"),BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("154742504910672534362390528"),BigInteger.Parse("79228162514264337593543950336"),BigInteger.Parse("40564819207303340847894502572032") };
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
public class A013743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013743Inst Instance=new A013743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013744
{
public static readonly BigInteger[] Value={ 9L,6561L,4782969L,3486784401L,2541865828329L,1853020188851841L,1350851717672992089L,BigInteger.Parse("984770902183611232881"),BigInteger.Parse("717897987691852588770249"),BigInteger.Parse("523347633027360537213511521"),BigInteger.Parse("381520424476945831628649898809") };
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
public class A013744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013744Inst Instance=new A013744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013745
{
public static readonly BigInteger[] Value={ 81L,59049L,43046721L,31381059609L,22876792454961L,16677181699666569L,12157665459056928801UL,BigInteger.Parse("8862938119652501095929"),BigInteger.Parse("6461081889226673298932241"),BigInteger.Parse("4710128697246244834921603689"),BigInteger.Parse("3433683820292512484657849089281") };
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
public class A013745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013745Inst Instance=new A013745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013746
{
public static readonly BigInteger[] Value={ 10L,10000L,10000000L,10000000000L,10000000000000L,10000000000000000L,10000000000000000000UL,BigInteger.Parse("10000000000000000000000"),BigInteger.Parse("10000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000") };
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
public class A013746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013746Inst Instance=new A013746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013747
{
public static readonly BigInteger[] Value={ 100L,100000L,100000000L,100000000000L,100000000000000L,100000000000000000L,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("100000000000000000000000"),BigInteger.Parse("100000000000000000000000000"),BigInteger.Parse("100000000000000000000000000000") };
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
public class A013747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013747Inst Instance=new A013747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013748
{
public static readonly BigInteger[] Value={ 11L,14641L,19487171L,25937424601L,34522712143931L,45949729863572161L,BigInteger.Parse("61159090448414546291"),BigInteger.Parse("81402749386839761113321"),BigInteger.Parse("108347059433883722041830251"),BigInteger.Parse("144209936106499234037676064081"),BigInteger.Parse("191943424957750480504146841291811") };
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
public class A013748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013748Inst Instance=new A013748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013749
{
public static readonly BigInteger[] Value={ 121L,161051L,214358881L,285311670611L,379749833583241L,505447028499293771L,BigInteger.Parse("672749994932560009201"),BigInteger.Parse("895430243255237372246531"),BigInteger.Parse("1191817653772720942460132761"),BigInteger.Parse("1586309297171491574414436704891"),BigInteger.Parse("2111377674535255285545615254209921") };
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
public class A013749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013749Inst Instance=new A013749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013750
{
public static readonly BigInteger[] Value={ 12L,20736L,35831808L,61917364224L,106993205379072L,184884258895036416L,BigInteger.Parse("319479999370622926848"),BigInteger.Parse("552061438912436417593344"),BigInteger.Parse("953962166440690129601298432"),BigInteger.Parse("1648446623609512543951043690496") };
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
public class A013750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013750Inst Instance=new A013750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013751
{
public static readonly BigInteger[] Value={ 144L,248832L,429981696L,743008370688L,1283918464548864L,2218611106740436992L,BigInteger.Parse("3833759992447475122176"),BigInteger.Parse("6624737266949237011120128"),BigInteger.Parse("11447545997288281555215581184") };
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
public class A013751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013751Inst Instance=new A013751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013752
{
public static readonly BigInteger[] Value={ 13L,28561L,62748517L,137858491849L,302875106592253L,665416609183179841L,BigInteger.Parse("1461920290375446110677"),BigInteger.Parse("3211838877954855105157369"),BigInteger.Parse("7056410014866816666030739693") };
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
public class A013752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013752Inst Instance=new A013752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013753
{
public static readonly BigInteger[] Value={ 169L,371293L,815730721L,1792160394037L,3937376385699289L,8650415919381337933L,BigInteger.Parse("19004963774880799438801"),BigInteger.Parse("41753905413413116367045797"),BigInteger.Parse("91733330193268616658399616009"),BigInteger.Parse("201538126434611150798503956371773"),BigInteger.Parse("442779263776840698304313192148785281"),BigInteger.Parse("972786042517719014174576083150881262357") };
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
public class A013753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013753Inst Instance=new A013753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013754
{
public static readonly BigInteger[] Value={ 14L,38416L,105413504L,289254654976L,793714773254144L,2177953337809371136L,BigInteger.Parse("5976303958948914397184"),BigInteger.Parse("16398978063355821105872896"),BigInteger.Parse("44998795805848373114515226624"),BigInteger.Parse("123476695691247935826229781856256"),BigInteger.Parse("338820052976784335907174521413566464"),BigInteger.Parse("929722225368296217729286886758826377216") };
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
public class A013754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013754Inst Instance=new A013754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013755
{
public static readonly BigInteger[] Value={ 196L,537824L,1475789056L,4049565169664L,11112006825558016L,BigInteger.Parse("30491346729331195904"),BigInteger.Parse("83668255425284801560576"),BigInteger.Parse("229585692886981495482220544"),BigInteger.Parse("629983141281877223603213172736"),BigInteger.Parse("1728673739677471101567216945987584"),BigInteger.Parse("4743480741674980702700443299789930496") };
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
public class A013755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013755Inst Instance=new A013755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013756
{
public static readonly BigInteger[] Value={ 15L,50625L,170859375L,576650390625L,1946195068359375L,6568408355712890625L,BigInteger.Parse("22168378200531005859375"),BigInteger.Parse("74818276426792144775390625"),BigInteger.Parse("252511682940423488616943359375"),BigInteger.Parse("852226929923929274082183837890625"),BigInteger.Parse("2876265888493261300027370452880859375") };
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
public class A013756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013756Inst Instance=new A013756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013757
{
public static readonly BigInteger[] Value={ 225L,759375L,2562890625L,8649755859375L,29192926025390625L,BigInteger.Parse("98526125335693359375"),BigInteger.Parse("332525673007965087890625"),BigInteger.Parse("1122274146401882171630859375"),BigInteger.Parse("3787675244106352329254150390625"),BigInteger.Parse("12783403948858939111232757568359375") };
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
public class A013757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013757Inst Instance=new A013757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013806
{
public static readonly BigInteger[] Value={ 17L,1419857L,118587876497L,9904578032905937L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("69091933913008732880827217"),BigInteger.Parse("5770627412348402378939569991057"),BigInteger.Parse("481968572106750915091411825223071697"),BigInteger.Parse("40254497110927943179349807054456171205137") };
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
public class A013806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013806Inst Instance=new A013806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013807
{
public static readonly BigInteger[] Value={ 4913L,410338673L,34271896307633L,2862423051509815793L,BigInteger.Parse("239072435685151324847153"),BigInteger.Parse("19967568900859523802559065713"),BigInteger.Parse("1667711322168688287513535727415473"),BigInteger.Parse("139288917338851014461418017489467720433"),BigInteger.Parse("11633549665058175578832094238737833478284593") };
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
public class A013807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013807Inst Instance=new A013807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013808
{
public static readonly BigInteger[] Value={ 18L,1889568L,198359290368L,20822964865671168L,BigInteger.Parse("2185911559738696531968"),BigInteger.Parse("229468251895129407139872768"),BigInteger.Parse("24088659210943104643915283693568"),BigInteger.Parse("2528731089327963353099650821015994368"),BigInteger.Parse("265456074833292280954988944586975024775168") };
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
public class A013808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013808Inst Instance=new A013808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013809
{
public static readonly BigInteger[] Value={ 5832L,612220032L,64268410079232L,6746640616477458432L,BigInteger.Parse("708235345355337676357632"),BigInteger.Parse("74347713614021927913318776832"),BigInteger.Parse("7804725584345565904628551916716032"),BigInteger.Parse("819308872942260126404286866009182175232"),BigInteger.Parse("86007768245986699029416418046179908027154432") };
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
public class A013809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013809Inst Instance=new A013809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013810
{
public static readonly BigInteger[] Value={ 19L,2476099L,322687697779L,42052983462257059L,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("714209495693373205673756419"),BigInteger.Parse("93076495688256089536609610280499"),BigInteger.Parse("12129821994589221844500501021364910179"),BigInteger.Parse("1580770532156861979997149793605296459437459") };
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
public class A013810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013810Inst Instance=new A013810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013811
{
public static readonly BigInteger[] Value={ 6859L,893871739L,116490258898219L,15181127029874798299UL,BigInteger.Parse("1978419655660313589123979"),BigInteger.Parse("257829627945307727248226067259"),BigInteger.Parse("33600614943460448322716069311260139"),BigInteger.Parse("4378865740046709085864680868712732574619"),BigInteger.Parse("570658162108627174778971075491512021856922699") };
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
public class A013811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013811Inst Instance=new A013811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013812
{
public static readonly BigInteger[] Value={ 20L,3200000L,512000000000L,81920000000000000L,BigInteger.Parse("13107200000000000000000"),BigInteger.Parse("2097152000000000000000000000"),BigInteger.Parse("335544320000000000000000000000000"),BigInteger.Parse("53687091200000000000000000000000000000"),BigInteger.Parse("8589934592000000000000000000000000000000000") };
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
public class A013812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013812Inst Instance=new A013812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013813
{
public static readonly BigInteger[] Value={ 8000L,1280000000L,204800000000000L,BigInteger.Parse("32768000000000000000"),BigInteger.Parse("5242880000000000000000000"),BigInteger.Parse("838860800000000000000000000000"),BigInteger.Parse("134217728000000000000000000000000000"),BigInteger.Parse("21474836480000000000000000000000000000000"),BigInteger.Parse("3435973836800000000000000000000000000000000000") };
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
public class A013813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013813Inst Instance=new A013813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013814
{
public static readonly BigInteger[] Value={ 21L,4084101L,794280046581L,154472377739119461L,BigInteger.Parse("30041942495081691894741"),BigInteger.Parse("5842587018385982521381124421"),BigInteger.Parse("1136272165922724266740722458520501"),BigInteger.Parse("220983347100817338120002444455525554981"),BigInteger.Parse("42977062327514056734916195400155065458259861") };
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
public class A013814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013814Inst Instance=new A013814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013815
{
public static readonly BigInteger[] Value={ 9261L,1801088541L,350277500542221L,BigInteger.Parse("68122318582951682301"),BigInteger.Parse("13248496640331026125580781"),BigInteger.Parse("2576580875108218291929075869661"),BigInteger.Parse("501096025171921401632658604207540941"),BigInteger.Parse("97453656071460446110921078004886769746621"),BigInteger.Parse("18952884486433699020098042171468383867092598701") };
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
public class A013815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013815Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013815.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013815Inst Instance=new A013815Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013816
{
public static readonly BigInteger[] Value={ 22L,5153632L,1207269217792L,282810057883082752L,BigInteger.Parse("66249952919459433152512"),BigInteger.Parse("15519448971100888972574851072"),BigInteger.Parse("3635524038174209847159494312722432"),BigInteger.Parse("851643319086537701956194499721106030592"),BigInteger.Parse("199502557355935975909450298726667414302359552") };
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
public class A013816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013816Inst Instance=new A013816Inst();

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