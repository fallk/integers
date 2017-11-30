using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200305
{
public static readonly long[] Value={ 7L,4L,9L,4L,8L,3L,5L,5L,6L,2L,5L,9L,1L,5L,5L,2L,2L,3L,5L,6L,8L,3L,6L,3L,4L,8L,7L,7L,3L,5L,7L,9L,3L,9L,4L,2L,5L,6L,2L,1L,5L,9L,3L,5L,7L,9L,4L,4L,7L,1L,3L,3L,2L,7L,9L,6L,9L,0L,6L,5L,2L,0L,9L,0L,1L,8L,1L,8L,6L,4L,0L,1L,2L,0L,3L,7L,3L,4L,3L,2L,7L,4L,0L,6L,6L,0L,2L,3L,8L,2L,0L,8L,4L,7L,3L,7L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200305Inst : IEnumerable<long>
{
public static readonly long[] Value=A200305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200305.Bytes);
public long this[int i]=>Value[i];

public static A200305Inst Instance=new A200305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200306
{
public static readonly long[] Value={ 9L,0L,3L,0L,5L,9L,6L,1L,3L,9L,0L,4L,8L,6L,4L,2L,5L,0L,9L,1L,0L,2L,2L,7L,4L,6L,4L,5L,5L,2L,6L,1L,6L,5L,5L,1L,3L,8L,3L,0L,6L,6L,7L,8L,4L,2L,8L,2L,3L,3L,3L,3L,9L,2L,0L,0L,9L,9L,1L,7L,6L,5L,2L,9L,4L,7L,4L,5L,4L,3L,7L,5L,5L,2L,1L,0L,1L,4L,2L,6L,7L,5L,1L,7L,6L,7L,4L,5L,5L,7L,4L,9L,6L,8L,2L,7L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200306Inst : IEnumerable<long>
{
public static readonly long[] Value=A200306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200306.Bytes);
public long this[int i]=>Value[i];

public static A200306Inst Instance=new A200306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200307
{
public static readonly long[] Value={ 6L,1L,7L,4L,0L,6L,5L,1L,4L,4L,2L,0L,1L,3L,2L,1L,3L,1L,6L,8L,8L,2L,9L,8L,4L,3L,5L,0L,7L,2L,3L,0L,9L,8L,1L,2L,5L,7L,3L,1L,3L,9L,1L,2L,9L,5L,5L,9L,8L,2L,5L,4L,5L,5L,5L,4L,4L,5L,8L,1L,9L,7L,6L,3L,6L,4L,4L,3L,7L,4L,4L,1L,0L,8L,2L,0L,8L,0L,0L,5L,4L,9L,4L,6L,8L,7L,4L,7L,4L,5L,2L,0L,6L,5L,2L,2L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200307Inst : IEnumerable<long>
{
public static readonly long[] Value=A200307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200307.Bytes);
public long this[int i]=>Value[i];

public static A200307Inst Instance=new A200307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200308
{
public static readonly long[] Value={ 1L,0L,6L,7L,4L,0L,8L,4L,8L,5L,6L,9L,3L,5L,9L,1L,7L,2L,3L,8L,3L,9L,2L,6L,0L,5L,6L,7L,0L,0L,7L,0L,6L,4L,1L,8L,4L,7L,6L,0L,4L,6L,0L,0L,3L,5L,9L,5L,3L,0L,2L,7L,8L,6L,5L,0L,5L,4L,6L,5L,9L,3L,0L,4L,0L,8L,3L,5L,4L,3L,1L,7L,8L,2L,0L,4L,4L,8L,3L,7L,9L,5L,5L,4L,1L,5L,1L,6L,5L,4L,8L,3L,2L,1L,1L,0L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200308Inst : IEnumerable<long>
{
public static readonly long[] Value=A200308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200308.Bytes);
public long this[int i]=>Value[i];

public static A200308Inst Instance=new A200308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200309
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,65L,440L,3571L,33824L,366113L,4458240L,60321091L,897774592L,14576528801L,256391130112L,4856647308787L,98567413125120L,2133825372539585L,49080991762153472L,1195339768057071619L,BigInteger.Parse("30729146849826701312"),BigInteger.Parse("831545527540481198465"),BigInteger.Parse("23627123985544955559936") };
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
public class A200309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200309Inst Instance=new A200309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200310
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,8L,12L,18L,26L,37L,53L,76L,108L,154L,218L,309L,437L,620L,876L,1242L,1754L,2485L,3509L,4972L,7020L,9946L,14042L,19893L,28085L,39788L,56172L,79578L,112346L,159157L,224693L,318316L,449388L,636634L,898778L,1273269L,1797557L,2546540L,3595116L,5093082L,7190234L,10186165L,14380469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200310Inst : IEnumerable<long>
{
public static readonly long[] Value=A200310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200310.Bytes);
public long this[int i]=>Value[i];

public static A200310Inst Instance=new A200310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200311
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200311Inst : IEnumerable<long>
{
public static readonly long[] Value=A200311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200311.Bytes);
public long this[int i]=>Value[i];

public static A200311Inst Instance=new A200311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200312
{
public static readonly long[] Value={ 1L,1L,8L,35L,266L,1680L,12804L,93093L,726440L,5635058L,45063668L,362121760L,2955642508L,24284658100L,201428123040L,1680921310635L,14119413718770L,119205791509200L,1011387051005100L,8617021562542470L,73704123363739440L,632601537174078420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200312Inst : IEnumerable<long>
{
public static readonly long[] Value=A200312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200312.Bytes);
public long this[int i]=>Value[i];

public static A200312Inst Instance=new A200312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200313
{
public static readonly BigInteger[] Value={ 1L,1L,70L,28000L,33833800L,91842150400L,471920698849600L,4105733038511104000L,BigInteger.Parse("55918460253906250000000"),BigInteger.Parse("1124922893768186370457600000"),BigInteger.Parse("31962429471680921191680301600000"),BigInteger.Parse("1237813985055170041194334820761600000"),BigInteger.Parse("63474917512551971525535771981021376000000") };
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
public class A200313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200313Inst Instance=new A200313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200314
{
public static readonly BigInteger[] Value={ 1L,1L,315L,975975L,12909521625L,495181420358625L,BigInteger.Parse("44035787449951171875"),BigInteger.Parse("7845481113748784765634375"),BigInteger.Parse("2526730187976408357560632640625"),BigInteger.Parse("1362965093449949100037985665872890625"),BigInteger.Parse("1160978904909328561005478318639484556796875") };
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
public class A200314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200314Inst Instance=new A200314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200315
{
public static readonly BigInteger[] Value={ 1L,1L,1386L,32288256L,4527372986136L,2373840824586206976L,BigInteger.Parse("3532226719132271834449776"),BigInteger.Parse("12455133709483299692008910094336"),BigInteger.Parse("91656142095228409912231665590704016256"),BigInteger.Parse("1280796898530759870923631204720457656538791936") };
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
public class A200315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200315Inst Instance=new A200315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200316
{
public static readonly long[] Value={ 1L,2L,6L,22L,84L,308L,1090L,3782L,13000L,44504L,152102L,519506L,1773948L,6056932L,20680010L,70606382L,241065744L,823050480L,2810070734L,9594182314L,32756588164L,111837988444L,381838777906L,1303679135238L,4451038985688L,15196797672872L,51885112720758L,177146855537986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200316Inst : IEnumerable<long>
{
public static readonly long[] Value=A200316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200316.Bytes);
public long this[int i]=>Value[i];

public static A200316Inst Instance=new A200316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200317
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,90L,736L,7308L,85364L,1146660L,17411296L,294880608L,5510730224L,112638576960L,2499645858256L,59850581734128L,1537891759461344L,42211161452391840L,1232537502720495616L,BigInteger.Parse("38148561442665067968"),BigInteger.Parse("1247578217573259535424"),BigInteger.Parse("42985394533206479112000") };
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
public class A200317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200317Inst Instance=new A200317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200318
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,120L,1156L,13608L,189316L,3039060L,55291336L,1124309208L,25268818576L,622008616320L,16642670404816L,480923246983728L,14926731083999296L,495243684302520000L,17491488288340789696UL,BigInteger.Parse("655224017429959987968"),BigInteger.Parse("25947019896579324410176"),BigInteger.Parse("1083050878686674070676800") };
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
public class A200318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200318Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200318.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200318Inst Instance=new A200318Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200319
{
public static readonly BigInteger[] Value={ 1L,2L,12L,132L,2040L,40440L,979440L,28034160L,925858080L,34654465440L,1449705660480L,67029745527360L,3394417068282240L,186842736763562880L,11107390768144070400UL,BigInteger.Parse("709223357051739129600"),BigInteger.Parse("48408150749346010022400"),BigInteger.Parse("3517279496138031162739200"),BigInteger.Parse("271050342684747077612160000") };
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
public class A200319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200319Inst Instance=new A200319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200320
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,150L,1590L,20580L,314790L,5554710L,111071520L,2482076520L,61301435580L,1658129152680L,48749053413060L,1547849157554700L,52785934927525800L,1924269399236784600L,BigInteger.Parse("74672595203551745400"),BigInteger.Parse("3073314600152521124400"),BigInteger.Parse("133716009695044269893400"),BigInteger.Parse("6132253708189762323370200") };
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
public class A200320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200320Inst Instance=new A200320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200321
{
public static readonly long[] Value={ 17L,43L,59L,103L,139L,151L,157L,173L,193L,281L,457L,461L,463L,499L,607L,1409L,1451L,2143L,2657L,4229L,16063L,19583L,19699L,62143L,124981L,166303L,172663L,240257L,244301L,276041L,289853L,305411L,327319L,376639L,417941L,505663L,518761L,524119L,600703L,1056287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200321Inst : IEnumerable<long>
{
public static readonly long[] Value=A200321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200321.Bytes);
public long this[int i]=>Value[i];

public static A200321Inst Instance=new A200321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200322
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,4L,7L,8L,9L,10L,9L,8L,9L,8L,15L,16L,17L,18L,17L,16L,21L,18L,17L,16L,17L,16L,19L,16L,17L,16L,31L,32L,33L,34L,33L,36L,33L,34L,33L,32L,33L,42L,33L,32L,37L,34L,33L,32L,33L,32L,35L,32L,33L,36L,35L,32L,33L,32L,35L,32L,33L,32L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200322Inst : IEnumerable<long>
{
public static readonly long[] Value=A200322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200322.Bytes);
public long this[int i]=>Value[i];

public static A200322Inst Instance=new A200322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200323
{
public static readonly long[] Value={ 2L,3L,2L,3L,3L,2L,2L,1L,2L,3L,2L,7L,2L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,1L,2L,3L,2L,3L,4L,2L,2L,3L,2L,2L,3L,1L,2L,1L,3L,2L,2L,3L,2L,4L,3L,2L,1L,3L,2L,2L,1L,2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,3L,3L,2L,3L,4L,1L,2L,2L,1L,2L,3L,2L,7L,3L,2L,3L,2L,2L,3L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200323Inst : IEnumerable<long>
{
public static readonly long[] Value=A200323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200323.Bytes);
public long this[int i]=>Value[i];

public static A200323Inst Instance=new A200323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200324
{
public static readonly long[] Value={ 3L,5L,4L,6L,2L,5L,2L,4L,5L,1L,5L,3L,1L,2L,4L,4L,1L,3L,2L,1L,3L,2L,3L,4L,2L,0L,1L,0L,1L,6L,1L,2L,0L,4L,0L,2L,2L,1L,2L,2L,0L,3L,0L,1L,0L,4L,4L,1L,0L,1L,1L,0L,3L,1L,1L,1L,0L,1L,1L,0L,2L,4L,1L,0L,1L,3L,1L,2L,0L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,0L,2L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200324Inst : IEnumerable<long>
{
public static readonly long[] Value=A200324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200324.Bytes);
public long this[int i]=>Value[i];

public static A200324Inst Instance=new A200324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200325
{
public static readonly long[] Value={ 1L,5L,5L,5L,5L,5L,5L,5L,5L,9L,11L,11L,7L,7L,11L,17L,13L,7L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200325Inst : IEnumerable<long>
{
public static readonly long[] Value=A200325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200325.Bytes);
public long this[int i]=>Value[i];

public static A200325Inst Instance=new A200325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200326
{
public static readonly long[] Value={ 1L,6L,8L,6L,6L,6L,6L,6L,6L,16L,18L,18L,10L,10L,18L,30L,22L,14L,8L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200326Inst : IEnumerable<long>
{
public static readonly long[] Value=A200326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200326.Bytes);
public long this[int i]=>Value[i];

public static A200326Inst Instance=new A200326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200327
{
public static readonly long[] Value={ 1L,7L,11L,13L,13L,9L,7L,7L,17L,25L,31L,29L,13L,21L,33L,55L,79L,77L,31L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200327Inst : IEnumerable<long>
{
public static readonly long[] Value=A200327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200327.Bytes);
public long this[int i]=>Value[i];

public static A200327Inst Instance=new A200327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200328
{
public static readonly long[] Value={ 1L,8L,14L,20L,28L,26L,18L,16L,30L,34L,44L,42L,16L,44L,54L,98L,168L,248L,76L,54L,30L,12L,18L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200328Inst : IEnumerable<long>
{
public static readonly long[] Value=A200328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200328.Bytes);
public long this[int i]=>Value[i];

public static A200328Inst Instance=new A200328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200329
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,8L,5L,4L,3L,2L,1L,8L,11L,6L,5L,4L,3L,2L,1L,9L,14L,13L,6L,5L,4L,3L,2L,1L,10L,17L,20L,13L,6L,5L,4L,3L,2L,1L,11L,20L,27L,28L,9L,6L,5L,4L,3L,2L,1L,12L,25L,36L,43L,26L,7L,6L,5L,4L,3L,2L,1L,13L,30L,49L,58L,49L,18L,7L,6L,9L,4L,3L,2L,1L,14L,35L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200329Inst : IEnumerable<long>
{
public static readonly long[] Value=A200329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200329.Bytes);
public long this[int i]=>Value[i];

public static A200329Inst Instance=new A200329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200330
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,13L,20L,27L,36L,49L,62L,81L,100L,119L,146L,177L,208L,247L,286L,329L,380L,435L,490L,555L,624L,697L,780L,867L,954L,1059L,1164L,1273L,1394L,1519L,1648L,1797L,1946L,2099L,2264L,2441L,2618L,2817L,3016L,3219L,3444L,3677L,3910L,4165L,4420L,4687L,4974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200330Inst : IEnumerable<long>
{
public static readonly long[] Value=A200330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200330.Bytes);
public long this[int i]=>Value[i];

public static A200330Inst Instance=new A200330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200331
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,13L,28L,43L,58L,87L,116L,159L,206L,271L,350L,453L,566L,689L,828L,1007L,1226L,1481L,1744L,2035L,2366L,2753L,3158L,3653L,4172L,4787L,5432L,6137L,6870L,7653L,8610L,9665L,10750L,11913L,13108L,14481L,15896L,17541L,19234L,21013L,22952L,25023L,27160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200331Inst : IEnumerable<long>
{
public static readonly long[] Value=A200331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200331.Bytes);
public long this[int i]=>Value[i];

public static A200331Inst Instance=new A200331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200332
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,26L,49L,76L,117L,174L,257L,348L,505L,704L,965L,1290L,1655L,2080L,2605L,3346L,4255L,5252L,6403L,7734L,9275L,10998L,13237L,15704L,18585L,21774L,25341L,29192L,33409L,38746L,44719L,51168L,58207L,65718L,74187L,83264L,94195L,105850L,118427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200332Inst : IEnumerable<long>
{
public static readonly long[] Value=A200332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200332.Bytes);
public long this[int i]=>Value[i];

public static A200332Inst Instance=new A200332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200333
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,18L,43L,78L,131L,224L,363L,526L,833L,1236L,1803L,2496L,3415L,4528L,5877L,7916L,10451L,13488L,17327L,21768L,26935L,33012L,41353L,50824L,62305L,75252L,90125L,107056L,126205L,150204L,178441L,209636L,244833L,284382L,328443L,376446L,436733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200333Inst : IEnumerable<long>
{
public static readonly long[] Value=A200333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200333.Bytes);
public long this[int i]=>Value[i];

public static A200333Inst Instance=new A200333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200334
{
public static readonly long[] Value={ 3L,5L,5L,0L,9L,3L,5L,7L,1L,9L,3L,0L,6L,7L,7L,6L,2L,3L,6L,2L,7L,3L,7L,6L,9L,0L,2L,2L,4L,3L,3L,8L,8L,8L,8L,8L,5L,8L,9L,0L,6L,1L,7L,3L,5L,8L,7L,9L,6L,8L,1L,0L,5L,2L,5L,4L,1L,3L,1L,3L,9L,9L,4L,4L,8L,7L,4L,3L,6L,9L,9L,3L,7L,8L,7L,8L,2L,3L,1L,3L,9L,7L,9L,8L,3L,5L,1L,2L,5L,1L,9L,1L,3L,1L,5L,8L,0L,7L,9L,3L,7L,1L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200334Inst : IEnumerable<long>
{
public static readonly long[] Value=A200334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200334.Bytes);
public long this[int i]=>Value[i];

public static A200334Inst Instance=new A200334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200335
{
public static readonly BigInteger[] Value={ 137L,253772063L,472142416783537L,BigInteger.Parse("878420022140682133063"),BigInteger.Parse("1634298694352222684783778137"),BigInteger.Parse("3040609452244043180572708973082863"),BigInteger.Parse("5657047804679503550674811676317937783937"),BigInteger.Parse("10524926126507566387571141730985597902165021463") };
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
public class A200335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200335Inst Instance=new A200335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200336
{
public static readonly long[] Value={ 1L,2L,5L,9L,5L,1L,7L,0L,3L,6L,9L,8L,4L,5L,0L,1L,6L,1L,2L,8L,6L,3L,9L,8L,9L,6L,4L,9L,4L,8L,6L,4L,6L,0L,7L,0L,9L,5L,6L,5L,4L,2L,9L,0L,5L,1L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200336Inst : IEnumerable<long>
{
public static readonly long[] Value=A200336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200336.Bytes);
public long this[int i]=>Value[i];

public static A200336Inst Instance=new A200336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200337
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,12L,24L,72L,384L,1104L,2208L,6624L,35328L,101568L,28421376L,67326336L,366139392L,983761152L,1967522304L,5902566912L,31480356864L,90506025984L,25325947097088L,59993690093568L,326262418538496L,876617757413376L,BigInteger.Parse("248432976768114295652352"),BigInteger.Parse("584740458214216890753024") };
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
public class A200337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200337Inst Instance=new A200337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200338
{
public static readonly long[] Value={ 1L,1L,7L,2L,0L,9L,3L,6L,1L,7L,2L,8L,5L,6L,6L,9L,0L,3L,9L,6L,8L,7L,8L,1L,8L,7L,9L,5L,8L,1L,0L,8L,9L,8L,8L,0L,4L,0L,2L,4L,2L,4L,5L,7L,0L,8L,8L,0L,2L,7L,6L,3L,7L,1L,7L,6L,0L,1L,8L,6L,6L,3L,6L,7L,1L,2L,1L,8L,6L,6L,3L,4L,6L,0L,7L,6L,4L,1L,2L,2L,8L,3L,6L,5L,4L,5L,6L,1L,1L,2L,2L,8L,6L,7L,2L,3L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200338Inst : IEnumerable<long>
{
public static readonly long[] Value=A200338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200338.Bytes);
public long this[int i]=>Value[i];

public static A200338Inst Instance=new A200338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200339
{
public static readonly long[] Value={ 1L,3L,0L,7L,4L,7L,7L,6L,0L,0L,3L,0L,1L,3L,4L,9L,9L,2L,1L,2L,1L,6L,9L,3L,5L,0L,7L,1L,6L,9L,0L,0L,4L,8L,0L,8L,8L,7L,0L,5L,5L,2L,7L,4L,6L,2L,2L,3L,6L,3L,7L,9L,4L,4L,8L,8L,6L,9L,2L,8L,5L,5L,9L,3L,2L,3L,2L,2L,7L,2L,2L,7L,0L,7L,6L,8L,2L,1L,1L,0L,9L,6L,4L,0L,4L,7L,0L,9L,5L,0L,9L,9L,9L,9L,3L,0L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200339Inst : IEnumerable<long>
{
public static readonly long[] Value=A200339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200339.Bytes);
public long this[int i]=>Value[i];

public static A200339Inst Instance=new A200339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200340
{
public static readonly long[] Value={ 1L,3L,6L,8L,3L,7L,1L,2L,7L,5L,0L,4L,7L,8L,9L,7L,7L,3L,4L,0L,8L,0L,7L,9L,0L,8L,8L,6L,6L,4L,0L,4L,2L,0L,6L,5L,2L,3L,7L,3L,9L,0L,9L,1L,5L,1L,6L,4L,9L,6L,3L,9L,1L,8L,6L,9L,0L,7L,9L,4L,4L,7L,3L,8L,5L,6L,4L,2L,5L,2L,7L,0L,2L,0L,8L,1L,5L,6L,9L,4L,2L,9L,9L,6L,3L,1L,4L,1L,7L,3L,1L,3L,1L,3L,1L,1L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200340Inst : IEnumerable<long>
{
public static readonly long[] Value=A200340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200340.Bytes);
public long this[int i]=>Value[i];

public static A200340Inst Instance=new A200340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200341
{
public static readonly long[] Value={ 1L,4L,0L,4L,9L,3L,7L,8L,9L,6L,3L,7L,8L,1L,7L,5L,7L,8L,8L,8L,2L,3L,5L,2L,2L,7L,4L,9L,3L,2L,8L,0L,0L,5L,3L,1L,7L,4L,3L,4L,4L,8L,8L,0L,0L,9L,1L,6L,4L,0L,2L,9L,4L,5L,7L,1L,5L,9L,2L,0L,3L,6L,7L,4L,6L,3L,7L,8L,8L,9L,6L,0L,2L,5L,8L,0L,3L,2L,5L,2L,6L,0L,8L,9L,8L,9L,0L,4L,2L,1L,5L,1L,6L,3L,8L,4L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200341Inst : IEnumerable<long>
{
public static readonly long[] Value=A200341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200341.Bytes);
public long this[int i]=>Value[i];

public static A200341Inst Instance=new A200341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200342
{
public static readonly long[] Value={ 1L,3L,3L,1L,8L,9L,1L,4L,1L,7L,5L,5L,2L,2L,8L,8L,2L,0L,3L,7L,6L,7L,3L,2L,9L,1L,4L,9L,7L,5L,8L,0L,8L,9L,2L,0L,1L,1L,5L,7L,7L,7L,5L,2L,8L,2L,4L,3L,8L,6L,1L,1L,9L,5L,3L,6L,6L,8L,2L,7L,5L,1L,0L,6L,4L,5L,8L,1L,6L,5L,4L,4L,4L,1L,3L,1L,1L,8L,6L,5L,3L,2L,6L,7L,1L,7L,7L,0L,0L,5L,1L,4L,2L,1L,5L,6L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200342Inst : IEnumerable<long>
{
public static readonly long[] Value=A200342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200342.Bytes);
public long this[int i]=>Value[i];

public static A200342Inst Instance=new A200342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200343
{
public static readonly long[] Value={ 1L,3L,8L,4L,3L,3L,3L,9L,8L,6L,0L,7L,9L,0L,1L,7L,1L,0L,1L,1L,4L,3L,1L,2L,1L,9L,4L,7L,7L,9L,4L,2L,7L,2L,4L,9L,7L,0L,0L,0L,4L,1L,2L,2L,3L,9L,1L,7L,0L,1L,7L,9L,7L,4L,5L,1L,4L,3L,8L,0L,3L,8L,9L,1L,9L,0L,1L,0L,5L,4L,2L,4L,1L,7L,2L,4L,8L,2L,0L,6L,9L,2L,7L,9L,4L,1L,0L,7L,5L,9L,3L,6L,8L,0L,3L,5L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200343Inst : IEnumerable<long>
{
public static readonly long[] Value=A200343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200343.Bytes);
public long this[int i]=>Value[i];

public static A200343Inst Instance=new A200343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200344
{
public static readonly long[] Value={ 1L,4L,1L,6L,3L,2L,9L,7L,0L,4L,2L,3L,0L,1L,1L,2L,6L,3L,8L,9L,8L,2L,4L,4L,0L,6L,5L,1L,6L,3L,0L,0L,5L,3L,4L,7L,5L,7L,1L,1L,5L,2L,8L,9L,0L,3L,3L,5L,0L,3L,7L,2L,4L,5L,5L,0L,4L,4L,1L,5L,2L,0L,4L,0L,1L,5L,3L,1L,3L,6L,5L,6L,9L,2L,9L,6L,0L,7L,0L,4L,7L,9L,6L,3L,7L,2L,4L,0L,6L,7L,4L,9L,0L,6L,6L,9L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200344Inst : IEnumerable<long>
{
public static readonly long[] Value=A200344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200344.Bytes);
public long this[int i]=>Value[i];

public static A200344Inst Instance=new A200344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200345
{
public static readonly long[] Value={ 1L,4L,3L,8L,3L,7L,1L,9L,3L,5L,3L,2L,3L,1L,6L,6L,3L,4L,3L,0L,2L,4L,7L,1L,1L,2L,3L,3L,3L,8L,7L,5L,7L,8L,9L,2L,1L,8L,4L,8L,3L,9L,0L,1L,5L,3L,7L,3L,5L,5L,7L,2L,3L,9L,2L,2L,1L,4L,0L,1L,8L,4L,2L,5L,0L,7L,7L,9L,8L,5L,2L,3L,8L,9L,4L,3L,5L,0L,4L,9L,3L,8L,8L,6L,0L,5L,4L,7L,8L,2L,9L,1L,3L,2L,2L,4L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200345Inst : IEnumerable<long>
{
public static readonly long[] Value=A200345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200345.Bytes);
public long this[int i]=>Value[i];

public static A200345Inst Instance=new A200345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200346
{
public static readonly long[] Value={ 1L,3L,9L,8L,7L,1L,8L,4L,7L,5L,9L,7L,1L,1L,1L,4L,8L,0L,4L,5L,0L,6L,7L,2L,5L,2L,5L,7L,2L,2L,8L,0L,9L,9L,4L,9L,8L,1L,7L,4L,9L,0L,9L,2L,2L,8L,3L,8L,8L,0L,5L,5L,0L,4L,0L,7L,4L,4L,2L,1L,2L,8L,2L,8L,7L,5L,3L,6L,0L,7L,5L,4L,4L,1L,9L,0L,1L,4L,7L,9L,0L,0L,4L,3L,4L,4L,3L,8L,6L,3L,2L,4L,8L,7L,0L,4L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200346Inst : IEnumerable<long>
{
public static readonly long[] Value=A200346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200346.Bytes);
public long this[int i]=>Value[i];

public static A200346Inst Instance=new A200346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200347
{
public static readonly long[] Value={ 1L,4L,2L,6L,6L,3L,5L,1L,0L,9L,9L,3L,3L,0L,4L,3L,8L,0L,9L,0L,1L,4L,9L,2L,5L,7L,1L,1L,4L,9L,6L,1L,0L,4L,3L,4L,4L,2L,4L,9L,7L,2L,8L,1L,7L,6L,8L,0L,7L,7L,5L,4L,0L,6L,1L,2L,7L,6L,8L,6L,2L,5L,9L,1L,3L,8L,4L,4L,1L,5L,5L,0L,6L,0L,1L,5L,6L,7L,5L,3L,8L,3L,1L,8L,9L,4L,7L,0L,2L,4L,8L,5L,1L,8L,9L,8L,7L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200347Inst : IEnumerable<long>
{
public static readonly long[] Value=A200347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200347.Bytes);
public long this[int i]=>Value[i];

public static A200347Inst Instance=new A200347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200348
{
public static readonly long[] Value={ 1L,4L,4L,6L,1L,9L,2L,4L,9L,5L,1L,6L,1L,0L,3L,6L,9L,3L,8L,9L,4L,7L,5L,9L,6L,0L,3L,9L,9L,3L,7L,2L,1L,2L,7L,4L,0L,5L,3L,0L,0L,7L,9L,5L,3L,2L,7L,6L,4L,2L,6L,9L,3L,6L,1L,9L,4L,0L,6L,5L,0L,5L,2L,0L,6L,5L,5L,9L,8L,5L,9L,2L,6L,0L,2L,6L,0L,7L,5L,3L,6L,5L,2L,3L,5L,3L,4L,7L,4L,8L,7L,8L,0L,1L,9L,1L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200348Inst : IEnumerable<long>
{
public static readonly long[] Value=A200348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200348.Bytes);
public long this[int i]=>Value[i];

public static A200348Inst Instance=new A200348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200349
{
public static readonly long[] Value={ 1L,4L,6L,0L,8L,1L,3L,0L,5L,2L,2L,2L,3L,0L,5L,1L,5L,0L,3L,4L,1L,9L,2L,4L,2L,6L,6L,3L,3L,7L,9L,0L,6L,0L,0L,7L,2L,4L,9L,3L,2L,4L,7L,9L,1L,0L,1L,6L,3L,7L,8L,1L,5L,6L,2L,0L,1L,0L,3L,9L,3L,2L,4L,6L,1L,9L,8L,2L,2L,2L,7L,0L,4L,5L,2L,4L,4L,1L,7L,9L,9L,1L,3L,6L,9L,8L,4L,6L,2L,2L,3L,8L,0L,9L,6L,2L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200349Inst : IEnumerable<long>
{
public static readonly long[] Value=A200349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200349.Bytes);
public long this[int i]=>Value[i];

public static A200349Inst Instance=new A200349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200350
{
public static readonly long[] Value={ 1L,4L,3L,5L,9L,2L,8L,9L,0L,2L,3L,3L,8L,6L,4L,1L,2L,9L,9L,0L,3L,2L,0L,3L,2L,4L,4L,8L,3L,2L,2L,1L,4L,2L,5L,7L,2L,2L,7L,2L,1L,7L,1L,9L,3L,6L,9L,9L,6L,8L,5L,8L,1L,8L,7L,0L,3L,5L,0L,7L,5L,4L,2L,2L,8L,7L,5L,0L,8L,2L,0L,8L,2L,4L,6L,0L,9L,8L,1L,5L,0L,1L,0L,4L,2L,1L,0L,4L,5L,9L,8L,2L,1L,7L,3L,3L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200350Inst : IEnumerable<long>
{
public static readonly long[] Value=A200350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200350.Bytes);
public long this[int i]=>Value[i];

public static A200350Inst Instance=new A200350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200351
{
public static readonly long[] Value={ 1L,4L,5L,3L,3L,0L,4L,1L,5L,8L,5L,7L,4L,3L,3L,6L,7L,9L,5L,3L,0L,4L,0L,2L,9L,6L,2L,5L,8L,3L,8L,5L,5L,0L,8L,8L,6L,8L,8L,6L,6L,0L,5L,7L,0L,7L,5L,5L,8L,7L,5L,9L,8L,4L,0L,0L,7L,0L,0L,5L,3L,4L,8L,7L,1L,0L,2L,2L,1L,7L,1L,2L,6L,6L,3L,4L,4L,4L,9L,4L,3L,9L,8L,8L,3L,6L,1L,3L,2L,7L,3L,5L,2L,9L,6L,6L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200351Inst : IEnumerable<long>
{
public static readonly long[] Value=A200351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200351.Bytes);
public long this[int i]=>Value[i];

public static A200351Inst Instance=new A200351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200352
{
public static readonly long[] Value={ 1L,4L,6L,6L,4L,6L,3L,4L,7L,1L,0L,1L,0L,8L,5L,3L,8L,0L,8L,0L,2L,1L,1L,8L,1L,5L,1L,4L,4L,7L,5L,9L,8L,2L,1L,8L,5L,5L,3L,6L,6L,1L,5L,5L,1L,2L,9L,5L,9L,0L,0L,4L,1L,3L,3L,1L,8L,8L,4L,4L,4L,8L,2L,3L,5L,4L,9L,4L,9L,6L,3L,0L,6L,8L,9L,4L,5L,8L,8L,7L,1L,7L,1L,2L,9L,1L,4L,6L,0L,8L,9L,0L,7L,8L,6L,5L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200352Inst : IEnumerable<long>
{
public static readonly long[] Value=A200352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200352.Bytes);
public long this[int i]=>Value[i];

public static A200352Inst Instance=new A200352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200353
{
public static readonly long[] Value={ 1L,4L,7L,6L,8L,3L,6L,9L,4L,2L,0L,3L,5L,6L,2L,9L,5L,9L,6L,6L,0L,0L,2L,2L,5L,3L,3L,2L,4L,9L,9L,6L,8L,5L,6L,6L,4L,3L,5L,6L,7L,9L,0L,2L,8L,3L,6L,1L,0L,4L,8L,0L,7L,3L,0L,9L,4L,9L,8L,8L,6L,3L,5L,6L,4L,4L,5L,2L,4L,3L,6L,7L,8L,9L,5L,0L,5L,0L,9L,7L,7L,6L,6L,8L,3L,9L,3L,5L,1L,7L,9L,5L,8L,2L,3L,8L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200353Inst : IEnumerable<long>
{
public static readonly long[] Value=A200353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200353.Bytes);
public long this[int i]=>Value[i];

public static A200353Inst Instance=new A200353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200354
{
public static readonly long[] Value={ 1L,4L,5L,9L,7L,7L,2L,3L,4L,6L,4L,3L,8L,5L,7L,0L,0L,3L,3L,7L,7L,1L,7L,0L,2L,8L,7L,3L,5L,8L,9L,5L,4L,4L,7L,7L,3L,5L,3L,9L,9L,8L,8L,7L,3L,5L,6L,9L,6L,4L,4L,6L,5L,6L,2L,2L,5L,0L,4L,5L,4L,2L,3L,5L,9L,0L,1L,7L,7L,2L,9L,1L,0L,2L,7L,3L,1L,6L,6L,5L,6L,2L,5L,0L,4L,5L,5L,5L,6L,5L,5L,8L,4L,2L,1L,2L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200354Inst : IEnumerable<long>
{
public static readonly long[] Value=A200354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200354.Bytes);
public long this[int i]=>Value[i];

public static A200354Inst Instance=new A200354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200355
{
public static readonly long[] Value={ 1L,4L,7L,1L,6L,4L,2L,8L,6L,9L,7L,6L,5L,3L,3L,8L,3L,0L,6L,1L,1L,0L,9L,6L,4L,7L,9L,3L,2L,9L,4L,4L,0L,1L,5L,2L,1L,6L,6L,4L,6L,5L,3L,8L,3L,5L,3L,8L,1L,8L,3L,6L,4L,2L,3L,5L,0L,3L,0L,0L,4L,4L,6L,1L,9L,6L,9L,6L,0L,1L,8L,5L,8L,7L,0L,4L,9L,3L,1L,6L,3L,1L,7L,2L,3L,8L,8L,3L,5L,3L,5L,3L,5L,5L,9L,9L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200355Inst : IEnumerable<long>
{
public static readonly long[] Value=A200355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200355.Bytes);
public long this[int i]=>Value[i];

public static A200355Inst Instance=new A200355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200356
{
public static readonly long[] Value={ 1L,4L,8L,1L,0L,9L,3L,5L,7L,0L,0L,9L,6L,8L,2L,8L,2L,3L,1L,2L,1L,6L,9L,9L,4L,9L,3L,4L,8L,4L,7L,0L,5L,9L,9L,5L,0L,9L,7L,3L,0L,5L,5L,4L,7L,5L,7L,9L,9L,9L,8L,9L,6L,9L,9L,8L,1L,6L,4L,2L,8L,2L,3L,0L,3L,0L,5L,5L,8L,5L,9L,0L,8L,6L,1L,2L,0L,6L,4L,7L,4L,3L,5L,7L,5L,0L,0L,0L,1L,3L,1L,0L,7L,8L,0L,2L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200356Inst : IEnumerable<long>
{
public static readonly long[] Value=A200356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200356.Bytes);
public long this[int i]=>Value[i];

public static A200356Inst Instance=new A200356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200357
{
public static readonly long[] Value={ 1L,4L,8L,8L,8L,2L,3L,9L,3L,2L,0L,0L,4L,9L,5L,7L,6L,8L,9L,0L,1L,1L,0L,2L,5L,6L,8L,5L,3L,8L,5L,4L,4L,3L,7L,5L,7L,9L,3L,0L,7L,0L,5L,3L,2L,8L,0L,6L,8L,3L,5L,6L,9L,4L,3L,3L,1L,2L,5L,1L,0L,6L,7L,6L,4L,3L,4L,7L,5L,1L,8L,9L,6L,9L,5L,9L,6L,9L,1L,2L,0L,1L,4L,1L,8L,5L,6L,7L,1L,2L,7L,9L,4L,3L,3L,2L,9L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200357Inst : IEnumerable<long>
{
public static readonly long[] Value=A200357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200357.Bytes);
public long this[int i]=>Value[i];

public static A200357Inst Instance=new A200357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200358
{
public static readonly long[] Value={ 1L,3L,6L,1L,4L,6L,7L,2L,4L,9L,5L,0L,1L,4L,4L,4L,1L,9L,9L,9L,3L,0L,0L,0L,6L,1L,9L,6L,1L,1L,0L,2L,7L,3L,6L,2L,6L,7L,7L,8L,0L,5L,2L,7L,5L,9L,7L,8L,6L,3L,1L,1L,0L,8L,0L,5L,8L,1L,0L,9L,7L,6L,1L,3L,2L,7L,2L,1L,7L,8L,4L,3L,2L,8L,7L,4L,1L,6L,7L,8L,4L,8L,7L,2L,9L,0L,4L,9L,9L,4L,1L,3L,5L,5L,7L,9L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200358Inst : IEnumerable<long>
{
public static readonly long[] Value=A200358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200358.Bytes);
public long this[int i]=>Value[i];

public static A200358Inst Instance=new A200358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200359
{
public static readonly long[] Value={ 1L,4L,3L,0L,7L,5L,7L,4L,5L,7L,5L,9L,3L,5L,3L,5L,4L,4L,3L,5L,1L,5L,4L,9L,3L,9L,2L,8L,4L,7L,3L,2L,3L,8L,6L,5L,9L,6L,4L,0L,0L,4L,5L,0L,5L,7L,9L,1L,8L,9L,4L,7L,0L,8L,8L,2L,0L,0L,6L,2L,1L,2L,1L,0L,5L,6L,7L,2L,3L,6L,7L,5L,6L,1L,2L,1L,2L,3L,8L,9L,2L,7L,4L,3L,3L,6L,7L,2L,9L,7L,3L,2L,5L,8L,9L,1L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200359Inst : IEnumerable<long>
{
public static readonly long[] Value=A200359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200359.Bytes);
public long this[int i]=>Value[i];

public static A200359Inst Instance=new A200359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200360
{
public static readonly long[] Value={ 1L,4L,1L,6L,4L,9L,7L,8L,3L,4L,1L,7L,8L,0L,0L,1L,3L,0L,2L,3L,8L,7L,9L,2L,6L,6L,8L,6L,2L,7L,1L,0L,0L,2L,9L,1L,7L,7L,9L,8L,4L,0L,3L,9L,5L,7L,6L,9L,1L,4L,6L,0L,4L,0L,7L,0L,7L,5L,6L,3L,9L,8L,0L,6L,1L,4L,9L,1L,8L,4L,9L,2L,3L,4L,8L,3L,5L,0L,6L,8L,1L,8L,1L,1L,8L,6L,3L,0L,6L,2L,7L,1L,5L,4L,5L,0L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200360Inst : IEnumerable<long>
{
public static readonly long[] Value=A200360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200360.Bytes);
public long this[int i]=>Value[i];

public static A200360Inst Instance=new A200360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200361
{
public static readonly long[] Value={ 1L,4L,3L,9L,7L,1L,8L,2L,0L,2L,0L,7L,1L,9L,7L,6L,6L,7L,0L,3L,4L,9L,2L,6L,1L,3L,2L,4L,1L,4L,8L,3L,7L,8L,3L,0L,3L,1L,3L,0L,6L,8L,9L,2L,4L,3L,4L,3L,9L,0L,6L,3L,8L,8L,5L,0L,1L,4L,9L,4L,8L,3L,8L,0L,2L,3L,3L,0L,8L,5L,6L,3L,8L,1L,3L,0L,7L,3L,2L,6L,5L,2L,7L,4L,9L,4L,5L,2L,3L,1L,3L,5L,5L,7L,2L,8L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200361Inst : IEnumerable<long>
{
public static readonly long[] Value=A200361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200361.Bytes);
public long this[int i]=>Value[i];

public static A200361Inst Instance=new A200361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200362
{
public static readonly long[] Value={ 1L,4L,5L,6L,3L,3L,1L,7L,0L,8L,0L,7L,6L,4L,7L,2L,5L,7L,5L,3L,6L,8L,8L,1L,7L,2L,2L,2L,8L,7L,3L,1L,2L,7L,2L,6L,8L,5L,3L,0L,9L,6L,3L,8L,8L,0L,7L,4L,3L,2L,6L,4L,9L,5L,7L,4L,5L,2L,9L,8L,4L,1L,6L,2L,9L,3L,6L,6L,9L,3L,2L,1L,4L,6L,6L,9L,9L,1L,9L,4L,5L,4L,9L,2L,6L,4L,7L,7L,7L,9L,0L,1L,5L,0L,6L,6L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200362Inst : IEnumerable<long>
{
public static readonly long[] Value=A200362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200362.Bytes);
public long this[int i]=>Value[i];

public static A200362Inst Instance=new A200362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200363
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,4L,8L,1L,7L,5L,4L,0L,7L,9L,2L,8L,0L,9L,3L,8L,9L,8L,5L,1L,0L,4L,3L,0L,6L,7L,8L,4L,6L,8L,8L,2L,0L,6L,6L,9L,8L,8L,6L,2L,2L,9L,7L,8L,0L,3L,1L,9L,7L,5L,8L,5L,4L,1L,9L,3L,2L,9L,9L,7L,7L,0L,5L,9L,4L,5L,5L,1L,2L,9L,0L,6L,9L,4L,8L,9L,5L,3L,6L,1L,3L,1L,7L,8L,9L,9L,8L,2L,0L,9L,9L,0L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200363Inst : IEnumerable<long>
{
public static readonly long[] Value=A200363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200363.Bytes);
public long this[int i]=>Value[i];

public static A200363Inst Instance=new A200363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200364
{
public static readonly long[] Value={ 1L,4L,4L,7L,7L,7L,5L,5L,3L,8L,4L,2L,8L,4L,9L,3L,9L,8L,1L,4L,0L,8L,3L,9L,9L,1L,7L,2L,4L,7L,4L,7L,7L,9L,8L,3L,2L,8L,0L,6L,1L,6L,2L,9L,0L,9L,0L,3L,8L,3L,7L,3L,6L,7L,1L,7L,4L,0L,7L,6L,9L,3L,6L,8L,0L,8L,3L,4L,4L,3L,4L,3L,4L,5L,3L,2L,5L,0L,1L,7L,0L,3L,6L,0L,6L,6L,4L,0L,9L,6L,9L,6L,7L,1L,1L,7L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200364Inst : IEnumerable<long>
{
public static readonly long[] Value=A200364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200364.Bytes);
public long this[int i]=>Value[i];

public static A200364Inst Instance=new A200364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200365
{
public static readonly long[] Value={ 1L,4L,6L,3L,3L,5L,1L,5L,2L,6L,2L,3L,9L,0L,5L,7L,3L,0L,0L,7L,6L,6L,6L,7L,3L,2L,2L,4L,3L,4L,8L,1L,5L,4L,1L,3L,0L,6L,7L,5L,6L,6L,7L,3L,6L,6L,7L,6L,4L,1L,9L,4L,3L,8L,9L,7L,3L,4L,3L,8L,2L,4L,9L,0L,0L,5L,8L,3L,3L,5L,2L,0L,6L,6L,6L,8L,5L,2L,2L,6L,9L,8L,9L,0L,5L,7L,0L,4L,9L,3L,6L,0L,8L,4L,2L,4L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200365Inst : IEnumerable<long>
{
public static readonly long[] Value=A200365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200365.Bytes);
public long this[int i]=>Value[i];

public static A200365Inst Instance=new A200365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200366
{
public static readonly long[] Value={ 1L,4L,6L,8L,2L,3L,5L,9L,2L,7L,5L,2L,7L,7L,5L,3L,2L,5L,6L,6L,3L,4L,3L,7L,2L,4L,8L,9L,0L,7L,8L,3L,8L,4L,1L,0L,0L,4L,4L,2L,4L,2L,8L,7L,4L,9L,5L,6L,4L,3L,8L,6L,1L,5L,1L,9L,9L,5L,1L,1L,1L,2L,9L,6L,9L,6L,3L,8L,8L,5L,7L,9L,5L,6L,2L,2L,0L,1L,6L,9L,2L,1L,1L,6L,6L,3L,7L,5L,2L,3L,1L,6L,7L,9L,5L,4L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200366Inst : IEnumerable<long>
{
public static readonly long[] Value=A200366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200366.Bytes);
public long this[int i]=>Value[i];

public static A200366Inst Instance=new A200366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200367
{
public static readonly long[] Value={ 1L,4L,7L,8L,5L,3L,2L,5L,2L,2L,0L,1L,6L,5L,0L,1L,4L,9L,2L,4L,3L,4L,4L,0L,8L,0L,5L,0L,4L,0L,9L,0L,8L,4L,3L,5L,0L,7L,4L,8L,3L,3L,2L,7L,5L,6L,3L,8L,8L,4L,2L,8L,4L,6L,0L,5L,1L,2L,8L,2L,8L,0L,6L,6L,7L,4L,7L,5L,7L,9L,2L,2L,6L,8L,0L,2L,7L,3L,5L,9L,4L,9L,9L,9L,7L,8L,2L,2L,9L,2L,3L,3L,5L,5L,3L,5L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200367Inst : IEnumerable<long>
{
public static readonly long[] Value=A200367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200367.Bytes);
public long this[int i]=>Value[i];

public static A200367Inst Instance=new A200367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200368
{
public static readonly long[] Value={ 1L,4L,8L,6L,8L,3L,2L,1L,2L,2L,2L,3L,5L,9L,2L,9L,0L,1L,4L,2L,9L,7L,6L,8L,9L,5L,0L,9L,4L,5L,2L,1L,3L,4L,2L,4L,0L,1L,2L,6L,8L,2L,7L,6L,8L,9L,9L,9L,3L,8L,5L,6L,3L,5L,3L,4L,3L,9L,7L,2L,3L,4L,6L,8L,7L,4L,5L,0L,9L,6L,7L,7L,4L,0L,4L,0L,4L,4L,1L,6L,8L,0L,1L,6L,1L,4L,0L,3L,0L,1L,9L,1L,5L,7L,6L,0L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200368Inst : IEnumerable<long>
{
public static readonly long[] Value=A200368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200368.Bytes);
public long this[int i]=>Value[i];

public static A200368Inst Instance=new A200368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200369
{
public static readonly long[] Value={ 1L,4L,9L,3L,6L,8L,9L,3L,5L,7L,9L,7L,4L,3L,7L,2L,9L,4L,2L,9L,7L,8L,1L,6L,9L,6L,9L,5L,4L,7L,3L,7L,3L,3L,0L,2L,8L,3L,3L,2L,1L,0L,1L,0L,6L,2L,8L,0L,2L,3L,8L,1L,5L,0L,7L,2L,6L,6L,9L,8L,5L,6L,1L,1L,3L,6L,3L,0L,5L,5L,7L,0L,0L,7L,5L,9L,0L,0L,0L,0L,3L,2L,7L,3L,3L,4L,5L,8L,7L,5L,1L,7L,4L,5L,6L,4L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200369Inst : IEnumerable<long>
{
public static readonly long[] Value=A200369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200369.Bytes);
public long this[int i]=>Value[i];

public static A200369Inst Instance=new A200369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200370
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,8L,7L,6L,5L,4L,3L,2L,1L,9L,10L,7L,6L,5L,4L,3L,2L,1L,10L,13L,8L,7L,6L,5L,4L,3L,2L,1L,11L,16L,11L,8L,7L,6L,5L,4L,3L,2L,1L,12L,19L,14L,9L,8L,7L,6L,5L,4L,3L,2L,1L,13L,22L,21L,12L,9L,8L,7L,6L,5L,4L,3L,2L,1L,14L,25L,28L,21L,10L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200370Inst : IEnumerable<long>
{
public static readonly long[] Value=A200370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200370.Bytes);
public long this[int i]=>Value[i];

public static A200370Inst Instance=new A200370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200371
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,11L,14L,21L,28L,35L,42L,49L,60L,75L,90L,105L,120L,139L,162L,185L,208L,233L,262L,295L,328L,365L,402L,447L,492L,541L,590L,639L,692L,757L,822L,887L,952L,1027L,1102L,1185L,1268L,1355L,1450L,1549L,1648L,1751L,1858L,1973L,2092L,2219L,2346L,2473L,2608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200371Inst : IEnumerable<long>
{
public static readonly long[] Value=A200371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200371.Bytes);
public long this[int i]=>Value[i];

public static A200371Inst Instance=new A200371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200372
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,12L,21L,30L,39L,52L,65L,84L,107L,130L,155L,184L,221L,266L,323L,384L,447L,520L,605L,696L,803L,914L,1055L,1200L,1357L,1524L,1691L,1886L,2111L,2344L,2597L,2868L,3179L,3494L,3849L,4212L,4591L,5028L,5481L,5946L,6445L,6970L,7557L,8182L,8839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200372Inst : IEnumerable<long>
{
public static readonly long[] Value=A200372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200372.Bytes);
public long this[int i]=>Value[i];

public static A200372Inst Instance=new A200372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200373
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,15L,24L,39L,54L,69L,92L,117L,142L,171L,208L,267L,338L,447L,560L,687L,844L,1011L,1198L,1415L,1648L,1957L,2294L,2685L,3104L,3551L,4098L,4731L,5396L,6107L,6870L,7791L,8764L,9871L,11038L,12281L,13784L,15397L,17098L,18923L,20844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200373Inst : IEnumerable<long>
{
public static readonly long[] Value=A200373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200373.Bytes);
public long this[int i]=>Value[i];

public static A200373Inst Instance=new A200373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200374
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,13L,18L,23L,30L,39L,48L,63L,82L,109L,142L,187L,236L,295L,380L,527L,682L,859L,1086L,1353L,1662L,2055L,2488L,3017L,3616L,4299L,5180L,6147L,7290L,8677L,10178L,11831L,13712L,15807L,18058L,20807L,23788L,27387L,31390L,35773L,40496L,45739L,51654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200374Inst : IEnumerable<long>
{
public static readonly long[] Value=A200374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200374.Bytes);
public long this[int i]=>Value[i];

public static A200374Inst Instance=new A200374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200375
{
public static readonly ulong[] Value={ 1L,1L,6L,25L,154L,882L,5676L,36465L,244530L,1657942L,11471668L,80242890L,568080772L,4056976900L,29212908120L,211783889025L,1544811959970L,11328491394990L,83473572128100L,617702666484750L,4588654943721420L,34206312386929020L,255803818897858920L,1918528298674328250L,14427334095935095764UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200375Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A200375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200375.Bytes);
public ulong this[int i]=>Value[i];

public static A200375Inst Instance=new A200375Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200376
{
public static readonly long[] Value={ 1L,1L,5L,9L,37L,81L,301L,729L,2549L,6561L,22045L,59049L,193029L,531441L,1703469L,4782969L,15111573L,43046721L,134539837L,387420489L,1200901157L,3486784401L,10739313997L,31381059609L,96172251061L,282429536481L,862142190941L,2541865828329L,7734936371269L,22876792454961L,69439155241581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200376Inst : IEnumerable<long>
{
public static readonly long[] Value=A200376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200376.Bytes);
public long this[int i]=>Value[i];

public static A200376Inst Instance=new A200376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200377
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,19L,34L,61L,106L,181L,311L,543L,955L,1668L,2885L,4980L,8650L,15114L,26391L,45845L,79385L,137718L,239866L,418338L,727926L,1263097L,2191463L,3810775L,6638258L,11556361L,20078960L,34855400L,60567092L,105405431L,183483906L,319039355L,554158992L,962743619L,1674359119L,2913758685L,5068194691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200377Inst : IEnumerable<long>
{
public static readonly long[] Value=A200377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200377.Bytes);
public long this[int i]=>Value[i];

public static A200377Inst Instance=new A200377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200378
{
public static readonly BigInteger[] Value={ 1L,6L,36L,222L,1446L,10116L,75924L,602256L,4958352L,41783046L,357442416L,3091766904L,26991194550L,237605649780L,2107693469880L,18826297197444L,169203629332230L,1529098507275372L,13885733651626548L,126641707880226888L,1159483975207373952L,10652962589325269040UL,BigInteger.Parse("98187525261135608400") };
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
public class A200378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200378Inst Instance=new A200378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200379
{
public static readonly long[] Value={ 2L,6L,17L,47L,121L,291L,665L,1467L,3162L,6718L,14156L,29702L,62190L,130060L,271760L,567488L,1184917L,2475907L,5181798L,10869647L,22858188L,48178441L,101712259L,214900119L,454006064L,958316150L,2019797853L,4248758319L,8917387482L,18670242203L,38989676130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200379Inst : IEnumerable<long>
{
public static readonly long[] Value=A200379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200379.Bytes);
public long this[int i]=>Value[i];

public static A200379Inst Instance=new A200379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200380
{
public static readonly long[] Value={ 1L,1L,3L,6L,21L,51L,201L,498L,2241L,4581L,26991L,17766L,359613L,-995409L,6968781L,-53627454L,259953921L,-2292378327L,13839388731L,-108459180954L,809434284741L,-6158416812309L,50614251147153L,-407335408369614L,3478999597913601L,-30042633320442099L,266107969086122151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200380Inst : IEnumerable<long>
{
public static readonly long[] Value=A200380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200380.Bytes);
public long this[int i]=>Value[i];

public static A200380Inst Instance=new A200380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200381
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,14L,16L,18L,21L,22L,24L,27L,28L,29L,32L,33L,36L,42L,44L,47L,48L,49L,54L,56L,58L,63L,64L,66L,72L,76L,77L,81L,84L,87L,88L,94L,96L,98L,99L,108L,112L,116L,121L,123L,126L,128L,132L,141L,144L,147L,152L,154L,162L,168L,174L,176L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200381Inst : IEnumerable<long>
{
public static readonly long[] Value=A200381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200381.Bytes);
public long this[int i]=>Value[i];

public static A200381Inst Instance=new A200381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200382
{
public static readonly long[] Value={ 1L,4L,8L,2L,7L,4L,8L,3L,4L,0L,4L,1L,3L,3L,0L,7L,1L,4L,3L,2L,2L,9L,5L,6L,8L,8L,1L,2L,8L,3L,3L,3L,9L,6L,7L,9L,2L,0L,7L,9L,3L,2L,5L,6L,8L,4L,4L,8L,1L,8L,3L,8L,9L,8L,2L,1L,7L,7L,2L,5L,0L,5L,2L,7L,9L,4L,9L,5L,8L,9L,2L,2L,9L,6L,4L,6L,9L,1L,8L,0L,6L,3L,0L,9L,1L,1L,5L,0L,0L,1L,4L,0L,8L,9L,7L,7L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200382Inst : IEnumerable<long>
{
public static readonly long[] Value=A200382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200382.Bytes);
public long this[int i]=>Value[i];

public static A200382Inst Instance=new A200382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200383
{
public static readonly long[] Value={ 1L,4L,9L,6L,6L,7L,5L,5L,4L,8L,7L,8L,8L,8L,1L,6L,0L,6L,9L,0L,1L,6L,4L,1L,8L,4L,4L,9L,3L,8L,9L,0L,0L,6L,7L,1L,4L,5L,8L,7L,6L,7L,0L,2L,3L,6L,1L,7L,3L,6L,8L,9L,3L,4L,6L,9L,9L,5L,0L,2L,2L,3L,1L,8L,8L,4L,1L,2L,6L,4L,6L,0L,3L,6L,4L,6L,9L,5L,9L,0L,1L,5L,3L,4L,9L,3L,9L,5L,8L,2L,3L,8L,1L,2L,6L,8L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200383Inst : IEnumerable<long>
{
public static readonly long[] Value=A200383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200383.Bytes);
public long this[int i]=>Value[i];

public static A200383Inst Instance=new A200383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200384
{
public static readonly long[] Value={ 1L,4L,3L,1L,8L,4L,8L,5L,0L,2L,0L,9L,5L,6L,7L,6L,3L,8L,7L,7L,0L,5L,6L,4L,7L,3L,7L,0L,3L,7L,4L,7L,3L,6L,2L,7L,9L,0L,3L,3L,1L,5L,0L,9L,1L,9L,3L,2L,0L,4L,2L,2L,9L,0L,3L,1L,1L,1L,1L,0L,9L,3L,2L,1L,9L,4L,7L,3L,9L,8L,3L,7L,0L,8L,2L,7L,1L,7L,5L,2L,8L,4L,1L,0L,7L,3L,9L,5L,1L,9L,7L,0L,3L,3L,8L,2L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200384Inst : IEnumerable<long>
{
public static readonly long[] Value=A200384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200384.Bytes);
public long this[int i]=>Value[i];

public static A200384Inst Instance=new A200384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200385
{
public static readonly long[] Value={ 1L,4L,5L,1L,1L,4L,1L,2L,5L,8L,9L,1L,5L,4L,6L,0L,1L,9L,8L,2L,1L,9L,8L,7L,5L,6L,5L,7L,5L,7L,1L,4L,4L,5L,2L,9L,8L,6L,6L,6L,4L,9L,2L,7L,9L,4L,9L,2L,3L,8L,7L,5L,0L,5L,0L,9L,5L,8L,9L,5L,1L,4L,8L,9L,7L,2L,0L,1L,4L,2L,1L,1L,5L,1L,1L,1L,9L,9L,6L,0L,0L,9L,1L,6L,7L,2L,0L,6L,1L,1L,7L,0L,3L,4L,3L,6L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200385Inst : IEnumerable<long>
{
public static readonly long[] Value=A200385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200385.Bytes);
public long this[int i]=>Value[i];

public static A200385Inst Instance=new A200385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200386
{
public static readonly long[] Value={ 1L,4L,7L,6L,1L,7L,8L,8L,3L,0L,6L,4L,3L,9L,0L,2L,3L,9L,9L,8L,9L,9L,2L,5L,6L,9L,1L,7L,2L,9L,9L,8L,3L,3L,2L,0L,3L,3L,6L,9L,0L,0L,6L,1L,2L,6L,5L,0L,3L,4L,3L,1L,4L,4L,0L,1L,2L,5L,6L,9L,9L,6L,4L,2L,4L,6L,4L,6L,9L,4L,3L,2L,8L,2L,6L,8L,8L,8L,3L,1L,2L,5L,3L,3L,4L,4L,8L,5L,8L,7L,0L,6L,5L,4L,7L,1L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200386Inst : IEnumerable<long>
{
public static readonly long[] Value=A200386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200386.Bytes);
public long this[int i]=>Value[i];

public static A200386Inst Instance=new A200386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200387
{
public static readonly long[] Value={ 1L,4L,5L,8L,1L,0L,6L,6L,4L,1L,5L,9L,8L,3L,3L,2L,8L,4L,5L,9L,7L,3L,6L,8L,0L,6L,2L,6L,6L,1L,4L,5L,1L,9L,4L,7L,2L,5L,8L,4L,0L,6L,7L,6L,4L,9L,5L,0L,5L,2L,9L,3L,7L,8L,5L,0L,8L,4L,3L,9L,5L,3L,5L,2L,0L,7L,2L,9L,8L,1L,4L,4L,4L,4L,2L,6L,8L,2L,2L,0L,5L,8L,1L,2L,3L,3L,9L,5L,1L,1L,5L,4L,5L,9L,1L,7L,5L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200387Inst : IEnumerable<long>
{
public static readonly long[] Value=A200387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200387.Bytes);
public long this[int i]=>Value[i];

public static A200387Inst Instance=new A200387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200388
{
public static readonly long[] Value={ 1L,4L,7L,0L,7L,2L,8L,6L,3L,0L,2L,9L,4L,4L,6L,0L,1L,5L,8L,2L,9L,8L,9L,3L,6L,8L,6L,5L,6L,5L,6L,5L,0L,8L,6L,5L,6L,3L,8L,0L,9L,0L,6L,8L,2L,1L,6L,1L,9L,1L,1L,7L,3L,9L,7L,6L,4L,9L,7L,3L,2L,2L,2L,0L,6L,3L,5L,6L,6L,0L,6L,0L,1L,6L,1L,4L,1L,7L,7L,2L,7L,1L,9L,1L,2L,2L,0L,7L,9L,3L,8L,5L,4L,7L,6L,8L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200388Inst : IEnumerable<long>
{
public static readonly long[] Value=A200388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200388.Bytes);
public long this[int i]=>Value[i];

public static A200388Inst Instance=new A200388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200389
{
public static readonly long[] Value={ 1L,4L,8L,0L,6L,0L,2L,5L,1L,2L,4L,7L,4L,4L,7L,4L,3L,9L,5L,5L,9L,4L,6L,4L,6L,8L,9L,4L,4L,0L,7L,1L,0L,1L,3L,1L,2L,4L,5L,6L,9L,9L,2L,0L,1L,2L,2L,3L,9L,5L,5L,9L,6L,4L,5L,9L,2L,6L,9L,8L,4L,5L,0L,6L,0L,6L,5L,4L,7L,9L,4L,2L,3L,7L,8L,7L,8L,9L,9L,9L,1L,5L,4L,4L,4L,0L,2L,1L,3L,9L,8L,8L,0L,9L,7L,0L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200389Inst : IEnumerable<long>
{
public static readonly long[] Value=A200389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200389.Bytes);
public long this[int i]=>Value[i];

public static A200389Inst Instance=new A200389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200390
{
public static readonly long[] Value={ 1L,4L,8L,8L,5L,8L,4L,1L,5L,4L,5L,8L,6L,8L,7L,1L,3L,8L,9L,6L,6L,6L,1L,6L,4L,5L,2L,9L,2L,8L,9L,8L,6L,4L,0L,5L,2L,2L,8L,8L,2L,8L,9L,7L,0L,2L,0L,0L,9L,2L,0L,5L,3L,6L,2L,6L,6L,5L,7L,5L,7L,1L,7L,5L,6L,0L,5L,4L,2L,8L,6L,0L,1L,0L,2L,2L,3L,9L,3L,0L,6L,2L,6L,1L,9L,1L,7L,0L,8L,8L,2L,2L,4L,5L,6L,2L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200390Inst : IEnumerable<long>
{
public static readonly long[] Value=A200390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200390.Bytes);
public long this[int i]=>Value[i];

public static A200390Inst Instance=new A200390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200391
{
public static readonly long[] Value={ 1L,4L,7L,5L,7L,0L,5L,3L,5L,7L,5L,3L,2L,5L,0L,0L,0L,9L,6L,5L,0L,5L,4L,0L,5L,4L,8L,7L,2L,4L,5L,5L,3L,3L,3L,9L,5L,9L,5L,3L,2L,0L,1L,8L,2L,9L,2L,4L,3L,0L,6L,4L,3L,0L,3L,6L,4L,3L,6L,2L,5L,1L,1L,3L,0L,2L,8L,4L,2L,3L,4L,0L,4L,6L,3L,9L,0L,5L,9L,4L,8L,6L,1L,8L,2L,6L,6L,7L,2L,4L,3L,0L,1L,7L,5L,8L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200391Inst : IEnumerable<long>
{
public static readonly long[] Value=A200391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200391.Bytes);
public long this[int i]=>Value[i];

public static A200391Inst Instance=new A200391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200392
{
public static readonly long[] Value={ 1L,4L,8L,4L,6L,6L,9L,5L,6L,8L,5L,7L,3L,0L,0L,5L,9L,7L,2L,5L,2L,7L,4L,3L,7L,0L,8L,4L,4L,7L,2L,8L,4L,8L,9L,6L,5L,7L,5L,4L,6L,9L,2L,6L,6L,3L,3L,9L,4L,6L,4L,6L,6L,1L,5L,8L,1L,3L,5L,2L,9L,6L,1L,0L,8L,1L,2L,3L,7L,3L,7L,9L,7L,1L,4L,9L,2L,7L,8L,2L,5L,7L,3L,5L,4L,5L,2L,2L,9L,9L,6L,1L,5L,8L,6L,6L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200392Inst : IEnumerable<long>
{
public static readonly long[] Value=A200392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200392.Bytes);
public long this[int i]=>Value[i];

public static A200392Inst Instance=new A200392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200393
{
public static readonly long[] Value={ 1L,4L,9L,1L,9L,8L,3L,5L,2L,0L,9L,2L,6L,4L,9L,5L,2L,3L,9L,3L,0L,6L,6L,1L,7L,2L,0L,7L,4L,1L,3L,3L,6L,7L,5L,3L,7L,2L,1L,9L,0L,8L,9L,6L,9L,5L,5L,4L,8L,4L,2L,2L,9L,8L,5L,9L,6L,5L,8L,7L,4L,2L,9L,1L,5L,2L,9L,0L,5L,6L,2L,3L,2L,1L,7L,1L,2L,2L,6L,9L,2L,2L,9L,7L,8L,0L,3L,4L,6L,3L,9L,7L,5L,1L,4L,5L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200393Inst : IEnumerable<long>
{
public static readonly long[] Value=A200393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200393.Bytes);
public long this[int i]=>Value[i];

public static A200393Inst Instance=new A200393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200394
{
public static readonly long[] Value={ 1L,4L,9L,8L,0L,8L,5L,9L,8L,7L,2L,5L,6L,7L,2L,2L,2L,7L,8L,4L,6L,0L,3L,0L,0L,8L,9L,0L,4L,3L,0L,0L,9L,5L,0L,9L,7L,9L,5L,6L,4L,9L,2L,5L,3L,1L,8L,2L,1L,5L,6L,1L,4L,0L,5L,9L,1L,9L,3L,0L,2L,8L,2L,1L,0L,8L,6L,1L,8L,0L,5L,6L,8L,8L,3L,2L,5L,0L,0L,1L,8L,4L,5L,7L,5L,0L,9L,0L,5L,7L,9L,4L,1L,3L,7L,0L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200394Inst : IEnumerable<long>
{
public static readonly long[] Value=A200394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200394.Bytes);
public long this[int i]=>Value[i];

public static A200394Inst Instance=new A200394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200395
{
public static readonly long[] Value={ 1L,4L,8L,8L,4L,1L,6L,3L,4L,3L,2L,9L,7L,6L,7L,3L,1L,8L,7L,0L,2L,3L,8L,9L,2L,2L,2L,9L,5L,2L,0L,9L,0L,8L,2L,7L,8L,6L,2L,9L,4L,3L,4L,5L,2L,1L,0L,3L,5L,7L,7L,4L,2L,9L,6L,9L,5L,6L,2L,2L,9L,5L,0L,4L,0L,7L,8L,1L,1L,0L,6L,7L,3L,8L,2L,4L,8L,6L,6L,6L,4L,0L,5L,2L,7L,4L,5L,4L,3L,2L,0L,0L,7L,3L,6L,6L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200395Inst : IEnumerable<long>
{
public static readonly long[] Value=A200395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200395.Bytes);
public long this[int i]=>Value[i];

public static A200395Inst Instance=new A200395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200396
{
public static readonly long[] Value={ 1L,4L,9L,5L,1L,3L,5L,7L,9L,3L,1L,6L,6L,3L,0L,3L,3L,1L,0L,4L,2L,4L,5L,2L,2L,6L,6L,8L,8L,2L,5L,8L,1L,4L,8L,6L,2L,9L,2L,4L,0L,7L,2L,0L,5L,7L,6L,0L,8L,8L,2L,0L,8L,0L,0L,5L,1L,3L,6L,2L,6L,7L,0L,5L,2L,2L,5L,8L,5L,9L,2L,3L,9L,9L,0L,7L,4L,8L,8L,8L,6L,5L,5L,1L,9L,1L,3L,6L,7L,2L,7L,9L,5L,9L,3L,2L,3L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200396Inst : IEnumerable<long>
{
public static readonly long[] Value=A200396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200396.Bytes);
public long this[int i]=>Value[i];

public static A200396Inst Instance=new A200396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200397
{
public static readonly long[] Value={ 1L,5L,0L,5L,6L,0L,3L,3L,3L,1L,8L,3L,8L,0L,2L,7L,2L,2L,5L,3L,2L,2L,1L,6L,6L,4L,4L,4L,5L,7L,7L,7L,4L,5L,8L,4L,6L,1L,2L,3L,8L,9L,4L,5L,8L,3L,9L,6L,1L,2L,7L,5L,5L,5L,5L,0L,8L,8L,8L,9L,1L,9L,9L,0L,1L,7L,9L,2L,7L,8L,1L,0L,2L,0L,9L,1L,0L,9L,4L,8L,7L,7L,0L,9L,3L,7L,3L,7L,4L,0L,4L,6L,6L,1L,8L,8L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200397Inst : IEnumerable<long>
{
public static readonly long[] Value=A200397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200397.Bytes);
public long this[int i]=>Value[i];

public static A200397Inst Instance=new A200397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200398
{
public static readonly long[] Value={ 1L,4L,9L,8L,0L,6L,4L,2L,9L,1L,2L,7L,5L,6L,5L,9L,0L,0L,4L,5L,8L,8L,3L,6L,1L,0L,9L,6L,0L,1L,5L,6L,5L,4L,8L,9L,8L,2L,8L,1L,4L,3L,3L,5L,2L,7L,9L,6L,3L,2L,3L,8L,1L,3L,3L,1L,4L,6L,9L,0L,7L,4L,4L,1L,4L,4L,1L,1L,5L,2L,5L,9L,7L,0L,3L,0L,3L,7L,2L,6L,4L,1L,3L,6L,0L,3L,6L,9L,7L,2L,2L,9L,3L,3L,3L,8L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200398Inst : IEnumerable<long>
{
public static readonly long[] Value=A200398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200398.Bytes);
public long this[int i]=>Value[i];

public static A200398Inst Instance=new A200398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200399
{
public static readonly long[] Value={ 1L,5L,0L,3L,2L,9L,9L,1L,1L,6L,2L,7L,0L,4L,4L,2L,7L,4L,8L,1L,2L,6L,7L,0L,9L,5L,7L,4L,6L,0L,0L,6L,9L,4L,2L,0L,8L,9L,5L,4L,4L,8L,8L,7L,4L,2L,0L,6L,4L,7L,0L,3L,8L,1L,7L,0L,9L,4L,4L,4L,3L,3L,4L,4L,3L,0L,9L,4L,8L,5L,1L,2L,3L,6L,1L,5L,3L,4L,8L,9L,0L,1L,8L,2L,2L,3L,4L,3L,5L,2L,0L,0L,4L,8L,0L,6L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200399Inst : IEnumerable<long>
{
public static readonly long[] Value=A200399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200399.Bytes);
public long this[int i]=>Value[i];

public static A200399Inst Instance=new A200399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200400
{
public static readonly long[] Value={ 1L,5L,0L,7L,7L,9L,4L,3L,3L,8L,2L,6L,9L,8L,3L,5L,0L,8L,7L,3L,1L,4L,7L,5L,4L,2L,3L,6L,1L,0L,4L,3L,6L,2L,5L,9L,6L,0L,9L,0L,3L,3L,9L,9L,9L,1L,2L,1L,4L,9L,9L,9L,3L,2L,3L,9L,4L,9L,5L,8L,7L,7L,6L,1L,5L,7L,4L,0L,0L,8L,1L,3L,7L,6L,7L,9L,5L,1L,9L,1L,4L,3L,1L,4L,2L,7L,4L,5L,6L,4L,8L,1L,1L,6L,6L,5L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200400Inst : IEnumerable<long>
{
public static readonly long[] Value=A200400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200400.Bytes);
public long this[int i]=>Value[i];

public static A200400Inst Instance=new A200400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200401
{
public static readonly long[] Value={ 1L,5L,1L,1L,7L,0L,2L,5L,1L,6L,4L,9L,5L,3L,8L,3L,6L,1L,8L,2L,4L,6L,3L,0L,3L,7L,3L,0L,2L,2L,1L,7L,7L,2L,8L,8L,4L,3L,0L,0L,9L,8L,4L,4L,0L,8L,3L,7L,2L,1L,3L,2L,9L,5L,3L,4L,1L,1L,3L,5L,6L,8L,5L,3L,7L,3L,3L,7L,4L,2L,1L,1L,9L,4L,6L,3L,6L,0L,4L,6L,5L,8L,1L,3L,6L,2L,2L,6L,8L,1L,9L,8L,9L,6L,8L,5L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200401Inst : IEnumerable<long>
{
public static readonly long[] Value=A200401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200401.Bytes);
public long this[int i]=>Value[i];

public static A200401Inst Instance=new A200401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200402
{
public static readonly long[] Value={ 1L,1L,-2L,-5L,24L,81L,-439L,-1590L,9144L,34451L,-206641L,-799196L,4936378L,19442800L,-122613798L,-489411508L,3134773097L,12640278932L,-81948641010L,-333099985517L,2180523864984L,8920922434686L,-58861487584914L,-242105281357185L,1608002839956522L,6643707274089977L,-44372373955131024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200402Inst : IEnumerable<long>
{
public static readonly long[] Value=A200402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200402.Bytes);
public long this[int i]=>Value[i];

public static A200402Inst Instance=new A200402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200403
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,584L,3660L,25910L,204564L,1782520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200403Inst : IEnumerable<long>
{
public static readonly long[] Value=A200403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200403.Bytes);
public long this[int i]=>Value[i];

public static A200403Inst Instance=new A200403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200404
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,582L,3622L,25369L,197523L,1692535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200404Inst : IEnumerable<long>
{
public static readonly long[] Value=A200404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200404.Bytes);
public long this[int i]=>Value[i];

public static A200404Inst Instance=new A200404Inst();

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