using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A258082
{
public static readonly long[] Value={ 240L,29790L,24024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258082Inst : IEnumerable<long>
{
public static readonly long[] Value=A258082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258082.Bytes);
public long this[int i]=>Value[i];

public static A258082Inst Instance=new A258082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258083
{
public static readonly long[] Value={ 21L,12L,3L,24L,15L,6L,27L,18L,9L,210L,111L,312L,213L,114L,315L,216L,117L,318L,219L,120L,321L,222L,123L,324L,225L,126L,327L,228L,129L,30L,231L,132L,33L,234L,135L,36L,237L,138L,39L,240L,141L,42L,243L,144L,45L,246L,147L,48L,249L,150L,51L,252L,153L,54L,255L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258083Inst : IEnumerable<long>
{
public static readonly long[] Value=A258083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258083.Bytes);
public long this[int i]=>Value[i];

public static A258083Inst Instance=new A258083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258084
{
public static readonly long[] Value={ 2L,3L,5L,7L,10L,13L,15L,18L,19L,31L,35L,37L,38L,72L,75L,78L,79L,91L,92L,100L,103L,105L,106L,113L,114L,124L,127L,128L,133L,138L,139L,143L,147L,154L,155L,163L,165L,166L,174L,179L,181L,184L,193L,198L,199L,301L,302L,304L,307L,308L,315L,323L,324L,335L,345L,348L,351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258084Inst : IEnumerable<long>
{
public static readonly long[] Value=A258084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258084.Bytes);
public long this[int i]=>Value[i];

public static A258084Inst Instance=new A258084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258085
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,12L,13L,20L,21L,33L,34L,54L,55L,88L,89L,143L,144L,232L,233L,376L,377L,609L,610L,986L,987L,1596L,1597L,2583L,2584L,4180L,4181L,6764L,6765L,10945L,10946L,17710L,17711L,28656L,28657L,46367L,46368L,75024L,75025L,121392L,121393L,196417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258085Inst : IEnumerable<long>
{
public static readonly long[] Value=A258085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258085.Bytes);
public long this[int i]=>Value[i];

public static A258085Inst Instance=new A258085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258086
{
public static readonly long[] Value={ 1L,3L,5L,9L,0L,9L,8L,2L,7L,7L,1L,1L,3L,5L,4L,8L,2L,6L,4L,6L,4L,3L,5L,2L,4L,2L,0L,6L,0L,7L,5L,7L,2L,0L,7L,8L,7L,1L,1L,2L,8L,2L,8L,4L,5L,1L,0L,5L,1L,5L,6L,8L,6L,9L,4L,0L,6L,0L,6L,5L,2L,6L,3L,1L,6L,6L,5L,0L,1L,6L,5L,6L,7L,1L,3L,6L,5L,3L,4L,2L,1L,3L,0L,3L,2L,9L,0L,7L,6L,2L,6L,4L,7L,0L,9L,8L,5L,5L,3L,8L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258086Inst : IEnumerable<long>
{
public static readonly long[] Value=A258086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258086.Bytes);
public long this[int i]=>Value[i];

public static A258086Inst Instance=new A258086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258087
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,9L,14L,18L,25L,30L,39L,45L,56L,63L,76L,84L,99L,108L,125L,135L,154L,165L,186L,198L,221L,234L,259L,273L,300L,315L,344L,360L,391L,408L,441L,459L,494L,513L,550L,570L,609L,630L,671L,693L,736L,759L,804L,828L,875L,900L,949L,975L,1026L,1053L,1106L,1134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258087Inst : IEnumerable<long>
{
public static readonly long[] Value=A258087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258087.Bytes);
public long this[int i]=>Value[i];

public static A258087Inst Instance=new A258087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258088
{
public static readonly long[] Value={ 12L,18L,42L,102L,108L,228L,312L,462L,858L,882L,1092L,1302L,1428L,1488L,1872L,1998L,2688L,3462L,4518L,4788L,5232L,5652L,6828L,7878L,8292L,10458L,13692L,13878L,15732L,16062L,16068L,16188L,17388L,19422L,19428L,20748L,21018L,21318L,22278L,23058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258088Inst : IEnumerable<long>
{
public static readonly long[] Value=A258088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258088.Bytes);
public long this[int i]=>Value[i];

public static A258088Inst Instance=new A258088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258089
{
public static readonly long[] Value={ 0L,1L,2L,3L,20L,94L,444L,2101L,9944L,47061L,222722L,1054060L,4988472L,23608573L,111730550L,528778923L,2502512960L,11843458282L,56050660404L,265266821305L,1255408695956L,5941380026829L,28118330498198L,133073546286496L,629787345390192L,2980548061443481L,14105819705015690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258089Inst : IEnumerable<long>
{
public static readonly long[] Value=A258089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258089.Bytes);
public long this[int i]=>Value[i];

public static A258089Inst Instance=new A258089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258090
{
public static readonly long[] Value={ 1L,-2L,-1L,4L,-3L,0L,3L,0L,1L,-2L,-2L,-4L,0L,2L,3L,-4L,9L,6L,-9L,0L,-6L,2L,3L,4L,-7L,8L,0L,-12L,-3L,-6L,6L,0L,9L,0L,8L,4L,2L,-6L,-5L,8L,-7L,-10L,-1L,4L,5L,2L,-13L,0L,9L,-8L,-2L,12L,-3L,4L,0L,-4L,-16L,6L,-1L,12L,10L,0L,6L,0L,1L,-8L,15L,-12L,0L,-6L,1L,-16L,-16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258090Inst : IEnumerable<long>
{
public static readonly long[] Value=A258090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258090.Bytes);
public long this[int i]=>Value[i];

public static A258090Inst Instance=new A258090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258091
{
public static readonly long[] Value={ 5L,3L,73L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,19L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,37L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,71L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,19L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,37L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,73L,3L,5L,3L,7L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258091Inst : IEnumerable<long>
{
public static readonly long[] Value=A258091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258091.Bytes);
public long this[int i]=>Value[i];

public static A258091Inst Instance=new A258091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258092
{
public static readonly long[] Value={ 1L,-2L,4L,-10L,20L,-36L,64L,-112L,189L,-308L,492L,-778L,1210L,-1844L,2776L,-4144L,6114L,-8914L,12884L,-18484L,26302L,-37124L,52040L,-72512L,100415L,-138196L,189160L,-257648L,349184L,-470932L,632312L,-845472L,1125853L,-1493222L,1973060L,-2597892L,3408754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258092Inst : IEnumerable<long>
{
public static readonly long[] Value=A258092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258092.Bytes);
public long this[int i]=>Value[i];

public static A258092Inst Instance=new A258092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258093
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-3L,0L,4L,6L,0L,-10L,-12L,0L,20L,24L,0L,-36L,-45L,0L,64L,78L,0L,-112L,-132L,0L,189L,222L,0L,-308L,-363L,0L,492L,576L,0L,-778L,-900L,0L,1210L,1392L,0L,-1844L,-2121L,0L,2776L,3180L,0L,-4144L,-4716L,0L,6114L,6936L,0L,-8914L,-10098L,0L,12884L,14550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258093Inst : IEnumerable<long>
{
public static readonly long[] Value=A258093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258093.Bytes);
public long this[int i]=>Value[i];

public static A258093Inst Instance=new A258093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258094
{
public static readonly long[] Value={ 1L,7L,6L,4L,-3L,-12L,-8L,12L,30L,20L,-30L,-72L,-46L,60L,156L,96L,-117L,-300L,-188L,228L,552L,344L,-420L,-1008L,-603L,732L,1770L,1048L,-1245L,-2976L,-1776L,2088L,4908L,2900L,-3420L,-7992L,-4658L,5460L,12756L,7408L,-8583L,-19944L,-11564L,13344L,30756L,17744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258094Inst : IEnumerable<long>
{
public static readonly long[] Value=A258094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258094.Bytes);
public long this[int i]=>Value[i];

public static A258094Inst Instance=new A258094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258095
{
public static readonly long[] Value={ 39L,183L,219L,1047L,1227L,1299L,1875L,2271L,2559L,2703L,3315L,3531L,3819L,4359L,5079L,5187L,5403L,6015L,6339L,6447L,6843L,7491L,7599L,7671L,8499L,8535L,8859L,9327L,9579L,10119L,10155L,10623L,10983L,11379L,11667L,11811L,12639L,12711L,13467L,13755L,13899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258095Inst : IEnumerable<long>
{
public static readonly long[] Value=A258095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258095.Bytes);
public long this[int i]=>Value[i];

public static A258095Inst Instance=new A258095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258096
{
public static readonly long[] Value={ 1L,2L,4L,8L,7L,10L,12L,8L,18L,18L,16L,24L,21L,20L,28L,32L,20L,32L,36L,24L,42L,42L,28L,48L,57L,36L,52L,40L,36L,58L,60L,56L,48L,66L,48L,72L,74L,42L,80L,80L,61L,82L,72L,56L,90L,96L,64L,72L,98L,70L,100L,104L,64L,106L,108L,72L,114L,96L,84L,144L,111L,84L,104L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258096Inst : IEnumerable<long>
{
public static readonly long[] Value=A258096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258096.Bytes);
public long this[int i]=>Value[i];

public static A258096Inst Instance=new A258096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258097
{
public static readonly long[] Value={ 1L,3L,9L,26L,68L,198L,536L,1660L,4769L,15945L,46240L,165732L,488268L,1848866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258097Inst : IEnumerable<long>
{
public static readonly long[] Value=A258097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258097.Bytes);
public long this[int i]=>Value[i];

public static A258097Inst Instance=new A258097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258098
{
public static readonly long[] Value={ 79L,238L,119L,358L,179L,538L,269L,808L,404L,202L,101L,304L,152L,76L,38L,19L,58L,29L,88L,44L,22L,11L,34L,17L,52L,26L,13L,40L,20L,10L,5L,16L,8L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258098Inst : IEnumerable<long>
{
public static readonly long[] Value=A258098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258098.Bytes);
public long this[int i]=>Value[i];

public static A258098Inst Instance=new A258098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258099
{
public static readonly long[] Value={ 1L,-2L,5L,-12L,26L,-50L,92L,-168L,295L,-496L,818L,-1332L,2126L,-3324L,5126L,-7824L,11793L,-17548L,25857L,-37788L,54734L,-78578L,111968L,-158496L,222842L,-311224L,432095L,-596676L,819504L,-1119624L,1522282L,-2060448L,2776514L,-3725294L,4978142L,-6626988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258099Inst : IEnumerable<long>
{
public static readonly long[] Value=A258099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258099.Bytes);
public long this[int i]=>Value[i];

public static A258099Inst Instance=new A258099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258100
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-2L,0L,4L,5L,0L,-10L,-12L,0L,20L,26L,0L,-39L,-50L,0L,76L,92L,0L,-140L,-168L,0L,244L,295L,0L,-415L,-496L,0L,696L,818L,0L,-1140L,-1332L,0L,1820L,2126L,0L,-2861L,-3324L,0L,4448L,5126L,0L,-6816L,-7824L,0L,10292L,11793L,0L,-15372L,-17548L,0L,22756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258100Inst : IEnumerable<long>
{
public static readonly long[] Value=A258100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258100.Bytes);
public long this[int i]=>Value[i];

public static A258100Inst Instance=new A258100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258101
{
public static readonly long[] Value={ 1L,4L,15867L,21357L,49887L,63468L,69875L,85428L,86387L,149875L,199548L,247475L,271607L,279500L,293944L,318681L,345548L,599500L,637659L,989900L,1086428L,1169091L,1274724L,1897875L,1913571L,2550636L,2665269L,2801880L,2855691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258101Inst : IEnumerable<long>
{
public static readonly long[] Value=A258101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258101.Bytes);
public long this[int i]=>Value[i];

public static A258101Inst Instance=new A258101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258102
{
public static readonly long[] Value={ 1L,0L,6L,2L,5L,5L,0L,8L,0L,5L,4L,9L,6L,2L,5L,5L,9L,3L,7L,8L,6L,9L,4L,4L,5L,9L,3L,8L,7L,9L,3L,3L,7L,5L,8L,6L,3L,2L,8L,5L,4L,8L,4L,1L,5L,7L,3L,3L,8L,6L,2L,6L,3L,2L,0L,1L,0L,7L,8L,1L,0L,8L,5L,9L,1L,6L,5L,7L,6L,1L,1L,6L,4L,9L,0L,1L,4L,4L,8L,1L,7L,6L,8L,6L,3L,2L,1L,4L,9L,6L,3L,9L,6L,1L,6L,3L,1L,3L,1L,8L,8L,3L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258102Inst : IEnumerable<long>
{
public static readonly long[] Value=A258102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258102.Bytes);
public long this[int i]=>Value[i];

public static A258102Inst Instance=new A258102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258103
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,4L,26L,87L,47L,87L,0L,547L,1303L,3402L,0L,24192L,187562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258103Inst : IEnumerable<long>
{
public static readonly long[] Value=A258103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258103.Bytes);
public long this[int i]=>Value[i];

public static A258103Inst Instance=new A258103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258104
{
public static readonly long[] Value={ 8L,9L,6L,4L,4L,0L,7L,8L,8L,7L,7L,6L,7L,6L,2L,8L,6L,4L,2L,3L,2L,7L,7L,0L,9L,0L,0L,0L,3L,4L,9L,7L,0L,4L,9L,9L,1L,3L,8L,7L,8L,4L,4L,0L,3L,4L,1L,6L,2L,4L,1L,4L,6L,0L,9L,8L,3L,4L,8L,3L,3L,9L,8L,7L,0L,6L,5L,5L,9L,6L,7L,9L,7L,8L,0L,6L,1L,3L,6L,0L,3L,1L,4L,2L,3L,3L,7L,6L,9L,9L,2L,2L,7L,6L,0L,7L,8L,1L,2L,2L,3L,6L,5L,5L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258104Inst : IEnumerable<long>
{
public static readonly long[] Value=A258104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258104.Bytes);
public long this[int i]=>Value[i];

public static A258104Inst Instance=new A258104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258105
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,10L,5L,8L,7L,12L,14L,18L,20L,11L,9L,16L,24L,22L,13L,26L,15L,28L,19L,32L,21L,34L,30L,36L,38L,40L,17L,44L,25L,42L,23L,48L,50L,54L,27L,52L,46L,60L,29L,56L,58L,62L,33L,64L,66L,71L,35L,69L,31L,75L,37L,77L,39L,68L,41L,81L,73L,79L,45L,83L,85L,89L,43L,87L,93L,97L,49L,91L,51L,99L,55L,101L,95L,103L,53L,105L,47L,107L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258105Inst : IEnumerable<long>
{
public static readonly long[] Value=A258105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258105.Bytes);
public long this[int i]=>Value[i];

public static A258105Inst Instance=new A258105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258106
{
public static readonly long[] Value={ 1998L,3876L,4524L,10062L,21582L,45220L,52780L,85428L,125976L,226100L,263900L,271092L,511428L,597012L,602946L,839106L,1033974L,1130500L,1274724L,1280532L,1319500L,1435764L,1469720L,1575860L,1810926L,1895706L,2171364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258106Inst : IEnumerable<long>
{
public static readonly long[] Value=A258106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258106.Bytes);
public long this[int i]=>Value[i];

public static A258106Inst Instance=new A258106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258107
{
public static readonly long[] Value={ 2L,3L,4L,82000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258107Inst : IEnumerable<long>
{
public static readonly long[] Value=A258107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258107.Bytes);
public long this[int i]=>Value[i];

public static A258107Inst Instance=new A258107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258108
{
public static readonly long[] Value={ 1L,3L,0L,-3L,6L,0L,-12L,15L,0L,-30L,36L,0L,-60L,78L,0L,-117L,150L,0L,-228L,276L,0L,-420L,504L,0L,-732L,885L,0L,-1245L,1488L,0L,-2088L,2454L,0L,-3420L,3996L,0L,-5460L,6378L,0L,-8583L,9972L,0L,-13344L,15378L,0L,-20448L,23472L,0L,-30876L,35379L,0L,-46116L,52644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258108Inst : IEnumerable<long>
{
public static readonly long[] Value=A258108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258108.Bytes);
public long this[int i]=>Value[i];

public static A258108Inst Instance=new A258108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258109
{
public static readonly long[] Value={ 1L,5L,18L,57L,169L,482L,1341L,3669L,9922L,26609L,70929L,188226L,497845L,1313501L,3459042L,9096393L,23895673L,62721698L,164531565L,431397285L,1130708866L,2962826465L,7761964833L,20331456642L,53249182309L,139449644717L,365166860706L,956185155129L,2503657040137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258109Inst : IEnumerable<long>
{
public static readonly long[] Value=A258109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258109.Bytes);
public long this[int i]=>Value[i];

public static A258109Inst Instance=new A258109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258110
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,212L,10592L,449977L,17727425L,680781219L,26046238416L,1001222256515L,38764377926857L,1511202832516487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258110Inst : IEnumerable<long>
{
public static readonly long[] Value=A258110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258110.Bytes);
public long this[int i]=>Value[i];

public static A258110Inst Instance=new A258110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258111
{
public static readonly long[] Value={ 1L,-3L,9L,-24L,57L,-126L,264L,-528L,1017L,-1896L,3438L,-6084L,10536L,-17898L,29880L,-49104L,79545L,-127170L,200856L,-313692L,484830L,-742080L,1125540L,-1692648L,2525160L,-3738765L,5496246L,-8025432L,11643576L,-16790310L,24072048L,-34321560L,48677625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258111Inst : IEnumerable<long>
{
public static readonly long[] Value=A258111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258111.Bytes);
public long this[int i]=>Value[i];

public static A258111Inst Instance=new A258111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258112
{
public static readonly long[] Value={ 1L,7L,9L,7L,8L,7L,8L,4L,9L,0L,0L,0L,9L,1L,6L,0L,4L,8L,1L,3L,5L,5L,9L,5L,0L,8L,8L,3L,7L,0L,3L,1L,3L,5L,2L,1L,6L,1L,7L,9L,3L,6L,6L,5L,2L,6L,5L,0L,1L,9L,5L,2L,5L,3L,6L,8L,5L,5L,2L,3L,6L,2L,5L,4L,2L,7L,4L,5L,5L,8L,4L,1L,3L,2L,4L,6L,3L,6L,0L,7L,4L,1L,7L,3L,9L,2L,7L,8L,8L,0L,5L,6L,9L,3L,2L,4L,0L,9L,5L,6L,6L,8L,5L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258112Inst : IEnumerable<long>
{
public static readonly long[] Value=A258112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258112.Bytes);
public long this[int i]=>Value[i];

public static A258112Inst Instance=new A258112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258113
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,5L,7L,9L,7L,5L,9L,0L,2L,9L,3L,1L,9L,3L,2L,8L,5L,3L,5L,9L,7L,7L,0L,7L,1L,6L,7L,5L,8L,4L,9L,1L,9L,0L,6L,6L,0L,0L,1L,8L,1L,5L,1L,0L,1L,8L,6L,5L,2L,7L,2L,0L,1L,4L,3L,7L,9L,7L,2L,4L,2L,0L,6L,9L,2L,7L,7L,1L,7L,2L,9L,7L,9L,8L,8L,2L,5L,9L,3L,8L,1L,6L,0L,9L,3L,6L,1L,4L,5L,4L,4L,5L,9L,4L,3L,5L,2L,2L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258113Inst : IEnumerable<long>
{
public static readonly long[] Value=A258113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258113.Bytes);
public long this[int i]=>Value[i];

public static A258113Inst Instance=new A258113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258114
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,72L,665L,6960L,85057L,1199744L,19070865L,336372480L,6522635801L,137996694528L,3163206890857L,78085740701696L,2065239729737745L,58263449436979200L,1746433243580269217L,BigInteger.Parse("55428341343200280576"),BigInteger.Parse("1856918215298125692073"),BigInteger.Parse("65483209810866254643200"),BigInteger.Parse("2424691204935999655757241") };
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
public class A258114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258114Inst Instance=new A258114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258115
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258115Inst : IEnumerable<long>
{
public static readonly long[] Value=A258115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258115.Bytes);
public long this[int i]=>Value[i];

public static A258115Inst Instance=new A258115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258116
{
public static readonly long[] Value={ 1L,2L,5L,10L,11L,17L,22L,23L,31L,34L,41L,46L,47L,55L,59L,62L,67L,73L,82L,83L,85L,94L,97L,103L,109L,110L,115L,118L,127L,134L,137L,146L,149L,155L,157L,166L,167L,170L,179L,187L,191L,194L,197L,205L,206L,211L,218L,227L,230L,233L,235L,241L,253L,254L,257L,269L,274L,277L,283L,295L,298L,307L,310L,313L,314L,331L,334L,335L,341L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258116Inst : IEnumerable<long>
{
public static readonly long[] Value=A258116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258116.Bytes);
public long this[int i]=>Value[i];

public static A258116Inst Instance=new A258116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258117
{
public static readonly long[] Value={ 1L,3L,7L,13L,19L,21L,29L,37L,39L,43L,53L,57L,61L,71L,79L,87L,89L,91L,101L,107L,111L,113L,129L,131L,133L,139L,151L,159L,163L,173L,181L,183L,193L,199L,203L,213L,223L,229L,237L,239L,247L,251L,259L,263L,267L,271L,273L,281L,293L,301L,303L,311L,317L,321L,337L,339L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258117Inst : IEnumerable<long>
{
public static readonly long[] Value=A258117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258117.Bytes);
public long this[int i]=>Value[i];

public static A258117Inst Instance=new A258117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258118
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,20L,24L,32L,30L,36L,40L,48L,64L,42L,54L,56L,60L,72L,80L,96L,128L,84L,90L,100L,108L,112L,120L,144L,160L,192L,256L,126L,132L,140L,150L,162L,168L,176L,180L,200L,216L,224L,240L,288L,320L,384L,512L,198L,210L,220L,252L,264L,270L,280L,300L,324L,336L,352L,360L,400L,432L,448L,480L,576L,640L,768L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258118Inst : IEnumerable<long>
{
public static readonly long[] Value=A258118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258118.Bytes);
public long this[int i]=>Value[i];

public static A258118Inst Instance=new A258118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258119
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,16L,18L,20L,32L,64L,42L,54L,56L,128L,100L,256L,162L,176L,512L,1024L,234L,260L,294L,392L,416L,486L,500L,2048L,4096L,1088L,1458L,8192L,1936L,2500L,16384L,798L,1026L,1064L,2058L,2432L,2744L,4374L,32768L,65536L,2300L,3042L,3380L,5408L,5888L,12500L,13122L,131072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258119Inst : IEnumerable<long>
{
public static readonly long[] Value=A258119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258119.Bytes);
public long this[int i]=>Value[i];

public static A258119Inst Instance=new A258119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258120
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,0L,3L,2L,2L,1L,3L,0L,1L,2L,4L,0L,3L,1L,3L,1L,2L,0L,4L,2L,1L,3L,2L,0L,3L,0L,5L,2L,1L,1L,4L,0L,2L,1L,4L,1L,2L,0L,3L,3L,1L,0L,5L,0L,3L,1L,2L,0L,4L,2L,3L,2L,1L,0L,4L,0L,1L,2L,6L,1L,3L,0L,2L,1L,2L,0L,5L,1L,1L,3L,3L,1L,2L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258120Inst : IEnumerable<long>
{
public static readonly long[] Value=A258120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258120.Bytes);
public long this[int i]=>Value[i];

public static A258120Inst Instance=new A258120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258121
{
public static readonly long[] Value={ 2L,5L,15L,39L,102L,267L,699L,1830L,4791L,12543L,32838L,85971L,225075L,589254L,1542687L,4038807L,10573734L,27682395L,72473451L,189737958L,496740423L,1300483311L,3404709510L,8913645219L,23336226147L,61095033222L,159948873519L,418751587335L,1096305888486L,2870166078123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258121Inst : IEnumerable<long>
{
public static readonly long[] Value=A258121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258121.Bytes);
public long this[int i]=>Value[i];

public static A258121Inst Instance=new A258121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258122
{
public static readonly BigInteger[] Value={ 1L,4L,32L,1728L,279936L,429981696L,2641807540224L,198135565516800000L,BigInteger.Parse("74300837068800000000000"),BigInteger.Parse("415989582513831936000000000000"),BigInteger.Parse("13974055172471046820331520000000000000"),BigInteger.Parse("8285929429609672784320522302259200000000000000"),BigInteger.Parse("34392048668455155319241086527782019661824000000000000000"),BigInteger.Parse("2908094259133650016606461590346496281704647737999360000000000000000"),BigInteger.Parse("1967201733524639238023450985668890257001862763630451357856563200000000000000000") };
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
public class A258122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258122Inst Instance=new A258122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258123
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,0L,1L,4L,1L,0L,1L,8L,2L,0L,0L,1L,15L,6L,1L,0L,0L,1L,32L,11L,3L,0L,0L,0L,1L,68L,25L,10L,2L,0L,0L,0L,1L,156L,47L,25L,6L,0L,0L,0L,0L,1L,361L,105L,58L,24L,2L,0L,0L,0L,0L,1L,869L,227L,124L,69L,11L,0L,0L,0L,0L,0L,1L,2105L,556L,256L,185L,52L,4L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258123Inst : IEnumerable<long>
{
public static readonly long[] Value=A258123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258123.Bytes);
public long this[int i]=>Value[i];

public static A258123Inst Instance=new A258123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258124
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,2L,2L,0L,0L,2L,2L,1L,2L,0L,0L,0L,4L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,4L,2L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258124Inst : IEnumerable<long>
{
public static readonly long[] Value=A258124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258124.Bytes);
public long this[int i]=>Value[i];

public static A258124Inst Instance=new A258124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258125
{
public static readonly long[] Value={ 2L,2L,4L,6L,8L,11L,13L,24L,37L,40L,77L,82L,93L,134L,165L,232L,243L,272L,275L,292L,303L,376L,477L,524L,577L,708L,1285L,1344L,1601L,1608L,3209L,3276L,6485L,6498L,7795L,7814L,9373L,13280L,13383L,13466L,14953L,21686L,22473L,24022L,24249L,36260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258125Inst : IEnumerable<long>
{
public static readonly long[] Value=A258125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258125.Bytes);
public long this[int i]=>Value[i];

public static A258125Inst Instance=new A258125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258126
{
public static readonly long[] Value={ 2L,3L,7L,5L,31L,7L,29L,37L,0L,11L,67L,13L,1093L,1471L,9949L,17L,131071L,19L,191L,211L,7547L,23L,277L,190051L,1807781L,61450327L,379L,29L,0L,31L,36457L,1149017L,0L,0L,631L,37L,0L,0L,0L,41L,0L,43L,947L,991L,0L,47L,1129L,8682997471L,0L,1125899906842573L,1327L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258126Inst : IEnumerable<long>
{
public static readonly long[] Value=A258126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258126.Bytes);
public long this[int i]=>Value[i];

public static A258126Inst Instance=new A258126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258127
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,2L,2L,0L,1L,2L,1L,4L,4L,6L,1L,16L,1L,2L,2L,4L,1L,2L,6L,8L,16L,2L,1L,0L,1L,4L,6L,0L,0L,2L,1L,0L,0L,0L,1L,0L,1L,2L,2L,0L,1L,2L,10L,0L,48L,2L,1L,36L,20L,6L,2L,8L,1L,10L,1L,16L,13L,2L,2L,0L,1L,0L,2L,0L,1L,2L,1L,0L,0L,2L,2L,0L,1L,8L,74L,64L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258127Inst : IEnumerable<long>
{
public static readonly long[] Value=A258127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258127.Bytes);
public long this[int i]=>Value[i];

public static A258127Inst Instance=new A258127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258128
{
public static readonly BigInteger[] Value={ 5461L,813281L,7272157205L,1083057360705L,9684433559760981L,1442322650052752161L,BigInteger.Parse("12896895753596262561301"),BigInteger.Parse("1920761265591267733640321"),BigInteger.Parse("17174976631595008767000306005"),BigInteger.Parse("2557904668044167195987033355105"),BigInteger.Parse("22872156829955018609383449248248341") };
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
public class A258128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258128Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258128.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258128Inst Instance=new A258128Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258129
{
public static readonly BigInteger[] Value={ 698901L,5102520783381L,BigInteger.Parse("37252493940331837461"),BigInteger.Parse("271973082264557457061125141"),BigInteger.Parse("1985621622943208359132836202790421"),BigInteger.Parse("14496630316026749501691464257547633057301"),BigInteger.Parse("105837027604506739193825102426073141683789429781"),BigInteger.Parse("772695182809023513889440668692977953487035688873891861") };
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
public class A258129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258129Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258129.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258129Inst Instance=new A258129Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258130
{
public static readonly BigInteger[] Value={ 1045L,1325345L,1910970885L,2755618515265L,3973599987865685L,5729928426883626945L,BigInteger.Parse("8262552817966202013445"),BigInteger.Parse("11914595433578836419585185"),BigInteger.Parse("17180838352667864150839647765"),BigInteger.Parse("24774756989951626526674352316385"),BigInteger.Parse("35725182398671892783600265200403845") };
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
public class A258130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258130Inst Instance=new A258130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258131
{
public static readonly BigInteger[] Value={ 49665L,348161L,19701781L,138502485L,7841194625L,55123576321L,3120775694421L,21939044808725L,1242060885120385L,8731684710231681L,494337111502154261L,3475188575627335765L,BigInteger.Parse("196744928316972210945"),BigInteger.Parse("1383116321414969338241"),BigInteger.Parse("78303987133043437737301") };
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
public class A258131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258131Inst Instance=new A258131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258132
{
public static readonly BigInteger[] Value={ 4715040L,8463840L,1122749669280L,2015496399840L,267373851637578960L,479974343542849680L,BigInteger.Parse("63672943775553479639280"),BigInteger.Parse("114302050117965712710960"),BigInteger.Parse("15163202176330482896520455040"),BigInteger.Parse("27220118818712616412771202880"),BigInteger.Parse("3610995292612020914167620625112640") };
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
public class A258132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258132Inst Instance=new A258132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258133
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,-2L,2L,0L,0L,0L,3L,-3L,3L,0L,0L,0L,4L,-4L,4L,0L,0L,0L,5L,-5L,5L,0L,0L,0L,6L,-6L,6L,0L,0L,0L,7L,-7L,7L,0L,0L,0L,8L,-8L,8L,0L,0L,0L,9L,-9L,9L,0L,0L,0L,10L,-10L,10L,0L,0L,0L,11L,-11L,11L,0L,0L,0L,12L,-12L,12L,0L,0L,0L,13L,-13L,13L,0L,0L,0L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258133Inst : IEnumerable<long>
{
public static readonly long[] Value=A258133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258133.Bytes);
public long this[int i]=>Value[i];

public static A258133Inst Instance=new A258133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258134
{
public static readonly long[] Value={ 6L,68L,828L,3444L,6237L,10755L,14595L,15687L,16056L,18837L,27495L,42228L,44408L,46548L,50436L,55750L,68103L,88730L,108560L,129105L,132924L,161490L,168730L,168756L,181935L,189112L,249543L,260540L,273195L,299115L,304425L,313677L,345975L,369472L,424215L,430402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258134Inst : IEnumerable<long>
{
public static readonly long[] Value=A258134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258134.Bytes);
public long this[int i]=>Value[i];

public static A258134Inst Instance=new A258134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258135
{
public static readonly long[] Value={ 760L,918L,924L,1540L,4648L,6204L,8260L,15210L,20070L,21450L,27450L,30114L,41052L,47344L,50464L,55952L,60040L,60534L,61088L,63080L,77024L,77994L,81320L,99084L,117572L,132210L,136068L,150750L,169480L,215325L,215740L,226422L,309160L,476196L,495444L,505720L,530292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258135Inst : IEnumerable<long>
{
public static readonly long[] Value=A258135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258135.Bytes);
public long this[int i]=>Value[i];

public static A258135Inst Instance=new A258135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258136
{
public static readonly long[] Value={ 1L,3L,7L,13L,5L,15L,27L,9L,23L,39L,11L,31L,53L,17L,41L,67L,19L,49L,81L,21L,55L,93L,25L,65L,107L,29L,73L,119L,33L,83L,135L,35L,89L,145L,37L,95L,157L,43L,109L,45L,115L,187L,47L,121L,197L,51L,131L,213L,57L,141L,229L,59L,149L,241L,61L,155L,251L,63L,161L,263L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258136Inst : IEnumerable<long>
{
public static readonly long[] Value=A258136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258136.Bytes);
public long this[int i]=>Value[i];

public static A258136Inst Instance=new A258136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258137
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,18L,14L,16L,28L,20L,22L,36L,24L,26L,48L,30L,32L,60L,34L,38L,68L,40L,42L,78L,44L,46L,86L,50L,52L,100L,54L,56L,108L,58L,62L,114L,66L,64L,70L,72L,140L,74L,76L,146L,80L,82L,156L,84L,88L,170L,90L,92L,180L,94L,96L,188L,98L,102L,194L,104L,106L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258137Inst : IEnumerable<long>
{
public static readonly long[] Value=A258137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258137.Bytes);
public long this[int i]=>Value[i];

public static A258137Inst Instance=new A258137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258138
{
public static readonly long[] Value={ 1L,2L,14L,70L,166L,350L,1050L,2002L,1870L,4730L,5170L,9350L,15106L,29050L,45318L,65450L,25850L,139590L,75530L,129250L,180950L,226590L,383350L,341530L,377650L,551650L,697950L,439450L,1127610L,1489950L,1004850L,1654950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258138Inst : IEnumerable<long>
{
public static readonly long[] Value=A258138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258138.Bytes);
public long this[int i]=>Value[i];

public static A258138Inst Instance=new A258138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258139
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,2L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,2L,2L,0L,1L,0L,2L,1L,0L,1L,1L,0L,2L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,2L,2L,0L,2L,0L,3L,1L,0L,0L,1L,0L,3L,1L,0L,1L,2L,0L,3L,0L,1L,1L,2L,0L,0L,1L,1L,1L,2L,0L,2L,0L,1L,1L,1L,0L,2L,1L,1L,0L,1L,0L,3L,1L,0L,0L,2L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258139Inst : IEnumerable<long>
{
public static readonly long[] Value=A258139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258139.Bytes);
public long this[int i]=>Value[i];

public static A258139Inst Instance=new A258139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258140
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,1L,1L,3L,3L,3L,0L,2L,2L,3L,2L,1L,2L,2L,3L,3L,2L,2L,2L,3L,3L,2L,0L,4L,4L,5L,1L,4L,4L,2L,2L,2L,3L,3L,3L,5L,1L,3L,3L,4L,4L,1L,2L,3L,4L,3L,1L,5L,4L,5L,1L,1L,3L,4L,6L,4L,2L,3L,2L,6L,7L,3L,2L,2L,3L,5L,3L,4L,4L,4L,5L,2L,5L,2L,4L,6L,1L,5L,2L,5L,5L,2L,3L,3L,4L,4L,2L,4L,5L,6L,3L,2L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258140Inst : IEnumerable<long>
{
public static readonly long[] Value=A258140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258140.Bytes);
public long this[int i]=>Value[i];

public static A258140Inst Instance=new A258140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258141
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,2L,1L,0L,2L,0L,2L,1L,0L,0L,1L,0L,2L,1L,0L,1L,2L,0L,2L,0L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,0L,0L,1L,1L,0L,2L,1L,0L,0L,1L,0L,2L,1L,0L,0L,2L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258141Inst : IEnumerable<long>
{
public static readonly long[] Value=A258141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258141.Bytes);
public long this[int i]=>Value[i];

public static A258141Inst Instance=new A258141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258142
{
public static readonly long[] Value={ 6L,21L,60L,85L,90L,261L,976L,2009L,87360L,97273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258142Inst : IEnumerable<long>
{
public static readonly long[] Value=A258142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258142.Bytes);
public long this[int i]=>Value[i];

public static A258142Inst Instance=new A258142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258143
{
public static readonly long[] Value={ 1L,2L,6L,10L,25L,41L,98L,162L,381L,637L,1485L,2509L,5811L,9907L,22818L,39202L,89845L,155381L,354521L,616665L,1401291L,2449867L,5546381L,9740685L,21977515L,38754731L,87167163L,154276027L,345994215L,614429671L,1374282018L,2448023842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258143Inst : IEnumerable<long>
{
public static readonly long[] Value=A258143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258143.Bytes);
public long this[int i]=>Value[i];

public static A258143Inst Instance=new A258143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258144
{
public static readonly long[] Value={ 1L,2L,0L,-2L,5L,11L,-14L,-34L,57L,127L,-209L,-461L,793L,1717L,-3002L,-6434L,11441L,24311L,-43757L,-92377L,167961L,352717L,-646645L,-1352077L,2496145L,5200301L,-9657699L,-20058299L,37442161L,77558761L,-145422674L,-300540194L,565722721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258144Inst : IEnumerable<long>
{
public static readonly long[] Value=A258144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258144.Bytes);
public long this[int i]=>Value[i];

public static A258144Inst Instance=new A258144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258145
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,5L,3L,6L,4L,7L,2L,5L,8L,42L,6L,40L,9L,4L,7L,12L,41L,10L,5L,39L,8L,8L,3L,42L,11L,11L,6L,40L,9L,9L,4L,38L,43L,4L,7L,12L,7L,41L,2L,10L,10L,34L,5L,39L,44L,8L,8L,32L,13L,37L,42L,25L,3L,11L,6L,11L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258145Inst : IEnumerable<long>
{
public static readonly long[] Value=A258145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258145.Bytes);
public long this[int i]=>Value[i];

public static A258145Inst Instance=new A258145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258146
{
public static readonly long[] Value={ 1L,8L,1L,6L,9L,0L,1L,1L,3L,8L,1L,6L,2L,0L,9L,3L,2L,8L,4L,6L,2L,2L,3L,2L,4L,7L,3L,2L,5L,4L,9L,7L,1L,2L,7L,5L,9L,3L,1L,0L,8L,0L,7L,0L,8L,5L,1L,9L,0L,8L,7L,1L,0L,2L,5L,0L,4L,6L,6L,5L,3L,1L,1L,8L,8L,2L,2L,0L,6L,4L,0L,4L,7L,3L,1L,5L,4L,6L,9L,2L,9L,8L,1L,9L,7L,7L,2L,3L,9L,4L,4L,6L,7L,4L,9L,3L,8L,2L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258146Inst : IEnumerable<long>
{
public static readonly long[] Value=A258146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258146.Bytes);
public long this[int i]=>Value[i];

public static A258146Inst Instance=new A258146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258147
{
public static readonly long[] Value={ 3L,9L,1L,0L,0L,2L,2L,1L,8L,9L,5L,5L,7L,7L,0L,6L,4L,1L,9L,1L,1L,0L,0L,3L,4L,1L,7L,5L,1L,0L,1L,8L,1L,9L,4L,5L,9L,6L,7L,9L,7L,3L,4L,2L,6L,4L,8L,3L,3L,4L,6L,3L,4L,0L,2L,6L,6L,9L,8L,3L,6L,5L,6L,5L,2L,1L,1L,5L,1L,5L,1L,4L,9L,3L,2L,0L,3L,1L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258147Inst : IEnumerable<long>
{
public static readonly long[] Value=A258147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258147.Bytes);
public long this[int i]=>Value[i];

public static A258147Inst Instance=new A258147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258148
{
public static readonly long[] Value={ 5L,7L,6L,6L,8L,8L,8L,5L,6L,2L,2L,4L,3L,7L,3L,0L,8L,5L,7L,7L,6L,7L,0L,0L,8L,4L,1L,7L,6L,8L,4L,8L,6L,1L,2L,6L,3L,4L,6L,4L,0L,0L,9L,3L,1L,5L,0L,0L,1L,3L,0L,0L,6L,9L,3L,3L,6L,5L,0L,3L,2L,3L,1L,8L,7L,8L,1L,8L,1L,8L,1L,5L,9L,8L,6L,9L,8L,4L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258148Inst : IEnumerable<long>
{
public static readonly long[] Value=A258148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258148.Bytes);
public long this[int i]=>Value[i];

public static A258148Inst Instance=new A258148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258149
{
public static readonly long[] Value={ 1L,0L,7L,7L,0L,17L,0L,1L,0L,31L,23L,0L,0L,0L,49L,0L,17L,0L,23L,0L,71L,47L,0L,7L,0L,41L,0L,97L,0L,41L,0L,7L,0L,0L,0L,127L,79L,0L,31L,0L,0L,0L,89L,0L,161L,0L,73L,0L,17L,0L,47L,0L,119L,0L,199L,119L,0L,0L,0L,1L,0L,73L,0L,0L,0L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258149Inst : IEnumerable<long>
{
public static readonly long[] Value=A258149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258149.Bytes);
public long this[int i]=>Value[i];

public static A258149Inst Instance=new A258149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258150
{
public static readonly long[] Value={ 1L,0L,5L,10L,0L,14L,0L,35L,0L,30L,35L,0L,0L,0L,55L,0L,105L,0L,154L,0L,91L,84L,0L,220L,0L,260L,0L,140L,0L,231L,0L,390L,0L,0L,0L,204L,165L,0L,455L,0L,0L,0L,595L,0L,285L,0L,429L,0L,770L,0L,935L,0L,836L,0L,385L,286L,0L,0L,0L,1190L,0L,1330L,0L,0L,0L,506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258150Inst : IEnumerable<long>
{
public static readonly long[] Value=A258150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258150.Bytes);
public long this[int i]=>Value[i];

public static A258150Inst Instance=new A258150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258151
{
public static readonly long[] Value={ 1L,5L,10L,14L,30L,35L,55L,84L,91L,105L,140L,154L,165L,204L,220L,231L,260L,285L,286L,385L,390L,429L,455L,506L,595L,650L,680L,715L,770L,819L,836L,935L,969L,1015L,1105L,1190L,1240L,1309L,1326L,1330L,1495L,1496L,1615L,1729L,1771L,1785L,1820L,1925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258151Inst : IEnumerable<long>
{
public static readonly long[] Value=A258151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258151.Bytes);
public long this[int i]=>Value[i];

public static A258151Inst Instance=new A258151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258152
{
public static readonly long[] Value={ 1L,1L,4L,1L,18L,27L,1L,32L,36L,288L,256L,1L,50L,200L,750L,1500L,5000L,3125L,1L,72L,450L,400L,1620L,10800L,3375L,17280L,48600L,97200L,46656L,1L,98L,882L,2450L,3087L,30870L,25725L,46305L,48020L,432180L,259308L,420175L,1512630L,2117682L,823543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258152Inst : IEnumerable<long>
{
public static readonly long[] Value=A258152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258152.Bytes);
public long this[int i]=>Value[i];

public static A258152Inst Instance=new A258152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258153
{
public static readonly long[] Value={ 6L,7L,9L,11L,15L,17L,21L,23L,27L,28L,30L,32L,33L,35L,36L,38L,41L,42L,44L,45L,47L,48L,51L,52L,54L,56L,57L,60L,62L,63L,65L,66L,68L,71L,72L,75L,77L,78L,80L,83L,84L,86L,87L,90L,92L,93L,96L,98L,101L,102L,104L,105L,107L,108L,110L,111L,113L,114L,116L,117L,120L,122L,126L,128L,131L,132L,134L,135L,138L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258153Inst : IEnumerable<long>
{
public static readonly long[] Value=A258153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258153.Bytes);
public long this[int i]=>Value[i];

public static A258153Inst Instance=new A258153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258154
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,509203L,0L,0L,0L,0L,0L,777149L,0L,0L,0L,0L,0L,10157893L,0L,0L,0L,0L,0L,60014203L,0L,200883553191612793L,0L,0L,0L,7106977L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258154Inst : IEnumerable<long>
{
public static readonly long[] Value=A258154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258154.Bytes);
public long this[int i]=>Value[i];

public static A258154Inst Instance=new A258154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258155
{
public static readonly long[] Value={ 900L,11025L,148225L,1002001L,5909761L,17631601L,55190041L,160604929L,427538329L,1106427169L,2211538729L,4255083361L,6865945321L,11473194769L,21599886961L,36384418009L,58145123689L,84202691329L,120590202121L,167655034849L,229116352921L,340557446329L,513428138521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258155Inst : IEnumerable<long>
{
public static readonly long[] Value=A258155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258155.Bytes);
public long this[int i]=>Value[i];

public static A258155Inst Instance=new A258155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258156
{
public static readonly long[] Value={ 0L,6L,44L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258156Inst : IEnumerable<long>
{
public static readonly long[] Value=A258156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258156.Bytes);
public long this[int i]=>Value[i];

public static A258156Inst Instance=new A258156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258157
{
public static readonly long[] Value={ 61L,62L,5471L,5472L,7116L,8669L,12769L,16546L,18806L,18960L,22260L,23573L,26400L,29094L,29383L,30026L,31121L,36106L,36223L,46432L,53222L,53655L,54014L,56108L,56630L,56762L,59717L,66868L,69532L,70815L,71597L,73937L,74181L,88937L,91918L,106693L,107810L,109174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258157Inst : IEnumerable<long>
{
public static readonly long[] Value=A258157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258157.Bytes);
public long this[int i]=>Value[i];

public static A258157Inst Instance=new A258157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258158
{
public static readonly long[] Value={ 61L,62L,63L,2007L,2008L,2187L,2188L,2402L,2814L,3312L,3313L,5013L,5471L,5472L,5473L,6856L,7114L,7116L,7117L,7548L,7633L,7634L,7635L,7904L,8080L,8158L,8245L,8246L,8667L,8668L,8669L,8670L,10100L,10131L,10207L,10244L,10552L,11090L,11548L,11621L,11681L,12298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258158Inst : IEnumerable<long>
{
public static readonly long[] Value=A258158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258158.Bytes);
public long this[int i]=>Value[i];

public static A258158Inst Instance=new A258158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258159
{
public static readonly long[] Value={ 3L,5L,7L,9L,15L,17L,19L,21L,31L,33L,63L,65L,67L,71L,73L,85L,127L,129L,255L,257L,259L,261L,271L,273L,307L,341L,511L,513L,519L,585L,1023L,1025L,1027L,1035L,1055L,1057L,1117L,1365L,2047L,2049L,2071L,2137L,4095L,4097L,4099L,4101L,4103L,4105L,4109L,4111L,4117L,4131L,4135L,4141L,4159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258159Inst : IEnumerable<long>
{
public static readonly long[] Value=A258159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258159.Bytes);
public long this[int i]=>Value[i];

public static A258159Inst Instance=new A258159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258160
{
public static readonly long[] Value={ 16L,8L,24L,32L,56L,88L,144L,232L,376L,608L,984L,1592L,2576L,4168L,6744L,10912L,17656L,28568L,46224L,74792L,121016L,195808L,316824L,512632L,829456L,1342088L,2171544L,3513632L,5685176L,9198808L,14883984L,24082792L,38966776L,63049568L,102016344L,165065912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258160Inst : IEnumerable<long>
{
public static readonly long[] Value=A258160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258160.Bytes);
public long this[int i]=>Value[i];

public static A258160Inst Instance=new A258160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258161
{
public static readonly BigInteger[] Value={ 1L,2L,8L,256L,2097152L,36028797018963968L,BigInteger.Parse("22300745198530623141535718272648361505980416") };
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
public class A258161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258161Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258161.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258161Inst Instance=new A258161Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258162
{
public static readonly long[] Value={ 5L,7L,4L,0L,3L,8L,8L,8L,0L,7L,2L,2L,9L,4L,7L,4L,2L,8L,0L,0L,1L,9L,5L,7L,1L,6L,8L,8L,1L,0L,2L,4L,6L,1L,4L,6L,2L,9L,6L,1L,0L,1L,3L,0L,0L,7L,4L,5L,4L,8L,7L,3L,3L,3L,1L,4L,2L,5L,4L,0L,2L,4L,5L,1L,2L,3L,8L,8L,8L,4L,3L,8L,7L,1L,7L,7L,1L,2L,5L,0L,2L,6L,1L,0L,6L,2L,6L,2L,1L,6L,6L,6L,2L,8L,7L,2L,3L,3L,0L,5L,1L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258162Inst : IEnumerable<long>
{
public static readonly long[] Value=A258162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258162.Bytes);
public long this[int i]=>Value[i];

public static A258162Inst Instance=new A258162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258163
{
public static readonly long[] Value={ 2L,3L,3L,8L,9L,5L,1L,4L,4L,6L,5L,5L,1L,6L,8L,0L,1L,6L,1L,9L,6L,0L,0L,5L,5L,9L,1L,0L,5L,0L,5L,9L,1L,4L,0L,6L,5L,9L,0L,0L,7L,5L,2L,7L,6L,8L,3L,1L,9L,8L,4L,6L,4L,6L,6L,7L,7L,8L,5L,4L,5L,2L,0L,5L,4L,5L,6L,3L,6L,4L,7L,9L,5L,2L,5L,5L,8L,0L,1L,4L,8L,8L,8L,1L,0L,1L,7L,7L,7L,0L,4L,0L,3L,1L,5L,9L,8L,2L,6L,4L,8L,6L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258163Inst : IEnumerable<long>
{
public static readonly long[] Value=A258163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258163.Bytes);
public long this[int i]=>Value[i];

public static A258163Inst Instance=new A258163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258164
{
public static readonly long[] Value={ 1L,1L,8L,2L,9L,8L,7L,9L,3L,1L,8L,4L,5L,5L,1L,2L,5L,8L,7L,5L,4L,1L,6L,7L,2L,9L,0L,7L,2L,9L,2L,9L,6L,4L,4L,8L,4L,9L,0L,2L,9L,2L,8L,5L,2L,9L,0L,1L,0L,8L,2L,0L,6L,5L,7L,4L,7L,3L,4L,1L,1L,0L,4L,6L,0L,5L,3L,5L,5L,7L,2L,1L,9L,9L,6L,5L,6L,3L,2L,6L,3L,5L,3L,9L,0L,1L,6L,7L,9L,8L,8L,4L,3L,9L,3L,4L,7L,8L,8L,6L,4L,5L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258164Inst : IEnumerable<long>
{
public static readonly long[] Value=A258164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258164.Bytes);
public long this[int i]=>Value[i];

public static A258164Inst Instance=new A258164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258165
{
public static readonly long[] Value={ 3L,5L,9L,11L,17L,19L,23L,25L,29L,37L,41L,47L,49L,53L,59L,61L,67L,71L,79L,83L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,151L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,223L,227L,229L,233L,239L,251L,257L,263L,269L,271L,277L,281L,283L,289L,293L,311L,313L,317L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258165Inst : IEnumerable<long>
{
public static readonly long[] Value=A258165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258165.Bytes);
public long this[int i]=>Value[i];

public static A258165Inst Instance=new A258165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258166
{
public static readonly long[] Value={ 1730L,2031L,2032L,3682L,4655L,5445L,5836L,9756L,10607L,11496L,11497L,11576L,17724L,17951L,18935L,18936L,20948L,21488L,21489L,22519L,26310L,26311L,27436L,42326L,42423L,46644L,50738L,50851L,61950L,62130L,65569L,66123L,66903L,69229L,70682L,71253L,74661L,75184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258166Inst : IEnumerable<long>
{
public static readonly long[] Value=A258166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258166.Bytes);
public long this[int i]=>Value[i];

public static A258166Inst Instance=new A258166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258167
{
public static readonly long[] Value={ 231L,729L,818L,911L,1730L,1731L,2031L,2032L,2033L,2788L,3420L,3682L,3683L,3685L,3796L,4265L,4486L,4655L,4656L,4657L,4692L,5206L,5207L,5445L,5446L,5783L,5836L,5837L,5840L,6051L,6063L,8758L,9756L,9757L,9954L,9979L,10003L,10006L,10123L,10303L,10321L,10416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258167Inst : IEnumerable<long>
{
public static readonly long[] Value=A258167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258167.Bytes);
public long this[int i]=>Value[i];

public static A258167Inst Instance=new A258167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258168
{
public static readonly long[] Value={ 3L,4L,3L,4L,5L,4L,4L,4L,4L,7L,4L,5L,6L,4L,5L,5L,4L,5L,4L,3L,5L,6L,4L,6L,5L,6L,5L,5L,3L,6L,6L,7L,3L,7L,5L,8L,8L,5L,5L,9L,5L,4L,6L,7L,4L,7L,5L,6L,7L,5L,4L,5L,4L,7L,8L,6L,6L,8L,4L,8L,7L,5L,8L,7L,4L,7L,5L,7L,4L,6L,6L,13L,7L,7L,6L,8L,4L,10L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258168Inst : IEnumerable<long>
{
public static readonly long[] Value=A258168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258168.Bytes);
public long this[int i]=>Value[i];

public static A258168Inst Instance=new A258168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258169
{
public static readonly BigInteger[] Value={ 1L,2L,16L,32768L,72057594037927936L,BigInteger.Parse("822752278660603021077484591278675252491367932816789931674304512") };
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
public class A258169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258169Inst Instance=new A258169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258170
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,8L,6L,1L,0L,5L,15L,25L,10L,1L,0L,6L,36L,91L,65L,15L,1L,0L,7L,63L,301L,350L,140L,21L,1L,0L,8L,136L,972L,1702L,1050L,266L,28L,1L,0L,9L,261L,3027L,7770L,6951L,2646L,462L,36L,1L,0L,10L,530L,9355L,34115L,42526L,22827L,5880L,750L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258170Inst : IEnumerable<long>
{
public static readonly long[] Value=A258170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258170.Bytes);
public long this[int i]=>Value[i];

public static A258170Inst Instance=new A258170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258171
{
public static readonly long[] Value={ 0L,1L,3L,7L,19L,56L,214L,883L,4163L,21163L,116039L,678580L,4213848L,27644449L,190900217L,1382958677L,10480146333L,82864869820L,682076827740L,5832742205075L,51724158351527L,474869816158547L,4506715739125923L,44152005855084368L,445958869299027638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258171Inst : IEnumerable<long>
{
public static readonly long[] Value=A258171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258171.Bytes);
public long this[int i]=>Value[i];

public static A258171Inst Instance=new A258171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258172
{
public static readonly BigInteger[] Value={ 1L,1L,5L,40L,434L,5901L,95997L,1812525L,38875265L,932135347L,24678938063L,714385754446L,22428656766320L,758632387171075L,27489135956517315L,1061913384743418360L,BigInteger.Parse("43550536908458238570"),BigInteger.Parse("1889211624465639489675"),BigInteger.Parse("86406059558668152123975"),BigInteger.Parse("4154647501527354507485040") };
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
public class A258172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258172Inst Instance=new A258172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258173
{
public static readonly ulong[] Value={ 1L,1L,3L,12L,58L,321L,1975L,13265L,96073L,743753L,6113769L,53086314L,484861924L,4641853003L,46441475253L,484327870652L,5252981412262L,59132909030463L,689642443691329L,8319172260103292L,103645882500123026L,1331832693574410475L,17629142345935969713UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258173Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A258173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258173.Bytes);
public ulong this[int i]=>Value[i];

public static A258173Inst Instance=new A258173Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258174
{
public static readonly BigInteger[] Value={ 1L,1L,7L,84L,1486L,35753L,1111931L,43150593L,2035666985L,114412223081L,7538224510181L,574552299138202L,50096579094908148L,4949493445607316419L,BigInteger.Parse("549534510282406667069"),BigInteger.Parse("68071071679372210762156"),BigInteger.Parse("9347203754680124767253730"),BigInteger.Parse("1414740620049957735248175695") };
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
public class A258174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258174Inst Instance=new A258174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258175
{
public static readonly BigInteger[] Value={ 1L,2L,12L,114L,1448L,22770L,424164L,9095450L,220023184L,5914998594L,174682531260L,5614908340866L,194967208057272L,7267467723747218L,289270983756577620L,12239218862861690250UL,BigInteger.Parse("548301077168477951520"),BigInteger.Parse("25918121712918957399426"),BigInteger.Parse("1288797080051656060595820") };
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
public class A258175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258175Inst Instance=new A258175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258176
{
public static readonly BigInteger[] Value={ 1L,1L,7L,142L,9354L,2503597L,3260627607L,24105227716863L,1028836978599566213L,BigInteger.Parse("290383808553140390346475"),BigInteger.Parse("511963364817949502725911280781"),BigInteger.Parse("6704846980724405836568589845161191576"),BigInteger.Parse("584709361918378923208855262622537662297053728") };
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
public class A258176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258176Inst Instance=new A258176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258177
{
public static readonly BigInteger[] Value={ 1L,1L,5L,112L,15312L,22928885L,475971133797L,164769697242392241L,BigInteger.Parse("1674694178196441599627207"),BigInteger.Parse("434453335415659344048321288040053"),BigInteger.Parse("2772047111897899211702422870954450438220795"),BigInteger.Parse("919691726760748842849028933552012720445531166591469510") };
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
public class A258177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258177Inst Instance=new A258177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258178
{
public static readonly BigInteger[] Value={ 1L,1L,13L,414L,24324L,2279209L,311524201L,58467947511L,14424374692879L,4525566110365523L,1759527523008436279L,BigInteger.Parse("830255082140922306224"),BigInteger.Parse("467382831980334193769718"),BigInteger.Parse("309419146352957449765072455"),BigInteger.Parse("237980526477430552734199922151"),BigInteger.Parse("210427994109788912088395561755374") };
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
public class A258178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258178Inst Instance=new A258178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258179
{
public static readonly BigInteger[] Value={ 1L,1L,5L,34L,312L,3649L,52161L,889843L,17796555L,411120395L,10838039407L,322752018060L,10762432731362L,398802951148255L,16312276452291935L,732189190349581890L,BigInteger.Parse("35876807697443520000"),BigInteger.Parse("1910107567584518883891"),BigInteger.Parse("110035833179472385285367"),BigInteger.Parse("6832792252684597270659486") };
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
public class A258179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258179Inst Instance=new A258179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258180
{
public static readonly BigInteger[] Value={ 1L,1L,4L,33L,517L,15326L,852912L,91023697L,19716262702L,8794395041567L,8016790849841585L,15556074485786226848UL,BigInteger.Parse("64891787190080888991273"),BigInteger.Parse("561815453349204340865790817"),BigInteger.Parse("10402242033224422585780623039909"),BigInteger.Parse("423787530114579490372987256671625678") };
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
public class A258180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258180Inst Instance=new A258180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258181
{
public static readonly BigInteger[] Value={ 1L,1L,5L,89L,5933L,1540161L,1584150165L,6497470064169L,106497075348688637L,BigInteger.Parse("6980195689972655145233"),BigInteger.Parse("1829876050804408046228327525"),BigInteger.Parse("1918781572083632396857805205324025"),BigInteger.Parse("8047973452254281276702044410544321359565"),BigInteger.Parse("135022681866797995009325363468217320506328688097") };
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
public class A258181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258181Inst Instance=new A258181Inst();

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