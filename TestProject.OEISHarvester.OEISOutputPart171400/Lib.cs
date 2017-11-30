using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201857
{
public static readonly long[] Value={ 3L,67L,283L,643L,4603L,5827L,8707L,12163L,14107L,18427L,34843L,38083L,41467L,56443L,83227L,93307L,98563L,103963L,109507L,139387L,165883L,172867L,194683L,202243L,233923L,267907L,276763L,285763L,383683L,449347L,484123L,544963L,596227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201857Inst : IEnumerable<long>
{
public static readonly long[] Value=A201857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201857.Bytes);
public long this[int i]=>Value[i];

public static A201857Inst Instance=new A201857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201858
{
public static readonly long[] Value={ 193L,281L,641L,4993L,7193L,7681L,9241L,12161L,13441L,16193L,16921L,19993L,23321L,28793L,29761L,34841L,43801L,49921L,51193L,57793L,63361L,64793L,73721L,78401L,98561L,107641L,123001L,133121L,135193L,168193L,177601L,192193L,194681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201858Inst : IEnumerable<long>
{
public static readonly long[] Value=A201858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201858.Bytes);
public long this[int i]=>Value[i];

public static A201858Inst Instance=new A201858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201859
{
public static readonly long[] Value={ 23L,191L,383L,503L,1559L,2039L,2879L,3191L,3863L,5399L,6263L,6719L,9239L,9791L,12791L,14783L,19991L,26903L,29759L,33791L,39191L,46199L,49919L,53783L,55103L,57791L,59159L,66239L,91583L,100343L,113279L,117119L,124991L,129023L,131063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201859Inst : IEnumerable<long>
{
public static readonly long[] Value=A201859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201859.Bytes);
public long this[int i]=>Value[i];

public static A201859Inst Instance=new A201859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201860
{
public static readonly long[] Value={ 7L,79L,223L,439L,727L,1087L,3967L,4759L,5623L,8647L,13687L,18223L,31327L,33487L,53359L,56167L,71287L,74527L,77839L,81223L,91807L,95479L,99223L,127447L,149767L,159199L,164023L,184039L,189223L,194479L,199807L,239119L,245023L,263167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201860Inst : IEnumerable<long>
{
public static readonly long[] Value=A201860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201860.Bytes);
public long this[int i]=>Value[i];

public static A201860Inst Instance=new A201860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201861
{
public static readonly BigInteger[] Value={ 1L,4L,38L,661L,16286L,527654L,21191208L,1015335608L,56484795166L,3576188894116L,253756155257774L,19937566770720487L,1717714713900798962L,BigInteger.Parse("160977153444563000938"),BigInteger.Parse("16300053518916522372836"),BigInteger.Parse("1773133639291617644092637") };
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
public class A201861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201861Inst Instance=new A201861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201862
{
public static readonly BigInteger[] Value={ 2L,9L,70L,729L,9918L,167281L,3423362L,82609921L,2319730026L,74500064809L,2711723081550L,110568316431609L,5016846683306758L,251180326892449969L,13806795579059621930UL,BigInteger.Parse("827911558468860287041"),BigInteger.Parse("53940895144894708523922"),BigInteger.Parse("3799498445458163685753481"),BigInteger.Parse("288400498147873552894868886") };
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
public class A201862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201862Inst Instance=new A201862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201863
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,-1L,2L,0L,-2L,0L,4L,0L,-5L,0L,1L,8L,0L,-12L,0L,4L,0L,16L,0L,-28L,0L,13L,0L,-1L,32L,0L,-64L,0L,38L,0L,-6L,0L,64L,0L,-144L,0L,104L,0L,-25L,0L,1L,128L,0L,-320L,0L,272L,0L,-88L,0L,8L,0L,256L,0L,-704L,0L,688L,0L,-280L,0L,41L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201863Inst : IEnumerable<long>
{
public static readonly long[] Value=A201863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201863.Bytes);
public long this[int i]=>Value[i];

public static A201863Inst Instance=new A201863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201864
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,6L,10L,16L,27L,44L,71L,116L,188L,304L,493L,798L,1291L,2090L,3382L,5472L,8855L,14328L,23183L,37512L,60696L,98208L,158905L,257114L,416019L,673134L,1089154L,1762288L,2851443L,4613732L,7465175L,12078908L,19544084L,31622992L,51167077L,82790070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201864Inst : IEnumerable<long>
{
public static readonly long[] Value=A201864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201864.Bytes);
public long this[int i]=>Value[i];

public static A201864Inst Instance=new A201864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201865
{
public static readonly long[] Value={ 1L,-4L,37L,-232L,1705L,-11692L,82573L,-575824L,4037329L,-28241620L,197750389L,-1384075576L,9689060473L,-67821828988L,474757585885L,-3323288752288L,23263064312737L,-162841321048996L,1139889634763461L,-7979226281082760L,55854587454363721L,-390982101720192844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201865Inst : IEnumerable<long>
{
public static readonly long[] Value=A201865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201865.Bytes);
public long this[int i]=>Value[i];

public static A201865Inst Instance=new A201865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201866
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,11L,21L,39L,73L,129L,229L,407L,733L,1335L,2461L,4549L,8427L,15585L,28811L,53235L,98479L,182403L,338461L,628873L,1169875L,2177875L,4056997L,7561019L,14098931L,26303445L,49100159L,91702815L,171359391L,320357055L,599167829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201866Inst : IEnumerable<long>
{
public static readonly long[] Value=A201866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201866.Bytes);
public long this[int i]=>Value[i];

public static A201866Inst Instance=new A201866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201867
{
public static readonly long[] Value={ 1L,3L,5L,19L,45L,129L,345L,1031L,2969L,8803L,25791L,76285L,225047L,667807L,1984599L,5918017L,17672419L,52880691L,158447783L,475463579L,1428412619L,4296219727L,12934516047L,38978330199L,117561661847L,354857238103L,1071910795169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201867Inst : IEnumerable<long>
{
public static readonly long[] Value=A201867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201867.Bytes);
public long this[int i]=>Value[i];

public static A201867Inst Instance=new A201867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201868
{
public static readonly long[] Value={ 1L,3L,15L,45L,169L,643L,2509L,10129L,41031L,166337L,678169L,2772981L,11365437L,46717997L,192513137L,795049313L,3289962901L,13637608037L,56617168555L,235369429109L,979676940333L,4082222870535L,17027439214453L,71089263424863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201868Inst : IEnumerable<long>
{
public static readonly long[] Value=A201868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201868.Bytes);
public long this[int i]=>Value[i];

public static A201868Inst Instance=new A201868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201869
{
public static readonly long[] Value={ 1L,5L,21L,95L,443L,2191L,11107L,57203L,296293L,1541117L,8043485L,42109417L,221085605L,1163918489L,6142786425L,32491880113L,172201763497L,914222792849L,4861068133699L,25882407886253L,137978446814067L,736378930368467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201869Inst : IEnumerable<long>
{
public static readonly long[] Value=A201869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201869.Bytes);
public long this[int i]=>Value[i];

public static A201869Inst Instance=new A201869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201870
{
public static readonly long[] Value={ 1L,5L,27L,173L,977L,5963L,36569L,229949L,1451137L,9210249L,58617915L,374278491L,2396497371L,15387074629L,99039136267L,638882616201L,4129364962373L,26735915952717L,173368759816541L,1125743820087835L,7318831174181965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201870Inst : IEnumerable<long>
{
public static readonly long[] Value=A201870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201870.Bytes);
public long this[int i]=>Value[i];

public static A201870Inst Instance=new A201870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201871
{
public static readonly long[] Value={ 1L,7L,47L,285L,1905L,13635L,99143L,734607L,5477087L,40989699L,307950303L,2320964021L,17543356961L,132967038437L,1010302510909L,7693410001853L,58699664900479L,448643950237839L,3434254414420963L,26324281838259421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201871Inst : IEnumerable<long>
{
public static readonly long[] Value=A201871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201871.Bytes);
public long this[int i]=>Value[i];

public static A201871Inst Instance=new A201871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201872
{
public static readonly long[] Value={ 1L,7L,57L,431L,3373L,27647L,232969L,1990383L,17103271L,147612131L,1278588895L,11110113949L,96822737023L,846090334081L,7411911618255L,65073276474339L,572430700911207L,5044195360234563L,44516912275192801L,393415480687909671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201872Inst : IEnumerable<long>
{
public static readonly long[] Value=A201872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201872.Bytes);
public long this[int i]=>Value[i];

public static A201872Inst Instance=new A201872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201873
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,3L,5L,3L,1L,5L,15L,19L,5L,1L,5L,21L,45L,45L,11L,1L,7L,27L,95L,169L,129L,21L,1L,7L,47L,173L,443L,643L,345L,39L,1L,9L,57L,285L,977L,2191L,2509L,1031L,73L,1L,9L,67L,431L,1905L,5963L,11107L,10129L,2969L,129L,1L,11L,97L,633L,3373L,13635L,36569L,57203L,41031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201873Inst : IEnumerable<long>
{
public static readonly long[] Value=A201873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201873.Bytes);
public long this[int i]=>Value[i];

public static A201873Inst Instance=new A201873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201874
{
public static readonly long[] Value={ 3L,5L,15L,21L,27L,47L,57L,67L,97L,111L,125L,165L,183L,201L,251L,273L,295L,355L,381L,407L,477L,507L,537L,617L,651L,685L,775L,813L,851L,951L,993L,1035L,1145L,1191L,1237L,1357L,1407L,1457L,1587L,1641L,1695L,1835L,1893L,1951L,2101L,2163L,2225L,2385L,2451L,2517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201874Inst : IEnumerable<long>
{
public static readonly long[] Value=A201874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201874.Bytes);
public long this[int i]=>Value[i];

public static A201874Inst Instance=new A201874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201875
{
public static readonly long[] Value={ 3L,19L,45L,95L,173L,285L,431L,633L,879L,1183L,1557L,1999L,2509L,3117L,3803L,4581L,5471L,6463L,7557L,8791L,10137L,11609L,13235L,14997L,16895L,18975L,21201L,23587L,26169L,28921L,31843L,34989L,38315L,41835L,45593L,49555L,53721L,58153L,62799L,67673L,72827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201875Inst : IEnumerable<long>
{
public static readonly long[] Value=A201875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201875.Bytes);
public long this[int i]=>Value[i];

public static A201875Inst Instance=new A201875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201876
{
public static readonly long[] Value={ 5L,45L,169L,443L,977L,1905L,3373L,5555L,8655L,12901L,18541L,25891L,35207L,46827L,61141L,78483L,99295L,124019L,153047L,186915L,226123L,271207L,322711L,381229L,447347L,521711L,605043L,697945L,801117L,915391L,1041415L,1180073L,1332161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201876Inst : IEnumerable<long>
{
public static readonly long[] Value=A201876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201876.Bytes);
public long this[int i]=>Value[i];

public static A201876Inst Instance=new A201876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201877
{
public static readonly long[] Value={ 11L,129L,643L,2191L,5963L,13635L,27647L,51753L,90021L,147955L,233373L,353731L,518711L,742015L,1035117L,1413269L,1897685L,2504735L,3256189L,4183023L,5306711L,6657117L,8276669L,10192753L,12444053L,15087213L,18155235L,21697465L,25786411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201877Inst : IEnumerable<long>
{
public static readonly long[] Value=A201877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201877.Bytes);
public long this[int i]=>Value[i];

public static A201877Inst Instance=new A201877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201878
{
public static readonly long[] Value={ 21L,345L,2509L,11107L,36569L,99143L,232969L,492307L,958025L,1743993L,3006947L,4955757L,7859017L,12059931L,17987847L,26166137L,37233755L,51958111L,71242519L,96156041L,127946965L,168048881L,218120357L,280058879L,356003167L,448386363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201878Inst : IEnumerable<long>
{
public static readonly long[] Value=A201878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201878.Bytes);
public long this[int i]=>Value[i];

public static A201878Inst Instance=new A201878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201879
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,30L,31L,37L,41L,43L,47L,53L,59L,61L,67L,70L,71L,73L,79L,83L,89L,97L,101L,102L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201879Inst : IEnumerable<long>
{
public static readonly long[] Value=A201879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201879.Bytes);
public long this[int i]=>Value[i];

public static A201879Inst Instance=new A201879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201880
{
public static readonly long[] Value={ 4L,18L,21L,33L,39L,72L,93L,99L,100L,159L,171L,177L,189L,207L,213L,231L,245L,249L,261L,275L,291L,297L,303L,333L,338L,357L,369L,381L,399L,400L,453L,471L,475L,477L,484L,495L,537L,539L,543L,561L,609L,633L,648L,657L,669L,681L,711L,717L,783L,801L,833L,861L,909L,927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201880Inst : IEnumerable<long>
{
public static readonly long[] Value=A201880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201880.Bytes);
public long this[int i]=>Value[i];

public static A201880Inst Instance=new A201880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201881
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,1L,3L,3L,1L,4L,4L,1L,2L,2L,1L,1L,1L,2L,1L,2L,3L,1L,1L,3L,2L,5L,1L,1L,2L,1L,5L,2L,2L,2L,6L,1L,1L,1L,1L,1L,2L,3L,3L,2L,1L,3L,1L,1L,1L,1L,1L,6L,2L,1L,2L,1L,1L,2L,2L,3L,1L,1L,4L,4L,1L,2L,1L,1L,2L,2L,2L,1L,3L,1L,4L,1L,1L,2L,1L,1L,1L,1L,7L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201881Inst : IEnumerable<long>
{
public static readonly long[] Value=A201881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201881.Bytes);
public long this[int i]=>Value[i];

public static A201881Inst Instance=new A201881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201882
{
public static readonly long[] Value={ 1L,3L,8L,11L,27L,36L,84L,231L,349L,535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201882Inst : IEnumerable<long>
{
public static readonly long[] Value=A201882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201882.Bytes);
public long this[int i]=>Value[i];

public static A201882Inst Instance=new A201882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201883
{
public static readonly BigInteger[] Value={ 1L,0L,0L,1L,15L,192L,2530L,36165L,570507L,9969400L,192525084L,4087525095L,94813475185L,2387594185944L,64886220442290L,1892895183489583L,58997625514583385L,1956486468000839280L,BigInteger.Parse("68781080882461076488"),BigInteger.Parse("2555098360335768584385"),BigInteger.Parse("100009432504671913008351") };
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
public class A201883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201883Inst Instance=new A201883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201884
{
public static readonly long[] Value={ 0L,1L,1L,5L,1L,23L,25L,97L,155L,553L,893L,2945L,5721L,16499L,34509L,96903L,211929L,571639L,1310827L,3446631L,8106415L,21036009L,50484447L,129556711L,315618625L,804915729L,1980809241L,5032086931L,12478845269L,31624865741L,78861551727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201884Inst : IEnumerable<long>
{
public static readonly long[] Value=A201884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201884.Bytes);
public long this[int i]=>Value[i];

public static A201884Inst Instance=new A201884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201885
{
public static readonly long[] Value={ 1L,9L,63L,413L,3293L,25123L,196811L,1610765L,13183301L,109772649L,924269015L,7845330131L,67157103399L,578601709251L,5012862231269L,43640547493913L,381459159995789L,3345900096556721L,29435197443234979L,259612374333413841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201885Inst : IEnumerable<long>
{
public static readonly long[] Value=A201885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201885.Bytes);
public long this[int i]=>Value[i];

public static A201885Inst Instance=new A201885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201886
{
public static readonly BigInteger[] Value={ 1L,63L,765L,26003L,559115L,16513425L,435630965L,12576072219L,355197660509L,10318921933459L,299385686951737L,8776646594694357L,257891661687979323L,7614010950576116449L,BigInteger.Parse("225337048658653360699"),BigInteger.Parse("6687122593012508859001") };
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
public class A201886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201886Inst Instance=new A201886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201887
{
public static readonly long[] Value={ 5L,413L,26003L,2171313L,184247585L,16910703303L,1591685181703L,153167112074177L,14927625333671307L,1468389415886159993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201887Inst : IEnumerable<long>
{
public static readonly long[] Value=A201887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201887.Bytes);
public long this[int i]=>Value[i];

public static A201887Inst Instance=new A201887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201888
{
public static readonly long[] Value={ 0L,1L,1L,1L,9L,1L,5L,63L,63L,5L,1L,413L,765L,413L,1L,23L,3293L,26003L,26003L,3293L,23L,25L,25123L,559115L,2171313L,559115L,25123L,25L,97L,196811L,16513425L,184247585L,184247585L,16513425L,196811L,97L,155L,1610765L,435630965L,16910703303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201888Inst : IEnumerable<long>
{
public static readonly long[] Value=A201888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201888.Bytes);
public long this[int i]=>Value[i];

public static A201888Inst Instance=new A201888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201889
{
public static readonly long[] Value={ 2L,7L,1L,2L,8L,7L,7L,1L,8L,7L,0L,3L,7L,3L,1L,9L,6L,0L,2L,2L,1L,8L,8L,0L,5L,3L,4L,8L,5L,3L,9L,2L,0L,4L,5L,1L,3L,5L,6L,9L,4L,1L,1L,8L,2L,9L,2L,0L,2L,7L,8L,1L,6L,4L,2L,4L,8L,4L,1L,1L,0L,6L,6L,1L,5L,4L,4L,0L,8L,9L,5L,0L,4L,4L,1L,7L,7L,2L,6L,2L,7L,5L,5L,4L,3L,6L,6L,4L,3L,7L,2L,2L,9L,7L,2L,4L,2L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201889Inst : IEnumerable<long>
{
public static readonly long[] Value=A201889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201889.Bytes);
public long this[int i]=>Value[i];

public static A201889Inst Instance=new A201889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201890
{
public static readonly long[] Value={ 2L,5L,1L,2L,8L,6L,2L,4L,1L,7L,2L,5L,2L,3L,3L,9L,3L,5L,3L,9L,6L,5L,4L,7L,5L,2L,3L,3L,2L,1L,8L,4L,3L,2L,6L,5L,3L,8L,3L,2L,8L,3L,3L,6L,6L,3L,4L,0L,2L,6L,4L,7L,4L,2L,2L,2L,5L,1L,7L,8L,9L,4L,5L,4L,0L,9L,6L,6L,0L,0L,9L,5L,7L,0L,8L,2L,1L,0L,3L,8L,0L,7L,0L,6L,7L,3L,2L,9L,5L,0L,1L,8L,9L,4L,5L,0L,1L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201890Inst : IEnumerable<long>
{
public static readonly long[] Value=A201890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201890.Bytes);
public long this[int i]=>Value[i];

public static A201890Inst Instance=new A201890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201891
{
public static readonly long[] Value={ 2L,6L,7L,4L,0L,6L,0L,3L,1L,3L,7L,2L,3L,5L,6L,0L,3L,1L,7L,9L,1L,3L,4L,5L,7L,2L,6L,4L,5L,9L,1L,6L,9L,4L,9L,8L,9L,6L,2L,2L,7L,8L,7L,7L,9L,5L,0L,2L,7L,8L,2L,2L,2L,7L,8L,0L,8L,7L,7L,1L,8L,8L,1L,8L,1L,3L,7L,5L,6L,5L,5L,4L,9L,1L,6L,9L,9L,1L,8L,5L,7L,6L,4L,4L,5L,2L,1L,7L,4L,9L,5L,3L,8L,3L,5L,8L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201891Inst : IEnumerable<long>
{
public static readonly long[] Value=A201891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201891.Bytes);
public long this[int i]=>Value[i];

public static A201891Inst Instance=new A201891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201892
{
public static readonly long[] Value={ 2L,7L,9L,9L,4L,7L,4L,3L,9L,7L,7L,8L,6L,3L,8L,9L,6L,6L,7L,2L,6L,0L,6L,1L,6L,0L,6L,1L,8L,3L,3L,5L,5L,8L,3L,6L,8L,3L,2L,8L,4L,8L,2L,3L,5L,5L,9L,9L,8L,2L,5L,3L,0L,5L,7L,5L,6L,4L,9L,0L,7L,6L,7L,9L,1L,6L,5L,6L,8L,0L,5L,9L,1L,9L,3L,7L,0L,4L,5L,2L,8L,4L,4L,6L,8L,9L,4L,1L,1L,9L,3L,9L,5L,3L,3L,5L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201892Inst : IEnumerable<long>
{
public static readonly long[] Value=A201892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201892.Bytes);
public long this[int i]=>Value[i];

public static A201892Inst Instance=new A201892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201893
{
public static readonly long[] Value={ 2L,9L,0L,3L,4L,4L,6L,8L,7L,9L,0L,2L,6L,8L,9L,6L,8L,5L,8L,2L,8L,6L,8L,8L,8L,1L,7L,7L,0L,3L,4L,0L,7L,5L,9L,0L,0L,8L,3L,0L,0L,2L,7L,4L,7L,7L,9L,1L,2L,3L,0L,6L,5L,8L,7L,9L,5L,5L,4L,5L,5L,0L,5L,4L,2L,6L,8L,5L,3L,7L,2L,7L,7L,1L,4L,1L,4L,2L,9L,3L,1L,2L,3L,9L,7L,1L,8L,5L,4L,4L,1L,7L,7L,4L,4L,3L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201893Inst : IEnumerable<long>
{
public static readonly long[] Value=A201893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201893.Bytes);
public long this[int i]=>Value[i];

public static A201893Inst Instance=new A201893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201894
{
public static readonly long[] Value={ 2L,9L,9L,2L,8L,8L,4L,5L,9L,0L,3L,3L,8L,2L,0L,4L,4L,1L,9L,1L,1L,4L,5L,3L,4L,9L,0L,7L,8L,3L,2L,3L,3L,4L,2L,3L,3L,7L,0L,4L,0L,2L,3L,8L,2L,1L,1L,3L,1L,1L,5L,8L,6L,6L,1L,4L,0L,7L,2L,3L,0L,5L,7L,1L,5L,9L,5L,0L,8L,5L,3L,4L,7L,4L,3L,6L,9L,2L,3L,8L,8L,6L,2L,6L,1L,7L,5L,7L,8L,0L,8L,5L,1L,6L,9L,3L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201894Inst : IEnumerable<long>
{
public static readonly long[] Value=A201894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201894.Bytes);
public long this[int i]=>Value[i];

public static A201894Inst Instance=new A201894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201895
{
public static readonly long[] Value={ 2L,6L,4L,9L,2L,1L,9L,8L,8L,7L,7L,6L,7L,2L,9L,2L,9L,6L,5L,3L,4L,8L,4L,9L,6L,1L,3L,7L,9L,5L,3L,4L,0L,8L,1L,5L,2L,7L,9L,6L,9L,5L,4L,5L,4L,5L,4L,9L,7L,2L,0L,5L,7L,6L,3L,0L,7L,4L,6L,5L,8L,0L,9L,0L,6L,1L,2L,5L,0L,6L,6L,9L,9L,0L,9L,4L,1L,9L,6L,6L,6L,6L,7L,3L,7L,3L,0L,1L,0L,6L,4L,5L,0L,2L,0L,7L,9L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201895Inst : IEnumerable<long>
{
public static readonly long[] Value=A201895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201895.Bytes);
public long this[int i]=>Value[i];

public static A201895Inst Instance=new A201895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201896
{
public static readonly long[] Value={ 2L,8L,9L,3L,1L,1L,6L,4L,3L,0L,9L,2L,5L,2L,7L,1L,2L,2L,0L,3L,1L,5L,5L,3L,4L,9L,3L,1L,3L,4L,9L,5L,3L,0L,8L,8L,5L,3L,0L,4L,0L,7L,9L,0L,9L,1L,5L,4L,6L,9L,7L,7L,4L,0L,1L,8L,2L,1L,6L,3L,4L,9L,2L,8L,1L,6L,6L,5L,5L,3L,6L,6L,0L,7L,8L,3L,3L,7L,3L,0L,5L,1L,9L,0L,8L,9L,2L,1L,0L,2L,3L,8L,8L,7L,1L,7L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201896Inst : IEnumerable<long>
{
public static readonly long[] Value=A201896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201896.Bytes);
public long this[int i]=>Value[i];

public static A201896Inst Instance=new A201896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201897
{
public static readonly long[] Value={ 2L,1L,0L,9L,3L,5L,6L,9L,9L,5L,5L,7L,1L,0L,1L,6L,1L,2L,7L,2L,3L,1L,6L,9L,9L,2L,4L,7L,0L,5L,9L,2L,5L,7L,8L,8L,4L,1L,1L,5L,5L,3L,0L,3L,7L,9L,2L,8L,2L,6L,8L,5L,7L,5L,2L,0L,7L,4L,1L,9L,9L,4L,7L,4L,5L,1L,5L,9L,8L,2L,6L,1L,9L,7L,9L,8L,1L,1L,3L,6L,8L,1L,5L,0L,9L,9L,3L,5L,7L,0L,2L,0L,9L,0L,6L,7L,5L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201897Inst : IEnumerable<long>
{
public static readonly long[] Value=A201897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201897.Bytes);
public long this[int i]=>Value[i];

public static A201897Inst Instance=new A201897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201898
{
public static readonly long[] Value={ 6L,0L,8L,9L,8L,9L,1L,0L,3L,0L,1L,0L,1L,6L,5L,4L,9L,4L,8L,3L,5L,0L,4L,3L,7L,0L,1L,9L,2L,6L,0L,1L,1L,8L,7L,3L,3L,9L,7L,1L,1L,5L,3L,1L,7L,1L,1L,4L,2L,7L,7L,5L,0L,7L,0L,9L,4L,1L,6L,7L,7L,0L,2L,8L,8L,2L,2L,0L,7L,5L,9L,0L,4L,7L,1L,1L,3L,8L,2L,0L,5L,4L,3L,8L,1L,1L,3L,1L,0L,3L,9L,7L,3L,5L,4L,5L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201898Inst : IEnumerable<long>
{
public static readonly long[] Value=A201898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201898.Bytes);
public long this[int i]=>Value[i];

public static A201898Inst Instance=new A201898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201899
{
public static readonly long[] Value={ 2L,9L,9L,2L,2L,3L,4L,8L,7L,2L,0L,5L,3L,9L,3L,6L,8L,6L,5L,0L,9L,3L,3L,1L,1L,4L,5L,2L,7L,8L,3L,8L,8L,2L,6L,2L,1L,8L,1L,1L,5L,9L,4L,5L,4L,7L,7L,4L,9L,0L,0L,6L,3L,6L,3L,9L,1L,2L,5L,6L,2L,3L,9L,9L,9L,3L,6L,1L,6L,8L,9L,8L,5L,4L,9L,6L,4L,7L,1L,9L,5L,1L,2L,1L,1L,4L,9L,4L,4L,6L,8L,2L,5L,6L,7L,1L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201899Inst : IEnumerable<long>
{
public static readonly long[] Value=A201899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201899.Bytes);
public long this[int i]=>Value[i];

public static A201899Inst Instance=new A201899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201900
{
public static readonly long[] Value={ 3L,0L,7L,7L,4L,5L,4L,7L,2L,9L,8L,2L,6L,0L,8L,8L,7L,0L,5L,2L,1L,7L,7L,4L,2L,5L,0L,8L,3L,6L,7L,5L,6L,3L,7L,9L,8L,8L,2L,0L,7L,5L,7L,4L,0L,0L,8L,7L,0L,6L,5L,0L,9L,1L,8L,7L,9L,9L,5L,9L,0L,9L,1L,1L,8L,4L,5L,4L,2L,6L,0L,8L,9L,5L,1L,6L,7L,4L,1L,4L,6L,2L,1L,2L,4L,0L,4L,9L,5L,6L,9L,5L,8L,8L,4L,5L,2L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201900Inst : IEnumerable<long>
{
public static readonly long[] Value=A201900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201900.Bytes);
public long this[int i]=>Value[i];

public static A201900Inst Instance=new A201900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201901
{
public static readonly long[] Value={ 3L,1L,5L,2L,5L,9L,0L,7L,3L,6L,7L,5L,7L,1L,5L,8L,2L,7L,4L,9L,9L,6L,9L,8L,9L,0L,0L,4L,7L,6L,7L,1L,3L,9L,7L,8L,5L,8L,1L,3L,8L,0L,9L,4L,4L,8L,2L,5L,9L,8L,9L,3L,1L,5L,4L,6L,3L,5L,0L,1L,5L,8L,0L,5L,9L,3L,5L,0L,8L,5L,3L,3L,6L,7L,0L,4L,6L,0L,8L,0L,6L,7L,6L,4L,9L,5L,9L,5L,4L,4L,3L,7L,3L,6L,5L,7L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201901Inst : IEnumerable<long>
{
public static readonly long[] Value=A201901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201901.Bytes);
public long this[int i]=>Value[i];

public static A201901Inst Instance=new A201901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201902
{
public static readonly long[] Value={ 3L,2L,2L,0L,0L,1L,7L,9L,5L,0L,5L,2L,5L,7L,1L,0L,2L,9L,5L,7L,7L,7L,0L,9L,2L,0L,9L,2L,5L,0L,5L,1L,3L,0L,1L,7L,8L,3L,9L,2L,9L,8L,3L,1L,6L,0L,4L,3L,3L,1L,1L,5L,5L,0L,8L,4L,6L,2L,9L,1L,1L,4L,0L,0L,9L,8L,2L,4L,9L,0L,5L,6L,5L,5L,3L,2L,3L,7L,6L,0L,7L,0L,3L,7L,7L,3L,6L,5L,3L,1L,3L,0L,2L,0L,7L,8L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201902Inst : IEnumerable<long>
{
public static readonly long[] Value=A201902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201902.Bytes);
public long this[int i]=>Value[i];

public static A201902Inst Instance=new A201902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201903
{
public static readonly long[] Value={ 3L,7L,3L,8L,9L,0L,2L,0L,0L,9L,6L,6L,8L,9L,9L,6L,7L,2L,5L,1L,8L,0L,2L,0L,5L,8L,0L,9L,5L,3L,9L,2L,7L,8L,2L,3L,0L,1L,4L,7L,6L,6L,8L,8L,9L,7L,0L,7L,8L,6L,0L,7L,2L,8L,2L,2L,0L,0L,9L,9L,5L,7L,9L,2L,4L,2L,6L,0L,6L,8L,0L,9L,5L,0L,9L,5L,6L,0L,2L,8L,1L,5L,4L,6L,6L,1L,1L,4L,3L,9L,1L,8L,8L,9L,8L,5L,0L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201903Inst : IEnumerable<long>
{
public static readonly long[] Value=A201903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201903.Bytes);
public long this[int i]=>Value[i];

public static A201903Inst Instance=new A201903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201904
{
public static readonly long[] Value={ 3L,1L,6L,4L,1L,3L,7L,1L,1L,1L,6L,3L,7L,9L,3L,8L,3L,2L,5L,2L,8L,4L,4L,6L,6L,9L,6L,6L,7L,3L,8L,9L,2L,1L,5L,9L,6L,5L,6L,1L,5L,5L,3L,9L,9L,2L,8L,5L,9L,5L,4L,4L,6L,8L,2L,9L,4L,2L,9L,6L,9L,5L,3L,8L,4L,1L,0L,1L,9L,5L,2L,1L,7L,6L,4L,7L,0L,9L,8L,9L,5L,4L,3L,6L,1L,5L,6L,7L,8L,3L,8L,2L,0L,9L,3L,2L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201904Inst : IEnumerable<long>
{
public static readonly long[] Value=A201904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201904.Bytes);
public long this[int i]=>Value[i];

public static A201904Inst Instance=new A201904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201905
{
public static readonly long[] Value={ 3L,4L,2L,5L,6L,6L,7L,4L,1L,0L,2L,0L,2L,8L,7L,7L,3L,7L,3L,2L,6L,5L,6L,2L,6L,0L,6L,4L,7L,2L,5L,8L,1L,6L,6L,9L,7L,8L,2L,7L,3L,5L,7L,2L,6L,1L,7L,3L,3L,2L,3L,3L,5L,5L,5L,3L,6L,6L,6L,3L,4L,3L,8L,0L,6L,5L,1L,2L,9L,4L,4L,3L,4L,9L,4L,2L,4L,4L,2L,7L,5L,0L,1L,2L,8L,7L,3L,9L,9L,6L,5L,9L,7L,0L,2L,5L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201905Inst : IEnumerable<long>
{
public static readonly long[] Value=A201905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201905.Bytes);
public long this[int i]=>Value[i];

public static A201905Inst Instance=new A201905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201906
{
public static readonly long[] Value={ 3L,5L,6L,8L,7L,4L,9L,1L,9L,1L,3L,8L,6L,3L,6L,4L,8L,5L,6L,5L,0L,6L,6L,7L,0L,5L,8L,7L,5L,9L,9L,1L,2L,4L,4L,0L,9L,5L,9L,9L,2L,0L,0L,5L,2L,6L,2L,0L,8L,0L,4L,2L,0L,9L,9L,6L,8L,1L,8L,4L,5L,7L,7L,9L,2L,0L,7L,4L,7L,0L,6L,1L,9L,1L,8L,6L,6L,5L,3L,2L,2L,5L,4L,6L,7L,4L,0L,0L,6L,5L,0L,2L,7L,5L,6L,9L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201906Inst : IEnumerable<long>
{
public static readonly long[] Value=A201906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201906.Bytes);
public long this[int i]=>Value[i];

public static A201906Inst Instance=new A201906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201907
{
public static readonly long[] Value={ 3L,2L,3L,4L,9L,2L,3L,2L,1L,7L,7L,7L,6L,0L,6L,6L,3L,6L,7L,0L,3L,2L,7L,9L,6L,1L,3L,2L,7L,3L,0L,4L,4L,3L,0L,4L,4L,8L,4L,7L,8L,6L,8L,0L,4L,6L,8L,7L,0L,4L,0L,9L,6L,1L,1L,3L,1L,4L,6L,8L,8L,5L,5L,3L,1L,4L,3L,8L,6L,6L,5L,2L,1L,0L,2L,5L,9L,3L,6L,4L,2L,2L,0L,9L,5L,3L,8L,2L,5L,6L,0L,8L,1L,5L,7L,5L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201907Inst : IEnumerable<long>
{
public static readonly long[] Value=A201907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201907.Bytes);
public long this[int i]=>Value[i];

public static A201907Inst Instance=new A201907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201908
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,4L,3L,1L,2L,4L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,5L,10L,9L,7L,3L,6L,1L,2L,4L,8L,3L,6L,12L,11L,9L,5L,10L,7L,1L,2L,4L,8L,1L,2L,4L,8L,16L,15L,13L,9L,1L,2L,4L,8L,16L,13L,7L,14L,9L,18L,17L,15L,11L,3L,6L,12L,5L,10L,1L,2L,4L,8L,16L,11L,1L,2L,4L,8L,16L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201908Inst : IEnumerable<long>
{
public static readonly long[] Value=A201908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201908.Bytes);
public long this[int i]=>Value[i];

public static A201908Inst Instance=new A201908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201909
{
public static readonly long[] Value={ 1L,0L,1L,3L,4L,2L,1L,3L,2L,6L,4L,5L,1L,3L,9L,5L,4L,1L,3L,9L,1L,3L,9L,10L,13L,5L,15L,11L,16L,14L,8L,7L,4L,12L,2L,6L,1L,3L,9L,8L,5L,15L,7L,2L,6L,18L,16L,10L,11L,14L,4L,12L,17L,13L,1L,3L,9L,4L,12L,13L,16L,2L,6L,18L,8L,1L,3L,9L,27L,23L,11L,4L,12L,7L,21L,5L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201909Inst : IEnumerable<long>
{
public static readonly long[] Value=A201909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201909.Bytes);
public long this[int i]=>Value[i];

public static A201909Inst Instance=new A201909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201910
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,5L,4L,6L,2L,3L,1L,5L,3L,4L,9L,1L,5L,12L,8L,1L,5L,8L,6L,13L,14L,2L,10L,16L,12L,9L,11L,4L,3L,15L,7L,1L,5L,6L,11L,17L,9L,7L,16L,4L,1L,5L,2L,10L,4L,20L,8L,17L,16L,11L,9L,22L,18L,21L,13L,19L,3L,15L,6L,7L,12L,14L,1L,5L,25L,9L,16L,22L,23L,28L,24L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201910Inst : IEnumerable<long>
{
public static readonly long[] Value=A201910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201910.Bytes);
public long this[int i]=>Value[i];

public static A201910Inst Instance=new A201910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201911
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,3L,0L,1L,7L,5L,2L,3L,10L,4L,6L,9L,8L,1L,7L,10L,5L,9L,11L,12L,6L,3L,8L,4L,2L,1L,7L,15L,3L,4L,11L,9L,12L,16L,10L,2L,14L,13L,6L,8L,5L,1L,7L,11L,1L,7L,3L,21L,9L,17L,4L,5L,12L,15L,13L,22L,16L,20L,2L,14L,6L,19L,18L,11L,8L,10L,1L,7L,20L,24L,23L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201911Inst : IEnumerable<long>
{
public static readonly long[] Value=A201911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201911.Bytes);
public long this[int i]=>Value[i];

public static A201911Inst Instance=new A201911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201912
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,4L,3L,1L,2L,4L,1L,2L,4L,8L,5L,10L,9L,7L,3L,6L,1L,2L,4L,8L,3L,6L,12L,11L,9L,5L,10L,7L,1L,2L,4L,8L,16L,15L,13L,9L,1L,2L,4L,8L,16L,13L,7L,14L,9L,18L,17L,15L,11L,3L,6L,12L,5L,10L,1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L,8L,16L,3L,6L,12L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201912Inst : IEnumerable<long>
{
public static readonly long[] Value=A201912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201912.Bytes);
public long this[int i]=>Value[i];

public static A201912Inst Instance=new A201912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201913
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,2L,3L,1L,1L,2L,2L,2L,1L,3L,4L,1L,2L,2L,1L,1L,3L,2L,3L,1L,4L,5L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,1L,2L,3L,3L,3L,1L,1L,4L,2L,4L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201913Inst : IEnumerable<long>
{
public static readonly long[] Value=A201913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201913.Bytes);
public long this[int i]=>Value[i];

public static A201913Inst Instance=new A201913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201914
{
public static readonly long[] Value={ 2L,5L,3L,7L,47L,31L,191L,127L,1279L,3583L,5119L,6143L,20479L,8191L,81919L,294911L,1114111L,131071L,786431L,524287L,17825791L,14680063L,138412031L,109051903L,654311423L,1912602623L,738197503L,2818572287L,7247757311L,3758096383L,228707008511L,2147483647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201914Inst : IEnumerable<long>
{
public static readonly long[] Value=A201914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201914.Bytes);
public long this[int i]=>Value[i];

public static A201914Inst Instance=new A201914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201915
{
public static readonly long[] Value={ 1L,6L,11L,14L,15L,23L,42L,62L,69L,77L,30L,46L,51L,55L,71L,60L,78L,92L,123L,143L,167L,114L,135L,158L,177L,203L,209L,239L,132L,140L,182L,188L,195L,249L,287L,299L,120L,174L,184L,190L,267L,295L,319L,323L,359L,204L,220L,224L,246L,284L,286L,334L,415L,451L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201915Inst : IEnumerable<long>
{
public static readonly long[] Value=A201915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201915.Bytes);
public long this[int i]=>Value[i];

public static A201915Inst Instance=new A201915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201916
{
public static readonly long[] Value={ 0L,75L,203L,323L,552L,708L,1020L,1127L,1311L,1428L,1608L,1820L,1955L,2336L,2675L,3128L,3311L,3627L,3927L,4140L,4508L,4743L,5535L,6003L,6800L,7280L,7848L,8211L,8588L,9240L,9860L,11063L,11895L,13583L,14168L,15180L,15827L,16827L,18011L,18768L,20915L,22836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201916Inst : IEnumerable<long>
{
public static readonly long[] Value=A201916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201916.Bytes);
public long this[int i]=>Value[i];

public static A201916Inst Instance=new A201916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201917
{
public static readonly long[] Value={ 0L,2085L,2325L,5253L,6141L,6293L,7728L,10013L,11960L,12920L,14637L,16940L,17112L,18737L,21648L,21948L,23541L,24633L,26588L,27716L,31620L,33012L,34937L,35145L,38012L,40641L,42716L,44268L,47633L,49848L,52785L,54237L,56420L,56840L,60605L,63828L,67541L,70448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201917Inst : IEnumerable<long>
{
public static readonly long[] Value=A201917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201917.Bytes);
public long this[int i]=>Value[i];

public static A201917Inst Instance=new A201917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201918
{
public static readonly long[] Value={ 0L,1L,4L,9L,64L,81L,513L,1216L,6400L,14337L,234496L,483328L,2502657L,17432577L,18399232L,412549120L,842530816L,4317249537L,11162091520L,50755272705L,692253097984L,2178269839360L,6737830608897L,46758772080640L,60234433298433L,474731593596928L,809186870951937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201918Inst : IEnumerable<long>
{
public static readonly long[] Value=A201918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201918.Bytes);
public long this[int i]=>Value[i];

public static A201918Inst Instance=new A201918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201919
{
public static readonly long[] Value={ 0L,1L,7L,8L,49L,148L,344L,2401L,36016L,151264L,386561L,1764736L,5764801L,46941952L,58471553L,374712065L,1101076992L,4802079233L,15858967552L,139825248256L,149429406721L,1595702681601L,2453862488064L,14602557997056L,42091354378241L,127990382747648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201919Inst : IEnumerable<long>
{
public static readonly long[] Value=A201919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201919.Bytes);
public long this[int i]=>Value[i];

public static A201919Inst Instance=new A201919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201920
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,64L,3L,6L,12L,24L,48L,96L,67L,9L,18L,36L,72L,19L,38L,76L,27L,54L,108L,91L,57L,114L,103L,81L,37L,74L,23L,46L,92L,59L,118L,111L,97L,69L,13L,26L,52L,104L,83L,41L,82L,39L,78L,31L,62L,124L,123L,121L,117L,109L,93L,61L,122L,119L,113L,101L,77L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201920Inst : IEnumerable<long>
{
public static readonly long[] Value=A201920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201920.Bytes);
public long this[int i]=>Value[i];

public static A201920Inst Instance=new A201920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201921
{
public static readonly long[] Value={ 0L,1L,6L,10L,100L,126L,1000L,2376L,4375L,46251L,156250L,603126L,3640626L,7750000L,19140625L,151718751L,835156251L,1727734375L,5960937501L,32482421875L,236621093751L,340029296875L,8413134765625L,60784912109376L,68961425781250L,709516601562501L,1236678466796875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201921Inst : IEnumerable<long>
{
public static readonly long[] Value=A201921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201921.Bytes);
public long this[int i]=>Value[i];

public static A201921Inst Instance=new A201921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201922
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,6L,3L,1L,1L,21L,8L,3L,1L,1L,112L,30L,9L,3L,1L,1L,853L,145L,32L,9L,3L,1L,1L,11117L,1028L,154L,33L,9L,3L,1L,1L,261080L,12320L,1065L,156L,33L,9L,3L,1L,1L,11716571L,274806L,12513L,1074L,157L,33L,9L,3L,1L,1L,1006700565L,12007355L,276114L,12550L,1076L,157L,33L,9L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201922Inst : IEnumerable<long>
{
public static readonly long[] Value=A201922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201922.Bytes);
public long this[int i]=>Value[i];

public static A201922Inst Instance=new A201922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201923
{
public static readonly BigInteger[] Value={ 1L,1L,5L,44L,581L,10256L,227529L,6088256L,190930729L,6870227200L,279066777613L,12632667642880L,630670054092525L,34426087332253696L,2039903110075608977L,BigInteger.Parse("130404672744539242496"),BigInteger.Parse("8946117466489960168913"),BigInteger.Parse("655585000075494566199296"),BigInteger.Parse("51111210765059412626238741") };
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
public class A201923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201923Inst Instance=new A201923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201924
{
public static readonly long[] Value={ 3L,0L,2L,4L,0L,1L,4L,5L,0L,1L,1L,3L,5L,2L,9L,3L,7L,8L,4L,7L,7L,5L,5L,8L,9L,6L,2L,7L,7L,9L,7L,3L,9L,5L,3L,5L,1L,6L,5L,9L,8L,2L,8L,2L,8L,7L,1L,3L,2L,9L,0L,7L,9L,1L,9L,8L,7L,5L,0L,3L,5L,5L,4L,8L,2L,6L,2L,3L,8L,2L,5L,2L,4L,7L,0L,6L,6L,4L,3L,2L,9L,4L,3L,2L,4L,8L,4L,3L,4L,2L,4L,1L,0L,3L,3L,5L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201924Inst : IEnumerable<long>
{
public static readonly long[] Value=A201924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201924.Bytes);
public long this[int i]=>Value[i];

public static A201924Inst Instance=new A201924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201925
{
public static readonly long[] Value={ 7L,9L,5L,2L,2L,6L,6L,1L,3L,8L,6L,0L,5L,4L,0L,7L,9L,8L,8L,9L,6L,2L,6L,1L,5L,5L,6L,3L,8L,8L,7L,1L,8L,0L,2L,9L,3L,6L,3L,7L,4L,8L,5L,3L,8L,5L,6L,2L,0L,8L,7L,8L,6L,0L,3L,5L,7L,5L,0L,0L,6L,4L,4L,0L,0L,6L,9L,4L,8L,1L,6L,2L,4L,2L,3L,4L,8L,1L,2L,6L,8L,5L,9L,0L,8L,7L,3L,9L,7L,0L,2L,5L,4L,6L,5L,0L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201925Inst : IEnumerable<long>
{
public static readonly long[] Value=A201925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201925.Bytes);
public long this[int i]=>Value[i];

public static A201925Inst Instance=new A201925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201926
{
public static readonly long[] Value={ 3L,2L,9L,8L,6L,2L,7L,5L,6L,2L,8L,0L,3L,8L,6L,5L,1L,8L,0L,2L,5L,5L,9L,4L,1L,3L,1L,6L,4L,9L,2L,3L,4L,1L,3L,4L,3L,1L,8L,2L,0L,4L,3L,0L,3L,6L,5L,6L,2L,3L,9L,5L,6L,3L,7L,8L,3L,7L,0L,0L,8L,6L,3L,3L,5L,7L,8L,8L,6L,2L,0L,1L,5L,3L,4L,4L,6L,8L,4L,1L,7L,2L,0L,6L,2L,7L,1L,9L,0L,6L,5L,3L,7L,8L,4L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201926Inst : IEnumerable<long>
{
public static readonly long[] Value=A201926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201926.Bytes);
public long this[int i]=>Value[i];

public static A201926Inst Instance=new A201926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201927
{
public static readonly long[] Value={ 2L,3L,1L,4L,3L,6L,9L,9L,0L,2L,9L,6L,7L,6L,2L,8L,0L,1L,9L,1L,7L,3L,9L,1L,3L,3L,9L,2L,0L,4L,2L,9L,4L,7L,1L,8L,9L,3L,2L,0L,3L,5L,0L,5L,5L,7L,6L,8L,2L,8L,5L,8L,5L,9L,0L,7L,9L,3L,7L,5L,4L,4L,3L,2L,0L,9L,4L,9L,2L,5L,2L,5L,8L,4L,2L,1L,4L,5L,1L,0L,4L,0L,7L,3L,1L,4L,6L,5L,7L,5L,5L,4L,7L,5L,4L,9L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201927Inst : IEnumerable<long>
{
public static readonly long[] Value=A201927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201927.Bytes);
public long this[int i]=>Value[i];

public static A201927Inst Instance=new A201927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201928
{
public static readonly long[] Value={ 1L,5L,3L,6L,0L,7L,8L,0L,9L,4L,0L,2L,6L,9L,3L,1L,1L,3L,0L,5L,1L,1L,3L,6L,7L,0L,5L,2L,1L,5L,5L,0L,9L,5L,9L,8L,1L,8L,1L,3L,6L,9L,8L,2L,9L,7L,7L,4L,3L,8L,3L,6L,3L,8L,9L,0L,2L,0L,6L,2L,0L,6L,5L,4L,4L,9L,6L,7L,5L,7L,7L,8L,0L,2L,5L,5L,2L,4L,6L,8L,4L,1L,4L,1L,8L,2L,9L,0L,2L,7L,8L,0L,4L,0L,6L,7L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201928Inst : IEnumerable<long>
{
public static readonly long[] Value=A201928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201928.Bytes);
public long this[int i]=>Value[i];

public static A201928Inst Instance=new A201928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201929
{
public static readonly long[] Value={ 3L,3L,5L,6L,6L,9L,3L,9L,8L,0L,0L,3L,3L,3L,2L,1L,3L,0L,6L,8L,2L,5L,7L,6L,9L,0L,2L,4L,1L,8L,9L,0L,4L,6L,1L,6L,9L,6L,4L,8L,9L,1L,7L,5L,3L,0L,7L,0L,3L,2L,0L,4L,4L,3L,2L,7L,9L,6L,6L,8L,3L,7L,3L,6L,7L,9L,8L,0L,9L,5L,2L,9L,1L,3L,7L,1L,4L,2L,6L,8L,7L,3L,9L,9L,4L,9L,3L,9L,6L,4L,8L,3L,7L,6L,2L,4L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201929Inst : IEnumerable<long>
{
public static readonly long[] Value=A201929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201929.Bytes);
public long this[int i]=>Value[i];

public static A201929Inst Instance=new A201929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201930
{
public static readonly long[] Value={ 3L,4L,1L,0L,1L,4L,6L,8L,4L,4L,9L,4L,5L,6L,2L,9L,4L,9L,2L,2L,8L,6L,4L,8L,0L,6L,3L,6L,5L,3L,0L,2L,2L,6L,0L,6L,6L,2L,5L,2L,5L,3L,7L,8L,6L,7L,5L,2L,9L,8L,6L,1L,1L,6L,1L,3L,1L,4L,9L,0L,9L,4L,7L,4L,9L,5L,1L,4L,5L,3L,9L,8L,1L,4L,0L,1L,7L,1L,0L,0L,4L,5L,7L,2L,1L,2L,0L,7L,0L,5L,3L,8L,2L,1L,6L,1L,9L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201930Inst : IEnumerable<long>
{
public static readonly long[] Value=A201930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201930.Bytes);
public long this[int i]=>Value[i];

public static A201930Inst Instance=new A201930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201931
{
public static readonly long[] Value={ 4L,7L,9L,3L,0L,9L,5L,4L,5L,5L,1L,2L,7L,4L,9L,3L,5L,8L,9L,5L,6L,5L,6L,2L,1L,1L,0L,8L,5L,0L,4L,2L,0L,4L,3L,1L,4L,3L,4L,8L,9L,0L,9L,3L,1L,7L,4L,9L,1L,1L,1L,6L,0L,8L,1L,0L,6L,7L,9L,3L,2L,4L,1L,6L,4L,7L,7L,9L,2L,7L,2L,5L,5L,7L,4L,3L,6L,2L,1L,1L,3L,1L,9L,9L,3L,3L,1L,8L,8L,1L,4L,2L,4L,1L,1L,4L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201931Inst : IEnumerable<long>
{
public static readonly long[] Value=A201931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201931.Bytes);
public long this[int i]=>Value[i];

public static A201931Inst Instance=new A201931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201932
{
public static readonly long[] Value={ 3L,3L,7L,7L,3L,6L,1L,4L,8L,4L,1L,9L,7L,4L,0L,0L,5L,7L,9L,2L,5L,5L,0L,2L,5L,0L,5L,8L,8L,8L,9L,2L,1L,0L,6L,1L,4L,3L,9L,2L,6L,1L,0L,8L,0L,3L,0L,3L,1L,5L,9L,4L,9L,4L,8L,2L,5L,0L,4L,0L,2L,2L,1L,0L,4L,2L,4L,4L,1L,7L,7L,6L,0L,9L,0L,2L,6L,1L,0L,7L,7L,4L,6L,8L,2L,9L,4L,9L,2L,4L,0L,2L,5L,7L,2L,0L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201932Inst : IEnumerable<long>
{
public static readonly long[] Value=A201932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201932.Bytes);
public long this[int i]=>Value[i];

public static A201932Inst Instance=new A201932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201933
{
public static readonly long[] Value={ 4L,5L,6L,4L,0L,7L,8L,3L,6L,0L,3L,7L,9L,3L,7L,7L,2L,0L,1L,3L,4L,1L,4L,8L,6L,8L,5L,2L,3L,4L,2L,0L,7L,4L,4L,8L,0L,6L,9L,5L,7L,9L,6L,4L,3L,4L,6L,1L,3L,1L,4L,1L,1L,1L,2L,5L,2L,3L,5L,7L,5L,3L,5L,9L,5L,4L,2L,6L,0L,2L,8L,0L,7L,3L,3L,7L,5L,3L,7L,0L,3L,7L,9L,6L,6L,5L,7L,8L,4L,5L,5L,4L,5L,0L,8L,4L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201933Inst : IEnumerable<long>
{
public static readonly long[] Value=A201933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201933.Bytes);
public long this[int i]=>Value[i];

public static A201933Inst Instance=new A201933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201934
{
public static readonly long[] Value={ 2L,5L,9L,0L,6L,9L,5L,3L,3L,0L,5L,1L,1L,0L,9L,1L,0L,8L,6L,8L,6L,4L,0L,5L,6L,6L,4L,6L,5L,5L,9L,6L,2L,2L,6L,2L,8L,9L,6L,4L,8L,0L,5L,4L,5L,7L,8L,6L,4L,2L,5L,5L,1L,3L,1L,6L,9L,2L,1L,5L,6L,5L,9L,4L,9L,0L,1L,7L,2L,4L,9L,0L,0L,0L,8L,8L,2L,5L,6L,7L,1L,2L,6L,4L,9L,8L,1L,3L,4L,8L,3L,9L,7L,0L,1L,2L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201934Inst : IEnumerable<long>
{
public static readonly long[] Value=A201934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201934.Bytes);
public long this[int i]=>Value[i];

public static A201934Inst Instance=new A201934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201935
{
public static readonly long[] Value={ 3L,4L,3L,2L,0L,0L,8L,7L,1L,1L,6L,1L,0L,6L,8L,0L,3L,5L,2L,8L,0L,3L,7L,9L,1L,4L,6L,2L,6L,9L,4L,7L,1L,9L,7L,0L,6L,0L,4L,2L,2L,3L,3L,0L,3L,7L,3L,5L,4L,2L,0L,5L,2L,1L,0L,0L,8L,7L,1L,4L,8L,9L,9L,5L,3L,7L,4L,7L,9L,7L,1L,1L,3L,4L,3L,6L,4L,6L,3L,1L,4L,1L,6L,5L,3L,4L,9L,1L,1L,4L,0L,0L,4L,6L,5L,3L,3L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201935Inst : IEnumerable<long>
{
public static readonly long[] Value=A201935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201935.Bytes);
public long this[int i]=>Value[i];

public static A201935Inst Instance=new A201935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201936
{
public static readonly long[] Value={ 2L,6L,1L,7L,8L,6L,6L,6L,1L,3L,0L,6L,6L,8L,1L,2L,7L,6L,9L,1L,7L,8L,9L,7L,8L,0L,5L,9L,1L,4L,3L,2L,0L,2L,8L,1L,7L,3L,2L,0L,2L,7L,4L,3L,5L,9L,4L,1L,0L,4L,8L,2L,9L,1L,9L,2L,1L,0L,5L,0L,8L,1L,6L,1L,0L,4L,0L,3L,7L,0L,3L,2L,5L,3L,3L,2L,2L,7L,9L,6L,5L,9L,9L,6L,5L,0L,6L,3L,6L,1L,7L,0L,4L,5L,6L,3L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201936Inst : IEnumerable<long>
{
public static readonly long[] Value=A201936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201936.Bytes);
public long this[int i]=>Value[i];

public static A201936Inst Instance=new A201936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201937
{
public static readonly long[] Value={ 1L,4L,8L,7L,9L,6L,2L,0L,6L,5L,4L,9L,8L,1L,7L,7L,1L,5L,6L,2L,5L,4L,3L,7L,0L,1L,2L,0L,9L,3L,2L,6L,3L,2L,5L,6L,3L,7L,2L,6L,4L,8L,4L,2L,4L,3L,7L,8L,0L,2L,1L,0L,6L,8L,4L,6L,2L,3L,6L,9L,6L,8L,9L,7L,7L,2L,6L,8L,6L,8L,0L,9L,4L,4L,6L,2L,7L,6L,8L,7L,4L,4L,2L,2L,8L,9L,2L,0L,8L,3L,0L,1L,2L,0L,9L,0L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201937Inst : IEnumerable<long>
{
public static readonly long[] Value=A201937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201937.Bytes);
public long this[int i]=>Value[i];

public static A201937Inst Instance=new A201937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201938
{
public static readonly long[] Value={ 5L,3L,9L,8L,3L,5L,2L,7L,6L,9L,0L,2L,8L,2L,0L,0L,4L,9L,2L,1L,1L,8L,0L,3L,9L,0L,8L,3L,6L,3L,3L,3L,8L,7L,2L,0L,0L,9L,3L,0L,1L,3L,0L,7L,9L,8L,7L,4L,4L,2L,7L,4L,2L,8L,6L,2L,7L,3L,2L,2L,0L,2L,7L,1L,2L,1L,8L,2L,5L,4L,5L,7L,5L,2L,4L,9L,9L,2L,0L,3L,8L,2L,5L,8L,3L,8L,3L,8L,1L,2L,2L,3L,8L,6L,6L,7L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201938Inst : IEnumerable<long>
{
public static readonly long[] Value=A201938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201938.Bytes);
public long this[int i]=>Value[i];

public static A201938Inst Instance=new A201938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201939
{
public static readonly long[] Value={ 1L,1L,5L,0L,5L,8L,4L,9L,6L,7L,4L,1L,8L,6L,6L,3L,9L,4L,9L,5L,3L,4L,9L,3L,3L,7L,3L,3L,6L,1L,3L,7L,8L,8L,1L,9L,5L,7L,6L,6L,8L,3L,7L,4L,9L,4L,8L,4L,4L,2L,4L,2L,3L,4L,1L,1L,8L,3L,3L,9L,2L,5L,1L,8L,0L,8L,8L,3L,2L,2L,5L,4L,6L,1L,7L,6L,4L,1L,1L,7L,2L,8L,0L,1L,3L,6L,7L,5L,4L,4L,1L,4L,5L,2L,4L,6L,9L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201939Inst : IEnumerable<long>
{
public static readonly long[] Value=A201939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201939.Bytes);
public long this[int i]=>Value[i];

public static A201939Inst Instance=new A201939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201940
{
public static readonly long[] Value={ 1L,1L,4L,7L,7L,5L,7L,6L,3L,2L,1L,4L,4L,7L,4L,3L,4L,9L,3L,0L,3L,4L,3L,7L,1L,9L,9L,0L,6L,1L,0L,6L,7L,4L,7L,6L,6L,4L,3L,4L,6L,1L,9L,1L,2L,4L,4L,6L,2L,9L,3L,5L,9L,9L,1L,5L,2L,8L,4L,5L,4L,4L,0L,8L,2L,6L,9L,0L,5L,7L,7L,9L,2L,1L,8L,8L,7L,0L,9L,8L,1L,9L,2L,4L,6L,7L,6L,7L,8L,1L,0L,0L,1L,4L,5L,5L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201940Inst : IEnumerable<long>
{
public static readonly long[] Value=A201940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201940.Bytes);
public long this[int i]=>Value[i];

public static A201940Inst Instance=new A201940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201941
{
public static readonly long[] Value={ 4L,4L,4L,1L,3L,0L,2L,2L,8L,8L,2L,3L,9L,6L,6L,5L,9L,0L,5L,8L,5L,4L,6L,6L,3L,2L,9L,4L,9L,0L,9L,8L,4L,6L,6L,7L,0L,7L,9L,3L,2L,0L,9L,6L,9L,9L,4L,2L,1L,3L,7L,7L,5L,6L,9L,5L,9L,1L,8L,2L,6L,3L,4L,4L,1L,1L,8L,9L,3L,8L,6L,8L,5L,7L,4L,5L,2L,8L,5L,0L,8L,3L,6L,5L,4L,3L,8L,0L,2L,1L,0L,4L,2L,9L,8L,5L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201941Inst : IEnumerable<long>
{
public static readonly long[] Value=A201941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201941.Bytes);
public long this[int i]=>Value[i];

public static A201941Inst Instance=new A201941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201942
{
public static readonly long[] Value={ 1L,3L,0L,9L,7L,9L,9L,5L,8L,5L,8L,0L,4L,1L,5L,0L,4L,7L,7L,6L,6L,9L,2L,3L,3L,7L,0L,1L,9L,6L,8L,1L,7L,2L,5L,0L,6L,0L,1L,0L,8L,6L,8L,8L,9L,6L,4L,3L,0L,4L,8L,0L,4L,3L,5L,5L,5L,8L,4L,7L,5L,3L,6L,7L,4L,2L,6L,2L,1L,4L,5L,1L,3L,3L,5L,8L,2L,2L,6L,2L,3L,4L,9L,1L,5L,4L,2L,1L,4L,2L,8L,1L,2L,2L,4L,2L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201942Inst : IEnumerable<long>
{
public static readonly long[] Value=A201942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201942.Bytes);
public long this[int i]=>Value[i];

public static A201942Inst Instance=new A201942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201943
{
public static readonly long[] Value={ 1L,3L,9L,7L,6L,5L,8L,9L,7L,7L,4L,2L,2L,4L,3L,8L,0L,2L,0L,4L,4L,0L,3L,2L,5L,2L,0L,6L,5L,3L,0L,8L,3L,8L,9L,8L,3L,9L,7L,8L,9L,0L,1L,4L,6L,0L,1L,8L,9L,9L,0L,0L,8L,6L,9L,4L,8L,0L,0L,2L,8L,3L,7L,4L,6L,6L,2L,5L,8L,2L,0L,1L,3L,4L,1L,8L,7L,2L,7L,9L,8L,9L,1L,9L,0L,3L,3L,2L,0L,6L,2L,0L,1L,8L,7L,0L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201943Inst : IEnumerable<long>
{
public static readonly long[] Value=A201943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201943.Bytes);
public long this[int i]=>Value[i];

public static A201943Inst Instance=new A201943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201944
{
public static readonly long[] Value={ 5L,7L,5L,2L,9L,2L,4L,8L,3L,7L,0L,9L,3L,3L,1L,9L,7L,4L,7L,6L,7L,4L,6L,6L,8L,6L,6L,8L,0L,6L,8L,9L,4L,0L,9L,7L,8L,8L,3L,4L,1L,8L,7L,4L,7L,4L,2L,2L,1L,2L,1L,1L,7L,0L,5L,9L,1L,6L,9L,6L,2L,5L,9L,0L,4L,4L,1L,6L,1L,2L,7L,3L,0L,8L,8L,2L,0L,5L,8L,6L,4L,0L,0L,6L,8L,3L,7L,7L,2L,0L,7L,2L,6L,2L,3L,4L,9L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201944Inst : IEnumerable<long>
{
public static readonly long[] Value=A201944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201944.Bytes);
public long this[int i]=>Value[i];

public static A201944Inst Instance=new A201944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201945
{
public static readonly long[] Value={ 4L,6L,5L,8L,8L,6L,3L,2L,5L,8L,0L,7L,4L,7L,9L,3L,4L,0L,1L,4L,6L,7L,7L,5L,0L,6L,8L,8L,4L,3L,6L,1L,2L,9L,9L,4L,6L,5L,9L,6L,3L,3L,8L,2L,0L,0L,6L,3L,3L,0L,0L,2L,8L,9L,8L,2L,6L,6L,7L,6L,1L,2L,4L,8L,8L,7L,5L,2L,7L,3L,3L,7L,8L,0L,6L,2L,4L,2L,6L,6L,3L,0L,6L,3L,4L,4L,4L,0L,1L,8L,6L,2L,2L,0L,9L,3L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201945Inst : IEnumerable<long>
{
public static readonly long[] Value=A201945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201945.Bytes);
public long this[int i]=>Value[i];

public static A201945Inst Instance=new A201945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201946
{
public static readonly long[] Value={ 1L,2L,4L,9L,3L,9L,4L,3L,3L,6L,6L,4L,6L,3L,2L,4L,4L,7L,2L,5L,1L,1L,2L,7L,4L,3L,2L,1L,2L,6L,1L,0L,0L,8L,1L,2L,3L,4L,6L,9L,4L,4L,1L,3L,0L,0L,9L,0L,1L,5L,2L,9L,6L,9L,6L,2L,9L,7L,2L,6L,0L,7L,6L,8L,6L,8L,8L,2L,1L,2L,3L,9L,7L,3L,1L,0L,6L,2L,2L,9L,8L,3L,0L,0L,5L,3L,2L,5L,7L,7L,0L,8L,2L,8L,6L,5L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201946Inst : IEnumerable<long>
{
public static readonly long[] Value=A201946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201946.Bytes);
public long this[int i]=>Value[i];

public static A201946Inst Instance=new A201946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201947
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,0L,3L,5L,1L,-1L,5L,10L,4L,-2L,-1L,8L,20L,12L,-4L,-4L,0L,13L,38L,31L,-4L,-13L,-2L,1L,21L,71L,73L,3L,-33L,-11L,3L,1L,34L,130L,162L,34L,-74L,-42L,6L,6L,0L,55L,235L,344L,128L,-146L,-130L,0L,24L,3L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201947Inst : IEnumerable<long>
{
public static readonly long[] Value=A201947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201947.Bytes);
public long this[int i]=>Value[i];

public static A201947Inst Instance=new A201947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201948
{
public static readonly long[] Value={ 0L,1L,9L,10L,81L,244L,729L,5104L,6561L,98416L,413344L,1476225L,9034497L,24977728L,263063296L,349156737L,2711943424L,8308017153L,96467701761L,101891588608L,1286623443969L,2283843782656L,30847581595648L,33420828483585L,352189631991808L,804641749434369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201948Inst : IEnumerable<long>
{
public static readonly long[] Value=A201948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201948.Bytes);
public long this[int i]=>Value[i];

public static A201948Inst Instance=new A201948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201949
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,3L,5L,6L,5L,3L,1L,1L,6L,15L,24L,28L,24L,15L,6L,1L,1L,10L,40L,90L,139L,160L,139L,90L,40L,10L,1L,1L,15L,91L,300L,629L,945L,1078L,945L,629L,300L,91L,15L,1L,1L,21L,182L,861L,2520L,5019L,7377L,8358L,7377L,5019L,2520L,861L,182L,21L,1L,1L,28L,330L,2156L,8729L,23520L,45030L,65016L,73260L,65016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201949Inst : IEnumerable<long>
{
public static readonly long[] Value=A201949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201949.Bytes);
public long this[int i]=>Value[i];

public static A201949Inst Instance=new A201949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201950
{
public static readonly BigInteger[] Value={ 1L,0L,2L,6L,28L,160L,1078L,8358L,73260L,716112L,7721844L,91039740L,1164932470L,16077368580L,238037983558L,3763371442530L,63276351409092L,1127406030014112L,21218146474666864L,420611921077524912L,8759617763834095796L,BigInteger.Parse("191208185756772875880") };
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
public class A201950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201950Inst Instance=new A201950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201951
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,13L,33L,85L,234L,675L,2032L,6367L,20677L,69442L,240529L,857634L,3141970L,11808611L,45464065L,179088744L,720947705L,2962994169L,12420658682L,53061133078L,230828047288L,1021809688593L,4599749893986L,21043392417004L,97784119963565L,461277854065112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201951Inst : IEnumerable<long>
{
public static readonly long[] Value=A201951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201951.Bytes);
public long this[int i]=>Value[i];

public static A201951Inst Instance=new A201951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201952
{
public static readonly BigInteger[] Value={ 1L,1L,5L,24L,139L,945L,7377L,65016L,638418L,6910650L,81747665L,1049089470L,14516096009L,215419836359L,3412889885571L,57492203734320L,1026121982213480L,19342642266760680L,383995631680561234L,8007915240045479980L,BigInteger.Parse("175020604366224762038"),BigInteger.Parse("4000551483475536398178") };
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
public class A201952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201952Inst Instance=new A201952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201953
{
public static readonly BigInteger[] Value={ 1L,3L,15L,90L,629L,5019L,45030L,448776L,4919321L,58825415L,762089899L,10633219662L,158974192987L,2535484008225L,42970371055268L,771162539117408L,14609924404202130L,291386317037291622L,6102681801481066642L,BigInteger.Parse("133910606028043519500"),BigInteger.Parse("3072216586896101950757") };
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
public class A201953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201953Inst Instance=new A201953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201954
{
public static readonly BigInteger[] Value={ 1L,0L,2L,0L,24L,0L,552L,0L,15936L,0L,427008L,0L,35567232L,0L,7352654592L,0L,-1064016089088L,0L,-285531029213184L,0L,515396596477280256L,0L,BigInteger.Parse("-177833505179096580096"),0L,BigInteger.Parse("-286336846462160593059840"),0L,BigInteger.Parse("573948928392687509387673600"),0L,BigInteger.Parse("-211350462543692217044652785664") };
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
public class A201954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201954Inst Instance=new A201954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201955
{
public static readonly long[] Value={ 7L,231L,1587L,17903L,194633L,2232183L,25952953L,305979795L,3640250461L,43624267941L,525774918227L,6366440653727L,77388201173481L,943784967491137L,11542145313593503L,141498452574240619L,1738344524754583621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201955Inst : IEnumerable<long>
{
public static readonly long[] Value=A201955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201955.Bytes);
public long this[int i]=>Value[i];

public static A201955Inst Instance=new A201955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201956
{
public static readonly BigInteger[] Value={ 37L,1587L,17091L,303955L,4735345L,85454789L,1489376611L,27222524599L,493561989579L,9124430335331L,168519041238653L,3142665027511853L,58661584782394781L,1101133968614654601L,BigInteger.Parse("20697996312691430763") };
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
public class A201956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201956Inst Instance=new A201956Inst();

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